using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.Geometry;
using ESRI.ArcGIS.DataSourcesGDB;

namespace Task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            selectionMethodCombobox.SelectedIndex = 0;
            spatialRelationshipCombobox.SelectedIndex = 0;
        }


        // Loading Map Document from local hard drive
        IMapDocument mapDoc;
        private void loadMapDocumentButton_Click(object sender, EventArgs e)
        {
            dataFramesCombo.Items.Clear();
            fieldsListbox.Items.Clear();
            uniqueValuesListbox.Items.Clear();
            atrQueryTextbox.Text = "";

            // Opening map doc from path
            mapDoc = new MapDocument();
            mapDoc.Open(@mapDocumentTextbox.Text);
            
            // Passing map (dataframe) to map control
            IMap map = mapDoc.get_Map(0);
            axMapControl1.Map = map;

            // Adding maps (dataframes) to combobox
            for (int i = 0; i < mapDoc.MapCount; i++)
            {
                dataFramesCombo.Items.Add(mapDoc.get_Map(i).Name);
            }
            if(dataFramesCombo.Items.Count > 0)
                dataFramesCombo.SelectedIndex = 0;

            // Setting Focus Map
            activeDataFrameLabel.Text = mapDoc.ActiveView.FocusMap.Name;
        }

        private void dataFramesCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshLayers();
            fieldsListbox.Items.Clear();
            uniqueValuesListbox.Items.Clear();
            atrQueryTextbox.Text = "";
        }

        // Changing Visibility of layers
        private void layersListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // Checking modification
            bool makeItVisible;
            if (e.NewValue == CheckState.Checked)
                makeItVisible = true;
            else
                makeItVisible = false;

            // Finding layer to modiify
            IMap map = mapDoc.get_Map(dataFramesCombo.SelectedIndex);
            ILayer layer = map.get_Layer(e.Index);
            layer.Visible = makeItVisible;

            // Refreshing Map
            axMapControl1.ActiveView.Refresh();
        }

        // Adding layer from geodatabase
        private void addLayerButton_Click(object sender, EventArgs e)
        {
            // Getting active map view
            IActiveView activeV = axMapControl1.ActiveView;
            IMap focusMap = activeV.FocusMap;

            IWorkspaceFactory access = new AccessWorkspaceFactory();
            IWorkspace workspace;
            workspace = access.OpenFromFile(@geodatabaseTextbox.Text, 0);

            IFeatureWorkspace featureWorkspace;
            featureWorkspace = workspace as IFeatureWorkspace;
            IFeatureClass featureClass;
            featureClass = featureWorkspace.OpenFeatureClass(featureClassTextbox.Text);

            IFeatureLayer featureLayer = new FeatureLayer();
            featureLayer.FeatureClass = featureClass;
            featureLayer.Name = layerNameTextbox.Text;

            // Add layer to map
            focusMap.AddLayer(featureLayer);
            focusMap.MoveLayer(featureLayer, int.Parse(layerIndexTextbox.Text));
            refreshLayers();

        }

        // Remove exisiting Layer from map
        private void removeLayerButton_Click(object sender, EventArgs e)
        {
            // Getting active map view
            IActiveView activeV = axMapControl1.ActiveView;
            IMap focusMap = activeV.FocusMap;

            // Remove layer from map
            IFeatureLayer featureLayer = (IFeatureLayer)focusMap.get_Layer(layersListBox.SelectedIndex);
            focusMap.DeleteLayer(featureLayer);
            refreshLayers();
        }

        // Displaying location on status bar
        private void axMapControl1_OnMouseMove(object sender, ESRI.ArcGIS.Controls.IMapControlEvents2_OnMouseMoveEvent e)
        {
            currentLocationLabel.Text = "X: " + e.mapX + " , Y: " + e.mapY;
        }

        // Execute definition query on selected layer from checklistbox
        private void executeQueryButton_Click(object sender, EventArgs e)
        {
            IFeatureLayerDefinition featLayerDef;
            featLayerDef = (IFeatureLayerDefinition)axMapControl1.ActiveView.FocusMap.get_Layer(layersListBox.SelectedIndex);
            featLayerDef.DefinitionExpression = definitionQueryTextbox.Text;
            axMapControl1.ActiveView.Refresh();
        }

        private void refreshLayers()
        {
            // Changing map according to selected dataframe
            IMap map = mapDoc.get_Map(dataFramesCombo.SelectedIndex);
            axMapControl1.Map = map;

            // Loading layers for selected data frame from combobox and Adding them to checklistbox
            layersListBox.Items.Clear();
            layerAtrCombobox.Items.Clear();
            layerLocCombobox.Items.Clear();
            layerClearCombobox.Items.Clear();

            IEnumLayer mapLayers = map.get_Layers();
            ILayer currentLayer = mapLayers.Next();
            int currentLayerindex = 0;
            while (currentLayer != null)
            {
                layersListBox.Items.Add(currentLayer.Name);
                layerAtrCombobox.Items.Add(currentLayer.Name);
                layerLocCombobox.Items.Add(currentLayer.Name);
                layerClearCombobox.Items.Add(currentLayer.Name);

                if (currentLayer.Visible)
                    layersListBox.SetItemChecked(currentLayerindex, true);
                else
                    layersListBox.SetItemChecked(currentLayerindex, false);
                currentLayer = mapLayers.Next();
                currentLayerindex++;
            }

            axMapControl1.Refresh();
        }

        // Zoom in
        private void zoomInButton_Click(object sender, EventArgs e)
        {
            axMapControl1.ActiveView.FocusMap.MapScale /= 1.5;
            axMapControl1.Refresh();
        }

        // Zoom out
        private void zoomOutButton_Click(object sender, EventArgs e)
        {
            axMapControl1.ActiveView.FocusMap.MapScale *= 1.5;
            axMapControl1.Refresh();
        }

        // Full Extent
        private void fullExtentButton_Click(object sender, EventArgs e)
        {
            axMapControl1.ActiveView.Extent = axMapControl1.ActiveView.FullExtent;
            axMapControl1.ActiveView.Extent = axMapControl1.ActiveView.FullExtent;
            axMapControl1.Refresh();
        }

        private void layerManagementBtn_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
        }

        private void queryBtn_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
        }

        // Display fields of selected layer
        private void layerAtrCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            IFeatureLayer selectedLayer = (IFeatureLayer)axMapControl1.ActiveView.FocusMap.get_Layer(layerAtrCombobox.SelectedIndex);
            IFields fields = selectedLayer.FeatureClass.Fields;
            fieldsListbox.Items.Clear();
            uniqueValuesListbox.Items.Clear();
            atrQueryTextbox.Text = "";
            for (int i = 0; i < fields.FieldCount; i++)
            {
                fieldsListbox.Items.Add(fields.get_Field(i).Name);
            }
            atrSelectLabel.Text = "SELECT * FROM " + selectedLayer.Name + " WHERE:";
        }

        // Display unique values of selected field of selected layer
        private void fieldsListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            IFeatureLayer selectedLayer = (IFeatureLayer)axMapControl1.ActiveView.FocusMap.get_Layer(layerAtrCombobox.SelectedIndex);
            IFeatureCursor featCursor = selectedLayer.FeatureClass.Search(null, true);
            IFeature feat = featCursor.NextFeature();
            uniqueValuesListbox.Items.Clear();
            while (feat != null)
            {
                string value = feat.get_Value(fieldsListbox.SelectedIndex).ToString();

                float value_float;
                if (!float.TryParse(value, out value_float))
                {
                    value = "'" + value + "'";
                }

                if (!uniqueValuesListbox.Items.Contains(value))
                {
                    uniqueValuesListbox.Items.Add(value);
                }
                feat = featCursor.NextFeature();
            }
        }

        // Query Builder Button Clicks
        #region
        // Adding selected field to query textbox
        private void fieldsListbox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            atrQueryTextbox.Paste(fieldsListbox.SelectedItem + " ");
        }

        // Adding selected unique value to query textbox
        private void uniqueValuesListbox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            atrQueryTextbox.Paste(uniqueValuesListbox.SelectedItem + " ");
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            atrQueryTextbox.Paste((sender as Button).Text + " ");
        }

        private void btnNotEqual_Click(object sender, EventArgs e)
        {
            atrQueryTextbox.Paste((sender as Button).Text + " ");
        }

        private void btnLessThan_Click(object sender, EventArgs e)
        {
            atrQueryTextbox.Paste((sender as Button).Text + " ");
        }

        private void btnLessThanOrEqual_Click(object sender, EventArgs e)
        {
            atrQueryTextbox.Paste((sender as Button).Text + " ");
        }

        private void btnMoreThan_Click(object sender, EventArgs e)
        {
            atrQueryTextbox.Paste((sender as Button).Text + " ");
        }

        private void btnMoreThanOrEqual_Click(object sender, EventArgs e)
        {
            atrQueryTextbox.Paste((sender as Button).Text + " ");
        }

        private void btnQuestionMark_Click(object sender, EventArgs e)
        {
            atrQueryTextbox.Paste((sender as Button).Text + " ");
        }

        private void btnLike_Click(object sender, EventArgs e)
        {
            atrQueryTextbox.Paste((sender as Button).Text + " ");
        }

        private void btnAnd_Click(object sender, EventArgs e)
        {
            atrQueryTextbox.Paste((sender as Button).Text + " ");
        }

        private void btnOr_Click(object sender, EventArgs e)
        {
            atrQueryTextbox.Paste((sender as Button).Text + " ");
        }

        private void btnNot_Click(object sender, EventArgs e)
        {
            atrQueryTextbox.Paste((sender as Button).Text + " ");
        }

        private void btnIs_Click(object sender, EventArgs e)
        {
            atrQueryTextbox.Paste((sender as Button).Text + " ");
        }
        #endregion

        // Execute Attribute Query
        private void executeAtrQueryBtn_Click(object sender, EventArgs e)
        {
            IFeatureLayer selectedLayer = (IFeatureLayer)axMapControl1.ActiveView.FocusMap.get_Layer(layerAtrCombobox.SelectedIndex);

            // Selection
            IQueryFilter filter = new QueryFilterClass();
            filter.WhereClause = atrQueryTextbox.Text;
            IFeatureSelection featSelection = selectedLayer as IFeatureSelection;
            featSelection.SelectFeatures(filter, selectionMethod(), false);
            axMapControl1.Refresh();
        }

        private esriSelectionResultEnum selectionMethod()
        {
            if (selectionMethodCombobox.SelectedIndex == 0)
                return esriSelectionResultEnum.esriSelectionResultNew;
            else if (selectionMethodCombobox.SelectedIndex == 1)
                return esriSelectionResultEnum.esriSelectionResultAdd;
            else
                return esriSelectionResultEnum.esriSelectionResultSubtract;
        }

        // Clear layer selection
        private void clearSelectionButton_Click(object sender, EventArgs e)
        {
            IFeatureLayer selectedLayer = (IFeatureLayer)axMapControl1.ActiveView.FocusMap.get_Layer(layerClearCombobox.SelectedIndex);
            IFeatureSelection featSelection = selectedLayer as IFeatureSelection;
            featSelection.Clear();
            axMapControl1.Refresh();
        }

        private void executeSpatialQueryBtn_Click(object sender, EventArgs e)
        {
            // Getting Selection from source layer
            IFeatureLayer sourceLayer = (IFeatureLayer)axMapControl1.ActiveView.FocusMap.get_Layer(layerAtrCombobox.SelectedIndex);
            IFeatureSelection sourceSelection = sourceLayer as IFeatureSelection;
            ISelectionSet selectionSet = sourceSelection.SelectionSet;
            ICursor cursor;
            selectionSet.Search(null, true, out cursor);
            IFeatureCursor featCursor = (IFeatureCursor)cursor;
            IFeature feat = featCursor.NextFeature();
            if (feat == null)
                return;

            // Getting spatial relation
            ISpatialFilter sFilter = new SpatialFilterClass();
            sFilter.SpatialRel = spatialRelationship();
            sFilter.Geometry = feat.Shape;

            // Selection for target layer
            IFeatureLayer targetLayer = (IFeatureLayer)axMapControl1.ActiveView.FocusMap.get_Layer(layerLocCombobox.SelectedIndex);
            IFeatureSelection featSelection = targetLayer as IFeatureSelection;
            featSelection.SelectFeatures(sFilter, esriSelectionResultEnum.esriSelectionResultNew, false);
            feat = featCursor.NextFeature();
            while (feat != null)
            {
                sFilter.Geometry = feat.Shape;
                featSelection.SelectFeatures(sFilter, esriSelectionResultEnum.esriSelectionResultAdd, false);
                feat = featCursor.NextFeature();
            }
            axMapControl1.Refresh();
        }

        private esriSpatialRelEnum spatialRelationship()
        {
            if (spatialRelationshipCombobox.SelectedIndex == 0)
                return esriSpatialRelEnum.esriSpatialRelContains;
            else if (spatialRelationshipCombobox.SelectedIndex == 1)
                return esriSpatialRelEnum.esriSpatialRelIntersects;
            else if (spatialRelationshipCombobox.SelectedIndex == 2)
                return esriSpatialRelEnum.esriSpatialRelTouches;
            else
                return esriSpatialRelEnum.esriSpatialRelWithin;
        }

        // Show Attributes on datagridview for selected layer
        private void showAtrBtn_Click(object sender, EventArgs e)
        {
            IFeatureLayer selectedLayer = (IFeatureLayer)axMapControl1.ActiveView.FocusMap.get_Layer(layerClearCombobox.SelectedIndex);
            IFeatureSelection selection = selectedLayer as IFeatureSelection;
            ISelectionSet selectionSet = selection.SelectionSet;
            ICursor cursor;
            selectionSet.Search(null, true, out cursor);
            IFeatureCursor featCursor = (IFeatureCursor)cursor;
            IFeature feat = featCursor.NextFeature();

            // DataGridView Data
            DataTable table = new DataTable();

            // Adding columns
            IFields fields = selectedLayer.FeatureClass.Fields;
            for (int i = 0; i < fields.FieldCount; i++)
            {
                table.Columns.Add(fields.get_Field(i).Name);
            }

            // Adding rows
            while (feat != null)
            {
                string[] row = new string[fields.FieldCount];
                for (int i = 0; i < fields.FieldCount; i++)
                {
                    row[i] = feat.get_Value(i).ToString();
                }
                table.Rows.Add(row);
                feat = featCursor.NextFeature();
            }

            attributesDataGrid.DataSource = table;
        }

    }
        
}
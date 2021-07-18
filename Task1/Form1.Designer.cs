namespace Task1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.executeQueryButton = new System.Windows.Forms.Button();
            this.definitionQueryTextbox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.removeLayerButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addLayerButton = new System.Windows.Forms.Button();
            this.layerIndexTextbox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.layerNameTextbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.featureClassTextbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.geodatabaseTextbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.layersListBox = new System.Windows.Forms.CheckedListBox();
            this.activeDataFrameLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.clearSelectionButton = new System.Windows.Forms.Button();
            this.queryBtn = new System.Windows.Forms.Button();
            this.dataFramesCombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.loadMapDocumentButton = new System.Windows.Forms.Button();
            this.mapDocumentTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.currentLocationLabel = new System.Windows.Forms.Label();
            this.fullExtentButton = new System.Windows.Forms.Button();
            this.zoomOutButton = new System.Windows.Forms.Button();
            this.zoomInButton = new System.Windows.Forms.Button();
            this.layerManagementBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.attributesDataGrid = new System.Windows.Forms.DataGridView();
            this.executeSpatialQueryBtn = new System.Windows.Forms.Button();
            this.spatialRelationshipCombobox = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.layerLocCombobox = new System.Windows.Forms.ComboBox();
            this.executeAtrQueryBtn = new System.Windows.Forms.Button();
            this.atrSelectLabel = new System.Windows.Forms.Label();
            this.atrQueryTextbox = new System.Windows.Forms.TextBox();
            this.btnIs = new System.Windows.Forms.Button();
            this.btnNot = new System.Windows.Forms.Button();
            this.btnOr = new System.Windows.Forms.Button();
            this.btnAnd = new System.Windows.Forms.Button();
            this.btnLike = new System.Windows.Forms.Button();
            this.btnQuestionMark = new System.Windows.Forms.Button();
            this.btnMoreThanOrEqual = new System.Windows.Forms.Button();
            this.btnNotEqual = new System.Windows.Forms.Button();
            this.btnLessThanOrEqual = new System.Windows.Forms.Button();
            this.btnLessThan = new System.Windows.Forms.Button();
            this.btnMoreThan = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.uniqueValuesListbox = new System.Windows.Forms.ListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.fieldsListbox = new System.Windows.Forms.ListBox();
            this.selectionMethodCombobox = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.layerAtrCombobox = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.layerClearCombobox = new System.Windows.Forms.ComboBox();
            this.axMapControl1 = new ESRI.ArcGIS.Controls.AxMapControl();
            this.showAtrBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.attributesDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axMapControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.executeQueryButton);
            this.panel1.Controls.Add(this.definitionQueryTextbox);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.removeLayerButton);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.layersListBox);
            this.panel1.Controls.Add(this.activeDataFrameLabel);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 584);
            this.panel1.TabIndex = 0;
            // 
            // executeQueryButton
            // 
            this.executeQueryButton.Location = new System.Drawing.Point(395, 493);
            this.executeQueryButton.Name = "executeQueryButton";
            this.executeQueryButton.Size = new System.Drawing.Size(129, 23);
            this.executeQueryButton.TabIndex = 30;
            this.executeQueryButton.Text = "Execute Query";
            this.executeQueryButton.UseVisualStyleBackColor = true;
            this.executeQueryButton.Click += new System.EventHandler(this.executeQueryButton_Click);
            // 
            // definitionQueryTextbox
            // 
            this.definitionQueryTextbox.Location = new System.Drawing.Point(89, 430);
            this.definitionQueryTextbox.Multiline = true;
            this.definitionQueryTextbox.Name = "definitionQueryTextbox";
            this.definitionQueryTextbox.Size = new System.Drawing.Size(300, 129);
            this.definitionQueryTextbox.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(86, 414);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "Definition Query:";
            // 
            // removeLayerButton
            // 
            this.removeLayerButton.Location = new System.Drawing.Point(395, 91);
            this.removeLayerButton.Name = "removeLayerButton";
            this.removeLayerButton.Size = new System.Drawing.Size(129, 23);
            this.removeLayerButton.TabIndex = 27;
            this.removeLayerButton.Text = "Remove Layer";
            this.removeLayerButton.UseVisualStyleBackColor = true;
            this.removeLayerButton.Click += new System.EventHandler(this.removeLayerButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addLayerButton);
            this.groupBox1.Controls.Add(this.layerIndexTextbox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.layerNameTextbox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.featureClassTextbox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.geodatabaseTextbox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(89, 182);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(435, 193);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Layers from Geodatabase";
            // 
            // addLayerButton
            // 
            this.addLayerButton.Location = new System.Drawing.Point(184, 164);
            this.addLayerButton.Name = "addLayerButton";
            this.addLayerButton.Size = new System.Drawing.Size(108, 23);
            this.addLayerButton.TabIndex = 6;
            this.addLayerButton.Text = "Add Layer";
            this.addLayerButton.UseVisualStyleBackColor = true;
            this.addLayerButton.Click += new System.EventHandler(this.addLayerButton_Click);
            // 
            // layerIndexTextbox
            // 
            this.layerIndexTextbox.Location = new System.Drawing.Point(85, 131);
            this.layerIndexTextbox.Name = "layerIndexTextbox";
            this.layerIndexTextbox.Size = new System.Drawing.Size(344, 20);
            this.layerIndexTextbox.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Layer Index:";
            // 
            // layerNameTextbox
            // 
            this.layerNameTextbox.Location = new System.Drawing.Point(85, 95);
            this.layerNameTextbox.Name = "layerNameTextbox";
            this.layerNameTextbox.Size = new System.Drawing.Size(344, 20);
            this.layerNameTextbox.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Layer Name:";
            // 
            // featureClassTextbox
            // 
            this.featureClassTextbox.Location = new System.Drawing.Point(85, 59);
            this.featureClassTextbox.Name = "featureClassTextbox";
            this.featureClassTextbox.Size = new System.Drawing.Size(344, 20);
            this.featureClassTextbox.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Feature Class:";
            // 
            // geodatabaseTextbox
            // 
            this.geodatabaseTextbox.Location = new System.Drawing.Point(85, 27);
            this.geodatabaseTextbox.Name = "geodatabaseTextbox";
            this.geodatabaseTextbox.Size = new System.Drawing.Size(344, 20);
            this.geodatabaseTextbox.TabIndex = 1;
            this.geodatabaseTextbox.Text = "C:\\Data\\GIS Databases\\";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Geodatabase:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Layers:";
            // 
            // layersListBox
            // 
            this.layersListBox.FormattingEnabled = true;
            this.layersListBox.Location = new System.Drawing.Point(174, 48);
            this.layersListBox.Name = "layersListBox";
            this.layersListBox.Size = new System.Drawing.Size(215, 109);
            this.layersListBox.TabIndex = 29;
            this.layersListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.layersListBox_ItemCheck);
            // 
            // activeDataFrameLabel
            // 
            this.activeDataFrameLabel.AutoSize = true;
            this.activeDataFrameLabel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.activeDataFrameLabel.Location = new System.Drawing.Point(270, 0);
            this.activeDataFrameLabel.Name = "activeDataFrameLabel";
            this.activeDataFrameLabel.Size = new System.Drawing.Size(0, 13);
            this.activeDataFrameLabel.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Active Dataframe (On ArcMap):";
            // 
            // clearSelectionButton
            // 
            this.clearSelectionButton.Location = new System.Drawing.Point(455, 48);
            this.clearSelectionButton.Name = "clearSelectionButton";
            this.clearSelectionButton.Size = new System.Drawing.Size(153, 33);
            this.clearSelectionButton.TabIndex = 20;
            this.clearSelectionButton.Text = "Clear Layer Selection";
            this.clearSelectionButton.UseVisualStyleBackColor = true;
            this.clearSelectionButton.Click += new System.EventHandler(this.clearSelectionButton_Click);
            // 
            // queryBtn
            // 
            this.queryBtn.Location = new System.Drawing.Point(129, 10);
            this.queryBtn.Name = "queryBtn";
            this.queryBtn.Size = new System.Drawing.Size(111, 71);
            this.queryBtn.TabIndex = 18;
            this.queryBtn.Text = "Attribute and Spatial Query";
            this.queryBtn.UseVisualStyleBackColor = true;
            this.queryBtn.Click += new System.EventHandler(this.queryBtn_Click);
            // 
            // dataFramesCombo
            // 
            this.dataFramesCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dataFramesCombo.FormattingEnabled = true;
            this.dataFramesCombo.Location = new System.Drawing.Point(709, 48);
            this.dataFramesCombo.Name = "dataFramesCombo";
            this.dataFramesCombo.Size = new System.Drawing.Size(215, 21);
            this.dataFramesCombo.TabIndex = 28;
            this.dataFramesCombo.SelectedIndexChanged += new System.EventHandler(this.dataFramesCombo_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(621, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Data Frames:";
            // 
            // loadMapDocumentButton
            // 
            this.loadMapDocumentButton.Location = new System.Drawing.Point(930, 10);
            this.loadMapDocumentButton.Name = "loadMapDocumentButton";
            this.loadMapDocumentButton.Size = new System.Drawing.Size(129, 23);
            this.loadMapDocumentButton.TabIndex = 23;
            this.loadMapDocumentButton.Text = "Load Map Document";
            this.loadMapDocumentButton.UseVisualStyleBackColor = true;
            this.loadMapDocumentButton.Click += new System.EventHandler(this.loadMapDocumentButton_Click);
            // 
            // mapDocumentTextbox
            // 
            this.mapDocumentTextbox.Location = new System.Drawing.Point(709, 12);
            this.mapDocumentTextbox.Name = "mapDocumentTextbox";
            this.mapDocumentTextbox.Size = new System.Drawing.Size(215, 20);
            this.mapDocumentTextbox.TabIndex = 22;
            this.mapDocumentTextbox.Text = "C:\\Data\\Maps\\";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(621, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Map Document:";
            // 
            // currentLocationLabel
            // 
            this.currentLocationLabel.AutoSize = true;
            this.currentLocationLabel.Location = new System.Drawing.Point(937, 689);
            this.currentLocationLabel.Name = "currentLocationLabel";
            this.currentLocationLabel.Size = new System.Drawing.Size(0, 13);
            this.currentLocationLabel.TabIndex = 43;
            // 
            // fullExtentButton
            // 
            this.fullExtentButton.Location = new System.Drawing.Point(780, 684);
            this.fullExtentButton.Name = "fullExtentButton";
            this.fullExtentButton.Size = new System.Drawing.Size(75, 23);
            this.fullExtentButton.TabIndex = 42;
            this.fullExtentButton.Text = "Full Extent";
            this.fullExtentButton.UseVisualStyleBackColor = true;
            this.fullExtentButton.Click += new System.EventHandler(this.fullExtentButton_Click);
            // 
            // zoomOutButton
            // 
            this.zoomOutButton.Location = new System.Drawing.Point(699, 684);
            this.zoomOutButton.Name = "zoomOutButton";
            this.zoomOutButton.Size = new System.Drawing.Size(75, 23);
            this.zoomOutButton.TabIndex = 41;
            this.zoomOutButton.Text = "Zoom Out";
            this.zoomOutButton.UseVisualStyleBackColor = true;
            this.zoomOutButton.Click += new System.EventHandler(this.zoomOutButton_Click);
            // 
            // zoomInButton
            // 
            this.zoomInButton.Location = new System.Drawing.Point(618, 685);
            this.zoomInButton.Name = "zoomInButton";
            this.zoomInButton.Size = new System.Drawing.Size(75, 23);
            this.zoomInButton.TabIndex = 40;
            this.zoomInButton.Text = "Zoom In";
            this.zoomInButton.UseVisualStyleBackColor = true;
            this.zoomInButton.Click += new System.EventHandler(this.zoomInButton_Click);
            // 
            // layerManagementBtn
            // 
            this.layerManagementBtn.Location = new System.Drawing.Point(12, 10);
            this.layerManagementBtn.Name = "layerManagementBtn";
            this.layerManagementBtn.Size = new System.Drawing.Size(111, 71);
            this.layerManagementBtn.TabIndex = 44;
            this.layerManagementBtn.Text = "Layer Management and Definiton Query";
            this.layerManagementBtn.UseVisualStyleBackColor = true;
            this.layerManagementBtn.Click += new System.EventHandler(this.layerManagementBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.attributesDataGrid);
            this.panel2.Controls.Add(this.executeSpatialQueryBtn);
            this.panel2.Controls.Add(this.spatialRelationshipCombobox);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.layerLocCombobox);
            this.panel2.Controls.Add(this.executeAtrQueryBtn);
            this.panel2.Controls.Add(this.atrSelectLabel);
            this.panel2.Controls.Add(this.atrQueryTextbox);
            this.panel2.Controls.Add(this.btnIs);
            this.panel2.Controls.Add(this.btnNot);
            this.panel2.Controls.Add(this.btnOr);
            this.panel2.Controls.Add(this.btnAnd);
            this.panel2.Controls.Add(this.btnLike);
            this.panel2.Controls.Add(this.btnQuestionMark);
            this.panel2.Controls.Add(this.btnMoreThanOrEqual);
            this.panel2.Controls.Add(this.btnNotEqual);
            this.panel2.Controls.Add(this.btnLessThanOrEqual);
            this.panel2.Controls.Add(this.btnLessThan);
            this.panel2.Controls.Add(this.btnMoreThan);
            this.panel2.Controls.Add(this.btnEqual);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.uniqueValuesListbox);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.fieldsListbox);
            this.panel2.Controls.Add(this.selectionMethodCombobox);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.layerAtrCombobox);
            this.panel2.Location = new System.Drawing.Point(12, 94);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 584);
            this.panel2.TabIndex = 45;
            this.panel2.Visible = false;
            // 
            // attributesDataGrid
            // 
            this.attributesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.attributesDataGrid.Location = new System.Drawing.Point(318, 6);
            this.attributesDataGrid.Name = "attributesDataGrid";
            this.attributesDataGrid.Size = new System.Drawing.Size(277, 563);
            this.attributesDataGrid.TabIndex = 53;
            // 
            // executeSpatialQueryBtn
            // 
            this.executeSpatialQueryBtn.Location = new System.Drawing.Point(89, 535);
            this.executeSpatialQueryBtn.Name = "executeSpatialQueryBtn";
            this.executeSpatialQueryBtn.Size = new System.Drawing.Size(110, 34);
            this.executeSpatialQueryBtn.TabIndex = 51;
            this.executeSpatialQueryBtn.Text = "Execute Spatial Query";
            this.executeSpatialQueryBtn.UseVisualStyleBackColor = true;
            this.executeSpatialQueryBtn.Click += new System.EventHandler(this.executeSpatialQueryBtn_Click);
            // 
            // spatialRelationshipCombobox
            // 
            this.spatialRelationshipCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.spatialRelationshipCombobox.FormattingEnabled = true;
            this.spatialRelationshipCombobox.Items.AddRange(new object[] {
            "Contains",
            "Intersects",
            "Touches",
            "Within"});
            this.spatialRelationshipCombobox.Location = new System.Drawing.Point(102, 499);
            this.spatialRelationshipCombobox.Name = "spatialRelationshipCombobox";
            this.spatialRelationshipCombobox.Size = new System.Drawing.Size(190, 21);
            this.spatialRelationshipCombobox.TabIndex = 50;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(0, 502);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(104, 13);
            this.label15.TabIndex = 49;
            this.label15.Text = "Spatial Relationship:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(0, 464);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 13);
            this.label14.TabIndex = 48;
            this.label14.Text = "Target Layer:";
            // 
            // layerLocCombobox
            // 
            this.layerLocCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.layerLocCombobox.FormattingEnabled = true;
            this.layerLocCombobox.Location = new System.Drawing.Point(102, 461);
            this.layerLocCombobox.Name = "layerLocCombobox";
            this.layerLocCombobox.Size = new System.Drawing.Size(190, 21);
            this.layerLocCombobox.TabIndex = 47;
            // 
            // executeAtrQueryBtn
            // 
            this.executeAtrQueryBtn.Location = new System.Drawing.Point(179, 374);
            this.executeAtrQueryBtn.Name = "executeAtrQueryBtn";
            this.executeAtrQueryBtn.Size = new System.Drawing.Size(110, 45);
            this.executeAtrQueryBtn.TabIndex = 46;
            this.executeAtrQueryBtn.Text = "Execute Attribute Query";
            this.executeAtrQueryBtn.UseVisualStyleBackColor = true;
            this.executeAtrQueryBtn.Click += new System.EventHandler(this.executeAtrQueryBtn_Click);
            // 
            // atrSelectLabel
            // 
            this.atrSelectLabel.AutoSize = true;
            this.atrSelectLabel.Location = new System.Drawing.Point(0, 318);
            this.atrSelectLabel.Name = "atrSelectLabel";
            this.atrSelectLabel.Size = new System.Drawing.Size(154, 13);
            this.atrSelectLabel.TabIndex = 45;
            this.atrSelectLabel.Text = "SELECT * FROM layer WHERE:";
            // 
            // atrQueryTextbox
            // 
            this.atrQueryTextbox.Location = new System.Drawing.Point(0, 334);
            this.atrQueryTextbox.Multiline = true;
            this.atrQueryTextbox.Name = "atrQueryTextbox";
            this.atrQueryTextbox.Size = new System.Drawing.Size(173, 121);
            this.atrQueryTextbox.TabIndex = 44;
            // 
            // btnIs
            // 
            this.btnIs.Location = new System.Drawing.Point(229, 271);
            this.btnIs.Name = "btnIs";
            this.btnIs.Size = new System.Drawing.Size(52, 23);
            this.btnIs.TabIndex = 43;
            this.btnIs.Text = "Is";
            this.btnIs.UseVisualStyleBackColor = true;
            this.btnIs.Click += new System.EventHandler(this.btnIs_Click);
            // 
            // btnNot
            // 
            this.btnNot.Location = new System.Drawing.Point(174, 271);
            this.btnNot.Name = "btnNot";
            this.btnNot.Size = new System.Drawing.Size(52, 23);
            this.btnNot.TabIndex = 42;
            this.btnNot.Text = "Not";
            this.btnNot.UseVisualStyleBackColor = true;
            this.btnNot.Click += new System.EventHandler(this.btnNot_Click);
            // 
            // btnOr
            // 
            this.btnOr.Location = new System.Drawing.Point(116, 271);
            this.btnOr.Name = "btnOr";
            this.btnOr.Size = new System.Drawing.Size(52, 23);
            this.btnOr.TabIndex = 41;
            this.btnOr.Text = "Or";
            this.btnOr.UseVisualStyleBackColor = true;
            this.btnOr.Click += new System.EventHandler(this.btnOr_Click);
            // 
            // btnAnd
            // 
            this.btnAnd.Location = new System.Drawing.Point(58, 271);
            this.btnAnd.Name = "btnAnd";
            this.btnAnd.Size = new System.Drawing.Size(52, 23);
            this.btnAnd.TabIndex = 40;
            this.btnAnd.Text = "And";
            this.btnAnd.UseVisualStyleBackColor = true;
            this.btnAnd.Click += new System.EventHandler(this.btnAnd_Click);
            // 
            // btnLike
            // 
            this.btnLike.Location = new System.Drawing.Point(0, 271);
            this.btnLike.Name = "btnLike";
            this.btnLike.Size = new System.Drawing.Size(52, 23);
            this.btnLike.TabIndex = 39;
            this.btnLike.Text = "Like";
            this.btnLike.UseVisualStyleBackColor = true;
            this.btnLike.Click += new System.EventHandler(this.btnLike_Click);
            // 
            // btnQuestionMark
            // 
            this.btnQuestionMark.Location = new System.Drawing.Point(246, 242);
            this.btnQuestionMark.Name = "btnQuestionMark";
            this.btnQuestionMark.Size = new System.Drawing.Size(35, 23);
            this.btnQuestionMark.TabIndex = 38;
            this.btnQuestionMark.Text = "?";
            this.btnQuestionMark.UseVisualStyleBackColor = true;
            this.btnQuestionMark.Click += new System.EventHandler(this.btnQuestionMark_Click);
            // 
            // btnMoreThanOrEqual
            // 
            this.btnMoreThanOrEqual.Location = new System.Drawing.Point(205, 242);
            this.btnMoreThanOrEqual.Name = "btnMoreThanOrEqual";
            this.btnMoreThanOrEqual.Size = new System.Drawing.Size(35, 23);
            this.btnMoreThanOrEqual.TabIndex = 37;
            this.btnMoreThanOrEqual.Text = ">=";
            this.btnMoreThanOrEqual.UseVisualStyleBackColor = true;
            this.btnMoreThanOrEqual.Click += new System.EventHandler(this.btnMoreThanOrEqual_Click);
            // 
            // btnNotEqual
            // 
            this.btnNotEqual.Location = new System.Drawing.Point(41, 242);
            this.btnNotEqual.Name = "btnNotEqual";
            this.btnNotEqual.Size = new System.Drawing.Size(35, 23);
            this.btnNotEqual.TabIndex = 36;
            this.btnNotEqual.Text = "<>";
            this.btnNotEqual.UseVisualStyleBackColor = true;
            this.btnNotEqual.Click += new System.EventHandler(this.btnNotEqual_Click);
            // 
            // btnLessThanOrEqual
            // 
            this.btnLessThanOrEqual.Location = new System.Drawing.Point(123, 242);
            this.btnLessThanOrEqual.Name = "btnLessThanOrEqual";
            this.btnLessThanOrEqual.Size = new System.Drawing.Size(35, 23);
            this.btnLessThanOrEqual.TabIndex = 35;
            this.btnLessThanOrEqual.Text = "<=";
            this.btnLessThanOrEqual.UseVisualStyleBackColor = true;
            this.btnLessThanOrEqual.Click += new System.EventHandler(this.btnLessThanOrEqual_Click);
            // 
            // btnLessThan
            // 
            this.btnLessThan.Location = new System.Drawing.Point(82, 242);
            this.btnLessThan.Name = "btnLessThan";
            this.btnLessThan.Size = new System.Drawing.Size(35, 23);
            this.btnLessThan.TabIndex = 34;
            this.btnLessThan.Text = "<";
            this.btnLessThan.UseVisualStyleBackColor = true;
            this.btnLessThan.Click += new System.EventHandler(this.btnLessThan_Click);
            // 
            // btnMoreThan
            // 
            this.btnMoreThan.Location = new System.Drawing.Point(164, 242);
            this.btnMoreThan.Name = "btnMoreThan";
            this.btnMoreThan.Size = new System.Drawing.Size(35, 23);
            this.btnMoreThan.TabIndex = 33;
            this.btnMoreThan.Text = ">";
            this.btnMoreThan.UseVisualStyleBackColor = true;
            this.btnMoreThan.Click += new System.EventHandler(this.btnMoreThan_Click);
            // 
            // btnEqual
            // 
            this.btnEqual.Location = new System.Drawing.Point(0, 242);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(35, 23);
            this.btnEqual.TabIndex = 32;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = true;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(166, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 13);
            this.label10.TabIndex = 31;
            this.label10.Text = "Unique values:";
            // 
            // uniqueValuesListbox
            // 
            this.uniqueValuesListbox.FormattingEnabled = true;
            this.uniqueValuesListbox.Location = new System.Drawing.Point(169, 89);
            this.uniqueValuesListbox.Name = "uniqueValuesListbox";
            this.uniqueValuesListbox.Size = new System.Drawing.Size(120, 147);
            this.uniqueValuesListbox.TabIndex = 30;
            this.uniqueValuesListbox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.uniqueValuesListbox_MouseDoubleClick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 73);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(121, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "Fields of selected layer:";
            // 
            // fieldsListbox
            // 
            this.fieldsListbox.FormattingEnabled = true;
            this.fieldsListbox.Location = new System.Drawing.Point(3, 89);
            this.fieldsListbox.Name = "fieldsListbox";
            this.fieldsListbox.Size = new System.Drawing.Size(121, 147);
            this.fieldsListbox.TabIndex = 28;
            this.fieldsListbox.SelectedIndexChanged += new System.EventHandler(this.fieldsListbox_SelectedIndexChanged);
            this.fieldsListbox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.fieldsListbox_MouseDoubleClick);
            // 
            // selectionMethodCombobox
            // 
            this.selectionMethodCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectionMethodCombobox.FormattingEnabled = true;
            this.selectionMethodCombobox.Items.AddRange(new object[] {
            "Create new selection",
            "Add to current selection",
            "Remove from current selection"});
            this.selectionMethodCombobox.Location = new System.Drawing.Point(102, 33);
            this.selectionMethodCombobox.Name = "selectionMethodCombobox";
            this.selectionMethodCombobox.Size = new System.Drawing.Size(190, 21);
            this.selectionMethodCombobox.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 36);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Selection Method:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Layer:";
            // 
            // layerAtrCombobox
            // 
            this.layerAtrCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.layerAtrCombobox.FormattingEnabled = true;
            this.layerAtrCombobox.Location = new System.Drawing.Point(102, 6);
            this.layerAtrCombobox.Name = "layerAtrCombobox";
            this.layerAtrCombobox.Size = new System.Drawing.Size(190, 21);
            this.layerAtrCombobox.TabIndex = 24;
            this.layerAtrCombobox.SelectedIndexChanged += new System.EventHandler(this.layerAtrCombobox_SelectedIndexChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(246, 18);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(38, 13);
            this.label17.TabIndex = 56;
            this.label17.Text = "Layer:";
            // 
            // layerClearCombobox
            // 
            this.layerClearCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.layerClearCombobox.FormattingEnabled = true;
            this.layerClearCombobox.Location = new System.Drawing.Point(290, 15);
            this.layerClearCombobox.Name = "layerClearCombobox";
            this.layerClearCombobox.Size = new System.Drawing.Size(318, 21);
            this.layerClearCombobox.TabIndex = 56;
            // 
            // axMapControl1
            // 
            this.axMapControl1.Location = new System.Drawing.Point(618, 94);
            this.axMapControl1.Name = "axMapControl1";
            this.axMapControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axMapControl1.OcxState")));
            this.axMapControl1.Size = new System.Drawing.Size(643, 584);
            this.axMapControl1.TabIndex = 39;
            this.axMapControl1.OnMouseMove += new ESRI.ArcGIS.Controls.IMapControlEvents2_Ax_OnMouseMoveEventHandler(this.axMapControl1_OnMouseMove);
            // 
            // showAtrBtn
            // 
            this.showAtrBtn.Location = new System.Drawing.Point(290, 48);
            this.showAtrBtn.Name = "showAtrBtn";
            this.showAtrBtn.Size = new System.Drawing.Size(153, 33);
            this.showAtrBtn.TabIndex = 57;
            this.showAtrBtn.Text = "Show Layer Attributes";
            this.showAtrBtn.UseVisualStyleBackColor = true;
            this.showAtrBtn.Click += new System.EventHandler(this.showAtrBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 720);
            this.Controls.Add(this.showAtrBtn);
            this.Controls.Add(this.layerClearCombobox);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.layerManagementBtn);
            this.Controls.Add(this.clearSelectionButton);
            this.Controls.Add(this.currentLocationLabel);
            this.Controls.Add(this.queryBtn);
            this.Controls.Add(this.fullExtentButton);
            this.Controls.Add(this.zoomOutButton);
            this.Controls.Add(this.zoomInButton);
            this.Controls.Add(this.axMapControl1);
            this.Controls.Add(this.dataFramesCombo);
            this.Controls.Add(this.loadMapDocumentButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mapDocumentTextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.attributesDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axMapControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button clearSelectionButton;
        private System.Windows.Forms.Button queryBtn;
        private System.Windows.Forms.Button executeQueryButton;
        private System.Windows.Forms.TextBox definitionQueryTextbox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button removeLayerButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button addLayerButton;
        private System.Windows.Forms.TextBox layerIndexTextbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox layerNameTextbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox featureClassTextbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox geodatabaseTextbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox layersListBox;
        private System.Windows.Forms.ComboBox dataFramesCombo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label activeDataFrameLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button loadMapDocumentButton;
        private System.Windows.Forms.TextBox mapDocumentTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label currentLocationLabel;
        private System.Windows.Forms.Button fullExtentButton;
        private System.Windows.Forms.Button zoomOutButton;
        private System.Windows.Forms.Button zoomInButton;
        private ESRI.ArcGIS.Controls.AxMapControl axMapControl1;
        private System.Windows.Forms.Button layerManagementBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox spatialRelationshipCombobox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox layerLocCombobox;
        private System.Windows.Forms.Button executeAtrQueryBtn;
        private System.Windows.Forms.Label atrSelectLabel;
        private System.Windows.Forms.TextBox atrQueryTextbox;
        private System.Windows.Forms.Button btnIs;
        private System.Windows.Forms.Button btnNot;
        private System.Windows.Forms.Button btnOr;
        private System.Windows.Forms.Button btnAnd;
        private System.Windows.Forms.Button btnLike;
        private System.Windows.Forms.Button btnQuestionMark;
        private System.Windows.Forms.Button btnMoreThanOrEqual;
        private System.Windows.Forms.Button btnNotEqual;
        private System.Windows.Forms.Button btnLessThanOrEqual;
        private System.Windows.Forms.Button btnLessThan;
        private System.Windows.Forms.Button btnMoreThan;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox uniqueValuesListbox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListBox fieldsListbox;
        private System.Windows.Forms.ComboBox selectionMethodCombobox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox layerAtrCombobox;
        private System.Windows.Forms.Button executeSpatialQueryBtn;
        private System.Windows.Forms.DataGridView attributesDataGrid;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox layerClearCombobox;
        private System.Windows.Forms.Button showAtrBtn;

    }
}


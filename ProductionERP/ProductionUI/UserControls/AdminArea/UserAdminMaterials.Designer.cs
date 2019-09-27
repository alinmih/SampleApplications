﻿namespace ProductionUI.UserControls.AdminArea
{
    partial class UserAdminMaterials
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.leftPanel = new System.Windows.Forms.Panel();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.topPanel = new System.Windows.Forms.Panel();
            this.borromPanel = new System.Windows.Forms.Panel();
            this.userPanel = new System.Windows.Forms.Panel();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.materialsListPanel = new System.Windows.Forms.Panel();
            this.materialsListMainPanel = new System.Windows.Forms.Panel();
            this.rawMaterialDataGridView = new System.Windows.Forms.DataGridView();
            this.materialsListHeaderPanel = new System.Windows.Forms.Panel();
            this.materialDeleteButton = new System.Windows.Forms.Button();
            this.materialModifyButton = new System.Windows.Forms.Button();
            this.materialCreateButton = new System.Windows.Forms.Button();
            this.materialListLabel = new System.Windows.Forms.Label();
            this.materialsCatPanel = new System.Windows.Forms.Panel();
            this.materialCatMainPanel = new System.Windows.Forms.Panel();
            this.warehousePanel = new System.Windows.Forms.Panel();
            this.warehouseListPanel = new System.Windows.Forms.Panel();
            this.warehouseDataGridView = new System.Windows.Forms.DataGridView();
            this.warehouseNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.warehouseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.warehouseHeaderPanel = new System.Windows.Forms.Panel();
            this.deleteWarehouseButton = new System.Windows.Forms.Button();
            this.modifyWarehouseButton = new System.Windows.Forms.Button();
            this.createWarehouseButton = new System.Windows.Forms.Button();
            this.warehouseLabel = new System.Windows.Forms.Label();
            this.materialsCatMainPanel = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.materialCatGrid = new System.Windows.Forms.DataGridView();
            this.categoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.separationPanel = new System.Windows.Forms.Panel();
            this.materialsCatHeaderPanel = new System.Windows.Forms.Panel();
            this.materialCatDeleteButton = new System.Windows.Forms.Button();
            this.materialCatModifyButton = new System.Windows.Forms.Button();
            this.materialCatCreateButton = new System.Windows.Forms.Button();
            this.materialCatLabel = new System.Windows.Forms.Label();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.materialCostLabel = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.dataGridColMaterialNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridColMaterialName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialCat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialLenght = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialWidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialThick = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialMeasureUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridColStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridColValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridColLoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.materialsListPanel.SuspendLayout();
            this.materialsListMainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rawMaterialDataGridView)).BeginInit();
            this.materialsListHeaderPanel.SuspendLayout();
            this.materialsCatPanel.SuspendLayout();
            this.materialCatMainPanel.SuspendLayout();
            this.warehousePanel.SuspendLayout();
            this.warehouseListPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseDataGridView)).BeginInit();
            this.warehouseHeaderPanel.SuspendLayout();
            this.materialsCatMainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materialCatGrid)).BeginInit();
            this.materialsCatHeaderPanel.SuspendLayout();
            this.headerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(10, 687);
            this.leftPanel.TabIndex = 0;
            // 
            // rightPanel
            // 
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightPanel.Location = new System.Drawing.Point(925, 0);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(10, 687);
            this.rightPanel.TabIndex = 1;
            // 
            // topPanel
            // 
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(10, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(915, 10);
            this.topPanel.TabIndex = 2;
            // 
            // borromPanel
            // 
            this.borromPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.borromPanel.Location = new System.Drawing.Point(10, 677);
            this.borromPanel.Name = "borromPanel";
            this.borromPanel.Size = new System.Drawing.Size(915, 10);
            this.borromPanel.TabIndex = 3;
            // 
            // userPanel
            // 
            this.userPanel.Controls.Add(this.mainPanel);
            this.userPanel.Controls.Add(this.headerPanel);
            this.userPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userPanel.Location = new System.Drawing.Point(10, 10);
            this.userPanel.Name = "userPanel";
            this.userPanel.Size = new System.Drawing.Size(915, 667);
            this.userPanel.TabIndex = 4;
            // 
            // mainPanel
            // 
            this.mainPanel.AutoScroll = true;
            this.mainPanel.AutoScrollMinSize = new System.Drawing.Size(0, 559);
            this.mainPanel.Controls.Add(this.materialsListPanel);
            this.mainPanel.Controls.Add(this.materialsCatPanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 40);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(915, 627);
            this.mainPanel.TabIndex = 1;
            // 
            // materialsListPanel
            // 
            this.materialsListPanel.Controls.Add(this.materialsListMainPanel);
            this.materialsListPanel.Controls.Add(this.materialsListHeaderPanel);
            this.materialsListPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialsListPanel.Location = new System.Drawing.Point(0, 0);
            this.materialsListPanel.Name = "materialsListPanel";
            this.materialsListPanel.Size = new System.Drawing.Size(523, 627);
            this.materialsListPanel.TabIndex = 1;
            // 
            // materialsListMainPanel
            // 
            this.materialsListMainPanel.Controls.Add(this.rawMaterialDataGridView);
            this.materialsListMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialsListMainPanel.Location = new System.Drawing.Point(0, 66);
            this.materialsListMainPanel.Name = "materialsListMainPanel";
            this.materialsListMainPanel.Size = new System.Drawing.Size(523, 561);
            this.materialsListMainPanel.TabIndex = 1;
            // 
            // rawMaterialDataGridView
            // 
            this.rawMaterialDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rawMaterialDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridColMaterialNumber,
            this.dataGridColMaterialName,
            this.materialCat,
            this.materialLenght,
            this.materialWidth,
            this.materialThick,
            this.materialMeasureUnit,
            this.materialPrice,
            this.dataGridColStock,
            this.dataGridColValue,
            this.dataGridColLoc});
            this.rawMaterialDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rawMaterialDataGridView.Location = new System.Drawing.Point(0, 0);
            this.rawMaterialDataGridView.Name = "rawMaterialDataGridView";
            this.rawMaterialDataGridView.RowHeadersVisible = false;
            this.rawMaterialDataGridView.Size = new System.Drawing.Size(523, 561);
            this.rawMaterialDataGridView.TabIndex = 10;
            // 
            // materialsListHeaderPanel
            // 
            this.materialsListHeaderPanel.Controls.Add(this.materialDeleteButton);
            this.materialsListHeaderPanel.Controls.Add(this.materialModifyButton);
            this.materialsListHeaderPanel.Controls.Add(this.materialCreateButton);
            this.materialsListHeaderPanel.Controls.Add(this.materialListLabel);
            this.materialsListHeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialsListHeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.materialsListHeaderPanel.Name = "materialsListHeaderPanel";
            this.materialsListHeaderPanel.Size = new System.Drawing.Size(523, 66);
            this.materialsListHeaderPanel.TabIndex = 0;
            // 
            // materialDeleteButton
            // 
            this.materialDeleteButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.materialDeleteButton.FlatAppearance.BorderSize = 0;
            this.materialDeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialDeleteButton.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialDeleteButton.ForeColor = System.Drawing.Color.White;
            this.materialDeleteButton.Location = new System.Drawing.Point(267, 25);
            this.materialDeleteButton.Name = "materialDeleteButton";
            this.materialDeleteButton.Size = new System.Drawing.Size(121, 31);
            this.materialDeleteButton.TabIndex = 27;
            this.materialDeleteButton.Text = "Delete";
            this.materialDeleteButton.UseVisualStyleBackColor = false;
            // 
            // materialModifyButton
            // 
            this.materialModifyButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.materialModifyButton.FlatAppearance.BorderSize = 0;
            this.materialModifyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialModifyButton.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialModifyButton.ForeColor = System.Drawing.Color.White;
            this.materialModifyButton.Location = new System.Drawing.Point(140, 25);
            this.materialModifyButton.Name = "materialModifyButton";
            this.materialModifyButton.Size = new System.Drawing.Size(121, 31);
            this.materialModifyButton.TabIndex = 28;
            this.materialModifyButton.Text = "Modify";
            this.materialModifyButton.UseVisualStyleBackColor = false;
            this.materialModifyButton.Click += new System.EventHandler(this.MaterialModifyButton_Click);
            // 
            // materialCreateButton
            // 
            this.materialCreateButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.materialCreateButton.FlatAppearance.BorderSize = 0;
            this.materialCreateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialCreateButton.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialCreateButton.ForeColor = System.Drawing.Color.White;
            this.materialCreateButton.Location = new System.Drawing.Point(11, 25);
            this.materialCreateButton.Name = "materialCreateButton";
            this.materialCreateButton.Size = new System.Drawing.Size(121, 31);
            this.materialCreateButton.TabIndex = 29;
            this.materialCreateButton.Text = "Create";
            this.materialCreateButton.UseVisualStyleBackColor = false;
            this.materialCreateButton.Click += new System.EventHandler(this.MaterialCreateButton_Click);
            // 
            // materialListLabel
            // 
            this.materialListLabel.AutoSize = true;
            this.materialListLabel.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialListLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.materialListLabel.Location = new System.Drawing.Point(7, 3);
            this.materialListLabel.Name = "materialListLabel";
            this.materialListLabel.Size = new System.Drawing.Size(120, 19);
            this.materialListLabel.TabIndex = 26;
            this.materialListLabel.Text = "Materials List";
            // 
            // materialsCatPanel
            // 
            this.materialsCatPanel.Controls.Add(this.materialCatMainPanel);
            this.materialsCatPanel.Controls.Add(this.materialsCatHeaderPanel);
            this.materialsCatPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.materialsCatPanel.Location = new System.Drawing.Point(523, 0);
            this.materialsCatPanel.Name = "materialsCatPanel";
            this.materialsCatPanel.Size = new System.Drawing.Size(392, 627);
            this.materialsCatPanel.TabIndex = 0;
            // 
            // materialCatMainPanel
            // 
            this.materialCatMainPanel.Controls.Add(this.warehousePanel);
            this.materialCatMainPanel.Controls.Add(this.materialsCatMainPanel);
            this.materialCatMainPanel.Controls.Add(this.separationPanel);
            this.materialCatMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialCatMainPanel.Location = new System.Drawing.Point(0, 66);
            this.materialCatMainPanel.Name = "materialCatMainPanel";
            this.materialCatMainPanel.Size = new System.Drawing.Size(392, 561);
            this.materialCatMainPanel.TabIndex = 1;
            // 
            // warehousePanel
            // 
            this.warehousePanel.Controls.Add(this.warehouseListPanel);
            this.warehousePanel.Controls.Add(this.warehouseHeaderPanel);
            this.warehousePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.warehousePanel.Location = new System.Drawing.Point(10, 288);
            this.warehousePanel.Name = "warehousePanel";
            this.warehousePanel.Size = new System.Drawing.Size(382, 273);
            this.warehousePanel.TabIndex = 14;
            // 
            // warehouseListPanel
            // 
            this.warehouseListPanel.Controls.Add(this.warehouseDataGridView);
            this.warehouseListPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.warehouseListPanel.Location = new System.Drawing.Point(0, 62);
            this.warehouseListPanel.Name = "warehouseListPanel";
            this.warehouseListPanel.Size = new System.Drawing.Size(382, 211);
            this.warehouseListPanel.TabIndex = 1;
            // 
            // warehouseDataGridView
            // 
            this.warehouseDataGridView.AllowUserToAddRows = false;
            this.warehouseDataGridView.AllowUserToDeleteRows = false;
            this.warehouseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.warehouseDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.warehouseNumber,
            this.warehouseName});
            this.warehouseDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.warehouseDataGridView.Location = new System.Drawing.Point(0, 0);
            this.warehouseDataGridView.Name = "warehouseDataGridView";
            this.warehouseDataGridView.ReadOnly = true;
            this.warehouseDataGridView.RowHeadersVisible = false;
            this.warehouseDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.warehouseDataGridView.Size = new System.Drawing.Size(382, 211);
            this.warehouseDataGridView.TabIndex = 13;
            // 
            // warehouseNumber
            // 
            this.warehouseNumber.HeaderText = "Number";
            this.warehouseNumber.Name = "warehouseNumber";
            this.warehouseNumber.ReadOnly = true;
            // 
            // warehouseName
            // 
            this.warehouseName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.warehouseName.HeaderText = "Name";
            this.warehouseName.MinimumWidth = 200;
            this.warehouseName.Name = "warehouseName";
            this.warehouseName.ReadOnly = true;
            // 
            // warehouseHeaderPanel
            // 
            this.warehouseHeaderPanel.Controls.Add(this.deleteWarehouseButton);
            this.warehouseHeaderPanel.Controls.Add(this.modifyWarehouseButton);
            this.warehouseHeaderPanel.Controls.Add(this.createWarehouseButton);
            this.warehouseHeaderPanel.Controls.Add(this.warehouseLabel);
            this.warehouseHeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.warehouseHeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.warehouseHeaderPanel.Name = "warehouseHeaderPanel";
            this.warehouseHeaderPanel.Size = new System.Drawing.Size(382, 62);
            this.warehouseHeaderPanel.TabIndex = 0;
            // 
            // deleteWarehouseButton
            // 
            this.deleteWarehouseButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.deleteWarehouseButton.FlatAppearance.BorderSize = 0;
            this.deleteWarehouseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteWarehouseButton.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteWarehouseButton.ForeColor = System.Drawing.Color.White;
            this.deleteWarehouseButton.Location = new System.Drawing.Point(269, 27);
            this.deleteWarehouseButton.Name = "deleteWarehouseButton";
            this.deleteWarehouseButton.Size = new System.Drawing.Size(111, 31);
            this.deleteWarehouseButton.TabIndex = 34;
            this.deleteWarehouseButton.Text = "Delete";
            this.deleteWarehouseButton.UseVisualStyleBackColor = false;
            // 
            // modifyWarehouseButton
            // 
            this.modifyWarehouseButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.modifyWarehouseButton.FlatAppearance.BorderSize = 0;
            this.modifyWarehouseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modifyWarehouseButton.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyWarehouseButton.ForeColor = System.Drawing.Color.White;
            this.modifyWarehouseButton.Location = new System.Drawing.Point(138, 27);
            this.modifyWarehouseButton.Name = "modifyWarehouseButton";
            this.modifyWarehouseButton.Size = new System.Drawing.Size(111, 31);
            this.modifyWarehouseButton.TabIndex = 35;
            this.modifyWarehouseButton.Text = "Modify";
            this.modifyWarehouseButton.UseVisualStyleBackColor = false;
            this.modifyWarehouseButton.Click += new System.EventHandler(this.ModifyWarehouseButton_Click);
            // 
            // createWarehouseButton
            // 
            this.createWarehouseButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.createWarehouseButton.FlatAppearance.BorderSize = 0;
            this.createWarehouseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createWarehouseButton.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createWarehouseButton.ForeColor = System.Drawing.Color.White;
            this.createWarehouseButton.Location = new System.Drawing.Point(7, 27);
            this.createWarehouseButton.Name = "createWarehouseButton";
            this.createWarehouseButton.Size = new System.Drawing.Size(111, 31);
            this.createWarehouseButton.TabIndex = 36;
            this.createWarehouseButton.Text = "Create";
            this.createWarehouseButton.UseVisualStyleBackColor = false;
            this.createWarehouseButton.Click += new System.EventHandler(this.CreateWarehouseButton_Click);
            // 
            // warehouseLabel
            // 
            this.warehouseLabel.AutoSize = true;
            this.warehouseLabel.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warehouseLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.warehouseLabel.Location = new System.Drawing.Point(3, 5);
            this.warehouseLabel.Name = "warehouseLabel";
            this.warehouseLabel.Size = new System.Drawing.Size(104, 19);
            this.warehouseLabel.TabIndex = 33;
            this.warehouseLabel.Text = "Warehouses";
            // 
            // materialsCatMainPanel
            // 
            this.materialsCatMainPanel.Controls.Add(this.panel4);
            this.materialsCatMainPanel.Controls.Add(this.materialCatGrid);
            this.materialsCatMainPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialsCatMainPanel.Location = new System.Drawing.Point(10, 0);
            this.materialsCatMainPanel.Name = "materialsCatMainPanel";
            this.materialsCatMainPanel.Size = new System.Drawing.Size(382, 288);
            this.materialsCatMainPanel.TabIndex = 13;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 278);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(382, 10);
            this.panel4.TabIndex = 13;
            // 
            // materialCatGrid
            // 
            this.materialCatGrid.AllowUserToAddRows = false;
            this.materialCatGrid.AllowUserToDeleteRows = false;
            this.materialCatGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.materialCatGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.categoryName});
            this.materialCatGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialCatGrid.Location = new System.Drawing.Point(0, 0);
            this.materialCatGrid.Name = "materialCatGrid";
            this.materialCatGrid.ReadOnly = true;
            this.materialCatGrid.RowHeadersVisible = false;
            this.materialCatGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.materialCatGrid.Size = new System.Drawing.Size(382, 288);
            this.materialCatGrid.TabIndex = 12;
            // 
            // categoryName
            // 
            this.categoryName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.categoryName.HeaderText = "Material Category Name";
            this.categoryName.Name = "categoryName";
            this.categoryName.ReadOnly = true;
            // 
            // separationPanel
            // 
            this.separationPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.separationPanel.Location = new System.Drawing.Point(0, 0);
            this.separationPanel.Name = "separationPanel";
            this.separationPanel.Size = new System.Drawing.Size(10, 561);
            this.separationPanel.TabIndex = 12;
            // 
            // materialsCatHeaderPanel
            // 
            this.materialsCatHeaderPanel.Controls.Add(this.materialCatDeleteButton);
            this.materialsCatHeaderPanel.Controls.Add(this.materialCatModifyButton);
            this.materialsCatHeaderPanel.Controls.Add(this.materialCatCreateButton);
            this.materialsCatHeaderPanel.Controls.Add(this.materialCatLabel);
            this.materialsCatHeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialsCatHeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.materialsCatHeaderPanel.Name = "materialsCatHeaderPanel";
            this.materialsCatHeaderPanel.Size = new System.Drawing.Size(392, 66);
            this.materialsCatHeaderPanel.TabIndex = 0;
            // 
            // materialCatDeleteButton
            // 
            this.materialCatDeleteButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.materialCatDeleteButton.FlatAppearance.BorderSize = 0;
            this.materialCatDeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialCatDeleteButton.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialCatDeleteButton.ForeColor = System.Drawing.Color.White;
            this.materialCatDeleteButton.Location = new System.Drawing.Point(277, 25);
            this.materialCatDeleteButton.Name = "materialCatDeleteButton";
            this.materialCatDeleteButton.Size = new System.Drawing.Size(111, 31);
            this.materialCatDeleteButton.TabIndex = 30;
            this.materialCatDeleteButton.Text = "Delete";
            this.materialCatDeleteButton.UseVisualStyleBackColor = false;
            // 
            // materialCatModifyButton
            // 
            this.materialCatModifyButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.materialCatModifyButton.FlatAppearance.BorderSize = 0;
            this.materialCatModifyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialCatModifyButton.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialCatModifyButton.ForeColor = System.Drawing.Color.White;
            this.materialCatModifyButton.Location = new System.Drawing.Point(146, 25);
            this.materialCatModifyButton.Name = "materialCatModifyButton";
            this.materialCatModifyButton.Size = new System.Drawing.Size(111, 31);
            this.materialCatModifyButton.TabIndex = 31;
            this.materialCatModifyButton.Text = "Modify";
            this.materialCatModifyButton.UseVisualStyleBackColor = false;
            this.materialCatModifyButton.Click += new System.EventHandler(this.MaterialCatModifyButton_Click);
            // 
            // materialCatCreateButton
            // 
            this.materialCatCreateButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.materialCatCreateButton.FlatAppearance.BorderSize = 0;
            this.materialCatCreateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialCatCreateButton.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialCatCreateButton.ForeColor = System.Drawing.Color.White;
            this.materialCatCreateButton.Location = new System.Drawing.Point(15, 25);
            this.materialCatCreateButton.Name = "materialCatCreateButton";
            this.materialCatCreateButton.Size = new System.Drawing.Size(111, 31);
            this.materialCatCreateButton.TabIndex = 32;
            this.materialCatCreateButton.Text = "Create";
            this.materialCatCreateButton.UseVisualStyleBackColor = false;
            this.materialCatCreateButton.Click += new System.EventHandler(this.MaterialCatCreateButton_Click);
            // 
            // materialCatLabel
            // 
            this.materialCatLabel.AutoSize = true;
            this.materialCatLabel.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialCatLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.materialCatLabel.Location = new System.Drawing.Point(11, 3);
            this.materialCatLabel.Name = "materialCatLabel";
            this.materialCatLabel.Size = new System.Drawing.Size(176, 19);
            this.materialCatLabel.TabIndex = 29;
            this.materialCatLabel.Text = "Materials Categories";
            // 
            // headerPanel
            // 
            this.headerPanel.Controls.Add(this.materialCostLabel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(915, 40);
            this.headerPanel.TabIndex = 0;
            // 
            // materialCostLabel
            // 
            this.materialCostLabel.AutoSize = true;
            this.materialCostLabel.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialCostLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.materialCostLabel.Location = new System.Drawing.Point(6, 3);
            this.materialCostLabel.Name = "materialCostLabel";
            this.materialCostLabel.Size = new System.Drawing.Size(295, 25);
            this.materialCostLabel.TabIndex = 21;
            this.materialCostLabel.Text = "Material Management Area";
            // 
            // dataGridColMaterialNumber
            // 
            this.dataGridColMaterialNumber.HeaderText = "Material No.";
            this.dataGridColMaterialNumber.Name = "dataGridColMaterialNumber";
            this.dataGridColMaterialNumber.ReadOnly = true;
            // 
            // dataGridColMaterialName
            // 
            this.dataGridColMaterialName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridColMaterialName.HeaderText = "Name";
            this.dataGridColMaterialName.MinimumWidth = 200;
            this.dataGridColMaterialName.Name = "dataGridColMaterialName";
            this.dataGridColMaterialName.ReadOnly = true;
            // 
            // materialCat
            // 
            this.materialCat.HeaderText = "Material Type";
            this.materialCat.Name = "materialCat";
            this.materialCat.ReadOnly = true;
            this.materialCat.Width = 150;
            // 
            // materialLenght
            // 
            this.materialLenght.HeaderText = "Lenght";
            this.materialLenght.Name = "materialLenght";
            this.materialLenght.ReadOnly = true;
            // 
            // materialWidth
            // 
            this.materialWidth.HeaderText = "Width";
            this.materialWidth.Name = "materialWidth";
            this.materialWidth.ReadOnly = true;
            // 
            // materialThick
            // 
            this.materialThick.HeaderText = "Thick";
            this.materialThick.Name = "materialThick";
            this.materialThick.ReadOnly = true;
            // 
            // materialMeasureUnit
            // 
            this.materialMeasureUnit.HeaderText = "Measure Unit";
            this.materialMeasureUnit.Name = "materialMeasureUnit";
            this.materialMeasureUnit.ReadOnly = true;
            // 
            // materialPrice
            // 
            this.materialPrice.HeaderText = "Price";
            this.materialPrice.Name = "materialPrice";
            this.materialPrice.ReadOnly = true;
            // 
            // dataGridColStock
            // 
            this.dataGridColStock.HeaderText = "Stock";
            this.dataGridColStock.Name = "dataGridColStock";
            this.dataGridColStock.ReadOnly = true;
            // 
            // dataGridColValue
            // 
            this.dataGridColValue.HeaderText = "Value";
            this.dataGridColValue.Name = "dataGridColValue";
            this.dataGridColValue.ReadOnly = true;
            // 
            // dataGridColLoc
            // 
            this.dataGridColLoc.HeaderText = "Location";
            this.dataGridColLoc.MinimumWidth = 100;
            this.dataGridColLoc.Name = "dataGridColLoc";
            this.dataGridColLoc.ReadOnly = true;
            // 
            // UserAdminMaterials
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(824, 677);
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.userPanel);
            this.Controls.Add(this.borromPanel);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.rightPanel);
            this.Controls.Add(this.leftPanel);
            this.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Name = "UserAdminMaterials";
            this.Size = new System.Drawing.Size(935, 677);
            this.userPanel.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.materialsListPanel.ResumeLayout(false);
            this.materialsListMainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rawMaterialDataGridView)).EndInit();
            this.materialsListHeaderPanel.ResumeLayout(false);
            this.materialsListHeaderPanel.PerformLayout();
            this.materialsCatPanel.ResumeLayout(false);
            this.materialCatMainPanel.ResumeLayout(false);
            this.warehousePanel.ResumeLayout(false);
            this.warehouseListPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.warehouseDataGridView)).EndInit();
            this.warehouseHeaderPanel.ResumeLayout(false);
            this.warehouseHeaderPanel.PerformLayout();
            this.materialsCatMainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.materialCatGrid)).EndInit();
            this.materialsCatHeaderPanel.ResumeLayout(false);
            this.materialsCatHeaderPanel.PerformLayout();
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel borromPanel;
        private System.Windows.Forms.Panel userPanel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel materialsListPanel;
        private System.Windows.Forms.Panel materialsListHeaderPanel;
        private System.Windows.Forms.Panel materialsCatPanel;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Panel materialsCatHeaderPanel;
        private System.Windows.Forms.Panel materialsListMainPanel;
        private System.Windows.Forms.DataGridView rawMaterialDataGridView;
        private System.Windows.Forms.Panel materialCatMainPanel;
        private System.Windows.Forms.Label materialCostLabel;
        private System.Windows.Forms.Button materialDeleteButton;
        private System.Windows.Forms.Button materialModifyButton;
        private System.Windows.Forms.Button materialCreateButton;
        private System.Windows.Forms.Label materialListLabel;
        private System.Windows.Forms.Button materialCatDeleteButton;
        private System.Windows.Forms.Button materialCatModifyButton;
        private System.Windows.Forms.Button materialCatCreateButton;
        private System.Windows.Forms.Label materialCatLabel;
        private System.Windows.Forms.Panel materialsCatMainPanel;
        private System.Windows.Forms.DataGridView materialCatGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryName;
        private System.Windows.Forms.Panel separationPanel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Panel warehousePanel;
        private System.Windows.Forms.Panel warehouseListPanel;
        private System.Windows.Forms.DataGridView warehouseDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn warehouseNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn warehouseName;
        private System.Windows.Forms.Panel warehouseHeaderPanel;
        private System.Windows.Forms.Button deleteWarehouseButton;
        private System.Windows.Forms.Button modifyWarehouseButton;
        private System.Windows.Forms.Button createWarehouseButton;
        private System.Windows.Forms.Label warehouseLabel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridColMaterialNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridColMaterialName;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialCat;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialLenght;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialWidth;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialThick;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialMeasureUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridColStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridColValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridColLoc;
    }
}

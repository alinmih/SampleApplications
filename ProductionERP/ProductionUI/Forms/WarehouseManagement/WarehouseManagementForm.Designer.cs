﻿namespace ProductionUI.Forms.WarehouseManagement
{
    partial class WarehouseManagementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WarehouseManagementForm));
            this.panelWarehouse = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.rawMaterialDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridColValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.addStockButton = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchByComboBox = new System.Windows.Forms.ComboBox();
            this.searchByLabel = new System.Windows.Forms.Label();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.searchButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.manufacturingCostLabel = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.closeLabel = new System.Windows.Forms.Label();
            this.dataGridColLoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialMeasureUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialThick = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialWidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialLenght = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialCat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridColMaterialName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridColMaterialNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridColStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelWarehouse.SuspendLayout();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rawMaterialDataGridView)).BeginInit();
            this.headerPanel.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.searchPanel.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelWarehouse
            // 
            this.panelWarehouse.Controls.Add(this.panelMain);
            this.panelWarehouse.Controls.Add(this.panelTop);
            this.panelWarehouse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelWarehouse.Location = new System.Drawing.Point(0, 0);
            this.panelWarehouse.Name = "panelWarehouse";
            this.panelWarehouse.Size = new System.Drawing.Size(1200, 658);
            this.panelWarehouse.TabIndex = 0;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.rawMaterialDataGridView);
            this.panelMain.Controls.Add(this.headerPanel);
            this.panelMain.Controls.Add(this.panel2);
            this.panelMain.Controls.Add(this.panel4);
            this.panelMain.Controls.Add(this.panel3);
            this.panelMain.Controls.Add(this.panel1);
            this.panelMain.Controls.Add(this.panel5);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 22);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1200, 636);
            this.panelMain.TabIndex = 1;
            // 
            // rawMaterialDataGridView
            // 
            this.rawMaterialDataGridView.AllowUserToAddRows = false;
            this.rawMaterialDataGridView.AllowUserToDeleteRows = false;
            this.rawMaterialDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rawMaterialDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridColValue});
            this.rawMaterialDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rawMaterialDataGridView.Location = new System.Drawing.Point(10, 142);
            this.rawMaterialDataGridView.Name = "rawMaterialDataGridView";
            this.rawMaterialDataGridView.ReadOnly = true;
            this.rawMaterialDataGridView.RowHeadersVisible = false;
            this.rawMaterialDataGridView.Size = new System.Drawing.Size(1180, 484);
            this.rawMaterialDataGridView.TabIndex = 14;
            // 
            // dataGridColValue
            // 
            this.dataGridColValue.HeaderText = "Value";
            this.dataGridColValue.Name = "dataGridColValue";
            this.dataGridColValue.ReadOnly = true;
            // 
            // headerPanel
            // 
            this.headerPanel.AutoScroll = true;
            this.headerPanel.BackColor = System.Drawing.Color.White;
            this.headerPanel.Controls.Add(this.panel7);
            this.headerPanel.Controls.Add(this.panel6);
            this.headerPanel.Controls.Add(this.searchPanel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(10, 68);
            this.headerPanel.MinimumSize = new System.Drawing.Size(949, 74);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1180, 74);
            this.headerPanel.TabIndex = 15;
            // 
            // panel7
            // 
            this.panel7.AutoScroll = true;
            this.panel7.Controls.Add(this.button1);
            this.panel7.Controls.Add(this.addStockButton);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(319, 74);
            this.panel7.TabIndex = 25;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DimGray;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(150, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 74);
            this.button1.TabIndex = 26;
            this.button1.Text = "Transfer Stock";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // addStockButton
            // 
            this.addStockButton.BackColor = System.Drawing.Color.White;
            this.addStockButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.addStockButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addStockButton.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addStockButton.ForeColor = System.Drawing.Color.DimGray;
            this.addStockButton.Image = ((System.Drawing.Image)(resources.GetObject("addStockButton.Image")));
            this.addStockButton.Location = new System.Drawing.Point(0, 0);
            this.addStockButton.Name = "addStockButton";
            this.addStockButton.Size = new System.Drawing.Size(150, 74);
            this.addStockButton.TabIndex = 25;
            this.addStockButton.Text = "Add Stock";
            this.addStockButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addStockButton.UseVisualStyleBackColor = false;
            // 
            // panel6
            // 
            this.panel6.AutoScroll = true;
            this.panel6.Controls.Add(this.searchTextBox);
            this.panel6.Controls.Add(this.searchByComboBox);
            this.panel6.Controls.Add(this.searchByLabel);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(580, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(475, 74);
            this.panel6.TabIndex = 24;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchTextBox.Location = new System.Drawing.Point(274, 25);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(190, 26);
            this.searchTextBox.TabIndex = 33;
            // 
            // searchByComboBox
            // 
            this.searchByComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchByComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchByComboBox.FormattingEnabled = true;
            this.searchByComboBox.Location = new System.Drawing.Point(106, 25);
            this.searchByComboBox.Name = "searchByComboBox";
            this.searchByComboBox.Size = new System.Drawing.Size(162, 27);
            this.searchByComboBox.TabIndex = 32;
            // 
            // searchByLabel
            // 
            this.searchByLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchByLabel.AutoSize = true;
            this.searchByLabel.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchByLabel.ForeColor = System.Drawing.Color.DimGray;
            this.searchByLabel.Location = new System.Drawing.Point(6, 28);
            this.searchByLabel.Name = "searchByLabel";
            this.searchByLabel.Size = new System.Drawing.Size(87, 19);
            this.searchByLabel.TabIndex = 31;
            this.searchByLabel.Text = "Search By:";
            // 
            // searchPanel
            // 
            this.searchPanel.AutoScroll = true;
            this.searchPanel.Controls.Add(this.searchButton);
            this.searchPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.searchPanel.Location = new System.Drawing.Point(1055, 0);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(125, 74);
            this.searchPanel.TabIndex = 23;
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.White;
            this.searchButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchButton.FlatAppearance.BorderSize = 0;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.ForeColor = System.Drawing.Color.DimGray;
            this.searchButton.Image = ((System.Drawing.Image)(resources.GetObject("searchButton.Image")));
            this.searchButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchButton.Location = new System.Drawing.Point(0, 0);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(125, 74);
            this.searchButton.TabIndex = 32;
            this.searchButton.Text = "Search";
            this.searchButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.searchButton.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 558);
            this.panel2.TabIndex = 12;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1190, 68);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 558);
            this.panel4.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 626);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1200, 10);
            this.panel3.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 8);
            this.panel1.TabIndex = 9;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.manufacturingCostLabel);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1200, 60);
            this.panel5.TabIndex = 13;
            // 
            // manufacturingCostLabel
            // 
            this.manufacturingCostLabel.AutoSize = true;
            this.manufacturingCostLabel.BackColor = System.Drawing.Color.White;
            this.manufacturingCostLabel.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manufacturingCostLabel.ForeColor = System.Drawing.Color.DimGray;
            this.manufacturingCostLabel.Location = new System.Drawing.Point(15, 17);
            this.manufacturingCostLabel.Name = "manufacturingCostLabel";
            this.manufacturingCostLabel.Size = new System.Drawing.Size(231, 25);
            this.manufacturingCostLabel.TabIndex = 3;
            this.manufacturingCostLabel.Text = "Warehouse Materials";
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.White;
            this.panelTop.Controls.Add(this.closeLabel);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1200, 22);
            this.panelTop.TabIndex = 0;
            // 
            // closeLabel
            // 
            this.closeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeLabel.AutoSize = true;
            this.closeLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeLabel.Location = new System.Drawing.Point(1167, 0);
            this.closeLabel.Name = "closeLabel";
            this.closeLabel.Size = new System.Drawing.Size(30, 29);
            this.closeLabel.TabIndex = 17;
            this.closeLabel.Text = "X";
            this.closeLabel.Click += new System.EventHandler(this.closeLabel_Click);
            // 
            // dataGridColLoc
            // 
            this.dataGridColLoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridColLoc.HeaderText = "Location";
            this.dataGridColLoc.MinimumWidth = 200;
            this.dataGridColLoc.Name = "dataGridColLoc";
            this.dataGridColLoc.ReadOnly = true;
            // 
            // materialPrice
            // 
            this.materialPrice.HeaderText = "Price";
            this.materialPrice.Name = "materialPrice";
            this.materialPrice.ReadOnly = true;
            // 
            // materialMeasureUnit
            // 
            this.materialMeasureUnit.HeaderText = "Measure Unit";
            this.materialMeasureUnit.Name = "materialMeasureUnit";
            this.materialMeasureUnit.ReadOnly = true;
            // 
            // materialThick
            // 
            this.materialThick.HeaderText = "Thick";
            this.materialThick.Name = "materialThick";
            this.materialThick.ReadOnly = true;
            // 
            // materialWidth
            // 
            this.materialWidth.HeaderText = "Width";
            this.materialWidth.Name = "materialWidth";
            this.materialWidth.ReadOnly = true;
            // 
            // materialLenght
            // 
            this.materialLenght.HeaderText = "Lenght";
            this.materialLenght.Name = "materialLenght";
            this.materialLenght.ReadOnly = true;
            // 
            // materialCat
            // 
            this.materialCat.HeaderText = "Material Type";
            this.materialCat.Name = "materialCat";
            this.materialCat.ReadOnly = true;
            this.materialCat.Width = 150;
            // 
            // dataGridColMaterialName
            // 
            this.dataGridColMaterialName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridColMaterialName.HeaderText = "Name";
            this.dataGridColMaterialName.MinimumWidth = 200;
            this.dataGridColMaterialName.Name = "dataGridColMaterialName";
            this.dataGridColMaterialName.ReadOnly = true;
            // 
            // dataGridColMaterialNumber
            // 
            this.dataGridColMaterialNumber.HeaderText = "Material No.";
            this.dataGridColMaterialNumber.Name = "dataGridColMaterialNumber";
            this.dataGridColMaterialNumber.ReadOnly = true;
            // 
            // dataGridColStock
            // 
            this.dataGridColStock.HeaderText = "Stock";
            this.dataGridColStock.Name = "dataGridColStock";
            this.dataGridColStock.ReadOnly = true;
            // 
            // WarehouseManagementForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1200, 658);
            this.Controls.Add(this.panelWarehouse);
            this.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DimGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "WarehouseManagementForm";
            this.Text = "Warehouse Management Form";
            this.panelWarehouse.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rawMaterialDataGridView)).EndInit();
            this.headerPanel.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.searchPanel.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelWarehouse;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.DataGridView rawMaterialDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridColValue;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button addStockButton;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.ComboBox searchByComboBox;
        private System.Windows.Forms.Label searchByLabel;
        private System.Windows.Forms.Panel searchPanel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label manufacturingCostLabel;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridColLoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialMeasureUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialThick;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialWidth;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialLenght;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialCat;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridColMaterialName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridColMaterialNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridColStock;
        private System.Windows.Forms.Label closeLabel;
    }
}
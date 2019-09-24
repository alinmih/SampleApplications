﻿namespace ProductionUI.UserControls
{
    partial class UserControlHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlHome));
            this.productsLabel = new System.Windows.Forms.Label();
            this.productionOverviewLabel = new System.Windows.Forms.Label();
            this.productsPanel = new System.Windows.Forms.Panel();
            this.productsValueLabel = new System.Windows.Forms.Label();
            this.productionOrdersPanel = new System.Windows.Forms.Panel();
            this.productionOrdersValueLabel = new System.Windows.Forms.Label();
            this.productionOrdersLabel = new System.Windows.Forms.Label();
            this.salesOrdersPanel = new System.Windows.Forms.Panel();
            this.salesOrdersValueLabel = new System.Windows.Forms.Label();
            this.salesOrdersLabel = new System.Windows.Forms.Label();
            this.offersPanel = new System.Windows.Forms.Panel();
            this.offersValueLabel = new System.Windows.Forms.Label();
            this.offersLabel = new System.Windows.Forms.Label();
            this.warehousePanel = new System.Windows.Forms.Panel();
            this.warehouseStockValueLabel = new System.Windows.Forms.Label();
            this.warehouseLabel = new System.Windows.Forms.Label();
            this.manufacturingCostPanel = new System.Windows.Forms.Panel();
            this.manufacturingCostsValueLabel = new System.Windows.Forms.Label();
            this.manufacturingCostLabel = new System.Windows.Forms.Label();
            this.homeRefreshButton = new System.Windows.Forms.Button();
            this.weeklyReportLabel = new System.Windows.Forms.Label();
            this.weeklyReportChart = new LiveCharts.WinForms.CartesianChart();
            this.productsPanel.SuspendLayout();
            this.productionOrdersPanel.SuspendLayout();
            this.salesOrdersPanel.SuspendLayout();
            this.offersPanel.SuspendLayout();
            this.warehousePanel.SuspendLayout();
            this.manufacturingCostPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // productsLabel
            // 
            this.productsLabel.AutoSize = true;
            this.productsLabel.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productsLabel.ForeColor = System.Drawing.Color.White;
            this.productsLabel.Location = new System.Drawing.Point(14, 12);
            this.productsLabel.Name = "productsLabel";
            this.productsLabel.Size = new System.Drawing.Size(124, 19);
            this.productsLabel.TabIndex = 0;
            this.productsLabel.Text = "Total Products";
            // 
            // productionOverviewLabel
            // 
            this.productionOverviewLabel.AutoSize = true;
            this.productionOverviewLabel.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productionOverviewLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.productionOverviewLabel.Location = new System.Drawing.Point(89, 19);
            this.productionOverviewLabel.Name = "productionOverviewLabel";
            this.productionOverviewLabel.Size = new System.Drawing.Size(228, 25);
            this.productionOverviewLabel.TabIndex = 0;
            this.productionOverviewLabel.Text = "Production Overview";
            // 
            // productsPanel
            // 
            this.productsPanel.BackColor = System.Drawing.Color.PaleGreen;
            this.productsPanel.Controls.Add(this.productsValueLabel);
            this.productsPanel.Controls.Add(this.productsLabel);
            this.productsPanel.ForeColor = System.Drawing.Color.White;
            this.productsPanel.Location = new System.Drawing.Point(94, 77);
            this.productsPanel.Name = "productsPanel";
            this.productsPanel.Size = new System.Drawing.Size(200, 100);
            this.productsPanel.TabIndex = 1;
            // 
            // productsValueLabel
            // 
            this.productsValueLabel.AutoSize = true;
            this.productsValueLabel.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productsValueLabel.ForeColor = System.Drawing.Color.White;
            this.productsValueLabel.Location = new System.Drawing.Point(14, 57);
            this.productsValueLabel.Name = "productsValueLabel";
            this.productsValueLabel.Size = new System.Drawing.Size(67, 19);
            this.productsValueLabel.TabIndex = 0;
            this.productsValueLabel.Text = "<1000>";
            // 
            // productionOrdersPanel
            // 
            this.productionOrdersPanel.BackColor = System.Drawing.Color.Turquoise;
            this.productionOrdersPanel.Controls.Add(this.productionOrdersValueLabel);
            this.productionOrdersPanel.Controls.Add(this.productionOrdersLabel);
            this.productionOrdersPanel.ForeColor = System.Drawing.Color.White;
            this.productionOrdersPanel.Location = new System.Drawing.Point(317, 77);
            this.productionOrdersPanel.Name = "productionOrdersPanel";
            this.productionOrdersPanel.Size = new System.Drawing.Size(240, 100);
            this.productionOrdersPanel.TabIndex = 1;
            // 
            // productionOrdersValueLabel
            // 
            this.productionOrdersValueLabel.AutoSize = true;
            this.productionOrdersValueLabel.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productionOrdersValueLabel.ForeColor = System.Drawing.Color.White;
            this.productionOrdersValueLabel.Location = new System.Drawing.Point(14, 57);
            this.productionOrdersValueLabel.Name = "productionOrdersValueLabel";
            this.productionOrdersValueLabel.Size = new System.Drawing.Size(67, 19);
            this.productionOrdersValueLabel.TabIndex = 0;
            this.productionOrdersValueLabel.Text = "<1000>";
            // 
            // productionOrdersLabel
            // 
            this.productionOrdersLabel.AutoSize = true;
            this.productionOrdersLabel.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productionOrdersLabel.ForeColor = System.Drawing.Color.White;
            this.productionOrdersLabel.Location = new System.Drawing.Point(14, 12);
            this.productionOrdersLabel.Name = "productionOrdersLabel";
            this.productionOrdersLabel.Size = new System.Drawing.Size(209, 19);
            this.productionOrdersLabel.TabIndex = 0;
            this.productionOrdersLabel.Text = "Active Production Orders";
            this.productionOrdersLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // salesOrdersPanel
            // 
            this.salesOrdersPanel.BackColor = System.Drawing.Color.RosyBrown;
            this.salesOrdersPanel.Controls.Add(this.salesOrdersValueLabel);
            this.salesOrdersPanel.Controls.Add(this.salesOrdersLabel);
            this.salesOrdersPanel.ForeColor = System.Drawing.Color.White;
            this.salesOrdersPanel.Location = new System.Drawing.Point(572, 77);
            this.salesOrdersPanel.Name = "salesOrdersPanel";
            this.salesOrdersPanel.Size = new System.Drawing.Size(200, 100);
            this.salesOrdersPanel.TabIndex = 1;
            // 
            // salesOrdersValueLabel
            // 
            this.salesOrdersValueLabel.AutoSize = true;
            this.salesOrdersValueLabel.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesOrdersValueLabel.ForeColor = System.Drawing.Color.White;
            this.salesOrdersValueLabel.Location = new System.Drawing.Point(14, 57);
            this.salesOrdersValueLabel.Name = "salesOrdersValueLabel";
            this.salesOrdersValueLabel.Size = new System.Drawing.Size(67, 19);
            this.salesOrdersValueLabel.TabIndex = 0;
            this.salesOrdersValueLabel.Text = "<1000>";
            // 
            // salesOrdersLabel
            // 
            this.salesOrdersLabel.AutoSize = true;
            this.salesOrdersLabel.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesOrdersLabel.ForeColor = System.Drawing.Color.White;
            this.salesOrdersLabel.Location = new System.Drawing.Point(14, 12);
            this.salesOrdersLabel.Name = "salesOrdersLabel";
            this.salesOrdersLabel.Size = new System.Drawing.Size(163, 19);
            this.salesOrdersLabel.TabIndex = 0;
            this.salesOrdersLabel.Text = "Active Sales Orders";
            this.salesOrdersLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // offersPanel
            // 
            this.offersPanel.BackColor = System.Drawing.Color.Gold;
            this.offersPanel.Controls.Add(this.offersValueLabel);
            this.offersPanel.Controls.Add(this.offersLabel);
            this.offersPanel.ForeColor = System.Drawing.Color.White;
            this.offersPanel.Location = new System.Drawing.Point(94, 195);
            this.offersPanel.Name = "offersPanel";
            this.offersPanel.Size = new System.Drawing.Size(200, 100);
            this.offersPanel.TabIndex = 1;
            // 
            // offersValueLabel
            // 
            this.offersValueLabel.AutoSize = true;
            this.offersValueLabel.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.offersValueLabel.ForeColor = System.Drawing.Color.White;
            this.offersValueLabel.Location = new System.Drawing.Point(14, 57);
            this.offersValueLabel.Name = "offersValueLabel";
            this.offersValueLabel.Size = new System.Drawing.Size(67, 19);
            this.offersValueLabel.TabIndex = 0;
            this.offersValueLabel.Text = "<1000>";
            // 
            // offersLabel
            // 
            this.offersLabel.AutoSize = true;
            this.offersLabel.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.offersLabel.ForeColor = System.Drawing.Color.White;
            this.offersLabel.Location = new System.Drawing.Point(14, 12);
            this.offersLabel.Name = "offersLabel";
            this.offersLabel.Size = new System.Drawing.Size(113, 19);
            this.offersLabel.TabIndex = 0;
            this.offersLabel.Text = "Active Offers";
            this.offersLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // warehousePanel
            // 
            this.warehousePanel.BackColor = System.Drawing.Color.MediumOrchid;
            this.warehousePanel.Controls.Add(this.warehouseStockValueLabel);
            this.warehousePanel.Controls.Add(this.warehouseLabel);
            this.warehousePanel.ForeColor = System.Drawing.Color.White;
            this.warehousePanel.Location = new System.Drawing.Point(317, 195);
            this.warehousePanel.Name = "warehousePanel";
            this.warehousePanel.Size = new System.Drawing.Size(240, 100);
            this.warehousePanel.TabIndex = 1;
            // 
            // warehouseStockValueLabel
            // 
            this.warehouseStockValueLabel.AutoSize = true;
            this.warehouseStockValueLabel.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warehouseStockValueLabel.ForeColor = System.Drawing.Color.White;
            this.warehouseStockValueLabel.Location = new System.Drawing.Point(14, 57);
            this.warehouseStockValueLabel.Name = "warehouseStockValueLabel";
            this.warehouseStockValueLabel.Size = new System.Drawing.Size(67, 19);
            this.warehouseStockValueLabel.TabIndex = 0;
            this.warehouseStockValueLabel.Text = "<1000>";
            // 
            // warehouseLabel
            // 
            this.warehouseLabel.AutoSize = true;
            this.warehouseLabel.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warehouseLabel.ForeColor = System.Drawing.Color.White;
            this.warehouseLabel.Location = new System.Drawing.Point(14, 12);
            this.warehouseLabel.Name = "warehouseLabel";
            this.warehouseLabel.Size = new System.Drawing.Size(143, 19);
            this.warehouseLabel.TabIndex = 0;
            this.warehouseLabel.Text = "Warehouse Stock";
            this.warehouseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // manufacturingCostPanel
            // 
            this.manufacturingCostPanel.BackColor = System.Drawing.Color.DarkCyan;
            this.manufacturingCostPanel.Controls.Add(this.manufacturingCostsValueLabel);
            this.manufacturingCostPanel.Controls.Add(this.manufacturingCostLabel);
            this.manufacturingCostPanel.ForeColor = System.Drawing.Color.White;
            this.manufacturingCostPanel.Location = new System.Drawing.Point(572, 195);
            this.manufacturingCostPanel.Name = "manufacturingCostPanel";
            this.manufacturingCostPanel.Size = new System.Drawing.Size(200, 100);
            this.manufacturingCostPanel.TabIndex = 1;
            // 
            // manufacturingCostsValueLabel
            // 
            this.manufacturingCostsValueLabel.AutoSize = true;
            this.manufacturingCostsValueLabel.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manufacturingCostsValueLabel.ForeColor = System.Drawing.Color.White;
            this.manufacturingCostsValueLabel.Location = new System.Drawing.Point(14, 57);
            this.manufacturingCostsValueLabel.Name = "manufacturingCostsValueLabel";
            this.manufacturingCostsValueLabel.Size = new System.Drawing.Size(67, 19);
            this.manufacturingCostsValueLabel.TabIndex = 0;
            this.manufacturingCostsValueLabel.Text = "<1000>";
            // 
            // manufacturingCostLabel
            // 
            this.manufacturingCostLabel.AutoSize = true;
            this.manufacturingCostLabel.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manufacturingCostLabel.ForeColor = System.Drawing.Color.White;
            this.manufacturingCostLabel.Location = new System.Drawing.Point(14, 12);
            this.manufacturingCostLabel.Name = "manufacturingCostLabel";
            this.manufacturingCostLabel.Size = new System.Drawing.Size(176, 19);
            this.manufacturingCostLabel.TabIndex = 0;
            this.manufacturingCostLabel.Text = "Manufacturing Costs";
            this.manufacturingCostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // homeRefreshButton
            // 
            this.homeRefreshButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.homeRefreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeRefreshButton.Image = ((System.Drawing.Image)(resources.GetObject("homeRefreshButton.Image")));
            this.homeRefreshButton.Location = new System.Drawing.Point(725, 9);
            this.homeRefreshButton.Name = "homeRefreshButton";
            this.homeRefreshButton.Size = new System.Drawing.Size(47, 49);
            this.homeRefreshButton.TabIndex = 2;
            this.homeRefreshButton.UseVisualStyleBackColor = true;
            this.homeRefreshButton.Click += new System.EventHandler(this.HomeRefreshButton_Click);
            // 
            // weeklyReportLabel
            // 
            this.weeklyReportLabel.AutoSize = true;
            this.weeklyReportLabel.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weeklyReportLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.weeklyReportLabel.Location = new System.Drawing.Point(89, 320);
            this.weeklyReportLabel.Name = "weeklyReportLabel";
            this.weeklyReportLabel.Size = new System.Drawing.Size(157, 25);
            this.weeklyReportLabel.TabIndex = 0;
            this.weeklyReportLabel.Text = "Weekly report";
            // 
            // weeklyReportChart
            // 
            this.weeklyReportChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.weeklyReportChart.Location = new System.Drawing.Point(94, 371);
            this.weeklyReportChart.MinimumSize = new System.Drawing.Size(678, 216);
            this.weeklyReportChart.Name = "weeklyReportChart";
            this.weeklyReportChart.Size = new System.Drawing.Size(678, 216);
            this.weeklyReportChart.TabIndex = 3;
            this.weeklyReportChart.Text = "cartesianChart1";
            // 
            // UserControlHome
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.weeklyReportChart);
            this.Controls.Add(this.homeRefreshButton);
            this.Controls.Add(this.manufacturingCostPanel);
            this.Controls.Add(this.warehousePanel);
            this.Controls.Add(this.offersPanel);
            this.Controls.Add(this.salesOrdersPanel);
            this.Controls.Add(this.productionOrdersPanel);
            this.Controls.Add(this.productsPanel);
            this.Controls.Add(this.weeklyReportLabel);
            this.Controls.Add(this.productionOverviewLabel);
            this.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(969, 677);
            this.Name = "UserControlHome";
            this.Size = new System.Drawing.Size(969, 677);
            this.productsPanel.ResumeLayout(false);
            this.productsPanel.PerformLayout();
            this.productionOrdersPanel.ResumeLayout(false);
            this.productionOrdersPanel.PerformLayout();
            this.salesOrdersPanel.ResumeLayout(false);
            this.salesOrdersPanel.PerformLayout();
            this.offersPanel.ResumeLayout(false);
            this.offersPanel.PerformLayout();
            this.warehousePanel.ResumeLayout(false);
            this.warehousePanel.PerformLayout();
            this.manufacturingCostPanel.ResumeLayout(false);
            this.manufacturingCostPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label productsLabel;
        private System.Windows.Forms.Label productionOverviewLabel;
        private System.Windows.Forms.Panel productsPanel;
        private System.Windows.Forms.Label productsValueLabel;
        private System.Windows.Forms.Panel productionOrdersPanel;
        private System.Windows.Forms.Label productionOrdersValueLabel;
        private System.Windows.Forms.Label productionOrdersLabel;
        private System.Windows.Forms.Panel salesOrdersPanel;
        private System.Windows.Forms.Label salesOrdersValueLabel;
        private System.Windows.Forms.Label salesOrdersLabel;
        private System.Windows.Forms.Panel offersPanel;
        private System.Windows.Forms.Label offersValueLabel;
        private System.Windows.Forms.Label offersLabel;
        private System.Windows.Forms.Panel warehousePanel;
        private System.Windows.Forms.Label warehouseStockValueLabel;
        private System.Windows.Forms.Label warehouseLabel;
        private System.Windows.Forms.Panel manufacturingCostPanel;
        private System.Windows.Forms.Label manufacturingCostsValueLabel;
        private System.Windows.Forms.Label manufacturingCostLabel;
        private System.Windows.Forms.Button homeRefreshButton;
        private System.Windows.Forms.Label weeklyReportLabel;
        private LiveCharts.WinForms.CartesianChart weeklyReportChart;
    }
}
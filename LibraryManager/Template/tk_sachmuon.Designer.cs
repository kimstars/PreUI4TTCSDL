﻿
namespace LibraryManager.Template
{
    partial class tk_sachmuon
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.charttk = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lbLoc = new System.Windows.Forms.Label();
            this.lbTKe = new System.Windows.Forms.Label();
            this.guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2ComboBox2 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgv_tksachmuon = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.charttk)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tksachmuon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(266, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh sách sách mượn";
            // 
            // charttk
            // 
            chartArea1.Name = "ChartArea1";
            this.charttk.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.charttk.Legends.Add(legend1);
            this.charttk.Location = new System.Drawing.Point(542, 98);
            this.charttk.Name = "charttk";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Sách mượn ";
            this.charttk.Series.Add(series1);
            this.charttk.Size = new System.Drawing.Size(271, 167);
            this.charttk.TabIndex = 3;
            this.charttk.Text = "chart1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgv_tksachmuon);
            this.panel2.Location = new System.Drawing.Point(54, 317);
            this.panel2.Name = "panel2";
            this.panel2.ShadowDecoration.Parent = this.panel2;
            this.panel2.Size = new System.Drawing.Size(759, 360);
            this.panel2.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BorderRadius = 20;
            this.panel1.Controls.Add(this.guna2ComboBox2);
            this.panel1.Controls.Add(this.guna2ComboBox1);
            this.panel1.Controls.Add(this.lbTKe);
            this.panel1.Controls.Add(this.lbLoc);
            this.panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Location = new System.Drawing.Point(54, 98);
            this.panel1.Name = "panel1";
            this.panel1.ShadowDecoration.Parent = this.panel1;
            this.panel1.Size = new System.Drawing.Size(363, 167);
            this.panel1.TabIndex = 5;
            // 
            // lbLoc
            // 
            this.lbLoc.AutoSize = true;
            this.lbLoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbLoc.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoc.Location = new System.Drawing.Point(26, 34);
            this.lbLoc.Name = "lbLoc";
            this.lbLoc.Size = new System.Drawing.Size(40, 23);
            this.lbLoc.TabIndex = 0;
            this.lbLoc.Text = "Lọc:";
            // 
            // lbTKe
            // 
            this.lbTKe.AutoSize = true;
            this.lbTKe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbTKe.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTKe.Location = new System.Drawing.Point(26, 96);
            this.lbTKe.Name = "lbTKe";
            this.lbTKe.Size = new System.Drawing.Size(85, 23);
            this.lbTKe.TabIndex = 1;
            this.lbTKe.Text = "Thống kê:";
            // 
            // guna2ComboBox1
            // 
            this.guna2ComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox1.FocusedColor = System.Drawing.Color.Empty;
            this.guna2ComboBox1.FocusedState.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2ComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2ComboBox1.FormattingEnabled = true;
            this.guna2ComboBox1.HoverState.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.ItemHeight = 30;
            this.guna2ComboBox1.ItemsAppearance.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.Location = new System.Drawing.Point(125, 21);
            this.guna2ComboBox1.Name = "guna2ComboBox1";
            this.guna2ComboBox1.ShadowDecoration.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.Size = new System.Drawing.Size(193, 36);
            this.guna2ComboBox1.TabIndex = 2;
            // 
            // guna2ComboBox2
            // 
            this.guna2ComboBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox2.FocusedColor = System.Drawing.Color.Empty;
            this.guna2ComboBox2.FocusedState.Parent = this.guna2ComboBox2;
            this.guna2ComboBox2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2ComboBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2ComboBox2.FormattingEnabled = true;
            this.guna2ComboBox2.HoverState.Parent = this.guna2ComboBox2;
            this.guna2ComboBox2.ItemHeight = 30;
            this.guna2ComboBox2.ItemsAppearance.Parent = this.guna2ComboBox2;
            this.guna2ComboBox2.Location = new System.Drawing.Point(125, 83);
            this.guna2ComboBox2.Name = "guna2ComboBox2";
            this.guna2ComboBox2.ShadowDecoration.Parent = this.guna2ComboBox2;
            this.guna2ComboBox2.Size = new System.Drawing.Size(193, 36);
            this.guna2ComboBox2.TabIndex = 3;
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(542, 98);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Sách mượn ";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(271, 167);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chartTK";
            // 
            // dgv_tksachmuon
            // 
            this.dgv_tksachmuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tksachmuon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_tksachmuon.Location = new System.Drawing.Point(0, 0);
            this.dgv_tksachmuon.Name = "dgv_tksachmuon";
            this.dgv_tksachmuon.RowHeadersWidth = 51;
            this.dgv_tksachmuon.RowTemplate.Height = 24;
            this.dgv_tksachmuon.Size = new System.Drawing.Size(759, 360);
            this.dgv_tksachmuon.TabIndex = 0;
            // 
            // tk_sachmuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.charttk);
            this.Controls.Add(this.label1);
            this.Name = "tk_sachmuon";
            this.Size = new System.Drawing.Size(895, 755);
            ((System.ComponentModel.ISupportInitialize)(this.charttk)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tksachmuon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart charttk;
        private Guna.UI2.WinForms.Guna2Panel panel2;
        private Guna.UI2.WinForms.Guna2Panel panel1;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox2;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
        private System.Windows.Forms.Label lbTKe;
        private System.Windows.Forms.Label lbLoc;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridView dgv_tksachmuon;
    }
}

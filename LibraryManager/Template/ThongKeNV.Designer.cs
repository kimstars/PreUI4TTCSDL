
namespace LibraryManager.Template
{
    partial class ThongKeNV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThongKeNV));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.bunifuPanel5 = new Bunifu.UI.WinForms.BunifuPanel();
            this.chartDG = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label14 = new System.Windows.Forms.Label();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuPanel2 = new Bunifu.UI.WinForms.BunifuPanel();
            this.guna2CircleButton2 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.circleProcessPercent = new Bunifu.UI.WinForms.BunifuCircleProgress();
            this.lbP_sanco = new System.Windows.Forms.Label();
            this.lbP_muon = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRp = new Guna.UI2.WinForms.Guna2Button();
            this.bunifuPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDG)).BeginInit();
            this.bunifuPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.bunifuPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuPanel5
            // 
            this.bunifuPanel5.BackgroundColor = System.Drawing.Color.White;
            this.bunifuPanel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel5.BackgroundImage")));
            this.bunifuPanel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel5.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel5.BorderRadius = 30;
            this.bunifuPanel5.BorderThickness = 1;
            this.bunifuPanel5.Controls.Add(this.chartDG);
            this.bunifuPanel5.Controls.Add(this.label14);
            this.bunifuPanel5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bunifuPanel5.Location = new System.Drawing.Point(28, 26);
            this.bunifuPanel5.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuPanel5.Name = "bunifuPanel5";
            this.bunifuPanel5.ShowBorders = true;
            this.bunifuPanel5.Size = new System.Drawing.Size(586, 408);
            this.bunifuPanel5.TabIndex = 21;
            // 
            // chartDG
            // 
            chartArea5.Name = "ChartArea1";
            this.chartDG.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chartDG.Legends.Add(legend5);
            this.chartDG.Location = new System.Drawing.Point(47, 57);
            this.chartDG.Margin = new System.Windows.Forms.Padding(4);
            this.chartDG.Name = "chartDG";
            series5.ChartArea = "ChartArea1";
            series5.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series5.Legend = "Legend1";
            series5.Name = "TienCoc";
            this.chartDG.Series.Add(series5);
            this.chartDG.Size = new System.Drawing.Size(501, 319);
            this.chartDG.TabIndex = 22;
            this.chartDG.Text = "chart1";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Segoe UI Black", 13F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(86)))), ((int)(((byte)(136)))));
            this.label14.Location = new System.Drawing.Point(42, 14);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(328, 30);
            this.label14.TabIndex = 18;
            this.label14.Text = "Thống kê tiền cọc theo tháng";
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.White;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 30;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.chart1);
            this.bunifuPanel1.Controls.Add(this.label1);
            this.bunifuPanel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bunifuPanel1.Location = new System.Drawing.Point(28, 463);
            this.bunifuPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(1151, 389);
            this.bunifuPanel1.TabIndex = 23;
            // 
            // chart1
            // 
            chartArea6.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chart1.Legends.Add(legend6);
            this.chart1.Location = new System.Drawing.Point(47, 81);
            this.chart1.Margin = new System.Windows.Forms.Padding(4);
            this.chart1.Name = "chart1";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series6.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series6.Legend = "Legend1";
            series6.Name = "SoLuong";
            series6.YValuesPerPoint = 2;
            this.chart1.Series.Add(series6);
            this.chart1.Size = new System.Drawing.Size(961, 283);
            this.chart1.TabIndex = 22;
            this.chart1.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 13F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(86)))), ((int)(((byte)(136)))));
            this.label1.Location = new System.Drawing.Point(42, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(416, 30);
            this.label1.TabIndex = 18;
            this.label1.Text = "Thống kê số lượng sách từng thể loại";
            // 
            // bunifuPanel2
            // 
            this.bunifuPanel2.BackgroundColor = System.Drawing.Color.White;
            this.bunifuPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel2.BackgroundImage")));
            this.bunifuPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel2.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel2.BorderRadius = 30;
            this.bunifuPanel2.BorderThickness = 1;
            this.bunifuPanel2.Controls.Add(this.btnRp);
            this.bunifuPanel2.Controls.Add(this.guna2CircleButton2);
            this.bunifuPanel2.Controls.Add(this.guna2CircleButton1);
            this.bunifuPanel2.Controls.Add(this.circleProcessPercent);
            this.bunifuPanel2.Controls.Add(this.lbP_sanco);
            this.bunifuPanel2.Controls.Add(this.lbP_muon);
            this.bunifuPanel2.Controls.Add(this.label2);
            this.bunifuPanel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bunifuPanel2.Location = new System.Drawing.Point(632, 26);
            this.bunifuPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuPanel2.Name = "bunifuPanel2";
            this.bunifuPanel2.ShowBorders = true;
            this.bunifuPanel2.Size = new System.Drawing.Size(547, 408);
            this.bunifuPanel2.TabIndex = 23;
            // 
            // guna2CircleButton2
            // 
            this.guna2CircleButton2.CheckedState.Parent = this.guna2CircleButton2;
            this.guna2CircleButton2.CustomImages.Parent = this.guna2CircleButton2;
            this.guna2CircleButton2.FillColor = System.Drawing.Color.Gray;
            this.guna2CircleButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton2.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton2.HoverState.Parent = this.guna2CircleButton2;
            this.guna2CircleButton2.Location = new System.Drawing.Point(44, 106);
            this.guna2CircleButton2.Margin = new System.Windows.Forms.Padding(4);
            this.guna2CircleButton2.Name = "guna2CircleButton2";
            this.guna2CircleButton2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton2.ShadowDecoration.Parent = this.guna2CircleButton2;
            this.guna2CircleButton2.Size = new System.Drawing.Size(13, 12);
            this.guna2CircleButton2.TabIndex = 36;
            // 
            // guna2CircleButton1
            // 
            this.guna2CircleButton1.CheckedState.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.CustomImages.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.FillColor = System.Drawing.Color.DodgerBlue;
            this.guna2CircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton1.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton1.HoverState.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.Location = new System.Drawing.Point(44, 69);
            this.guna2CircleButton1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2CircleButton1.Name = "guna2CircleButton1";
            this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton1.ShadowDecoration.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.Size = new System.Drawing.Size(13, 12);
            this.guna2CircleButton1.TabIndex = 35;
            // 
            // circleProcessPercent
            // 
            this.circleProcessPercent.Animated = false;
            this.circleProcessPercent.AnimationInterval = 1;
            this.circleProcessPercent.AnimationSpeed = 1;
            this.circleProcessPercent.BackColor = System.Drawing.Color.Transparent;
            this.circleProcessPercent.CircleMargin = 10;
            this.circleProcessPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold);
            this.circleProcessPercent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circleProcessPercent.IsPercentage = true;
            this.circleProcessPercent.LineProgressThickness = 10;
            this.circleProcessPercent.LineThickness = 10;
            this.circleProcessPercent.Location = new System.Drawing.Point(251, 127);
            this.circleProcessPercent.Margin = new System.Windows.Forms.Padding(4);
            this.circleProcessPercent.Name = "circleProcessPercent";
            this.circleProcessPercent.ProgressAnimationSpeed = 200;
            this.circleProcessPercent.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.circleProcessPercent.ProgressColor = System.Drawing.Color.DodgerBlue;
            this.circleProcessPercent.ProgressColor2 = System.Drawing.Color.DodgerBlue;
            this.circleProcessPercent.ProgressEndCap = Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles.Round;
            this.circleProcessPercent.ProgressFillStyle = Bunifu.UI.WinForms.BunifuCircleProgress.FillStyles.Solid;
            this.circleProcessPercent.ProgressStartCap = Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles.Round;
            this.circleProcessPercent.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.circleProcessPercent.Size = new System.Drawing.Size(245, 245);
            this.circleProcessPercent.SubScriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circleProcessPercent.SubScriptMargin = new System.Windows.Forms.Padding(5, -20, 0, 0);
            this.circleProcessPercent.SubScriptText = ".00";
            this.circleProcessPercent.SuperScriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circleProcessPercent.SuperScriptMargin = new System.Windows.Forms.Padding(5, 50, 0, 0);
            this.circleProcessPercent.SuperScriptText = "%";
            this.circleProcessPercent.TabIndex = 32;
            this.circleProcessPercent.Text = "30";
            this.circleProcessPercent.TextMargin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.circleProcessPercent.Value = 30;
            this.circleProcessPercent.ValueByTransition = 30;
            this.circleProcessPercent.ValueMargin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            // 
            // lbP_sanco
            // 
            this.lbP_sanco.AutoSize = true;
            this.lbP_sanco.BackColor = System.Drawing.Color.Transparent;
            this.lbP_sanco.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbP_sanco.ForeColor = System.Drawing.Color.DimGray;
            this.lbP_sanco.Location = new System.Drawing.Point(77, 57);
            this.lbP_sanco.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbP_sanco.Name = "lbP_sanco";
            this.lbP_sanco.Size = new System.Drawing.Size(156, 25);
            this.lbP_sanco.TabIndex = 33;
            this.lbP_sanco.Text = "Số sách chưa trả";
            // 
            // lbP_muon
            // 
            this.lbP_muon.AutoSize = true;
            this.lbP_muon.BackColor = System.Drawing.Color.Transparent;
            this.lbP_muon.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbP_muon.ForeColor = System.Drawing.Color.DimGray;
            this.lbP_muon.Location = new System.Drawing.Point(77, 94);
            this.lbP_muon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbP_muon.Name = "lbP_muon";
            this.lbP_muon.Size = new System.Drawing.Size(164, 25);
            this.lbP_muon.TabIndex = 34;
            this.lbP_muon.Text = "Số sách đã mượn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 13F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(86)))), ((int)(((byte)(136)))));
            this.label2.Location = new System.Drawing.Point(24, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(463, 30);
            this.label2.TabIndex = 18;
            this.label2.Text = "Số sách chưa trả với số sách đã cho mượn";
            // 
            // btnRp
            // 
            this.btnRp.CheckedState.Parent = this.btnRp;
            this.btnRp.CustomImages.Parent = this.btnRp;
            this.btnRp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRp.ForeColor = System.Drawing.Color.White;
            this.btnRp.HoverState.Parent = this.btnRp;
            this.btnRp.Location = new System.Drawing.Point(0, 375);
            this.btnRp.Name = "btnRp";
            this.btnRp.ShadowDecoration.Parent = this.btnRp;
            this.btnRp.Size = new System.Drawing.Size(547, 37);
            this.btnRp.TabIndex = 23;
            this.btnRp.Text = "Báo cáo thống kê lượt mượn trên mỗi đầu sách";
            this.btnRp.Click += new System.EventHandler(this.btnRp_Click);
            // 
            // ThongKeNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bunifuPanel2);
            this.Controls.Add(this.bunifuPanel1);
            this.Controls.Add(this.bunifuPanel5);
            this.Name = "ThongKeNV";
            this.Size = new System.Drawing.Size(1211, 856);
            this.Load += new System.EventHandler(this.ThongKeNV_Load);
            this.bunifuPanel5.ResumeLayout(false);
            this.bunifuPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDG)).EndInit();
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.bunifuPanel2.ResumeLayout(false);
            this.bunifuPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDG;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel2;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton2;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        private Bunifu.UI.WinForms.BunifuCircleProgress circleProcessPercent;
        private System.Windows.Forms.Label lbP_sanco;
        private System.Windows.Forms.Label lbP_muon;
        private Guna.UI2.WinForms.Guna2Button btnRp;
    }
}

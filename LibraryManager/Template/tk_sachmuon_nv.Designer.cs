
namespace LibraryManager.Template
{
    partial class tk_sachmuon_nv
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.charttk = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgv_tksachmuon = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbMadg = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rbtnMadocgia = new System.Windows.Forms.RadioButton();
            this.rbtnTrehan = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTK = new Guna.UI2.WinForms.Guna2Button();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.dateEnd = new LibraryManager.Template.DateTimePickerKiet();
            this.dateStart = new LibraryManager.Template.DateTimePickerKiet();
            this.reportGenerator1 = new DevExpress.XtraReports.ReportGeneration.ReportGenerator(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.charttk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tksachmuon)).BeginInit();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(86)))), ((int)(((byte)(136)))));
            this.label1.Location = new System.Drawing.Point(476, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thống kê sách mượn";
            // 
            // charttk
            // 
            this.charttk.BorderlineColor = System.Drawing.Color.Black;
            chartArea1.Name = "ChartArea1";
            this.charttk.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.charttk.Legends.Add(legend1);
            this.charttk.Location = new System.Drawing.Point(858, 249);
            this.charttk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.charttk.Name = "charttk";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Chart1";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.charttk.Series.Add(series1);
            this.charttk.Size = new System.Drawing.Size(405, 559);
            this.charttk.TabIndex = 3;
            this.charttk.Text = "chart1";
            title1.Name = "Title1";
            title2.Name = "Title2";
            this.charttk.Titles.Add(title1);
            this.charttk.Titles.Add(title2);
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
            this.dgv_tksachmuon.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgv_tksachmuon.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_tksachmuon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_tksachmuon.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_tksachmuon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_tksachmuon.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_tksachmuon.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_tksachmuon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_tksachmuon.ColumnHeadersHeight = 40;
            this.dgv_tksachmuon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgv_tksachmuon.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dgv_tksachmuon.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgv_tksachmuon.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgv_tksachmuon.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgv_tksachmuon.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_tksachmuon.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dgv_tksachmuon.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgv_tksachmuon.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dgv_tksachmuon.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgv_tksachmuon.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_tksachmuon.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dgv_tksachmuon.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_tksachmuon.CurrentTheme.Name = null;
            this.dgv_tksachmuon.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_tksachmuon.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgv_tksachmuon.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgv_tksachmuon.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgv_tksachmuon.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_tksachmuon.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_tksachmuon.EnableHeadersVisualStyles = false;
            this.dgv_tksachmuon.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgv_tksachmuon.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dgv_tksachmuon.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgv_tksachmuon.HeaderForeColor = System.Drawing.Color.White;
            this.dgv_tksachmuon.Location = new System.Drawing.Point(40, 249);
            this.dgv_tksachmuon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_tksachmuon.Name = "dgv_tksachmuon";
            this.dgv_tksachmuon.RowHeadersVisible = false;
            this.dgv_tksachmuon.RowHeadersWidth = 51;
            this.dgv_tksachmuon.RowTemplate.Height = 40;
            this.dgv_tksachmuon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_tksachmuon.Size = new System.Drawing.Size(748, 559);
            this.dgv_tksachmuon.TabIndex = 6;
            this.dgv_tksachmuon.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaSach";
            this.Column1.HeaderText = "Mã sách";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenDauSach";
            this.Column2.HeaderText = "Tên đầu sách";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "NgayMuon";
            this.Column3.HeaderText = "Ngày mượn";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "NgayTra";
            this.Column4.HeaderText = "Ngày trả";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // cmbMadg
            // 
            this.cmbMadg.BackColor = System.Drawing.Color.Transparent;
            this.cmbMadg.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbMadg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMadg.FocusedColor = System.Drawing.Color.Empty;
            this.cmbMadg.FocusedState.Parent = this.cmbMadg;
            this.cmbMadg.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbMadg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbMadg.FormattingEnabled = true;
            this.cmbMadg.HoverState.Parent = this.cmbMadg;
            this.cmbMadg.ItemHeight = 30;
            this.cmbMadg.ItemsAppearance.Parent = this.cmbMadg;
            this.cmbMadg.Location = new System.Drawing.Point(711, 87);
            this.cmbMadg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbMadg.Name = "cmbMadg";
            this.cmbMadg.ShadowDecoration.Parent = this.cmbMadg;
            this.cmbMadg.Size = new System.Drawing.Size(167, 36);
            this.cmbMadg.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label6.Location = new System.Drawing.Point(584, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "Mã độc giả";
            // 
            // rbtnMadocgia
            // 
            this.rbtnMadocgia.AutoSize = true;
            this.rbtnMadocgia.BackColor = System.Drawing.Color.Transparent;
            this.rbtnMadocgia.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rbtnMadocgia.Location = new System.Drawing.Point(117, 148);
            this.rbtnMadocgia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtnMadocgia.Name = "rbtnMadocgia";
            this.rbtnMadocgia.Size = new System.Drawing.Size(116, 27);
            this.rbtnMadocgia.TabIndex = 11;
            this.rbtnMadocgia.TabStop = true;
            this.rbtnMadocgia.Text = "Mã độc giả";
            this.rbtnMadocgia.UseVisualStyleBackColor = false;
            this.rbtnMadocgia.CheckedChanged += new System.EventHandler(this.rbtnMadocgia_CheckedChanged);
            // 
            // rbtnTrehan
            // 
            this.rbtnTrehan.AutoSize = true;
            this.rbtnTrehan.BackColor = System.Drawing.Color.Transparent;
            this.rbtnTrehan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rbtnTrehan.Location = new System.Drawing.Point(393, 148);
            this.rbtnTrehan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtnTrehan.Name = "rbtnTrehan";
            this.rbtnTrehan.Size = new System.Drawing.Size(88, 27);
            this.rbtnTrehan.TabIndex = 11;
            this.rbtnTrehan.TabStop = true;
            this.rbtnTrehan.Text = "Trễ hạn";
            this.rbtnTrehan.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.Location = new System.Drawing.Point(299, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "đến ngày";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label4.Location = new System.Drawing.Point(33, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Từ ngày";
            // 
            // btnTK
            // 
            this.btnTK.BackColor = System.Drawing.Color.Transparent;
            this.btnTK.BorderRadius = 15;
            this.btnTK.CheckedState.Parent = this.btnTK;
            this.btnTK.CustomImages.Parent = this.btnTK;
            this.btnTK.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(86)))), ((int)(((byte)(136)))));
            this.btnTK.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnTK.ForeColor = System.Drawing.Color.White;
            this.btnTK.HoverState.Parent = this.btnTK;
            this.btnTK.Location = new System.Drawing.Point(928, 87);
            this.btnTK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTK.Name = "btnTK";
            this.btnTK.ShadowDecoration.Parent = this.btnTK;
            this.btnTK.Size = new System.Drawing.Size(175, 44);
            this.btnTK.TabIndex = 7;
            this.btnTK.Text = "Thống kê";
            this.btnTK.Click += new System.EventHandler(this.btnTK_Click);
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BorderRadius = 10;
            this.guna2CustomGradientPanel1.Controls.Add(this.dateEnd);
            this.guna2CustomGradientPanel1.Controls.Add(this.dateStart);
            this.guna2CustomGradientPanel1.Controls.Add(this.label1);
            this.guna2CustomGradientPanel1.Controls.Add(this.cmbMadg);
            this.guna2CustomGradientPanel1.Controls.Add(this.btnTK);
            this.guna2CustomGradientPanel1.Controls.Add(this.label6);
            this.guna2CustomGradientPanel1.Controls.Add(this.rbtnMadocgia);
            this.guna2CustomGradientPanel1.Controls.Add(this.label4);
            this.guna2CustomGradientPanel1.Controls.Add(this.rbtnTrehan);
            this.guna2CustomGradientPanel1.Controls.Add(this.label3);
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(198)))), ((int)(((byte)(165)))));
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(198)))), ((int)(((byte)(165)))));
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(40, 23);
            this.guna2CustomGradientPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.ShadowDecoration.Parent = this.guna2CustomGradientPanel1;
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(1223, 198);
            this.guna2CustomGradientPanel1.TabIndex = 9;
            // 
            // dateEnd
            // 
            this.dateEnd.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.dateEnd.BorderRadius = 0;
            this.dateEnd.BorderSize = 0;
            this.dateEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.dateEnd.Location = new System.Drawing.Point(393, 87);
            this.dateEnd.Margin = new System.Windows.Forms.Padding(4);
            this.dateEnd.MinimumSize = new System.Drawing.Size(4, 44);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(157, 44);
            this.dateEnd.SkinColor = System.Drawing.Color.DarkCyan;
            this.dateEnd.TabIndex = 15;
            this.dateEnd.TextColor = System.Drawing.Color.White;
            // 
            // dateStart
            // 
            this.dateStart.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.dateStart.BorderRadius = 0;
            this.dateStart.BorderSize = 0;
            this.dateStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.dateStart.Location = new System.Drawing.Point(117, 87);
            this.dateStart.Margin = new System.Windows.Forms.Padding(4);
            this.dateStart.MinimumSize = new System.Drawing.Size(4, 44);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(160, 44);
            this.dateStart.SkinColor = System.Drawing.Color.DarkCyan;
            this.dateStart.TabIndex = 14;
            this.dateStart.TextColor = System.Drawing.Color.White;
            // 
            // tk_sachmuon_nv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Controls.Add(this.dgv_tksachmuon);
            this.Controls.Add(this.charttk);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "tk_sachmuon_nv";
            this.Size = new System.Drawing.Size(1303, 839);
            this.Load += new System.EventHandler(this.tk_sachmuon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.charttk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tksachmuon)).EndInit();
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart charttk;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Bunifu.UI.WinForms.BunifuDataGridView dgv_tksachmuon;
        private Guna.UI2.WinForms.Guna2Button btnTK;
        private System.Windows.Forms.RadioButton rbtnMadocgia;
        private System.Windows.Forms.RadioButton rbtnTrehan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ComboBox cmbMadg;
        private System.Windows.Forms.Label label6;
        private DateTimePickerKiet dateEnd;
        private DateTimePickerKiet dateStart;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private DevExpress.XtraReports.ReportGeneration.ReportGenerator reportGenerator1;
    }
}

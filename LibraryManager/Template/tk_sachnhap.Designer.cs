
namespace LibraryManager.Template
{
    partial class tk_sachnhap
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTK = new Guna.UI2.WinForms.Guna2Button();
            this.txtTongso = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_tkSachnhap = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.dateEnd = new LibraryManager.Template.DateTimePickerKiet();
            this.dateStart = new LibraryManager.Template.DateTimePickerKiet();
            this.TenDauSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tkSachnhap)).BeginInit();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(86)))), ((int)(((byte)(136)))));
            this.label1.Location = new System.Drawing.Point(295, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thống kê sách nhập";
            // 
            // btnTK
            // 
            this.btnTK.BackColor = System.Drawing.Color.Transparent;
            this.btnTK.CheckedState.Parent = this.btnTK;
            this.btnTK.CustomImages.Parent = this.btnTK;
            this.btnTK.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(86)))), ((int)(((byte)(136)))));
            this.btnTK.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnTK.ForeColor = System.Drawing.Color.White;
            this.btnTK.HoverState.Parent = this.btnTK;
            this.btnTK.Location = new System.Drawing.Point(609, 58);
            this.btnTK.Margin = new System.Windows.Forms.Padding(2);
            this.btnTK.Name = "btnTK";
            this.btnTK.ShadowDecoration.Parent = this.btnTK;
            this.btnTK.Size = new System.Drawing.Size(127, 40);
            this.btnTK.TabIndex = 6;
            this.btnTK.Text = "Thống kê";
            this.btnTK.Click += new System.EventHandler(this.btnTK_Click);
            // 
            // txtTongso
            // 
            this.txtTongso.BackColor = System.Drawing.Color.Transparent;
            this.txtTongso.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTongso.DefaultText = "";
            this.txtTongso.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTongso.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTongso.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTongso.DisabledState.Parent = this.txtTongso;
            this.txtTongso.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTongso.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtTongso.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTongso.FocusedState.Parent = this.txtTongso;
            this.txtTongso.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongso.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTongso.HoverState.Parent = this.txtTongso;
            this.txtTongso.Location = new System.Drawing.Point(458, 58);
            this.txtTongso.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtTongso.Name = "txtTongso";
            this.txtTongso.PasswordChar = '\0';
            this.txtTongso.PlaceholderText = "";
            this.txtTongso.SelectedText = "";
            this.txtTongso.ShadowDecoration.Parent = this.txtTongso;
            this.txtTongso.Size = new System.Drawing.Size(116, 40);
            this.txtTongso.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(394, 58);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tổng số:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(198, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "đến ngày";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Từ ngày";
            // 
            // dgv_tkSachnhap
            // 
            this.dgv_tkSachnhap.AllowCustomTheming = false;
            this.dgv_tkSachnhap.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgv_tkSachnhap.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_tkSachnhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_tkSachnhap.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_tkSachnhap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_tkSachnhap.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_tkSachnhap.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_tkSachnhap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_tkSachnhap.ColumnHeadersHeight = 40;
            this.dgv_tkSachnhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenDauSach,
            this.soluong});
            this.dgv_tkSachnhap.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.dgv_tkSachnhap.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgv_tkSachnhap.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgv_tkSachnhap.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.dgv_tkSachnhap.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_tkSachnhap.CurrentTheme.BackColor = System.Drawing.Color.Teal;
            this.dgv_tkSachnhap.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.dgv_tkSachnhap.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.Teal;
            this.dgv_tkSachnhap.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgv_tkSachnhap.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_tkSachnhap.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.dgv_tkSachnhap.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_tkSachnhap.CurrentTheme.Name = null;
            this.dgv_tkSachnhap.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.dgv_tkSachnhap.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgv_tkSachnhap.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgv_tkSachnhap.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.dgv_tkSachnhap.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_tkSachnhap.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_tkSachnhap.EnableHeadersVisualStyles = false;
            this.dgv_tkSachnhap.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.dgv_tkSachnhap.HeaderBackColor = System.Drawing.Color.Teal;
            this.dgv_tkSachnhap.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgv_tkSachnhap.HeaderForeColor = System.Drawing.Color.White;
            this.dgv_tkSachnhap.Location = new System.Drawing.Point(38, 157);
            this.dgv_tkSachnhap.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_tkSachnhap.Name = "dgv_tkSachnhap";
            this.dgv_tkSachnhap.RowHeadersVisible = false;
            this.dgv_tkSachnhap.RowHeadersWidth = 51;
            this.dgv_tkSachnhap.RowTemplate.Height = 40;
            this.dgv_tkSachnhap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_tkSachnhap.Size = new System.Drawing.Size(777, 440);
            this.dgv_tkSachnhap.TabIndex = 2;
            this.dgv_tkSachnhap.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Teal;
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BorderRadius = 10;
            this.guna2CustomGradientPanel1.Controls.Add(this.dateEnd);
            this.guna2CustomGradientPanel1.Controls.Add(this.label1);
            this.guna2CustomGradientPanel1.Controls.Add(this.dateStart);
            this.guna2CustomGradientPanel1.Controls.Add(this.btnTK);
            this.guna2CustomGradientPanel1.Controls.Add(this.label2);
            this.guna2CustomGradientPanel1.Controls.Add(this.txtTongso);
            this.guna2CustomGradientPanel1.Controls.Add(this.label3);
            this.guna2CustomGradientPanel1.Controls.Add(this.label4);
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(198)))), ((int)(((byte)(165)))));
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(198)))), ((int)(((byte)(165)))));
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(38, 3);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.ShadowDecoration.Parent = this.guna2CustomGradientPanel1;
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(777, 129);
            this.guna2CustomGradientPanel1.TabIndex = 3;
            // 
            // dateEnd
            // 
            this.dateEnd.BorderColor = System.Drawing.Color.Transparent;
            this.dateEnd.BorderRadius = 0;
            this.dateEnd.BorderSize = 0;
            this.dateEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.dateEnd.Location = new System.Drawing.Point(265, 58);
            this.dateEnd.MinimumSize = new System.Drawing.Size(4, 44);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(124, 44);
            this.dateEnd.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(149)))), ((int)(((byte)(79)))));
            this.dateEnd.TabIndex = 8;
            this.dateEnd.TextColor = System.Drawing.Color.White;
            // 
            // dateStart
            // 
            this.dateStart.BorderColor = System.Drawing.Color.Transparent;
            this.dateStart.BorderRadius = 0;
            this.dateStart.BorderSize = 0;
            this.dateStart.Cursor = System.Windows.Forms.Cursors.Default;
            this.dateStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.dateStart.Location = new System.Drawing.Point(69, 58);
            this.dateStart.MinimumSize = new System.Drawing.Size(4, 44);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(124, 44);
            this.dateStart.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(149)))), ((int)(((byte)(79)))));
            this.dateStart.TabIndex = 7;
            this.dateStart.TextColor = System.Drawing.Color.White;
            // 
            // TenDauSach
            // 
            this.TenDauSach.DataPropertyName = "TenDauSach";
            this.TenDauSach.HeaderText = "Tên đầu sách";
            this.TenDauSach.Name = "TenDauSach";
            // 
            // soluong
            // 
            this.soluong.DataPropertyName = "soluong";
            this.soluong.HeaderText = "Số lượng sách nhập của đầu sách";
            this.soluong.Name = "soluong";
            // 
            // tk_sachnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Controls.Add(this.dgv_tkSachnhap);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "tk_sachnhap";
            this.Size = new System.Drawing.Size(856, 652);
            this.Load += new System.EventHandler(this.tk_sachnhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tkSachnhap)).EndInit();
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtTongso;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnTK;
        private Bunifu.UI.WinForms.BunifuDataGridView dgv_tkSachnhap;
        private DateTimePickerKiet dateStart;
        private DateTimePickerKiet dateEnd;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDauSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
    }
}

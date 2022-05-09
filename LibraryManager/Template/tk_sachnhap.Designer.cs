
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnTK = new Guna.UI2.WinForms.Guna2Button();
            this.txtTongso = new Guna.UI2.WinForms.Guna2TextBox();
            this.mtxtNgayden = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mtxtNgaynhap = new System.Windows.Forms.MaskedTextBox();
            this.dgv_tkSachnhap = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tkSachnhap)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.guna2Panel1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(1109, 62);
            this.guna2Panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(27, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thống kê sách nhập";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.guna2Panel2.Controls.Add(this.btnTK);
            this.guna2Panel2.Controls.Add(this.txtTongso);
            this.guna2Panel2.Controls.Add(this.mtxtNgayden);
            this.guna2Panel2.Controls.Add(this.label4);
            this.guna2Panel2.Controls.Add(this.label3);
            this.guna2Panel2.Controls.Add(this.label2);
            this.guna2Panel2.Controls.Add(this.mtxtNgaynhap);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2Panel2.Location = new System.Drawing.Point(0, 62);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(1109, 98);
            this.guna2Panel2.TabIndex = 1;
            // 
            // btnTK
            // 
            this.btnTK.BorderRadius = 15;
            this.btnTK.BorderThickness = 2;
            this.btnTK.CheckedState.Parent = this.btnTK;
            this.btnTK.CustomImages.Parent = this.btnTK;
            this.btnTK.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnTK.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnTK.ForeColor = System.Drawing.Color.Black;
            this.btnTK.HoverState.Parent = this.btnTK;
            this.btnTK.Location = new System.Drawing.Point(638, 13);
            this.btnTK.Name = "btnTK";
            this.btnTK.ShadowDecoration.Parent = this.btnTK;
            this.btnTK.Size = new System.Drawing.Size(81, 50);
            this.btnTK.TabIndex = 6;
            this.btnTK.Text = "Thống kê";
            this.btnTK.Click += new System.EventHandler(this.btnTK_Click);
            // 
            // txtTongso
            // 
            this.txtTongso.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTongso.DefaultText = "";
            this.txtTongso.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTongso.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTongso.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTongso.DisabledState.Parent = this.txtTongso;
            this.txtTongso.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTongso.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTongso.FocusedState.Parent = this.txtTongso;
            this.txtTongso.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTongso.HoverState.Parent = this.txtTongso;
            this.txtTongso.Location = new System.Drawing.Point(515, 21);
            this.txtTongso.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtTongso.Name = "txtTongso";
            this.txtTongso.PasswordChar = '\0';
            this.txtTongso.PlaceholderText = "";
            this.txtTongso.SelectedText = "";
            this.txtTongso.ShadowDecoration.Parent = this.txtTongso;
            this.txtTongso.Size = new System.Drawing.Size(100, 33);
            this.txtTongso.TabIndex = 5;
            // 
            // mtxtNgayden
            // 
            this.mtxtNgayden.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.mtxtNgayden.Location = new System.Drawing.Point(300, 24);
            this.mtxtNgayden.Mask = "00/00/0000";
            this.mtxtNgayden.Name = "mtxtNgayden";
            this.mtxtNgayden.Size = new System.Drawing.Size(100, 30);
            this.mtxtNgayden.TabIndex = 4;
            this.mtxtNgayden.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(441, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tổng số:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(213, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "đến ngày";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Từ ngày";
            // 
            // mtxtNgaynhap
            // 
            this.mtxtNgaynhap.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.mtxtNgaynhap.Location = new System.Drawing.Point(107, 24);
            this.mtxtNgaynhap.Mask = "00/00/0000";
            this.mtxtNgaynhap.Name = "mtxtNgaynhap";
            this.mtxtNgaynhap.Size = new System.Drawing.Size(100, 30);
            this.mtxtNgaynhap.TabIndex = 0;
            // 
            // dgv_tkSachnhap
            // 
            this.dgv_tkSachnhap.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(217)))), ((int)(((byte)(198)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgv_tkSachnhap.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_tkSachnhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_tkSachnhap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_tkSachnhap.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_tkSachnhap.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(84)))), ((int)(((byte)(24)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_tkSachnhap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_tkSachnhap.ColumnHeadersHeight = 40;
            this.dgv_tkSachnhap.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(217)))), ((int)(((byte)(198)))));
            this.dgv_tkSachnhap.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgv_tkSachnhap.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgv_tkSachnhap.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(165)))), ((int)(((byte)(120)))));
            this.dgv_tkSachnhap.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_tkSachnhap.CurrentTheme.BackColor = System.Drawing.Color.Chocolate;
            this.dgv_tkSachnhap.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(210)))), ((int)(((byte)(187)))));
            this.dgv_tkSachnhap.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.Chocolate;
            this.dgv_tkSachnhap.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgv_tkSachnhap.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_tkSachnhap.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(84)))), ((int)(((byte)(24)))));
            this.dgv_tkSachnhap.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_tkSachnhap.CurrentTheme.Name = null;
            this.dgv_tkSachnhap.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(225)))), ((int)(((byte)(210)))));
            this.dgv_tkSachnhap.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgv_tkSachnhap.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgv_tkSachnhap.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(165)))), ((int)(((byte)(120)))));
            this.dgv_tkSachnhap.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(225)))), ((int)(((byte)(210)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(165)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_tkSachnhap.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_tkSachnhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_tkSachnhap.EnableHeadersVisualStyles = false;
            this.dgv_tkSachnhap.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(210)))), ((int)(((byte)(187)))));
            this.dgv_tkSachnhap.HeaderBackColor = System.Drawing.Color.Chocolate;
            this.dgv_tkSachnhap.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgv_tkSachnhap.HeaderForeColor = System.Drawing.Color.White;
            this.dgv_tkSachnhap.Location = new System.Drawing.Point(0, 160);
            this.dgv_tkSachnhap.Name = "dgv_tkSachnhap";
            this.dgv_tkSachnhap.RowHeadersVisible = false;
            this.dgv_tkSachnhap.RowHeadersWidth = 51;
            this.dgv_tkSachnhap.RowTemplate.Height = 40;
            this.dgv_tkSachnhap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_tkSachnhap.Size = new System.Drawing.Size(1109, 594);
            this.dgv_tkSachnhap.TabIndex = 2;
            this.dgv_tkSachnhap.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Chocolate;
            // 
            // tk_sachnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgv_tkSachnhap);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "tk_sachnhap";
            this.Size = new System.Drawing.Size(1109, 754);
            this.Load += new System.EventHandler(this.tk_sachnhap_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tkSachnhap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2TextBox txtTongso;
        private System.Windows.Forms.MaskedTextBox mtxtNgayden;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mtxtNgaynhap;
        private Guna.UI2.WinForms.Guna2Button btnTK;
        private Bunifu.UI.WinForms.BunifuDataGridView dgv_tkSachnhap;
    }
}


namespace LibraryManager.Template
{
    partial class Xu_ly_tra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Xu_ly_tra));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbMuontra = new System.Windows.Forms.Label();
            this.pnTTchung = new Guna.UI2.WinForms.Guna2Panel();
            this.btnTK = new Guna.UI2.WinForms.Guna2Button();
            this.cmbTKiem = new System.Windows.Forms.ComboBox();
            this.txtTK = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbtk = new System.Windows.Forms.Label();
            this.lbTimkiem = new System.Windows.Forms.Label();
            this.lbTTchung = new System.Windows.Forms.Label();
            this.pnTrasach = new Guna.UI2.WinForms.Guna2Panel();
            this.btnCapnhat = new Guna.UI2.WinForms.Guna2Button();
            this.cboxVi_pham = new Guna.UI2.WinForms.Guna2CheckBox();
            this.cboxTra = new Guna.UI2.WinForms.Guna2CheckBox();
            this.txtMadg = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMasach = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lbMadg = new System.Windows.Forms.Label();
            this.lbMasach = new System.Windows.Forms.Label();
            this.lb_nhap_tra_sach = new System.Windows.Forms.Label();
            this.dgv_trasach = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.pnTTchung.SuspendLayout();
            this.pnTrasach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_trasach)).BeginInit();
            this.SuspendLayout();
            // 
            // lbMuontra
            // 
            this.lbMuontra.AutoSize = true;
            this.lbMuontra.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.lbMuontra.Location = new System.Drawing.Point(22, 19);
            this.lbMuontra.Name = "lbMuontra";
            this.lbMuontra.Size = new System.Drawing.Size(139, 46);
            this.lbMuontra.TabIndex = 0;
            this.lbMuontra.Text = "Trả sách";
            // 
            // pnTTchung
            // 
            this.pnTTchung.BorderRadius = 15;
            this.pnTTchung.Controls.Add(this.btnTK);
            this.pnTTchung.Controls.Add(this.cmbTKiem);
            this.pnTTchung.Controls.Add(this.txtTK);
            this.pnTTchung.Controls.Add(this.lbtk);
            this.pnTTchung.Controls.Add(this.lbTimkiem);
            this.pnTTchung.Controls.Add(this.lbTTchung);
            this.pnTTchung.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pnTTchung.Location = new System.Drawing.Point(30, 88);
            this.pnTTchung.Name = "pnTTchung";
            this.pnTTchung.ShadowDecoration.Parent = this.pnTTchung;
            this.pnTTchung.Size = new System.Drawing.Size(479, 204);
            this.pnTTchung.TabIndex = 1;
            // 
            // btnTK
            // 
            this.btnTK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnTK.BorderRadius = 10;
            this.btnTK.CheckedState.Parent = this.btnTK;
            this.btnTK.CustomImages.Parent = this.btnTK;
            this.btnTK.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnTK.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTK.ForeColor = System.Drawing.Color.White;
            this.btnTK.HoverState.Parent = this.btnTK;
            this.btnTK.Image = ((System.Drawing.Image)(resources.GetObject("btnTK.Image")));
            this.btnTK.Location = new System.Drawing.Point(399, 100);
            this.btnTK.Name = "btnTK";
            this.btnTK.ShadowDecoration.Parent = this.btnTK;
            this.btnTK.Size = new System.Drawing.Size(60, 41);
            this.btnTK.TabIndex = 5;
            this.btnTK.Click += new System.EventHandler(this.btnTK_Click);
            // 
            // cmbTKiem
            // 
            this.cmbTKiem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbTKiem.FormattingEnabled = true;
            this.cmbTKiem.Items.AddRange(new object[] {
            "Mã độc giả",
            "Mã sách"});
            this.cmbTKiem.Location = new System.Drawing.Point(171, 57);
            this.cmbTKiem.Name = "cmbTKiem";
            this.cmbTKiem.Size = new System.Drawing.Size(221, 31);
            this.cmbTKiem.TabIndex = 4;
            // 
            // txtTK
            // 
            this.txtTK.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTK.DefaultText = "";
            this.txtTK.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTK.DisabledState.Parent = this.txtTK;
            this.txtTK.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTK.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTK.FocusedState.Parent = this.txtTK;
            this.txtTK.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTK.HoverState.Parent = this.txtTK;
            this.txtTK.Location = new System.Drawing.Point(171, 100);
            this.txtTK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTK.Name = "txtTK";
            this.txtTK.PasswordChar = '\0';
            this.txtTK.PlaceholderText = "";
            this.txtTK.SelectedText = "";
            this.txtTK.ShadowDecoration.Parent = this.txtTK;
            this.txtTK.Size = new System.Drawing.Size(221, 41);
            this.txtTK.TabIndex = 3;
            // 
            // lbtk
            // 
            this.lbtk.AutoSize = true;
            this.lbtk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbtk.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbtk.Location = new System.Drawing.Point(14, 109);
            this.lbtk.Name = "lbtk";
            this.lbtk.Size = new System.Drawing.Size(157, 23);
            this.lbtk.TabIndex = 2;
            this.lbtk.Text = "Nội dung tìm kiếm:";
            // 
            // lbTimkiem
            // 
            this.lbTimkiem.AutoSize = true;
            this.lbTimkiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbTimkiem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimkiem.Location = new System.Drawing.Point(14, 60);
            this.lbTimkiem.Name = "lbTimkiem";
            this.lbTimkiem.Size = new System.Drawing.Size(123, 23);
            this.lbTimkiem.TabIndex = 1;
            this.lbTimkiem.Text = "Tìm kiếm theo:";
            // 
            // lbTTchung
            // 
            this.lbTTchung.AutoSize = true;
            this.lbTTchung.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbTTchung.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTTchung.Location = new System.Drawing.Point(13, 10);
            this.lbTTchung.Name = "lbTTchung";
            this.lbTTchung.Size = new System.Drawing.Size(168, 28);
            this.lbTTchung.TabIndex = 0;
            this.lbTTchung.Text = "Thông tin chung";
            // 
            // pnTrasach
            // 
            this.pnTrasach.BorderRadius = 15;
            this.pnTrasach.Controls.Add(this.btnCapnhat);
            this.pnTrasach.Controls.Add(this.cboxVi_pham);
            this.pnTrasach.Controls.Add(this.cboxTra);
            this.pnTrasach.Controls.Add(this.txtMadg);
            this.pnTrasach.Controls.Add(this.txtMasach);
            this.pnTrasach.Controls.Add(this.label7);
            this.pnTrasach.Controls.Add(this.lbMadg);
            this.pnTrasach.Controls.Add(this.lbMasach);
            this.pnTrasach.Controls.Add(this.lb_nhap_tra_sach);
            this.pnTrasach.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pnTrasach.Location = new System.Drawing.Point(536, 88);
            this.pnTrasach.Name = "pnTrasach";
            this.pnTrasach.ShadowDecoration.Parent = this.pnTrasach;
            this.pnTrasach.Size = new System.Drawing.Size(466, 204);
            this.pnTrasach.TabIndex = 2;
            // 
            // btnCapnhat
            // 
            this.btnCapnhat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnCapnhat.BorderRadius = 15;
            this.btnCapnhat.CheckedState.Parent = this.btnCapnhat;
            this.btnCapnhat.CustomImages.Parent = this.btnCapnhat;
            this.btnCapnhat.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnCapnhat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCapnhat.ForeColor = System.Drawing.Color.Black;
            this.btnCapnhat.HoverState.Parent = this.btnCapnhat;
            this.btnCapnhat.Image = ((System.Drawing.Image)(resources.GetObject("btnCapnhat.Image")));
            this.btnCapnhat.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCapnhat.Location = new System.Drawing.Point(315, 148);
            this.btnCapnhat.Name = "btnCapnhat";
            this.btnCapnhat.ShadowDecoration.Parent = this.btnCapnhat;
            this.btnCapnhat.Size = new System.Drawing.Size(112, 45);
            this.btnCapnhat.TabIndex = 8;
            this.btnCapnhat.Text = "Cập nhật";
            this.btnCapnhat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cboxVi_pham
            // 
            this.cboxVi_pham.AutoSize = true;
            this.cboxVi_pham.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cboxVi_pham.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboxVi_pham.CheckedState.BorderRadius = 2;
            this.cboxVi_pham.CheckedState.BorderThickness = 0;
            this.cboxVi_pham.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboxVi_pham.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboxVi_pham.Location = new System.Drawing.Point(183, 157);
            this.cboxVi_pham.Name = "cboxVi_pham";
            this.cboxVi_pham.Size = new System.Drawing.Size(96, 27);
            this.cboxVi_pham.TabIndex = 7;
            this.cboxVi_pham.Text = "Vi phạm";
            this.cboxVi_pham.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cboxVi_pham.UncheckedState.BorderRadius = 2;
            this.cboxVi_pham.UncheckedState.BorderThickness = 0;
            this.cboxVi_pham.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cboxVi_pham.UseVisualStyleBackColor = false;
            // 
            // cboxTra
            // 
            this.cboxTra.AutoSize = true;
            this.cboxTra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cboxTra.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboxTra.CheckedState.BorderRadius = 2;
            this.cboxTra.CheckedState.BorderThickness = 0;
            this.cboxTra.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboxTra.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboxTra.Location = new System.Drawing.Point(28, 159);
            this.cboxTra.Name = "cboxTra";
            this.cboxTra.Size = new System.Drawing.Size(79, 27);
            this.cboxTra.TabIndex = 6;
            this.cboxTra.Text = "Đã trả";
            this.cboxTra.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cboxTra.UncheckedState.BorderRadius = 2;
            this.cboxTra.UncheckedState.BorderThickness = 0;
            this.cboxTra.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cboxTra.UseVisualStyleBackColor = false;
            // 
            // txtMadg
            // 
            this.txtMadg.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMadg.DefaultText = "";
            this.txtMadg.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMadg.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMadg.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMadg.DisabledState.Parent = this.txtMadg;
            this.txtMadg.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMadg.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMadg.FocusedState.Parent = this.txtMadg;
            this.txtMadg.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMadg.HoverState.Parent = this.txtMadg;
            this.txtMadg.Location = new System.Drawing.Point(135, 100);
            this.txtMadg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMadg.Name = "txtMadg";
            this.txtMadg.PasswordChar = '\0';
            this.txtMadg.PlaceholderText = "";
            this.txtMadg.SelectedText = "";
            this.txtMadg.ShadowDecoration.Parent = this.txtMadg;
            this.txtMadg.Size = new System.Drawing.Size(267, 41);
            this.txtMadg.TabIndex = 5;
            // 
            // txtMasach
            // 
            this.txtMasach.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMasach.DefaultText = "";
            this.txtMasach.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMasach.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMasach.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMasach.DisabledState.Parent = this.txtMasach;
            this.txtMasach.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMasach.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMasach.FocusedState.Parent = this.txtMasach;
            this.txtMasach.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMasach.HoverState.Parent = this.txtMasach;
            this.txtMasach.Location = new System.Drawing.Point(135, 45);
            this.txtMasach.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMasach.Name = "txtMasach";
            this.txtMasach.PasswordChar = '\0';
            this.txtMasach.PlaceholderText = "";
            this.txtMasach.SelectedText = "";
            this.txtMasach.ShadowDecoration.Parent = this.txtMasach;
            this.txtMasach.Size = new System.Drawing.Size(267, 38);
            this.txtMasach.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label7.Location = new System.Drawing.Point(46, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 23);
            this.label7.TabIndex = 3;
            // 
            // lbMadg
            // 
            this.lbMadg.AutoSize = true;
            this.lbMadg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbMadg.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbMadg.Location = new System.Drawing.Point(24, 109);
            this.lbMadg.Name = "lbMadg";
            this.lbMadg.Size = new System.Drawing.Size(99, 23);
            this.lbMadg.TabIndex = 2;
            this.lbMadg.Text = "Mã độc giả:";
            // 
            // lbMasach
            // 
            this.lbMasach.AutoSize = true;
            this.lbMasach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbMasach.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbMasach.Location = new System.Drawing.Point(24, 53);
            this.lbMasach.Name = "lbMasach";
            this.lbMasach.Size = new System.Drawing.Size(77, 23);
            this.lbMasach.TabIndex = 1;
            this.lbMasach.Text = "Mã sách:";
            // 
            // lb_nhap_tra_sach
            // 
            this.lb_nhap_tra_sach.AutoSize = true;
            this.lb_nhap_tra_sach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lb_nhap_tra_sach.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nhap_tra_sach.Location = new System.Drawing.Point(23, 10);
            this.lb_nhap_tra_sach.Name = "lb_nhap_tra_sach";
            this.lb_nhap_tra_sach.Size = new System.Drawing.Size(144, 28);
            this.lb_nhap_tra_sach.TabIndex = 0;
            this.lb_nhap_tra_sach.Text = "Nhập trả sách";
            // 
            // dgv_trasach
            // 
            this.dgv_trasach.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgv_trasach.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_trasach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_trasach.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_trasach.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_trasach.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_trasach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_trasach.ColumnHeadersHeight = 40;
            this.dgv_trasach.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dgv_trasach.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgv_trasach.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgv_trasach.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgv_trasach.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_trasach.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dgv_trasach.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgv_trasach.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dgv_trasach.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgv_trasach.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_trasach.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dgv_trasach.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_trasach.CurrentTheme.Name = null;
            this.dgv_trasach.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_trasach.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgv_trasach.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgv_trasach.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgv_trasach.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_trasach.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_trasach.EnableHeadersVisualStyles = false;
            this.dgv_trasach.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgv_trasach.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dgv_trasach.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgv_trasach.HeaderForeColor = System.Drawing.Color.White;
            this.dgv_trasach.Location = new System.Drawing.Point(30, 338);
            this.dgv_trasach.Name = "dgv_trasach";
            this.dgv_trasach.RowHeadersVisible = false;
            this.dgv_trasach.RowHeadersWidth = 51;
            this.dgv_trasach.RowTemplate.Height = 40;
            this.dgv_trasach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_trasach.Size = new System.Drawing.Size(972, 414);
            this.dgv_trasach.TabIndex = 3;
            this.dgv_trasach.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // Xu_ly_tra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgv_trasach);
            this.Controls.Add(this.pnTrasach);
            this.Controls.Add(this.pnTTchung);
            this.Controls.Add(this.lbMuontra);
            this.Name = "Xu_ly_tra";
            this.Size = new System.Drawing.Size(1054, 799);
            this.pnTTchung.ResumeLayout(false);
            this.pnTTchung.PerformLayout();
            this.pnTrasach.ResumeLayout(false);
            this.pnTrasach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_trasach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMuontra;
        private Guna.UI2.WinForms.Guna2Panel pnTTchung;
        private Guna.UI2.WinForms.Guna2Button btnTK;
        private System.Windows.Forms.ComboBox cmbTKiem;
        private Guna.UI2.WinForms.Guna2TextBox txtTK;
        private System.Windows.Forms.Label lbtk;
        private System.Windows.Forms.Label lbTimkiem;
        private System.Windows.Forms.Label lbTTchung;
        private Guna.UI2.WinForms.Guna2Panel pnTrasach;
        private Guna.UI2.WinForms.Guna2Button btnCapnhat;
        private Guna.UI2.WinForms.Guna2CheckBox cboxVi_pham;
        private Guna.UI2.WinForms.Guna2CheckBox cboxTra;
        private Guna.UI2.WinForms.Guna2TextBox txtMadg;
        private Guna.UI2.WinForms.Guna2TextBox txtMasach;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbMadg;
        private System.Windows.Forms.Label lbMasach;
        private System.Windows.Forms.Label lb_nhap_tra_sach;
        private Bunifu.UI.WinForms.BunifuDataGridView dgv_trasach;
    }
}

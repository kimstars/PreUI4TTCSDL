
namespace LibraryManager.Template
{
    partial class FrmTimKiemForDG
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTimKiemForDG));
            this.guna2CustomGradientPanel3 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.cbLoaiLoc = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTuKhoa = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvChonDauSach = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.MaDauSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDauSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LanTaiBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamXuatBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Anh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaTheLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaTacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNhaXuatBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNhaXuatBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTheLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.lbInfoMaDS = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbInfoTenNXB = new System.Windows.Forms.Label();
            this.lbInfoNamXB = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbInfoMota = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbInfoTenTG = new System.Windows.Forms.Label();
            this.lbInfoTenSach = new System.Windows.Forms.Label();
            this.imageBook = new System.Windows.Forms.PictureBox();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.guna2CustomGradientPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChonDauSach)).BeginInit();
            this.guna2CustomGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBook)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2CustomGradientPanel3
            // 
            this.guna2CustomGradientPanel3.BorderRadius = 20;
            this.guna2CustomGradientPanel3.Controls.Add(this.cbLoaiLoc);
            this.guna2CustomGradientPanel3.Controls.Add(this.btnSearch);
            this.guna2CustomGradientPanel3.Controls.Add(this.label4);
            this.guna2CustomGradientPanel3.Controls.Add(this.txtTuKhoa);
            this.guna2CustomGradientPanel3.Controls.Add(this.label5);
            this.guna2CustomGradientPanel3.FillColor = System.Drawing.Color.MediumVioletRed;
            this.guna2CustomGradientPanel3.FillColor2 = System.Drawing.Color.MediumVioletRed;
            this.guna2CustomGradientPanel3.FillColor4 = System.Drawing.Color.BlueViolet;
            this.guna2CustomGradientPanel3.Location = new System.Drawing.Point(69, 41);
            this.guna2CustomGradientPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.guna2CustomGradientPanel3.Name = "guna2CustomGradientPanel3";
            this.guna2CustomGradientPanel3.ShadowDecoration.Parent = this.guna2CustomGradientPanel3;
            this.guna2CustomGradientPanel3.Size = new System.Drawing.Size(777, 114);
            this.guna2CustomGradientPanel3.TabIndex = 30;
            // 
            // cbLoaiLoc
            // 
            this.cbLoaiLoc.BackColor = System.Drawing.Color.Transparent;
            this.cbLoaiLoc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbLoaiLoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoaiLoc.FocusedColor = System.Drawing.Color.Empty;
            this.cbLoaiLoc.FocusedState.Parent = this.cbLoaiLoc;
            this.cbLoaiLoc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbLoaiLoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbLoaiLoc.FormattingEnabled = true;
            this.cbLoaiLoc.HoverState.Parent = this.cbLoaiLoc;
            this.cbLoaiLoc.ItemHeight = 30;
            this.cbLoaiLoc.Items.AddRange(new object[] {
            "Mã đầu sách",
            "Tên đầu sách"});
            this.cbLoaiLoc.ItemsAppearance.Parent = this.cbLoaiLoc;
            this.cbLoaiLoc.Location = new System.Drawing.Point(401, 47);
            this.cbLoaiLoc.Name = "cbLoaiLoc";
            this.cbLoaiLoc.ShadowDecoration.Parent = this.cbLoaiLoc;
            this.cbLoaiLoc.Size = new System.Drawing.Size(188, 36);
            this.cbLoaiLoc.TabIndex = 8;
            this.cbLoaiLoc.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox2_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(397, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Lọc theo";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtTuKhoa
            // 
            this.txtTuKhoa.BackColor = System.Drawing.Color.Transparent;
            this.txtTuKhoa.BorderColor = System.Drawing.Color.Transparent;
            this.txtTuKhoa.BorderRadius = 6;
            this.txtTuKhoa.BorderThickness = 0;
            this.txtTuKhoa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTuKhoa.DefaultText = "";
            this.txtTuKhoa.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTuKhoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTuKhoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTuKhoa.DisabledState.Parent = this.txtTuKhoa;
            this.txtTuKhoa.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTuKhoa.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTuKhoa.FocusedState.Parent = this.txtTuKhoa;
            this.txtTuKhoa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTuKhoa.ForeColor = System.Drawing.Color.Black;
            this.txtTuKhoa.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTuKhoa.HoverState.Parent = this.txtTuKhoa;
            this.txtTuKhoa.Location = new System.Drawing.Point(32, 47);
            this.txtTuKhoa.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtTuKhoa.Name = "txtTuKhoa";
            this.txtTuKhoa.PasswordChar = '\0';
            this.txtTuKhoa.PlaceholderText = "";
            this.txtTuKhoa.SelectedText = "";
            this.txtTuKhoa.ShadowDecoration.Parent = this.txtTuKhoa;
            this.txtTuKhoa.Size = new System.Drawing.Size(348, 39);
            this.txtTuKhoa.TabIndex = 0;
            this.txtTuKhoa.TextChanged += new System.EventHandler(this.txtTuKhoa_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Từ khoá";
            // 
            // dgvChonDauSach
            // 
            this.dgvChonDauSach.AllowCustomTheming = false;
            this.dgvChonDauSach.AllowUserToOrderColumns = true;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dgvChonDauSach.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvChonDauSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChonDauSach.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvChonDauSach.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvChonDauSach.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvChonDauSach.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.MediumVioletRed;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(16)))), ((int)(((byte)(106)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvChonDauSach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvChonDauSach.ColumnHeadersHeight = 40;
            this.dgvChonDauSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDauSach,
            this.TenDauSach,
            this.SoLuong,
            this.LanTaiBan,
            this.NamXuatBan,
            this.GiaTien,
            this.MoTa,
            this.Anh,
            this.MaTheLoai,
            this.MaTacGia,
            this.TenTacGia,
            this.MaNhaXuatBan,
            this.DiaChi,
            this.TenNhaXuatBan,
            this.TenTheLoai});
            this.dgvChonDauSach.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(224)))));
            this.dgvChonDauSach.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvChonDauSach.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvChonDauSach.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(114)))), ((int)(((byte)(181)))));
            this.dgvChonDauSach.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvChonDauSach.CurrentTheme.BackColor = System.Drawing.Color.MediumVioletRed;
            this.dgvChonDauSach.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(184)))), ((int)(((byte)(218)))));
            this.dgvChonDauSach.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.MediumVioletRed;
            this.dgvChonDauSach.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgvChonDauSach.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvChonDauSach.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(16)))), ((int)(((byte)(106)))));
            this.dgvChonDauSach.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvChonDauSach.CurrentTheme.Name = null;
            this.dgvChonDauSach.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(208)))), ((int)(((byte)(230)))));
            this.dgvChonDauSach.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvChonDauSach.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvChonDauSach.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(114)))), ((int)(((byte)(181)))));
            this.dgvChonDauSach.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(208)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(114)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvChonDauSach.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvChonDauSach.EnableHeadersVisualStyles = false;
            this.dgvChonDauSach.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(184)))), ((int)(((byte)(218)))));
            this.dgvChonDauSach.HeaderBackColor = System.Drawing.Color.MediumVioletRed;
            this.dgvChonDauSach.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvChonDauSach.HeaderForeColor = System.Drawing.Color.White;
            this.dgvChonDauSach.Location = new System.Drawing.Point(69, 163);
            this.dgvChonDauSach.Margin = new System.Windows.Forms.Padding(4);
            this.dgvChonDauSach.Name = "dgvChonDauSach";
            this.dgvChonDauSach.RowHeadersVisible = false;
            this.dgvChonDauSach.RowHeadersWidth = 51;
            this.dgvChonDauSach.RowTemplate.Height = 40;
            this.dgvChonDauSach.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvChonDauSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChonDauSach.Size = new System.Drawing.Size(777, 531);
            this.dgvChonDauSach.TabIndex = 33;
            this.dgvChonDauSach.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.MediumVioletRed;
            this.dgvChonDauSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChonDauSach_CellClick);
            this.dgvChonDauSach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChonDauSach_CellContentClick);
            // 
            // MaDauSach
            // 
            this.MaDauSach.DataPropertyName = "MaDauSach";
            this.MaDauSach.HeaderText = "Mã đầu sách";
            this.MaDauSach.MinimumWidth = 6;
            this.MaDauSach.Name = "MaDauSach";
            this.MaDauSach.ReadOnly = true;
            // 
            // TenDauSach
            // 
            this.TenDauSach.DataPropertyName = "TenDauSach";
            this.TenDauSach.HeaderText = "Tên đầu sách";
            this.TenDauSach.MinimumWidth = 6;
            this.TenDauSach.Name = "TenDauSach";
            this.TenDauSach.ReadOnly = true;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            // 
            // LanTaiBan
            // 
            this.LanTaiBan.DataPropertyName = "LanTaiBan";
            this.LanTaiBan.HeaderText = "LanTaiBan";
            this.LanTaiBan.MinimumWidth = 6;
            this.LanTaiBan.Name = "LanTaiBan";
            this.LanTaiBan.ReadOnly = true;
            this.LanTaiBan.Visible = false;
            // 
            // NamXuatBan
            // 
            this.NamXuatBan.DataPropertyName = "NamXuatBan";
            this.NamXuatBan.HeaderText = "NamXuatBan";
            this.NamXuatBan.MinimumWidth = 6;
            this.NamXuatBan.Name = "NamXuatBan";
            this.NamXuatBan.ReadOnly = true;
            this.NamXuatBan.Visible = false;
            // 
            // GiaTien
            // 
            this.GiaTien.DataPropertyName = "GiaTien";
            this.GiaTien.HeaderText = "GiaTien";
            this.GiaTien.MinimumWidth = 6;
            this.GiaTien.Name = "GiaTien";
            this.GiaTien.ReadOnly = true;
            this.GiaTien.Visible = false;
            // 
            // MoTa
            // 
            this.MoTa.DataPropertyName = "MoTa";
            this.MoTa.HeaderText = "MoTa";
            this.MoTa.MinimumWidth = 6;
            this.MoTa.Name = "MoTa";
            this.MoTa.ReadOnly = true;
            this.MoTa.Visible = false;
            // 
            // Anh
            // 
            this.Anh.DataPropertyName = "Anh";
            this.Anh.HeaderText = "Anh";
            this.Anh.MinimumWidth = 6;
            this.Anh.Name = "Anh";
            this.Anh.ReadOnly = true;
            this.Anh.Visible = false;
            // 
            // MaTheLoai
            // 
            this.MaTheLoai.DataPropertyName = "MaTheLoai";
            this.MaTheLoai.HeaderText = "MaTheLoai";
            this.MaTheLoai.MinimumWidth = 6;
            this.MaTheLoai.Name = "MaTheLoai";
            this.MaTheLoai.ReadOnly = true;
            this.MaTheLoai.Visible = false;
            // 
            // MaTacGia
            // 
            this.MaTacGia.DataPropertyName = "MaTacGia";
            this.MaTacGia.HeaderText = "MaTacGia";
            this.MaTacGia.MinimumWidth = 6;
            this.MaTacGia.Name = "MaTacGia";
            this.MaTacGia.ReadOnly = true;
            this.MaTacGia.Visible = false;
            // 
            // TenTacGia
            // 
            this.TenTacGia.DataPropertyName = "TenTacGia";
            this.TenTacGia.HeaderText = "TenTacGia";
            this.TenTacGia.MinimumWidth = 6;
            this.TenTacGia.Name = "TenTacGia";
            this.TenTacGia.ReadOnly = true;
            this.TenTacGia.Visible = false;
            // 
            // MaNhaXuatBan
            // 
            this.MaNhaXuatBan.DataPropertyName = "MaNhaXuatBan";
            this.MaNhaXuatBan.HeaderText = "MaNhaXuatBan";
            this.MaNhaXuatBan.MinimumWidth = 6;
            this.MaNhaXuatBan.Name = "MaNhaXuatBan";
            this.MaNhaXuatBan.ReadOnly = true;
            this.MaNhaXuatBan.Visible = false;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "DiaChi";
            this.DiaChi.MinimumWidth = 6;
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.ReadOnly = true;
            this.DiaChi.Visible = false;
            // 
            // TenNhaXuatBan
            // 
            this.TenNhaXuatBan.DataPropertyName = "TenNhaXuatBan";
            this.TenNhaXuatBan.HeaderText = "TenNhaXuatBan";
            this.TenNhaXuatBan.MinimumWidth = 6;
            this.TenNhaXuatBan.Name = "TenNhaXuatBan";
            this.TenNhaXuatBan.ReadOnly = true;
            this.TenNhaXuatBan.Visible = false;
            // 
            // TenTheLoai
            // 
            this.TenTheLoai.DataPropertyName = "TenTheLoai";
            this.TenTheLoai.HeaderText = "TenTheLoai";
            this.TenTheLoai.MinimumWidth = 6;
            this.TenTheLoai.Name = "TenTheLoai";
            this.TenTheLoai.ReadOnly = true;
            this.TenTheLoai.Visible = false;
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BorderRadius = 20;
            this.guna2CustomGradientPanel1.Controls.Add(this.label6);
            this.guna2CustomGradientPanel1.Controls.Add(this.lbInfoMaDS);
            this.guna2CustomGradientPanel1.Controls.Add(this.imageBook);
            this.guna2CustomGradientPanel1.Controls.Add(this.label9);
            this.guna2CustomGradientPanel1.Controls.Add(this.lbInfoTenNXB);
            this.guna2CustomGradientPanel1.Controls.Add(this.lbInfoNamXB);
            this.guna2CustomGradientPanel1.Controls.Add(this.label2);
            this.guna2CustomGradientPanel1.Controls.Add(this.label10);
            this.guna2CustomGradientPanel1.Controls.Add(this.lbInfoMota);
            this.guna2CustomGradientPanel1.Controls.Add(this.label11);
            this.guna2CustomGradientPanel1.Controls.Add(this.lbInfoTenTG);
            this.guna2CustomGradientPanel1.Controls.Add(this.lbInfoTenSach);
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.DodgerBlue;
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.DodgerBlue;
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(869, 41);
            this.guna2CustomGradientPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.ShadowDecoration.Parent = this.guna2CustomGradientPanel1;
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(443, 653);
            this.guna2CustomGradientPanel1.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 28);
            this.label6.TabIndex = 27;
            this.label6.Text = "Mã đầu sách :";
            // 
            // lbInfoMaDS
            // 
            this.lbInfoMaDS.AutoSize = true;
            this.lbInfoMaDS.BackColor = System.Drawing.Color.Transparent;
            this.lbInfoMaDS.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInfoMaDS.Location = new System.Drawing.Point(156, 205);
            this.lbInfoMaDS.Name = "lbInfoMaDS";
            this.lbInfoMaDS.Size = new System.Drawing.Size(103, 28);
            this.lbInfoMaDS.TabIndex = 28;
            this.lbInfoMaDS.Text = "DS000000";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 244);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 28);
            this.label9.TabIndex = 19;
            this.label9.Text = "Tác giả :";
            // 
            // lbInfoTenNXB
            // 
            this.lbInfoTenNXB.AutoSize = true;
            this.lbInfoTenNXB.BackColor = System.Drawing.Color.Transparent;
            this.lbInfoTenNXB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInfoTenNXB.Location = new System.Drawing.Point(156, 327);
            this.lbInfoTenNXB.Name = "lbInfoTenNXB";
            this.lbInfoTenNXB.Size = new System.Drawing.Size(80, 28);
            this.lbInfoTenNXB.TabIndex = 26;
            this.lbInfoTenNXB.Text = "NXB Trẻ";
            // 
            // lbInfoNamXB
            // 
            this.lbInfoNamXB.AutoSize = true;
            this.lbInfoNamXB.BackColor = System.Drawing.Color.Transparent;
            this.lbInfoNamXB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInfoNamXB.Location = new System.Drawing.Point(156, 289);
            this.lbInfoNamXB.Name = "lbInfoNamXB";
            this.lbInfoNamXB.Size = new System.Drawing.Size(56, 28);
            this.lbInfoNamXB.TabIndex = 26;
            this.lbInfoNamXB.Text = "2020";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 327);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 28);
            this.label2.TabIndex = 20;
            this.label2.Text = "Nhà xuất bản:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(14, 289);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(145, 28);
            this.label10.TabIndex = 20;
            this.label10.Text = "Năm xuất bản:";
            // 
            // lbInfoMota
            // 
            this.lbInfoMota.BackColor = System.Drawing.Color.Transparent;
            this.lbInfoMota.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lbInfoMota.Location = new System.Drawing.Point(91, 370);
            this.lbInfoMota.Name = "lbInfoMota";
            this.lbInfoMota.Size = new System.Drawing.Size(331, 244);
            this.lbInfoMota.TabIndex = 25;
            this.lbInfoMota.Text = resources.GetString("lbInfoMota.Text");
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(14, 370);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 28);
            this.label11.TabIndex = 21;
            this.label11.Text = "Mô tả : ";
            // 
            // lbInfoTenTG
            // 
            this.lbInfoTenTG.AutoSize = true;
            this.lbInfoTenTG.BackColor = System.Drawing.Color.Transparent;
            this.lbInfoTenTG.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInfoTenTG.Location = new System.Drawing.Point(96, 244);
            this.lbInfoTenTG.Name = "lbInfoTenTG";
            this.lbInfoTenTG.Size = new System.Drawing.Size(155, 28);
            this.lbInfoTenTG.TabIndex = 24;
            this.lbInfoTenTG.Text = "Kevin D.Johnson";
            // 
            // lbInfoTenSach
            // 
            this.lbInfoTenSach.BackColor = System.Drawing.Color.Transparent;
            this.lbInfoTenSach.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.lbInfoTenSach.Location = new System.Drawing.Point(177, 42);
            this.lbInfoTenSach.Name = "lbInfoTenSach";
            this.lbInfoTenSach.Size = new System.Drawing.Size(245, 153);
            this.lbInfoTenSach.TabIndex = 23;
            this.lbInfoTenSach.Text = "Tư duy doanh nhân- Cách doanh nhân nghĩ, việc doanh nhân làm qua 100 bài học xươn" +
    "g máu";
            // 
            // imageBook
            // 
            this.imageBook.BackColor = System.Drawing.Color.Transparent;
            this.imageBook.BackgroundImage = global::LibraryManager.Properties.Resources.icons8_moleskine_500px;
            this.imageBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imageBook.Location = new System.Drawing.Point(15, 46);
            this.imageBook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imageBook.Name = "imageBook";
            this.imageBook.Size = new System.Drawing.Size(144, 144);
            this.imageBook.TabIndex = 3;
            this.imageBook.TabStop = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.BorderRadius = 18;
            this.btnSearch.CheckedState.Parent = this.btnSearch;
            this.btnSearch.CustomImages.Parent = this.btnSearch;
            this.btnSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(198)))), ((int)(((byte)(165)))));
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.HoverState.Parent = this.btnSearch;
            this.btnSearch.Image = global::LibraryManager.Properties.Resources.icons8_search_64px;
            this.btnSearch.Location = new System.Drawing.Point(618, 42);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.ShadowDecoration.Parent = this.btnSearch;
            this.btnSearch.Size = new System.Drawing.Size(125, 44);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Tìm kiếm";
            // 
            // FrmTimKiemForDG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Controls.Add(this.dgvChonDauSach);
            this.Controls.Add(this.guna2CustomGradientPanel3);
            this.Name = "FrmTimKiemForDG";
            this.Size = new System.Drawing.Size(1347, 783);
            this.Load += new System.EventHandler(this.FrmTimKiemForDG_Load);
            this.guna2CustomGradientPanel3.ResumeLayout(false);
            this.guna2CustomGradientPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChonDauSach)).EndInit();
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBook)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel3;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Guna.UI2.WinForms.Guna2TextBox txtTuKhoa;
        private System.Windows.Forms.Label label5;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvChonDauSach;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbInfoMaDS;
        private System.Windows.Forms.PictureBox imageBook;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbInfoTenNXB;
        private System.Windows.Forms.Label lbInfoNamXB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbInfoMota;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbInfoTenTG;
        private System.Windows.Forms.Label lbInfoTenSach;
        private Guna.UI2.WinForms.Guna2ComboBox cbLoaiLoc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDauSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDauSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn LanTaiBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamXuatBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoTa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Anh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTheLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTacGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTacGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhaXuatBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNhaXuatBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTheLoai;
    }
}
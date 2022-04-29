
namespace LibraryManager.Template
{
    partial class PhieuMuon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhieuMuon));
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.txtName = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvInfoBorrow = new System.Windows.Forms.DataGridView();
            this.lbMaMuonTra = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbMaDocGia = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnLoaiBo = new Guna.UI2.WinForms.Guna2Button();
            this.btnSearchNV = new Guna.UI2.WinForms.Guna2Button();
            this.lbInfoNamXB = new System.Windows.Forms.Label();
            this.lbInfoMota = new System.Windows.Forms.Label();
            this.lbInfoTenTG = new System.Windows.Forms.Label();
            this.lbInfoTenSach = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.imageBook = new System.Windows.Forms.PictureBox();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.lbTienCoc = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.MaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDauSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDauSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ViTriSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateHanTra = new LibraryManager.Template.DateTimePickerKiet();
            this.DateMuon = new LibraryManager.Template.DateTimePickerKiet();
            this.label7 = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfoBorrow)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBook)).BeginInit();
            this.guna2Panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(36, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 42);
            this.label1.TabIndex = 4;
            this.label1.Text = "MÃ PHIẾU MƯỢN : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(14, 10);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Họ và tên độc giả :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(14, 90);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Ngày mượn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(184, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Hạn trả:";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.guna2Panel1.BorderRadius = 15;
            this.guna2Panel1.Controls.Add(this.txtName);
            this.guna2Panel1.Controls.Add(this.dateHanTra);
            this.guna2Panel1.Controls.Add(this.label5);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.label4);
            this.guna2Panel1.Controls.Add(this.DateMuon);
            this.guna2Panel1.Location = new System.Drawing.Point(41, 98);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(350, 170);
            this.guna2Panel1.TabIndex = 18;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.Transparent;
            this.txtName.BorderColor = System.Drawing.Color.Transparent;
            this.txtName.BorderRadius = 6;
            this.txtName.BorderThickness = 0;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.DefaultText = "";
            this.txtName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.DisabledState.Parent = this.txtName;
            this.txtName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.FocusedState.Parent = this.txtName;
            this.txtName.ForeColor = System.Drawing.Color.Black;
            this.txtName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.HoverState.Parent = this.txtName;
            this.txtName.Location = new System.Drawing.Point(16, 37);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PlaceholderText = "";
            this.txtName.SelectedText = "";
            this.txtName.ShadowDecoration.Parent = this.txtName;
            this.txtName.Size = new System.Drawing.Size(150, 35);
            this.txtName.TabIndex = 0;
            // 
            // dgvInfoBorrow
            // 
            this.dgvInfoBorrow.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInfoBorrow.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInfoBorrow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfoBorrow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSach,
            this.MaDauSach,
            this.TenDauSach,
            this.ViTriSach,
            this.GiaTien});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInfoBorrow.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvInfoBorrow.Location = new System.Drawing.Point(41, 306);
            this.dgvInfoBorrow.Margin = new System.Windows.Forms.Padding(2);
            this.dgvInfoBorrow.Name = "dgvInfoBorrow";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInfoBorrow.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvInfoBorrow.RowHeadersWidth = 51;
            this.dgvInfoBorrow.RowTemplate.Height = 24;
            this.dgvInfoBorrow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInfoBorrow.Size = new System.Drawing.Size(558, 290);
            this.dgvInfoBorrow.TabIndex = 5;
            this.dgvInfoBorrow.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInfoBorrow_CellClick);
            // 
            // lbMaMuonTra
            // 
            this.lbMaMuonTra.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.lbMaMuonTra.Location = new System.Drawing.Point(271, 0);
            this.lbMaMuonTra.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMaMuonTra.Name = "lbMaMuonTra";
            this.lbMaMuonTra.Size = new System.Drawing.Size(150, 36);
            this.lbMaMuonTra.TabIndex = 3;
            this.lbMaMuonTra.Text = "000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DarkRed;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(41, 55);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mã độc giả :";
            // 
            // lbMaDocGia
            // 
            this.lbMaDocGia.AutoSize = true;
            this.lbMaDocGia.BackColor = System.Drawing.Color.DarkRed;
            this.lbMaDocGia.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaDocGia.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbMaDocGia.Location = new System.Drawing.Point(130, 55);
            this.lbMaDocGia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMaDocGia.Name = "lbMaDocGia";
            this.lbMaDocGia.Size = new System.Drawing.Size(84, 21);
            this.lbMaDocGia.TabIndex = 1;
            this.lbMaDocGia.Text = "dg000000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.MediumTurquoise;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(268, 55);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhân viên xử lý : Chu Tuấn Kiệt";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.guna2Panel2.BorderRadius = 10;
            this.guna2Panel2.Controls.Add(this.btnLoaiBo);
            this.guna2Panel2.Controls.Add(this.btnSearchNV);
            this.guna2Panel2.Controls.Add(this.lbInfoNamXB);
            this.guna2Panel2.Controls.Add(this.lbInfoMota);
            this.guna2Panel2.Controls.Add(this.lbInfoTenTG);
            this.guna2Panel2.Controls.Add(this.lbInfoTenSach);
            this.guna2Panel2.Controls.Add(this.label11);
            this.guna2Panel2.Controls.Add(this.label10);
            this.guna2Panel2.Controls.Add(this.label9);
            this.guna2Panel2.Controls.Add(this.imageBook);
            this.guna2Panel2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Panel2.Location = new System.Drawing.Point(627, 88);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(332, 508);
            this.guna2Panel2.TabIndex = 22;
            // 
            // btnLoaiBo
            // 
            this.btnLoaiBo.BorderRadius = 18;
            this.btnLoaiBo.CheckedState.Parent = this.btnLoaiBo;
            this.btnLoaiBo.CustomImages.Parent = this.btnLoaiBo;
            this.btnLoaiBo.FillColor = System.Drawing.Color.LightCoral;
            this.btnLoaiBo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLoaiBo.ForeColor = System.Drawing.Color.White;
            this.btnLoaiBo.HoverState.Parent = this.btnLoaiBo;
            this.btnLoaiBo.Image = global::LibraryManager.Properties.Resources.icons8_remove_tag_40px;
            this.btnLoaiBo.Location = new System.Drawing.Point(183, 418);
            this.btnLoaiBo.Margin = new System.Windows.Forms.Padding(2);
            this.btnLoaiBo.Name = "btnLoaiBo";
            this.btnLoaiBo.ShadowDecoration.Parent = this.btnLoaiBo;
            this.btnLoaiBo.Size = new System.Drawing.Size(119, 36);
            this.btnLoaiBo.TabIndex = 1;
            this.btnLoaiBo.Text = "Loại bỏ";
            this.btnLoaiBo.Click += new System.EventHandler(this.btnLoaiBo_Click);
            // 
            // btnSearchNV
            // 
            this.btnSearchNV.BorderRadius = 18;
            this.btnSearchNV.CheckedState.Parent = this.btnSearchNV;
            this.btnSearchNV.CustomImages.Parent = this.btnSearchNV;
            this.btnSearchNV.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSearchNV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSearchNV.ForeColor = System.Drawing.Color.White;
            this.btnSearchNV.HoverState.Parent = this.btnSearchNV;
            this.btnSearchNV.Image = global::LibraryManager.Properties.Resources.icons8_preview_file_64px;
            this.btnSearchNV.Location = new System.Drawing.Point(38, 418);
            this.btnSearchNV.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchNV.Name = "btnSearchNV";
            this.btnSearchNV.ShadowDecoration.Parent = this.btnSearchNV;
            this.btnSearchNV.Size = new System.Drawing.Size(119, 36);
            this.btnSearchNV.TabIndex = 2;
            this.btnSearchNV.Text = "Preview";
            // 
            // lbInfoNamXB
            // 
            this.lbInfoNamXB.AutoSize = true;
            this.lbInfoNamXB.BackColor = System.Drawing.Color.Transparent;
            this.lbInfoNamXB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInfoNamXB.Location = new System.Drawing.Point(149, 204);
            this.lbInfoNamXB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbInfoNamXB.Name = "lbInfoNamXB";
            this.lbInfoNamXB.Size = new System.Drawing.Size(46, 21);
            this.lbInfoNamXB.TabIndex = 26;
            this.lbInfoNamXB.Text = "2020";
            // 
            // lbInfoMota
            // 
            this.lbInfoMota.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lbInfoMota.Location = new System.Drawing.Point(70, 251);
            this.lbInfoMota.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbInfoMota.Name = "lbInfoMota";
            this.lbInfoMota.Size = new System.Drawing.Size(248, 167);
            this.lbInfoMota.TabIndex = 25;
            this.lbInfoMota.Text = resources.GetString("lbInfoMota.Text");
            // 
            // lbInfoTenTG
            // 
            this.lbInfoTenTG.AutoSize = true;
            this.lbInfoTenTG.BackColor = System.Drawing.Color.Transparent;
            this.lbInfoTenTG.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInfoTenTG.Location = new System.Drawing.Point(75, 171);
            this.lbInfoTenTG.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbInfoTenTG.Name = "lbInfoTenTG";
            this.lbInfoTenTG.Size = new System.Drawing.Size(124, 21);
            this.lbInfoTenTG.TabIndex = 24;
            this.lbInfoTenTG.Text = "Kevin D.Johnson";
            // 
            // lbInfoTenSach
            // 
            this.lbInfoTenSach.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.lbInfoTenSach.Location = new System.Drawing.Point(134, 28);
            this.lbInfoTenSach.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbInfoTenSach.Name = "lbInfoTenSach";
            this.lbInfoTenSach.Size = new System.Drawing.Size(184, 124);
            this.lbInfoTenSach.TabIndex = 23;
            this.lbInfoTenSach.Text = "Tư duy doanh nhân- Cách doanh nhân nghĩ, việc doanh nhân làm qua 100 bài học xươn" +
    "g máu";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 249);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 21);
            this.label11.TabIndex = 21;
            this.label11.Text = "Mô tả : ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 204);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 21);
            this.label10.TabIndex = 20;
            this.label10.Text = "Năm xuất bản:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 171);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 21);
            this.label9.TabIndex = 19;
            this.label9.Text = "Tác giả :";
            // 
            // imageBook
            // 
            this.imageBook.BackgroundImage = global::LibraryManager.Properties.Resources.icons8_circled_user_male_skin_type_6_80px;
            this.imageBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imageBook.Location = new System.Drawing.Point(14, 34);
            this.imageBook.Margin = new System.Windows.Forms.Padding(2);
            this.imageBook.Name = "imageBook";
            this.imageBook.Size = new System.Drawing.Size(108, 117);
            this.imageBook.TabIndex = 3;
            this.imageBook.TabStop = false;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.guna2Panel3.BorderRadius = 15;
            this.guna2Panel3.Controls.Add(this.lbTienCoc);
            this.guna2Panel3.Controls.Add(this.label14);
            this.guna2Panel3.Location = new System.Drawing.Point(417, 98);
            this.guna2Panel3.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.ShadowDecoration.Parent = this.guna2Panel3;
            this.guna2Panel3.Size = new System.Drawing.Size(182, 170);
            this.guna2Panel3.TabIndex = 19;
            // 
            // lbTienCoc
            // 
            this.lbTienCoc.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.lbTienCoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbTienCoc.Location = new System.Drawing.Point(19, 75);
            this.lbTienCoc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTienCoc.Name = "lbTienCoc";
            this.lbTienCoc.Size = new System.Drawing.Size(161, 42);
            this.lbTienCoc.TabIndex = 24;
            this.lbTienCoc.Text = "200.000 VND";
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(2, 10);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(178, 42);
            this.label14.TabIndex = 1;
            this.label14.Text = "Tổng tiền cọc:";
            // 
            // MaSach
            // 
            this.MaSach.DataPropertyName = "MaSach";
            this.MaSach.HeaderText = "Mã cuốn sách";
            this.MaSach.MinimumWidth = 6;
            this.MaSach.Name = "MaSach";
            this.MaSach.ReadOnly = true;
            // 
            // MaDauSach
            // 
            this.MaDauSach.DataPropertyName = "MaDauSach";
            this.MaDauSach.HeaderText = "Mã đầu sách";
            this.MaDauSach.MinimumWidth = 6;
            this.MaDauSach.Name = "MaDauSach";
            this.MaDauSach.ReadOnly = true;
            this.MaDauSach.Width = 90;
            // 
            // TenDauSach
            // 
            this.TenDauSach.DataPropertyName = "TenDauSach";
            this.TenDauSach.HeaderText = "Tên đầu sách";
            this.TenDauSach.MinimumWidth = 6;
            this.TenDauSach.Name = "TenDauSach";
            this.TenDauSach.ReadOnly = true;
            this.TenDauSach.Width = 150;
            // 
            // ViTriSach
            // 
            this.ViTriSach.DataPropertyName = "ViTriSach";
            this.ViTriSach.HeaderText = "Vị trí sách";
            this.ViTriSach.MinimumWidth = 6;
            this.ViTriSach.Name = "ViTriSach";
            this.ViTriSach.ReadOnly = true;
            this.ViTriSach.Width = 60;
            // 
            // GiaTien
            // 
            this.GiaTien.DataPropertyName = "GiaTien";
            this.GiaTien.HeaderText = "Giá tiền";
            this.GiaTien.MinimumWidth = 6;
            this.GiaTien.Name = "GiaTien";
            this.GiaTien.ReadOnly = true;
            this.GiaTien.Width = 150;
            // 
            // dateHanTra
            // 
            this.dateHanTra.BorderColor = System.Drawing.Color.Transparent;
            this.dateHanTra.BorderRadius = 6;
            this.dateHanTra.BorderSize = 0;
            this.dateHanTra.CustomFormat = "dd/MM/yyyy";
            this.dateHanTra.Enabled = false;
            this.dateHanTra.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateHanTra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateHanTra.Location = new System.Drawing.Point(187, 110);
            this.dateHanTra.Margin = new System.Windows.Forms.Padding(2);
            this.dateHanTra.MinimumSize = new System.Drawing.Size(4, 37);
            this.dateHanTra.Name = "dateHanTra";
            this.dateHanTra.Size = new System.Drawing.Size(138, 37);
            this.dateHanTra.SkinColor = System.Drawing.Color.White;
            this.dateHanTra.TabIndex = 2;
            this.dateHanTra.TextColor = System.Drawing.Color.Black;
            // 
            // DateMuon
            // 
            this.DateMuon.BorderColor = System.Drawing.Color.Transparent;
            this.DateMuon.BorderRadius = 6;
            this.DateMuon.BorderSize = 0;
            this.DateMuon.CustomFormat = "dd/MM/yyyy";
            this.DateMuon.Enabled = false;
            this.DateMuon.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateMuon.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateMuon.Location = new System.Drawing.Point(16, 110);
            this.DateMuon.Margin = new System.Windows.Forms.Padding(2);
            this.DateMuon.MinimumSize = new System.Drawing.Size(4, 37);
            this.DateMuon.Name = "DateMuon";
            this.DateMuon.Size = new System.Drawing.Size(141, 37);
            this.DateMuon.SkinColor = System.Drawing.Color.White;
            this.DateMuon.TabIndex = 1;
            this.DateMuon.TextColor = System.Drawing.Color.Black;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(42, 282);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(196, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "*Tiền cọc được tính bằng 10% giá sách";
            // 
            // PhieuMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbMaDocGia);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbMaMuonTra);
            this.Controls.Add(this.dgvInfoBorrow);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PhieuMuon";
            this.Size = new System.Drawing.Size(1000, 651);
            this.Load += new System.EventHandler(this.PhieuMuon_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfoBorrow)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBook)).EndInit();
            this.guna2Panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtName;
        private System.Windows.Forms.Label label5;
        private DateTimePickerKiet DateMuon;
        private System.Windows.Forms.Label label4;
        private DateTimePickerKiet dateHanTra;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.DataGridView dgvInfoBorrow;
        private System.Windows.Forms.Label lbMaMuonTra;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbMaDocGia;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label lbInfoTenTG;
        private System.Windows.Forms.Label lbInfoTenSach;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox imageBook;
        private System.Windows.Forms.Label lbInfoMota;
        private System.Windows.Forms.Label lbInfoNamXB;
        private Guna.UI2.WinForms.Guna2Button btnLoaiBo;
        private Guna.UI2.WinForms.Guna2Button btnSearchNV;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private System.Windows.Forms.Label lbTienCoc;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDauSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDauSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn ViTriSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaTien;
        private System.Windows.Forms.Label label7;
    }
}

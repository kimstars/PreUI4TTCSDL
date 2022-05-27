
namespace LibraryManager.Template
{
    partial class DanhSachDG
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.cbFilterDG = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDG = new System.Windows.Forms.DataGridView();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.pickerBirthday = new LibraryManager.Template.DateTimePickerKiet();
            this.txtSDT = new Guna.UI2.WinForms.Guna2TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbGender = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.guna2CustomGradientPanel2 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.txtCMND = new Guna.UI2.WinForms.Guna2TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTendangnhap = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDiachi = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtName = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.btnLuu = new Guna.UI2.WinForms.Guna2Button();
            this.btnSearchNV = new Guna.UI2.WinForms.Guna2Button();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDG)).BeginInit();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.guna2CustomGradientPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnLuu);
            this.panel1.Controls.Add(this.btnSearchNV);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cbFilterDG);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Location = new System.Drawing.Point(16, 65);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1019, 111);
            this.panel1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(349, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 28);
            this.label3.TabIndex = 7;
            this.label3.Text = "Bộ lọc";
            // 
            // cbFilterDG
            // 
            this.cbFilterDG.BackColor = System.Drawing.Color.Transparent;
            this.cbFilterDG.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbFilterDG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterDG.FocusedColor = System.Drawing.Color.Empty;
            this.cbFilterDG.FocusedState.Parent = this.cbFilterDG;
            this.cbFilterDG.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbFilterDG.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbFilterDG.FormattingEnabled = true;
            this.cbFilterDG.HoverState.Parent = this.cbFilterDG;
            this.cbFilterDG.ItemHeight = 30;
            this.cbFilterDG.Items.AddRange(new object[] {
            "Theo tên",
            "Theo Mã nhân viên",
            "Theo Chức vụ",
            "Theo Email",
            "Theo SDT",
            "Theo Tên đăng nhập",
            "Tất cả"});
            this.cbFilterDG.ItemsAppearance.Parent = this.cbFilterDG;
            this.cbFilterDG.Location = new System.Drawing.Point(354, 44);
            this.cbFilterDG.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbFilterDG.Name = "cbFilterDG";
            this.cbFilterDG.ShadowDecoration.Parent = this.cbFilterDG;
            this.cbFilterDG.Size = new System.Drawing.Size(190, 36);
            this.cbFilterDG.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.Location = new System.Drawing.Point(4, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tìm kiếm ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 41);
            this.label1.TabIndex = 6;
            this.label1.Text = "DANH SÁCH ĐỘC GIẢ";
            // 
            // dgvDG
            // 
            this.dgvDG.BackgroundColor = System.Drawing.Color.White;
            this.dgvDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDG.GridColor = System.Drawing.Color.Black;
            this.dgvDG.Location = new System.Drawing.Point(16, 182);
            this.dgvDG.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDG.Name = "dgvDG";
            this.dgvDG.RowHeadersWidth = 51;
            this.dgvDG.RowTemplate.Height = 24;
            this.dgvDG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDG.Size = new System.Drawing.Size(644, 606);
            this.dgvDG.TabIndex = 5;
            this.dgvDG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDG_CellClick);
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.guna2CustomGradientPanel1.BorderColor = System.Drawing.Color.Red;
            this.guna2CustomGradientPanel1.BorderRadius = 12;
            this.guna2CustomGradientPanel1.Controls.Add(this.pickerBirthday);
            this.guna2CustomGradientPanel1.Controls.Add(this.txtSDT);
            this.guna2CustomGradientPanel1.Controls.Add(this.label11);
            this.guna2CustomGradientPanel1.Controls.Add(this.cbGender);
            this.guna2CustomGradientPanel1.Controls.Add(this.label8);
            this.guna2CustomGradientPanel1.Controls.Add(this.txtName);
            this.guna2CustomGradientPanel1.Controls.Add(this.label4);
            this.guna2CustomGradientPanel1.Controls.Add(this.label5);
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.SystemColors.ControlLight;
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.SystemColors.ControlLight;
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.SystemColors.ControlLight;
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.SystemColors.ControlLight;
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(680, 182);
            this.guna2CustomGradientPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.ShadowDecoration.Parent = this.guna2CustomGradientPanel1;
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(355, 304);
            this.guna2CustomGradientPanel1.TabIndex = 9;
            // 
            // pickerBirthday
            // 
            this.pickerBirthday.BorderColor = System.Drawing.Color.Transparent;
            this.pickerBirthday.BorderRadius = 6;
            this.pickerBirthday.BorderSize = 0;
            this.pickerBirthday.CustomFormat = "dd/MM/yyyy";
            this.pickerBirthday.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pickerBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.pickerBirthday.Location = new System.Drawing.Point(25, 126);
            this.pickerBirthday.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pickerBirthday.MinimumSize = new System.Drawing.Size(4, 37);
            this.pickerBirthday.Name = "pickerBirthday";
            this.pickerBirthday.Size = new System.Drawing.Size(296, 37);
            this.pickerBirthday.SkinColor = System.Drawing.Color.White;
            this.pickerBirthday.TabIndex = 13;
            this.pickerBirthday.TextColor = System.Drawing.Color.Black;
            // 
            // txtSDT
            // 
            this.txtSDT.BackColor = System.Drawing.Color.Transparent;
            this.txtSDT.BorderColor = System.Drawing.Color.Transparent;
            this.txtSDT.BorderRadius = 6;
            this.txtSDT.BorderThickness = 0;
            this.txtSDT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSDT.DefaultText = "";
            this.txtSDT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSDT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSDT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSDT.DisabledState.Parent = this.txtSDT;
            this.txtSDT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSDT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSDT.FocusedState.Parent = this.txtSDT;
            this.txtSDT.ForeColor = System.Drawing.Color.Black;
            this.txtSDT.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSDT.HoverState.Parent = this.txtSDT;
            this.txtSDT.Location = new System.Drawing.Point(131, 220);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(5);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.PasswordChar = '\0';
            this.txtSDT.PlaceholderText = "";
            this.txtSDT.SelectedText = "";
            this.txtSDT.ShadowDecoration.Parent = this.txtSDT;
            this.txtSDT.Size = new System.Drawing.Size(189, 44);
            this.txtSDT.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(127, 190);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 17);
            this.label11.TabIndex = 11;
            this.label11.Text = "Số điện thoại:";
            // 
            // cbGender
            // 
            this.cbGender.BackColor = System.Drawing.Color.Transparent;
            this.cbGender.BorderRadius = 6;
            this.cbGender.BorderThickness = 0;
            this.cbGender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGender.FocusedColor = System.Drawing.Color.Empty;
            this.cbGender.FocusedState.Parent = this.cbGender;
            this.cbGender.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGender.ForeColor = System.Drawing.Color.Black;
            this.cbGender.FormattingEnabled = true;
            this.cbGender.HoverState.Parent = this.cbGender;
            this.cbGender.ItemHeight = 30;
            this.cbGender.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbGender.ItemsAppearance.Parent = this.cbGender;
            this.cbGender.Location = new System.Drawing.Point(24, 220);
            this.cbGender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbGender.Name = "cbGender";
            this.cbGender.ShadowDecoration.Parent = this.cbGender;
            this.cbGender.Size = new System.Drawing.Size(99, 36);
            this.cbGender.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(21, 190);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "Giới tính:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(21, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ngày sinh:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(21, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Họ và tên:";
            // 
            // guna2CustomGradientPanel2
            // 
            this.guna2CustomGradientPanel2.BackColor = System.Drawing.SystemColors.Control;
            this.guna2CustomGradientPanel2.BorderColor = System.Drawing.Color.Red;
            this.guna2CustomGradientPanel2.BorderRadius = 12;
            this.guna2CustomGradientPanel2.Controls.Add(this.txtCMND);
            this.guna2CustomGradientPanel2.Controls.Add(this.label10);
            this.guna2CustomGradientPanel2.Controls.Add(this.txtTendangnhap);
            this.guna2CustomGradientPanel2.Controls.Add(this.txtDiachi);
            this.guna2CustomGradientPanel2.Controls.Add(this.label6);
            this.guna2CustomGradientPanel2.Controls.Add(this.label7);
            this.guna2CustomGradientPanel2.FillColor = System.Drawing.SystemColors.ControlLight;
            this.guna2CustomGradientPanel2.FillColor2 = System.Drawing.SystemColors.ControlLight;
            this.guna2CustomGradientPanel2.FillColor3 = System.Drawing.SystemColors.ControlLight;
            this.guna2CustomGradientPanel2.FillColor4 = System.Drawing.SystemColors.ControlLight;
            this.guna2CustomGradientPanel2.Location = new System.Drawing.Point(680, 491);
            this.guna2CustomGradientPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2CustomGradientPanel2.Name = "guna2CustomGradientPanel2";
            this.guna2CustomGradientPanel2.ShadowDecoration.Parent = this.guna2CustomGradientPanel2;
            this.guna2CustomGradientPanel2.Size = new System.Drawing.Size(355, 297);
            this.guna2CustomGradientPanel2.TabIndex = 14;
            // 
            // txtCMND
            // 
            this.txtCMND.BackColor = System.Drawing.Color.Transparent;
            this.txtCMND.BorderColor = System.Drawing.Color.Transparent;
            this.txtCMND.BorderRadius = 6;
            this.txtCMND.BorderThickness = 0;
            this.txtCMND.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCMND.DefaultText = "";
            this.txtCMND.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCMND.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCMND.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCMND.DisabledState.Parent = this.txtCMND;
            this.txtCMND.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCMND.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCMND.FocusedState.Parent = this.txtCMND;
            this.txtCMND.ForeColor = System.Drawing.Color.Black;
            this.txtCMND.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCMND.HoverState.Parent = this.txtCMND;
            this.txtCMND.Location = new System.Drawing.Point(24, 220);
            this.txtCMND.Margin = new System.Windows.Forms.Padding(5);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.PasswordChar = '\0';
            this.txtCMND.PlaceholderText = "";
            this.txtCMND.SelectedText = "";
            this.txtCMND.ShadowDecoration.Parent = this.txtCMND;
            this.txtCMND.Size = new System.Drawing.Size(296, 44);
            this.txtCMND.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(21, 190);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(183, 17);
            this.label10.TabIndex = 8;
            this.label10.Text = "Số CMND (số thẻ căn cước)";
            // 
            // txtTendangnhap
            // 
            this.txtTendangnhap.BackColor = System.Drawing.Color.Transparent;
            this.txtTendangnhap.BorderColor = System.Drawing.Color.Transparent;
            this.txtTendangnhap.BorderRadius = 6;
            this.txtTendangnhap.BorderThickness = 0;
            this.txtTendangnhap.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTendangnhap.DefaultText = "";
            this.txtTendangnhap.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTendangnhap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTendangnhap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTendangnhap.DisabledState.Parent = this.txtTendangnhap;
            this.txtTendangnhap.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTendangnhap.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTendangnhap.FocusedState.Parent = this.txtTendangnhap;
            this.txtTendangnhap.ForeColor = System.Drawing.Color.Black;
            this.txtTendangnhap.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTendangnhap.HoverState.Parent = this.txtTendangnhap;
            this.txtTendangnhap.Location = new System.Drawing.Point(23, 126);
            this.txtTendangnhap.Margin = new System.Windows.Forms.Padding(5);
            this.txtTendangnhap.Name = "txtTendangnhap";
            this.txtTendangnhap.PasswordChar = '\0';
            this.txtTendangnhap.PlaceholderText = "";
            this.txtTendangnhap.SelectedText = "";
            this.txtTendangnhap.ShadowDecoration.Parent = this.txtTendangnhap;
            this.txtTendangnhap.Size = new System.Drawing.Size(296, 44);
            this.txtTendangnhap.TabIndex = 7;
            // 
            // txtDiachi
            // 
            this.txtDiachi.BackColor = System.Drawing.Color.Transparent;
            this.txtDiachi.BorderColor = System.Drawing.Color.Transparent;
            this.txtDiachi.BorderRadius = 6;
            this.txtDiachi.BorderThickness = 0;
            this.txtDiachi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiachi.DefaultText = "";
            this.txtDiachi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDiachi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDiachi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiachi.DisabledState.Parent = this.txtDiachi;
            this.txtDiachi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiachi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiachi.FocusedState.Parent = this.txtDiachi;
            this.txtDiachi.ForeColor = System.Drawing.Color.Black;
            this.txtDiachi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiachi.HoverState.Parent = this.txtDiachi;
            this.txtDiachi.Location = new System.Drawing.Point(23, 39);
            this.txtDiachi.Margin = new System.Windows.Forms.Padding(5);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.PasswordChar = '\0';
            this.txtDiachi.PlaceholderText = "";
            this.txtDiachi.SelectedText = "";
            this.txtDiachi.ShadowDecoration.Parent = this.txtDiachi;
            this.txtDiachi.Size = new System.Drawing.Size(296, 44);
            this.txtDiachi.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(20, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tên đăng nhập:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(21, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Địa chỉ:";
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
            this.txtName.IconRight = global::LibraryManager.Properties.Resources.icons8_tick_box_48px;
            this.txtName.Location = new System.Drawing.Point(25, 39);
            this.txtName.Margin = new System.Windows.Forms.Padding(5);
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PlaceholderText = "";
            this.txtName.SelectedText = "";
            this.txtName.ShadowDecoration.Parent = this.txtName;
            this.txtName.Size = new System.Drawing.Size(296, 44);
            this.txtName.TabIndex = 6;
            // 
            // btnXoa
            // 
            this.btnXoa.BorderRadius = 18;
            this.btnXoa.CheckedState.Parent = this.btnXoa;
            this.btnXoa.CustomImages.Parent = this.btnXoa;
            this.btnXoa.FillColor = System.Drawing.Color.Crimson;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.HoverState.Parent = this.btnXoa;
            this.btnXoa.Image = global::LibraryManager.Properties.Resources.icons8_Delete_30px;
            this.btnXoa.Location = new System.Drawing.Point(741, 44);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ShadowDecoration.Parent = this.btnXoa;
            this.btnXoa.Size = new System.Drawing.Size(115, 44);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xóa ";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BorderRadius = 18;
            this.btnLuu.CheckedState.Parent = this.btnLuu;
            this.btnLuu.CustomImages.Parent = this.btnLuu;
            this.btnLuu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(193)))), ((int)(((byte)(140)))));
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.HoverState.Parent = this.btnLuu;
            this.btnLuu.Image = global::LibraryManager.Properties.Resources.icons8_save_30px;
            this.btnLuu.Location = new System.Drawing.Point(862, 44);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.ShadowDecoration.Parent = this.btnLuu;
            this.btnLuu.Size = new System.Drawing.Size(144, 44);
            this.btnLuu.TabIndex = 8;
            this.btnLuu.Text = "Lưu thay đổi";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSearchNV
            // 
            this.btnSearchNV.BorderRadius = 18;
            this.btnSearchNV.CheckedState.Parent = this.btnSearchNV;
            this.btnSearchNV.CustomImages.Parent = this.btnSearchNV;
            this.btnSearchNV.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(193)))), ((int)(((byte)(140)))));
            this.btnSearchNV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSearchNV.ForeColor = System.Drawing.Color.White;
            this.btnSearchNV.HoverState.Parent = this.btnSearchNV;
            this.btnSearchNV.Image = global::LibraryManager.Properties.Resources.icons8_search_client_80px;
            this.btnSearchNV.Location = new System.Drawing.Point(591, 44);
            this.btnSearchNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchNV.Name = "btnSearchNV";
            this.btnSearchNV.ShadowDecoration.Parent = this.btnSearchNV;
            this.btnSearchNV.Size = new System.Drawing.Size(129, 44);
            this.btnSearchNV.TabIndex = 5;
            this.btnSearchNV.Text = "Tìm kiếm";
            this.btnSearchNV.Click += new System.EventHandler(this.btnSearchNV_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.Parent = this.txtSearch;
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.FocusedState.Parent = this.txtSearch;
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.HoverState.Parent = this.txtSearch;
            this.txtSearch.IconLeft = global::LibraryManager.Properties.Resources.icons8_search_32px;
            this.txtSearch.Location = new System.Drawing.Point(9, 44);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtSearch.PlaceholderText = "Nhập nội dung tìm kiếm";
            this.txtSearch.SelectedText = "";
            this.txtSearch.ShadowDecoration.Parent = this.txtSearch;
            this.txtSearch.Size = new System.Drawing.Size(312, 44);
            this.txtSearch.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.BorderRadius = 18;
            this.btnAdd.CheckedState.Parent = this.btnAdd;
            this.btnAdd.CustomImages.Parent = this.btnAdd;
            this.btnAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(193)))), ((int)(((byte)(140)))));
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.HoverState.Parent = this.btnAdd;
            this.btnAdd.Image = global::LibraryManager.Properties.Resources.icons8_add_30px;
            this.btnAdd.Location = new System.Drawing.Point(921, 14);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ShadowDecoration.Parent = this.btnAdd;
            this.btnAdd.Size = new System.Drawing.Size(115, 46);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Thêm";
            // 
            // DanhSachDG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.guna2CustomGradientPanel2);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDG);
            this.Controls.Add(this.btnAdd);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DanhSachDG";
            this.Size = new System.Drawing.Size(1779, 986);
            this.Load += new System.EventHandler(this.DanhSachDG_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDG)).EndInit();
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            this.guna2CustomGradientPanel2.ResumeLayout(false);
            this.guna2CustomGradientPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnSearchNV;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox cbFilterDG;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDG;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private DateTimePickerKiet pickerBirthday;
        private Guna.UI2.WinForms.Guna2TextBox txtSDT;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2ComboBox cbGender;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Button btnLuu;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel2;
        private Guna.UI2.WinForms.Guna2TextBox txtCMND;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2TextBox txtTendangnhap;
        private Guna.UI2.WinForms.Guna2TextBox txtDiachi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
    }
}

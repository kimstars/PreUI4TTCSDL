
namespace LibraryManager.Template
{
    partial class FrmThemNXB
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelShow = new System.Windows.Forms.Panel();
            this.btnBack = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2CustomGradientPanel3 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.btnThemNXB = new Guna.UI2.WinForms.Guna2Button();
            this.txtDiaChi = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenNhaXuatBan = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaNhaXuatBan = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvNhaXuatBan = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.MaNhaXuatBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNhaXuatBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSua = new Guna.UI2.WinForms.Guna2Button();
            this.panelShow.SuspendLayout();
            this.guna2CustomGradientPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhaXuatBan)).BeginInit();
            this.SuspendLayout();
            // 
            // panelShow
            // 
            this.panelShow.Controls.Add(this.btnBack);
            this.panelShow.Controls.Add(this.guna2HtmlLabel1);
            this.panelShow.Controls.Add(this.guna2CustomGradientPanel3);
            this.panelShow.Controls.Add(this.dgvNhaXuatBan);
            this.panelShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelShow.Location = new System.Drawing.Point(0, 0);
            this.panelShow.Name = "panelShow";
            this.panelShow.Size = new System.Drawing.Size(1194, 626);
            this.panelShow.TabIndex = 0;
            this.panelShow.Paint += new System.Windows.Forms.PaintEventHandler(this.panelShow_Paint);
            // 
            // btnBack
            // 
            this.btnBack.CheckedState.Parent = this.btnBack;
            this.btnBack.CustomImages.Parent = this.btnBack;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.HoverState.Parent = this.btnBack;
            this.btnBack.Location = new System.Drawing.Point(76, 46);
            this.btnBack.Name = "btnBack";
            this.btnBack.ShadowDecoration.Parent = this.btnBack;
            this.btnBack.Size = new System.Drawing.Size(180, 45);
            this.btnBack.TabIndex = 40;
            this.btnBack.Text = "Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(504, 46);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(225, 38);
            this.guna2HtmlLabel1.TabIndex = 38;
            this.guna2HtmlLabel1.Text = "Thêm nhà xuất bản";
            // 
            // guna2CustomGradientPanel3
            // 
            this.guna2CustomGradientPanel3.BorderRadius = 20;
            this.guna2CustomGradientPanel3.Controls.Add(this.btnSua);
            this.guna2CustomGradientPanel3.Controls.Add(this.guna2Button1);
            this.guna2CustomGradientPanel3.Controls.Add(this.btnThemNXB);
            this.guna2CustomGradientPanel3.Controls.Add(this.txtDiaChi);
            this.guna2CustomGradientPanel3.Controls.Add(this.label2);
            this.guna2CustomGradientPanel3.Controls.Add(this.txtTenNhaXuatBan);
            this.guna2CustomGradientPanel3.Controls.Add(this.label1);
            this.guna2CustomGradientPanel3.Controls.Add(this.txtMaNhaXuatBan);
            this.guna2CustomGradientPanel3.Controls.Add(this.label5);
            this.guna2CustomGradientPanel3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(198)))), ((int)(((byte)(165)))));
            this.guna2CustomGradientPanel3.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(198)))), ((int)(((byte)(165)))));
            this.guna2CustomGradientPanel3.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(244)))), ((int)(((byte)(197)))));
            this.guna2CustomGradientPanel3.Location = new System.Drawing.Point(76, 133);
            this.guna2CustomGradientPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.guna2CustomGradientPanel3.Name = "guna2CustomGradientPanel3";
            this.guna2CustomGradientPanel3.ShadowDecoration.Parent = this.guna2CustomGradientPanel3;
            this.guna2CustomGradientPanel3.Size = new System.Drawing.Size(434, 378);
            this.guna2CustomGradientPanel3.TabIndex = 37;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderRadius = 18;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.Red;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Image = global::LibraryManager.Properties.Resources.icons8_cancel_48px;
            this.guna2Button1.Location = new System.Drawing.Point(286, 304);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(77, 39);
            this.guna2Button1.TabIndex = 11;
            this.guna2Button1.Text = "Huỷ";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click_1);
            // 
            // btnThemNXB
            // 
            this.btnThemNXB.BackColor = System.Drawing.Color.Transparent;
            this.btnThemNXB.BorderRadius = 18;
            this.btnThemNXB.CheckedState.Parent = this.btnThemNXB;
            this.btnThemNXB.CustomImages.Parent = this.btnThemNXB;
            this.btnThemNXB.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(149)))), ((int)(((byte)(79)))));
            this.btnThemNXB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThemNXB.ForeColor = System.Drawing.Color.White;
            this.btnThemNXB.HoverState.Parent = this.btnThemNXB;
            this.btnThemNXB.Image = global::LibraryManager.Properties.Resources.icons8_add_30px;
            this.btnThemNXB.Location = new System.Drawing.Point(40, 304);
            this.btnThemNXB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemNXB.Name = "btnThemNXB";
            this.btnThemNXB.ShadowDecoration.Parent = this.btnThemNXB;
            this.btnThemNXB.Size = new System.Drawing.Size(77, 39);
            this.btnThemNXB.TabIndex = 10;
            this.btnThemNXB.Text = "Thêm";
            this.btnThemNXB.Click += new System.EventHandler(this.btnThemNXB_Click_1);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.BackColor = System.Drawing.Color.Transparent;
            this.txtDiaChi.BorderColor = System.Drawing.Color.Transparent;
            this.txtDiaChi.BorderRadius = 6;
            this.txtDiaChi.BorderThickness = 0;
            this.txtDiaChi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiaChi.DefaultText = "";
            this.txtDiaChi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDiaChi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDiaChi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiaChi.DisabledState.Parent = this.txtDiaChi;
            this.txtDiaChi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiaChi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiaChi.FocusedState.Parent = this.txtDiaChi;
            this.txtDiaChi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.ForeColor = System.Drawing.Color.Black;
            this.txtDiaChi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiaChi.HoverState.Parent = this.txtDiaChi;
            this.txtDiaChi.Location = new System.Drawing.Point(33, 189);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.PasswordChar = '\0';
            this.txtDiaChi.PlaceholderText = "";
            this.txtDiaChi.SelectedText = "";
            this.txtDiaChi.ShadowDecoration.Parent = this.txtDiaChi;
            this.txtDiaChi.Size = new System.Drawing.Size(359, 79);
            this.txtDiaChi.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Địa chỉ";
            // 
            // txtTenNhaXuatBan
            // 
            this.txtTenNhaXuatBan.BackColor = System.Drawing.Color.Transparent;
            this.txtTenNhaXuatBan.BorderColor = System.Drawing.Color.Transparent;
            this.txtTenNhaXuatBan.BorderRadius = 6;
            this.txtTenNhaXuatBan.BorderThickness = 0;
            this.txtTenNhaXuatBan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenNhaXuatBan.DefaultText = "";
            this.txtTenNhaXuatBan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenNhaXuatBan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenNhaXuatBan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenNhaXuatBan.DisabledState.Parent = this.txtTenNhaXuatBan;
            this.txtTenNhaXuatBan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenNhaXuatBan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenNhaXuatBan.FocusedState.Parent = this.txtTenNhaXuatBan;
            this.txtTenNhaXuatBan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNhaXuatBan.ForeColor = System.Drawing.Color.Black;
            this.txtTenNhaXuatBan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenNhaXuatBan.HoverState.Parent = this.txtTenNhaXuatBan;
            this.txtTenNhaXuatBan.Location = new System.Drawing.Point(33, 115);
            this.txtTenNhaXuatBan.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtTenNhaXuatBan.Name = "txtTenNhaXuatBan";
            this.txtTenNhaXuatBan.PasswordChar = '\0';
            this.txtTenNhaXuatBan.PlaceholderText = "";
            this.txtTenNhaXuatBan.SelectedText = "";
            this.txtTenNhaXuatBan.ShadowDecoration.Parent = this.txtTenNhaXuatBan;
            this.txtTenNhaXuatBan.Size = new System.Drawing.Size(359, 39);
            this.txtTenNhaXuatBan.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tên nhà xuất bản";
            // 
            // txtMaNhaXuatBan
            // 
            this.txtMaNhaXuatBan.BackColor = System.Drawing.Color.Transparent;
            this.txtMaNhaXuatBan.BorderColor = System.Drawing.Color.Transparent;
            this.txtMaNhaXuatBan.BorderRadius = 6;
            this.txtMaNhaXuatBan.BorderThickness = 0;
            this.txtMaNhaXuatBan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaNhaXuatBan.DefaultText = "";
            this.txtMaNhaXuatBan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaNhaXuatBan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaNhaXuatBan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaNhaXuatBan.DisabledState.Parent = this.txtMaNhaXuatBan;
            this.txtMaNhaXuatBan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaNhaXuatBan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaNhaXuatBan.FocusedState.Parent = this.txtMaNhaXuatBan;
            this.txtMaNhaXuatBan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNhaXuatBan.ForeColor = System.Drawing.Color.Black;
            this.txtMaNhaXuatBan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaNhaXuatBan.HoverState.Parent = this.txtMaNhaXuatBan;
            this.txtMaNhaXuatBan.Location = new System.Drawing.Point(33, 36);
            this.txtMaNhaXuatBan.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtMaNhaXuatBan.Name = "txtMaNhaXuatBan";
            this.txtMaNhaXuatBan.PasswordChar = '\0';
            this.txtMaNhaXuatBan.PlaceholderText = "";
            this.txtMaNhaXuatBan.SelectedText = "";
            this.txtMaNhaXuatBan.ShadowDecoration.Parent = this.txtMaNhaXuatBan;
            this.txtMaNhaXuatBan.Size = new System.Drawing.Size(359, 39);
            this.txtMaNhaXuatBan.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Mã nhà xuất bản :";
            // 
            // dgvNhaXuatBan
            // 
            this.dgvNhaXuatBan.AllowCustomTheming = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            this.dgvNhaXuatBan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvNhaXuatBan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhaXuatBan.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvNhaXuatBan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvNhaXuatBan.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvNhaXuatBan.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.MediumVioletRed;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(16)))), ((int)(((byte)(106)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNhaXuatBan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvNhaXuatBan.ColumnHeadersHeight = 40;
            this.dgvNhaXuatBan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNhaXuatBan,
            this.id,
            this.TenNhaXuatBan,
            this.DiaChi});
            this.dgvNhaXuatBan.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(224)))));
            this.dgvNhaXuatBan.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvNhaXuatBan.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvNhaXuatBan.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(114)))), ((int)(((byte)(181)))));
            this.dgvNhaXuatBan.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvNhaXuatBan.CurrentTheme.BackColor = System.Drawing.Color.MediumVioletRed;
            this.dgvNhaXuatBan.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(184)))), ((int)(((byte)(218)))));
            this.dgvNhaXuatBan.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.MediumVioletRed;
            this.dgvNhaXuatBan.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgvNhaXuatBan.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvNhaXuatBan.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(16)))), ((int)(((byte)(106)))));
            this.dgvNhaXuatBan.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvNhaXuatBan.CurrentTheme.Name = null;
            this.dgvNhaXuatBan.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(208)))), ((int)(((byte)(230)))));
            this.dgvNhaXuatBan.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvNhaXuatBan.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvNhaXuatBan.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(114)))), ((int)(((byte)(181)))));
            this.dgvNhaXuatBan.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(208)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(114)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNhaXuatBan.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvNhaXuatBan.EnableHeadersVisualStyles = false;
            this.dgvNhaXuatBan.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(184)))), ((int)(((byte)(218)))));
            this.dgvNhaXuatBan.HeaderBackColor = System.Drawing.Color.MediumVioletRed;
            this.dgvNhaXuatBan.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvNhaXuatBan.HeaderForeColor = System.Drawing.Color.White;
            this.dgvNhaXuatBan.Location = new System.Drawing.Point(575, 133);
            this.dgvNhaXuatBan.Margin = new System.Windows.Forms.Padding(4);
            this.dgvNhaXuatBan.Name = "dgvNhaXuatBan";
            this.dgvNhaXuatBan.RowHeadersVisible = false;
            this.dgvNhaXuatBan.RowHeadersWidth = 51;
            this.dgvNhaXuatBan.RowTemplate.Height = 40;
            this.dgvNhaXuatBan.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvNhaXuatBan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNhaXuatBan.Size = new System.Drawing.Size(628, 365);
            this.dgvNhaXuatBan.TabIndex = 39;
            this.dgvNhaXuatBan.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.MediumVioletRed;
            this.dgvNhaXuatBan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhaXuatBan_CellClick_1);
            // 
            // MaNhaXuatBan
            // 
            this.MaNhaXuatBan.DataPropertyName = "MaNhaXuatBan";
            this.MaNhaXuatBan.HeaderText = "Mã nhà xuất bản";
            this.MaNhaXuatBan.MinimumWidth = 6;
            this.MaNhaXuatBan.Name = "MaNhaXuatBan";
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // TenNhaXuatBan
            // 
            this.TenNhaXuatBan.DataPropertyName = "TenNhaXuatBan";
            this.TenNhaXuatBan.HeaderText = "Tên nhà xuất bản";
            this.TenNhaXuatBan.MinimumWidth = 6;
            this.TenNhaXuatBan.Name = "TenNhaXuatBan";
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.MinimumWidth = 6;
            this.DiaChi.Name = "DiaChi";
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Transparent;
            this.btnSua.BorderRadius = 18;
            this.btnSua.CheckedState.Parent = this.btnSua;
            this.btnSua.CustomImages.Parent = this.btnSua;
            this.btnSua.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(149)))), ((int)(((byte)(79)))));
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.HoverState.Parent = this.btnSua;
            this.btnSua.Image = global::LibraryManager.Properties.Resources.icons8_add_30px;
            this.btnSua.Location = new System.Drawing.Point(162, 304);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.ShadowDecoration.Parent = this.btnSua;
            this.btnSua.Size = new System.Drawing.Size(77, 39);
            this.btnSua.TabIndex = 12;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // FrmThemNXB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelShow);
            this.Name = "FrmThemNXB";
            this.Size = new System.Drawing.Size(1194, 626);
            this.Load += new System.EventHandler(this.FrmThemNXB_Load);
            this.panelShow.ResumeLayout(false);
            this.panelShow.PerformLayout();
            this.guna2CustomGradientPanel3.ResumeLayout(false);
            this.guna2CustomGradientPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhaXuatBan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelShow;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel3;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button btnThemNXB;
        private Guna.UI2.WinForms.Guna2TextBox txtDiaChi;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtTenNhaXuatBan;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtMaNhaXuatBan;
        private System.Windows.Forms.Label label5;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvNhaXuatBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhaXuatBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNhaXuatBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private Guna.UI2.WinForms.Guna2Button btnBack;
        private Guna.UI2.WinForms.Guna2Button btnSua;
    }
}
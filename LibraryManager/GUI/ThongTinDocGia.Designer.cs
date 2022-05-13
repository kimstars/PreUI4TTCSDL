
namespace LibraryManager.GUI
{
    partial class ThongTinDocGia
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
            this.components = new System.ComponentModel.Container();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnDeactive = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbinfoChuaTra = new System.Windows.Forms.Label();
            this.lbinfoTra = new System.Windows.Forms.Label();
            this.lbinfoMuon = new System.Windows.Forms.Label();
            this.lbDiaChi = new System.Windows.Forms.Label();
            this.lbSDT = new System.Windows.Forms.Label();
            this.lbNgaySinh = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lbNgayDK = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lbMaDG = new System.Windows.Forms.Label();
            this.btnActivate = new Guna.UI2.WinForms.Guna2Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.lbTenDG = new System.Windows.Forms.Label();
            this.panelinfo = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvDenHan = new System.Windows.Forms.DataGridView();
            this.dgvViPham = new System.Windows.Forms.DataGridView();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnWarning = new Guna.UI2.WinForms.Guna2Button();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.imageAvt = new LibraryManager.Template.PictureBoxKiet();
            this.panelinfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDenHan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageAvt)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // btnDeactive
            // 
            this.btnDeactive.AutoRoundedCorners = true;
            this.btnDeactive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(193)))), ((int)(((byte)(140)))));
            this.btnDeactive.BorderRadius = 22;
            this.btnDeactive.CheckedState.Parent = this.btnDeactive;
            this.btnDeactive.CustomImages.Parent = this.btnDeactive;
            this.btnDeactive.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDeactive.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeactive.ForeColor = System.Drawing.Color.White;
            this.btnDeactive.HoverState.Parent = this.btnDeactive;
            this.btnDeactive.Location = new System.Drawing.Point(220, 786);
            this.btnDeactive.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeactive.Name = "btnDeactive";
            this.btnDeactive.ShadowDecoration.Parent = this.btnDeactive;
            this.btnDeactive.Size = new System.Drawing.Size(129, 46);
            this.btnDeactive.TabIndex = 70;
            this.btnDeactive.Text = "Tạm khóa tài khoản";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 596);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 25);
            this.label1.TabIndex = 69;
            this.label1.Text = "Chưa trả, đến hạn :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 446);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 25);
            this.label5.TabIndex = 65;
            this.label5.Text = "Vi phạm :";
            // 
            // lbinfoChuaTra
            // 
            this.lbinfoChuaTra.AutoSize = true;
            this.lbinfoChuaTra.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbinfoChuaTra.Location = new System.Drawing.Point(93, 415);
            this.lbinfoChuaTra.Name = "lbinfoChuaTra";
            this.lbinfoChuaTra.Size = new System.Drawing.Size(248, 28);
            this.lbinfoChuaTra.TabIndex = 64;
            this.lbinfoChuaTra.Text = "- Còn 5 cuốn sách chưa trả ";
            // 
            // lbinfoTra
            // 
            this.lbinfoTra.AutoSize = true;
            this.lbinfoTra.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbinfoTra.Location = new System.Drawing.Point(93, 383);
            this.lbinfoTra.Name = "lbinfoTra";
            this.lbinfoTra.Size = new System.Drawing.Size(314, 28);
            this.lbinfoTra.TabIndex = 63;
            this.lbinfoTra.Text = "- Trả 4 cuốn sách ngày 04/09/2021";
            // 
            // lbinfoMuon
            // 
            this.lbinfoMuon.AutoSize = true;
            this.lbinfoMuon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbinfoMuon.Location = new System.Drawing.Point(93, 351);
            this.lbinfoMuon.Name = "lbinfoMuon";
            this.lbinfoMuon.Size = new System.Drawing.Size(392, 28);
            this.lbinfoMuon.TabIndex = 62;
            this.lbinfoMuon.Text = "- Đến mượn 15 cuốn sách ngày 23/03/2021";
            // 
            // lbDiaChi
            // 
            this.lbDiaChi.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiaChi.ForeColor = System.Drawing.Color.Black;
            this.lbDiaChi.Location = new System.Drawing.Point(303, 246);
            this.lbDiaChi.Name = "lbDiaChi";
            this.lbDiaChi.Size = new System.Drawing.Size(245, 89);
            this.lbDiaChi.TabIndex = 61;
            this.lbDiaChi.Text = "14 Ngõ 66A Triều Khúc, P. Tân Triều, Thanh Xuân, Hà Nội";
            // 
            // lbSDT
            // 
            this.lbSDT.AutoSize = true;
            this.lbSDT.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSDT.ForeColor = System.Drawing.Color.Black;
            this.lbSDT.Location = new System.Drawing.Point(403, 213);
            this.lbSDT.Name = "lbSDT";
            this.lbSDT.Size = new System.Drawing.Size(102, 25);
            this.lbSDT.TabIndex = 60;
            this.lbSDT.Text = "098594932";
            // 
            // lbNgaySinh
            // 
            this.lbNgaySinh.AutoSize = true;
            this.lbNgaySinh.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgaySinh.ForeColor = System.Drawing.Color.Black;
            this.lbNgaySinh.Location = new System.Drawing.Point(403, 177);
            this.lbNgaySinh.Name = "lbNgaySinh";
            this.lbNgaySinh.Size = new System.Drawing.Size(108, 25);
            this.lbNgaySinh.TabIndex = 59;
            this.lbNgaySinh.Text = "12-03-2001";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(225, 213);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(130, 25);
            this.label13.TabIndex = 50;
            this.label13.Text = "Số điện thoại:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(23, 319);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(193, 25);
            this.label14.TabIndex = 48;
            this.label14.Text = "Hoạt động gần đây : ";
            // 
            // lbNgayDK
            // 
            this.lbNgayDK.AutoSize = true;
            this.lbNgayDK.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgayDK.ForeColor = System.Drawing.Color.Black;
            this.lbNgayDK.Location = new System.Drawing.Point(403, 142);
            this.lbNgayDK.Name = "lbNgayDK";
            this.lbNgayDK.Size = new System.Drawing.Size(108, 25);
            this.lbNgayDK.TabIndex = 57;
            this.lbNgayDK.Text = "03-03-2020";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(225, 246);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(76, 25);
            this.label16.TabIndex = 47;
            this.label16.Text = "Địa chỉ:";
            // 
            // lbMaDG
            // 
            this.lbMaDG.AutoSize = true;
            this.lbMaDG.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaDG.ForeColor = System.Drawing.Color.Black;
            this.lbMaDG.Location = new System.Drawing.Point(403, 106);
            this.lbMaDG.Name = "lbMaDG";
            this.lbMaDG.Size = new System.Drawing.Size(98, 25);
            this.lbMaDG.TabIndex = 56;
            this.lbMaDG.Text = "DG000003";
            // 
            // btnActivate
            // 
            this.btnActivate.AutoRoundedCorners = true;
            this.btnActivate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(193)))), ((int)(((byte)(140)))));
            this.btnActivate.BorderRadius = 22;
            this.btnActivate.CheckedState.Parent = this.btnActivate;
            this.btnActivate.CustomImages.Parent = this.btnActivate;
            this.btnActivate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(193)))), ((int)(((byte)(140)))));
            this.btnActivate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActivate.ForeColor = System.Drawing.Color.White;
            this.btnActivate.HoverState.Parent = this.btnActivate;
            this.btnActivate.Location = new System.Drawing.Point(384, 786);
            this.btnActivate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnActivate.Name = "btnActivate";
            this.btnActivate.ShadowDecoration.Parent = this.btnActivate;
            this.btnActivate.Size = new System.Drawing.Size(129, 46);
            this.btnActivate.TabIndex = 55;
            this.btnActivate.Text = "Mở khóa tài khoản";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(225, 142);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(185, 25);
            this.label18.TabIndex = 54;
            this.label18.Text = "Hoạt động từ ngày :";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(225, 106);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(123, 25);
            this.label19.TabIndex = 53;
            this.label19.Text = "Mã độc giả : ";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(225, 177);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(103, 25);
            this.label20.TabIndex = 49;
            this.label20.Text = "Ngày sinh:";
            // 
            // lbTenDG
            // 
            this.lbTenDG.AutoSize = true;
            this.lbTenDG.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lbTenDG.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lbTenDG.Location = new System.Drawing.Point(224, 60);
            this.lbTenDG.Name = "lbTenDG";
            this.lbTenDG.Size = new System.Drawing.Size(193, 37);
            this.lbTenDG.TabIndex = 51;
            this.lbTenDG.Text = "Chu Tuấn Kiệt";
            // 
            // panelinfo
            // 
            this.panelinfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(229)))), ((int)(((byte)(208)))));
            this.panelinfo.BorderRadius = 15;
            this.panelinfo.Controls.Add(this.dgvDenHan);
            this.panelinfo.Controls.Add(this.dgvViPham);
            this.panelinfo.Controls.Add(this.guna2ControlBox1);
            this.panelinfo.Controls.Add(this.btnWarning);
            this.panelinfo.Controls.Add(this.imageAvt);
            this.panelinfo.Controls.Add(this.btnDeactive);
            this.panelinfo.Controls.Add(this.label1);
            this.panelinfo.Controls.Add(this.label5);
            this.panelinfo.Controls.Add(this.lbinfoChuaTra);
            this.panelinfo.Controls.Add(this.lbinfoTra);
            this.panelinfo.Controls.Add(this.lbinfoMuon);
            this.panelinfo.Controls.Add(this.lbDiaChi);
            this.panelinfo.Controls.Add(this.lbSDT);
            this.panelinfo.Controls.Add(this.lbNgaySinh);
            this.panelinfo.Controls.Add(this.label13);
            this.panelinfo.Controls.Add(this.label14);
            this.panelinfo.Controls.Add(this.lbNgayDK);
            this.panelinfo.Controls.Add(this.label16);
            this.panelinfo.Controls.Add(this.lbMaDG);
            this.panelinfo.Controls.Add(this.btnActivate);
            this.panelinfo.Controls.Add(this.label18);
            this.panelinfo.Controls.Add(this.label19);
            this.panelinfo.Controls.Add(this.label20);
            this.panelinfo.Controls.Add(this.lbTenDG);
            this.panelinfo.Location = new System.Drawing.Point(11, 9);
            this.panelinfo.Margin = new System.Windows.Forms.Padding(4);
            this.panelinfo.Name = "panelinfo";
            this.panelinfo.ShadowDecoration.Parent = this.panelinfo;
            this.panelinfo.Size = new System.Drawing.Size(563, 849);
            this.panelinfo.TabIndex = 11;
            // 
            // dgvDenHan
            // 
            this.dgvDenHan.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvDenHan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDenHan.Location = new System.Drawing.Point(38, 640);
            this.dgvDenHan.Name = "dgvDenHan";
            this.dgvDenHan.RowHeadersWidth = 51;
            this.dgvDenHan.RowTemplate.Height = 24;
            this.dgvDenHan.Size = new System.Drawing.Size(480, 118);
            this.dgvDenHan.TabIndex = 75;
            // 
            // dgvViPham
            // 
            this.dgvViPham.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvViPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViPham.Location = new System.Drawing.Point(38, 475);
            this.dgvViPham.Name = "dgvViPham";
            this.dgvViPham.RowHeadersWidth = 51;
            this.dgvViPham.RowTemplate.Height = 24;
            this.dgvViPham.Size = new System.Drawing.Size(480, 118);
            this.dgvViPham.TabIndex = 74;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(488, 11);
            this.guna2ControlBox1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(60, 36);
            this.guna2ControlBox1.TabIndex = 73;
            // 
            // btnWarning
            // 
            this.btnWarning.AutoRoundedCorners = true;
            this.btnWarning.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(193)))), ((int)(((byte)(140)))));
            this.btnWarning.BorderRadius = 22;
            this.btnWarning.CheckedState.Parent = this.btnWarning;
            this.btnWarning.CustomImages.Parent = this.btnWarning;
            this.btnWarning.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(86)))), ((int)(((byte)(136)))));
            this.btnWarning.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWarning.ForeColor = System.Drawing.Color.White;
            this.btnWarning.HoverState.Parent = this.btnWarning;
            this.btnWarning.Location = new System.Drawing.Point(47, 786);
            this.btnWarning.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnWarning.Name = "btnWarning";
            this.btnWarning.ShadowDecoration.Parent = this.btnWarning;
            this.btnWarning.Size = new System.Drawing.Size(129, 46);
            this.btnWarning.TabIndex = 72;
            this.btnWarning.Text = "Nhắc nhở ";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panelinfo;
            this.bunifuDragControl1.Vertical = true;
            // 
            // imageAvt
            // 
            this.imageAvt.BackColor = System.Drawing.Color.White;
            this.imageAvt.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.imageAvt.BorderColor = System.Drawing.Color.RoyalBlue;
            this.imageAvt.BorderColor2 = System.Drawing.Color.HotPink;
            this.imageAvt.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.imageAvt.BorderSize = 2;
            this.imageAvt.GradientAngle = 50F;
            this.imageAvt.Image = global::LibraryManager.Properties.Resources.icons8_manager_100px;
            this.imageAvt.Location = new System.Drawing.Point(19, 57);
            this.imageAvt.Margin = new System.Windows.Forms.Padding(4);
            this.imageAvt.Name = "imageAvt";
            this.imageAvt.Size = new System.Drawing.Size(172, 172);
            this.imageAvt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageAvt.TabIndex = 71;
            this.imageAvt.TabStop = false;
            // 
            // ThongTinDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 871);
            this.Controls.Add(this.panelinfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ThongTinDocGia";
            this.Text = "DocGiaActivity";
            this.Load += new System.EventHandler(this.ThongTinDocGia_Load);
            this.panelinfo.ResumeLayout(false);
            this.panelinfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDenHan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageAvt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel panelinfo;
        private Template.PictureBoxKiet imageAvt;
        private Guna.UI2.WinForms.Guna2Button btnDeactive;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbinfoChuaTra;
        private System.Windows.Forms.Label lbinfoTra;
        private System.Windows.Forms.Label lbinfoMuon;
        private System.Windows.Forms.Label lbDiaChi;
        private System.Windows.Forms.Label lbSDT;
        private System.Windows.Forms.Label lbNgaySinh;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lbNgayDK;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lbMaDG;
        private Guna.UI2.WinForms.Guna2Button btnActivate;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lbTenDG;
        private Guna.UI2.WinForms.Guna2Button btnWarning;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.DataGridView dgvDenHan;
        private System.Windows.Forms.DataGridView dgvViPham;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}
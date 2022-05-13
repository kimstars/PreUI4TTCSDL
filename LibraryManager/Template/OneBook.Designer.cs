
namespace LibraryManager.Template
{
    partial class OneBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OneBook));
            this.imgBook = new System.Windows.Forms.PictureBox();
            this.lbInfoTenSach = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.lbSoLuong = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbInfoTenTG = new System.Windows.Forms.Label();
            this.panelMain = new Guna.UI2.WinForms.Guna2Panel();
            this.tickPic = new Bunifu.UI.WinForms.BunifuPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgBook)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tickPic)).BeginInit();
            this.SuspendLayout();
            // 
            // imgBook
            // 
            this.imgBook.BackgroundImage = global::LibraryManager.Properties.Resources.icons8_study_200px;
            this.imgBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imgBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgBook.Location = new System.Drawing.Point(12, 14);
            this.imgBook.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.imgBook.Name = "imgBook";
            this.imgBook.Size = new System.Drawing.Size(151, 218);
            this.imgBook.TabIndex = 0;
            this.imgBook.TabStop = false;
            this.imgBook.Click += new System.EventHandler(this.imgBook_Click);
            // 
            // lbInfoTenSach
            // 
            this.lbInfoTenSach.BackColor = System.Drawing.Color.Transparent;
            this.lbInfoTenSach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbInfoTenSach.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbInfoTenSach.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold);
            this.lbInfoTenSach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(86)))), ((int)(((byte)(136)))));
            this.lbInfoTenSach.Location = new System.Drawing.Point(0, 0);
            this.lbInfoTenSach.Name = "lbInfoTenSach";
            this.lbInfoTenSach.Size = new System.Drawing.Size(194, 105);
            this.lbInfoTenSach.TabIndex = 24;
            this.lbInfoTenSach.Text = "Tư duy doanh nhân- Cách doanh nhân nghĩ, việc doanh nhân làm qua 100 bài học xươn" +
    "g máu";
            this.lbInfoTenSach.Click += new System.EventHandler(this.imgBook_Click);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator1.BackgroundImage")));
            this.bunifuSeparator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator1.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.bunifuSeparator1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.Silver;
            this.bunifuSeparator1.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(0, 105);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator1.Size = new System.Drawing.Size(194, 21);
            this.bunifuSeparator1.TabIndex = 25;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.lbSoLuong);
            this.panel1.Controls.Add(this.bunifuSeparator1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lbInfoTenSach);
            this.panel1.Controls.Add(this.lbInfoTenTG);
            this.panel1.Location = new System.Drawing.Point(171, 14);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 218);
            this.panel1.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(3, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 15);
            this.label9.TabIndex = 26;
            this.label9.Text = "Tác giả :";
            this.label9.Click += new System.EventHandler(this.imgBook_Click);
            // 
            // lbSoLuong
            // 
            this.lbSoLuong.AutoSize = true;
            this.lbSoLuong.BackColor = System.Drawing.Color.Transparent;
            this.lbSoLuong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbSoLuong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lbSoLuong.Location = new System.Drawing.Point(84, 185);
            this.lbSoLuong.Name = "lbSoLuong";
            this.lbSoLuong.Size = new System.Drawing.Size(21, 15);
            this.lbSoLuong.TabIndex = 29;
            this.lbSoLuong.Text = "50";
            this.lbSoLuong.Click += new System.EventHandler(this.imgBook_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(3, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 28;
            this.label2.Text = "Số lượng:";
            this.label2.Click += new System.EventHandler(this.imgBook_Click);
            // 
            // lbInfoTenTG
            // 
            this.lbInfoTenTG.BackColor = System.Drawing.Color.Transparent;
            this.lbInfoTenTG.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbInfoTenTG.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lbInfoTenTG.Location = new System.Drawing.Point(3, 142);
            this.lbInfoTenTG.Name = "lbInfoTenTG";
            this.lbInfoTenTG.Size = new System.Drawing.Size(188, 43);
            this.lbInfoTenTG.TabIndex = 27;
            this.lbInfoTenTG.Text = "Kevin D.Johnson";
            this.lbInfoTenTG.Click += new System.EventHandler(this.imgBook_Click);
            // 
            // panelMain
            // 
            this.panelMain.BorderColor = System.Drawing.Color.White;
            this.panelMain.BorderThickness = 5;
            this.panelMain.Controls.Add(this.tickPic);
            this.panelMain.Controls.Add(this.imgBook);
            this.panelMain.Controls.Add(this.panel1);
            this.panelMain.Location = new System.Drawing.Point(4, 4);
            this.panelMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelMain.Name = "panelMain";
            this.panelMain.ShadowDecoration.Parent = this.panelMain;
            this.panelMain.Size = new System.Drawing.Size(378, 240);
            this.panelMain.TabIndex = 27;
            // 
            // tickPic
            // 
            this.tickPic.AllowFocused = false;
            this.tickPic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tickPic.AutoSizeHeight = true;
            this.tickPic.BackColor = System.Drawing.Color.Transparent;
            this.tickPic.BorderRadius = 22;
            this.tickPic.Image = global::LibraryManager.Properties.Resources.icons8_tick_box_48px;
            this.tickPic.IsCircle = true;
            this.tickPic.Location = new System.Drawing.Point(118, 187);
            this.tickPic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tickPic.Name = "tickPic";
            this.tickPic.Size = new System.Drawing.Size(45, 45);
            this.tickPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.tickPic.TabIndex = 30;
            this.tickPic.TabStop = false;
            this.tickPic.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            this.tickPic.Visible = false;
            // 
            // OneBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panelMain);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "OneBook";
            this.Size = new System.Drawing.Size(390, 251);
            this.Load += new System.EventHandler(this.OneBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgBook)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tickPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgBook;
        private System.Windows.Forms.Label lbInfoTenSach;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbSoLuong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbInfoTenTG;
        private Guna.UI2.WinForms.Guna2Panel panelMain;
        private Bunifu.UI.WinForms.BunifuPictureBox tickPic;
    }
}

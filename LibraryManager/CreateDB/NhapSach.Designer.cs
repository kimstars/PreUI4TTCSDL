
namespace LibraryManager.CreateDB
{
    partial class NhapSach
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSubmit = new Guna.UI2.WinForms.Guna2Button();
            this.dgvTTNhap = new System.Windows.Forms.DataGridView();
            this.txtMaNhap = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbNV = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoluong = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvDauSach = new System.Windows.Forms.DataGridView();
            this.txtMaDauSach = new Guna.UI2.WinForms.Guna2TextBox();
            this.dateNhap = new LibraryManager.Template.DateTimePickerKiet();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTTNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDauSach)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(173, 233);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(176, 21);
            this.label7.TabIndex = 30;
            this.label7.Text = "* auto random";
            // 
            // btnSubmit
            // 
            this.btnSubmit.CheckedState.Parent = this.btnSubmit;
            this.btnSubmit.CustomImages.Parent = this.btnSubmit;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.HoverState.Parent = this.btnSubmit;
            this.btnSubmit.Location = new System.Drawing.Point(177, 271);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.ShadowDecoration.Parent = this.btnSubmit;
            this.btnSubmit.Size = new System.Drawing.Size(619, 39);
            this.btnSubmit.TabIndex = 29;
            this.btnSubmit.Text = "Xác nhận nhập sách";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // dgvTTNhap
            // 
            this.dgvTTNhap.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTTNhap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTTNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTTNhap.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTTNhap.Location = new System.Drawing.Point(67, 401);
            this.dgvTTNhap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvTTNhap.Name = "dgvTTNhap";
            this.dgvTTNhap.RowHeadersWidth = 51;
            this.dgvTTNhap.Size = new System.Drawing.Size(729, 192);
            this.dgvTTNhap.TabIndex = 28;
            // 
            // txtMaNhap
            // 
            this.txtMaNhap.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaNhap.DefaultText = "";
            this.txtMaNhap.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaNhap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaNhap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaNhap.DisabledState.Parent = this.txtMaNhap;
            this.txtMaNhap.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaNhap.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaNhap.FocusedState.Parent = this.txtMaNhap;
            this.txtMaNhap.ForeColor = System.Drawing.Color.Black;
            this.txtMaNhap.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaNhap.HoverState.Parent = this.txtMaNhap;
            this.txtMaNhap.Location = new System.Drawing.Point(177, 15);
            this.txtMaNhap.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtMaNhap.Name = "txtMaNhap";
            this.txtMaNhap.PasswordChar = '\0';
            this.txtMaNhap.PlaceholderText = "";
            this.txtMaNhap.SelectedText = "";
            this.txtMaNhap.ShadowDecoration.Parent = this.txtMaNhap;
            this.txtMaNhap.Size = new System.Drawing.Size(200, 44);
            this.txtMaNhap.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(16, 106);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 25);
            this.label6.TabIndex = 25;
            this.label6.Text = "Chọn đầu sách";
            // 
            // cbNV
            // 
            this.cbNV.FormattingEnabled = true;
            this.cbNV.Location = new System.Drawing.Point(595, 105);
            this.cbNV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbNV.Name = "cbNV";
            this.cbNV.Size = new System.Drawing.Size(201, 24);
            this.cbNV.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(405, 105);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(199, 25);
            this.label5.TabIndex = 20;
            this.label5.Text = "Chọn mã nhân viên";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(16, 185);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 32);
            this.label4.TabIndex = 18;
            this.label4.Text = "Ngày nhập";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(16, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 31);
            this.label3.TabIndex = 17;
            this.label3.Text = "Mã phiếu nhập : ";
            // 
            // txtSoluong
            // 
            this.txtSoluong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoluong.DefaultText = "";
            this.txtSoluong.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSoluong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSoluong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoluong.DisabledState.Parent = this.txtSoluong;
            this.txtSoluong.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoluong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoluong.FocusedState.Parent = this.txtSoluong;
            this.txtSoluong.ForeColor = System.Drawing.Color.Black;
            this.txtSoluong.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoluong.HoverState.Parent = this.txtSoluong;
            this.txtSoluong.Location = new System.Drawing.Point(595, 16);
            this.txtSoluong.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.PasswordChar = '\0';
            this.txtSoluong.PlaceholderText = "";
            this.txtSoluong.SelectedText = "";
            this.txtSoluong.ShadowDecoration.Parent = this.txtSoluong;
            this.txtSoluong.Size = new System.Drawing.Size(201, 44);
            this.txtSoluong.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(435, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 31);
            this.label1.TabIndex = 31;
            this.label1.Text = "Số lượng sách :";
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(175, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 21);
            this.label2.TabIndex = 33;
            this.label2.Text = "* auto random";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(64, 352);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(448, 26);
            this.label8.TabIndex = 34;
            this.label8.Text = "Chọn đầu sách đầu tiên rồi nhập các  thông tin khác";
            // 
            // dgvDauSach
            // 
            this.dgvDauSach.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDauSach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDauSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDauSach.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDauSach.Location = new System.Drawing.Point(852, 44);
            this.dgvDauSach.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvDauSach.Name = "dgvDauSach";
            this.dgvDauSach.RowHeadersWidth = 51;
            this.dgvDauSach.Size = new System.Drawing.Size(557, 549);
            this.dgvDauSach.TabIndex = 35;
            this.dgvDauSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDauSach_CellClick);
            // 
            // txtMaDauSach
            // 
            this.txtMaDauSach.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaDauSach.DefaultText = "";
            this.txtMaDauSach.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaDauSach.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaDauSach.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaDauSach.DisabledState.Parent = this.txtMaDauSach;
            this.txtMaDauSach.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaDauSach.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaDauSach.FocusedState.Parent = this.txtMaDauSach;
            this.txtMaDauSach.ForeColor = System.Drawing.Color.Black;
            this.txtMaDauSach.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaDauSach.HoverState.Parent = this.txtMaDauSach;
            this.txtMaDauSach.Location = new System.Drawing.Point(179, 89);
            this.txtMaDauSach.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtMaDauSach.Name = "txtMaDauSach";
            this.txtMaDauSach.PasswordChar = '\0';
            this.txtMaDauSach.PlaceholderText = "";
            this.txtMaDauSach.SelectedText = "";
            this.txtMaDauSach.ShadowDecoration.Parent = this.txtMaDauSach;
            this.txtMaDauSach.Size = new System.Drawing.Size(201, 44);
            this.txtMaDauSach.TabIndex = 36;
            // 
            // dateNhap
            // 
            this.dateNhap.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.dateNhap.BorderRadius = 0;
            this.dateNhap.BorderSize = 0;
            this.dateNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.dateNhap.Location = new System.Drawing.Point(177, 167);
            this.dateNhap.Margin = new System.Windows.Forms.Padding(4);
            this.dateNhap.MinimumSize = new System.Drawing.Size(4, 40);
            this.dateNhap.Name = "dateNhap";
            this.dateNhap.Size = new System.Drawing.Size(199, 40);
            this.dateNhap.SkinColor = System.Drawing.Color.MidnightBlue;
            this.dateNhap.TabIndex = 22;
            this.dateNhap.TextColor = System.Drawing.Color.White;
            // 
            // NhapSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1445, 650);
            this.Controls.Add(this.txtMaDauSach);
            this.Controls.Add(this.dgvDauSach);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSoluong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.dgvTTNhap);
            this.Controls.Add(this.txtMaNhap);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateNhap);
            this.Controls.Add(this.cbNV);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "NhapSach";
            this.Text = "NhapSach";
            this.Load += new System.EventHandler(this.NhapSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTTNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDauSach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2Button btnSubmit;
        private System.Windows.Forms.DataGridView dgvTTNhap;
        private Guna.UI2.WinForms.Guna2TextBox txtMaNhap;
        private System.Windows.Forms.Label label6;
        private Template.DateTimePickerKiet dateNhap;
        private System.Windows.Forms.ComboBox cbNV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtSoluong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvDauSach;
        private Guna.UI2.WinForms.Guna2TextBox txtMaDauSach;
    }
}
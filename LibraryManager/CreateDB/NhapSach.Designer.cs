
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
            this.cbNV = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvDauSach = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbSoluong = new System.Windows.Forms.Label();
            this.dateNhap = new LibraryManager.Template.DateTimePickerKiet();
            this.lbPhieunhap = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTTNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDauSach)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(174, 148);
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
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4);
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
            this.dgvTTNhap.Margin = new System.Windows.Forms.Padding(4);
            this.dgvTTNhap.Name = "dgvTTNhap";
            this.dgvTTNhap.RowHeadersWidth = 51;
            this.dgvTTNhap.Size = new System.Drawing.Size(729, 192);
            this.dgvTTNhap.TabIndex = 28;
            // 
            // cbNV
            // 
            this.cbNV.FormattingEnabled = true;
            this.cbNV.Location = new System.Drawing.Point(595, 105);
            this.cbNV.Margin = new System.Windows.Forms.Padding(4);
            this.cbNV.Name = "cbNV";
            this.cbNV.Size = new System.Drawing.Size(201, 24);
            this.cbNV.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(409, 104);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 25);
            this.label5.TabIndex = 20;
            this.label5.Text = "Chọn mã nhân viên";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(16, 111);
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
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(419, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 21);
            this.label2.TabIndex = 33;
            this.label2.Text = "* auto random";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(64, 352);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(448, 26);
            this.label8.TabIndex = 34;
            this.label8.Text = "Mỗi lần submit tự động nhập 400 cuốn sách";
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
            this.dgvDauSach.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDauSach.Name = "dgvDauSach";
            this.dgvDauSach.RowHeadersWidth = 51;
            this.dgvDauSach.Size = new System.Drawing.Size(557, 549);
            this.dgvDauSach.TabIndex = 35;
            this.dgvDauSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDauSach_CellClick);
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(592, 148);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 21);
            this.label1.TabIndex = 37;
            this.label1.Text = "* auto random";
            // 
            // label9
            // 
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(174, 209);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(203, 29);
            this.label9.TabIndex = 38;
            this.label9.Text = "Số lượng sách chưa nhập : ";
            // 
            // lbSoluong
            // 
            this.lbSoluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoluong.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbSoluong.Location = new System.Drawing.Point(364, 198);
            this.lbSoluong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSoluong.Name = "lbSoluong";
            this.lbSoluong.Size = new System.Drawing.Size(109, 52);
            this.lbSoluong.TabIndex = 39;
            this.lbSoluong.Text = "100";
            // 
            // dateNhap
            // 
            this.dateNhap.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.dateNhap.BorderRadius = 0;
            this.dateNhap.BorderSize = 0;
            this.dateNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.dateNhap.Location = new System.Drawing.Point(177, 93);
            this.dateNhap.Margin = new System.Windows.Forms.Padding(4);
            this.dateNhap.MinimumSize = new System.Drawing.Size(4, 40);
            this.dateNhap.Name = "dateNhap";
            this.dateNhap.Size = new System.Drawing.Size(199, 40);
            this.dateNhap.SkinColor = System.Drawing.Color.MidnightBlue;
            this.dateNhap.TabIndex = 22;
            this.dateNhap.TextColor = System.Drawing.Color.White;
            // 
            // lbPhieunhap
            // 
            this.lbPhieunhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhieunhap.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbPhieunhap.Location = new System.Drawing.Point(170, 11);
            this.lbPhieunhap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPhieunhap.Name = "lbPhieunhap";
            this.lbPhieunhap.Size = new System.Drawing.Size(221, 52);
            this.lbPhieunhap.TabIndex = 40;
            this.lbPhieunhap.Text = "PN000000";
            // 
            // NhapSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1445, 650);
            this.Controls.Add(this.lbPhieunhap);
            this.Controls.Add(this.lbSoluong);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDauSach);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.dgvTTNhap);
            this.Controls.Add(this.dateNhap);
            this.Controls.Add(this.cbNV);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NhapSach";
            this.Text = "NhapSach OneClick";
            this.Load += new System.EventHandler(this.NhapSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTTNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDauSach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2Button btnSubmit;
        private System.Windows.Forms.DataGridView dgvTTNhap;
        private Template.DateTimePickerKiet dateNhap;
        private System.Windows.Forms.ComboBox cbNV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvDauSach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbSoluong;
        private System.Windows.Forms.Label lbPhieunhap;
    }
}
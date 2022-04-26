﻿
namespace LibraryManager.Template
{
    partial class DanhsachNV
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
            this.dgvNhanvien = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearchNV = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbFilterNV = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanvien)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvNhanvien
            // 
            this.dgvNhanvien.BackgroundColor = System.Drawing.Color.White;
            this.dgvNhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanvien.GridColor = System.Drawing.Color.Black;
            this.dgvNhanvien.Location = new System.Drawing.Point(3, 173);
            this.dgvNhanvien.Name = "dgvNhanvien";
            this.dgvNhanvien.RowHeadersWidth = 51;
            this.dgvNhanvien.RowTemplate.Height = 24;
            this.dgvNhanvien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNhanvien.Size = new System.Drawing.Size(1103, 606);
            this.dgvNhanvien.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(525, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "DANH SÁCH NHÂN VIÊN THƯ VIỆN";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSearchNV);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cbFilterNV);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Location = new System.Drawing.Point(3, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1103, 111);
            this.panel1.TabIndex = 4;
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
            this.btnSearchNV.Location = new System.Drawing.Point(878, 55);
            this.btnSearchNV.Name = "btnSearchNV";
            this.btnSearchNV.ShadowDecoration.Parent = this.btnSearchNV;
            this.btnSearchNV.Size = new System.Drawing.Size(159, 44);
            this.btnSearchNV.TabIndex = 5;
            this.btnSearchNV.Text = "Tìm kiếm";
            this.btnSearchNV.Click += new System.EventHandler(this.btnSearchNV_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(523, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 28);
            this.label3.TabIndex = 7;
            this.label3.Text = "Bộ lọc";
            // 
            // cbFilterNV
            // 
            this.cbFilterNV.BackColor = System.Drawing.Color.Transparent;
            this.cbFilterNV.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbFilterNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterNV.FocusedColor = System.Drawing.Color.Empty;
            this.cbFilterNV.FocusedState.Parent = this.cbFilterNV;
            this.cbFilterNV.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbFilterNV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbFilterNV.FormattingEnabled = true;
            this.cbFilterNV.HoverState.Parent = this.cbFilterNV;
            this.cbFilterNV.ItemHeight = 30;
            this.cbFilterNV.Items.AddRange(new object[] {
            "Theo tên",
            "Theo Mã nhân viên",
            "Theo Chức vụ",
            "Theo Email",
            "Theo SDT",
            "Theo Tên đăng nhập",
            "Auto select"});
            this.cbFilterNV.ItemsAppearance.Parent = this.cbFilterNV;
            this.cbFilterNV.Location = new System.Drawing.Point(528, 55);
            this.cbFilterNV.Name = "cbFilterNV";
            this.cbFilterNV.ShadowDecoration.Parent = this.cbFilterNV;
            this.cbFilterNV.Size = new System.Drawing.Size(283, 36);
            this.cbFilterNV.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.Location = new System.Drawing.Point(4, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tìm kiếm NV";
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
            this.txtSearch.Location = new System.Drawing.Point(7, 55);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtSearch.PlaceholderText = "Nhập nội dung tìm kiếm";
            this.txtSearch.SelectedText = "";
            this.txtSearch.ShadowDecoration.Parent = this.txtSearch;
            this.txtSearch.Size = new System.Drawing.Size(483, 44);
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
            this.btnAdd.Location = new System.Drawing.Point(992, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ShadowDecoration.Parent = this.btnAdd;
            this.btnAdd.Size = new System.Drawing.Size(114, 45);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Thêm NV";
            // 
            // DanhsachNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvNhanvien);
            this.Name = "DanhsachNV";
            this.Size = new System.Drawing.Size(1134, 803);
            this.Load += new System.EventHandler(this.DanhsachNV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanvien)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNhanvien;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnSearchNV;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox cbFilterNV;
        private System.Windows.Forms.Label label2;
    }
}

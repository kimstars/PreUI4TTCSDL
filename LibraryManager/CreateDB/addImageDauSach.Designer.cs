
namespace LibraryManager.CreateDB
{
    partial class addImageDauSach
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
            this.btnSubmit = new Guna.UI2.WinForms.Guna2Button();
            this.dgvInfo = new System.Windows.Forms.DataGridView();
            this.cbTableName = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.folderDlg = new System.Windows.Forms.FolderBrowserDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.txtPathFolder = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.CheckedState.Parent = this.btnSubmit;
            this.btnSubmit.CustomImages.Parent = this.btnSubmit;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.HoverState.Parent = this.btnSubmit;
            this.btnSubmit.Location = new System.Drawing.Point(170, 122);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.ShadowDecoration.Parent = this.btnSubmit;
            this.btnSubmit.Size = new System.Drawing.Size(277, 51);
            this.btnSubmit.TabIndex = 31;
            this.btnSubmit.Text = "submit";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // dgvInfo
            // 
            this.dgvInfo.BackgroundColor = System.Drawing.Color.White;
            this.dgvInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfo.Location = new System.Drawing.Point(21, 195);
            this.dgvInfo.Margin = new System.Windows.Forms.Padding(4);
            this.dgvInfo.Name = "dgvInfo";
            this.dgvInfo.RowHeadersWidth = 51;
            this.dgvInfo.Size = new System.Drawing.Size(1015, 394);
            this.dgvInfo.TabIndex = 30;
            // 
            // cbTableName
            // 
            this.cbTableName.FormattingEnabled = true;
            this.cbTableName.Items.AddRange(new object[] {
            "DOCGIA",
            "NHANVIEN",
            "DAUSACH"});
            this.cbTableName.Location = new System.Drawing.Point(170, 48);
            this.cbTableName.Margin = new System.Windows.Forms.Padding(4);
            this.cbTableName.Name = "cbTableName";
            this.cbTableName.Size = new System.Drawing.Size(162, 24);
            this.cbTableName.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(449, 55);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Chọn thư mục chứa ảnh :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 51);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Chọn bảng :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(897, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 44);
            this.button1.TabIndex = 35;
            this.button1.Text = "Chọn";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPathFolder
            // 
            this.txtPathFolder.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPathFolder.DefaultText = "";
            this.txtPathFolder.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPathFolder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPathFolder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPathFolder.DisabledState.Parent = this.txtPathFolder;
            this.txtPathFolder.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPathFolder.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPathFolder.FocusedState.Parent = this.txtPathFolder;
            this.txtPathFolder.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPathFolder.HoverState.Parent = this.txtPathFolder;
            this.txtPathFolder.Location = new System.Drawing.Point(623, 35);
            this.txtPathFolder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPathFolder.Name = "txtPathFolder";
            this.txtPathFolder.PasswordChar = '\0';
            this.txtPathFolder.PlaceholderText = "";
            this.txtPathFolder.SelectedText = "";
            this.txtPathFolder.ShadowDecoration.Parent = this.txtPathFolder;
            this.txtPathFolder.Size = new System.Drawing.Size(267, 44);
            this.txtPathFolder.TabIndex = 36;
            // 
            // addImageDauSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 614);
            this.Controls.Add(this.txtPathFolder);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.dgvInfo);
            this.Controls.Add(this.cbTableName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Name = "addImageDauSach";
            this.Text = "addImageDauSach";
            this.Load += new System.EventHandler(this.addImageDauSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnSubmit;
        private System.Windows.Forms.DataGridView dgvInfo;
        private System.Windows.Forms.ComboBox cbTableName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FolderBrowserDialog folderDlg;
        private System.Windows.Forms.Button button1;
        private Guna.UI2.WinForms.Guna2TextBox txtPathFolder;
    }
}
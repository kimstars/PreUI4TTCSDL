
namespace LibraryManager.Template
{
    partial class TK_sachmuon_dg
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.rbtnChuaTra = new System.Windows.Forms.RadioButton();
            this.rbtnTrehen = new System.Windows.Forms.RadioButton();
            this.rbtnDamuon = new System.Windows.Forms.RadioButton();
            this.lbTK = new System.Windows.Forms.Label();
            this.dgvTK = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTK)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.guna2Panel1.Controls.Add(this.guna2Button1);
            this.guna2Panel1.Controls.Add(this.rbtnChuaTra);
            this.guna2Panel1.Controls.Add(this.rbtnTrehen);
            this.guna2Panel1.Controls.Add(this.rbtnDamuon);
            this.guna2Panel1.Controls.Add(this.lbTK);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(1093, 174);
            this.guna2Panel1.TabIndex = 0;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 15;
            this.guna2Button1.BorderThickness = 3;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2Button1.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(409, 107);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(115, 45);
            this.guna2Button1.TabIndex = 5;
            this.guna2Button1.Text = "Thống kê";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // rbtnChuaTra
            // 
            this.rbtnChuaTra.AutoSize = true;
            this.rbtnChuaTra.Location = new System.Drawing.Point(282, 125);
            this.rbtnChuaTra.Name = "rbtnChuaTra";
            this.rbtnChuaTra.Size = new System.Drawing.Size(97, 27);
            this.rbtnChuaTra.TabIndex = 4;
            this.rbtnChuaTra.TabStop = true;
            this.rbtnChuaTra.Text = "Chưa trả";
            this.rbtnChuaTra.UseVisualStyleBackColor = true;
            // 
            // rbtnTrehen
            // 
            this.rbtnTrehen.AutoSize = true;
            this.rbtnTrehen.Location = new System.Drawing.Point(163, 125);
            this.rbtnTrehen.Name = "rbtnTrehen";
            this.rbtnTrehen.Size = new System.Drawing.Size(88, 27);
            this.rbtnTrehen.TabIndex = 4;
            this.rbtnTrehen.TabStop = true;
            this.rbtnTrehen.Text = "Trễ hẹn";
            this.rbtnTrehen.UseVisualStyleBackColor = true;
            // 
            // rbtnDamuon
            // 
            this.rbtnDamuon.AutoSize = true;
            this.rbtnDamuon.Location = new System.Drawing.Point(33, 125);
            this.rbtnDamuon.Name = "rbtnDamuon";
            this.rbtnDamuon.Size = new System.Drawing.Size(102, 27);
            this.rbtnDamuon.TabIndex = 4;
            this.rbtnDamuon.TabStop = true;
            this.rbtnDamuon.Text = "Đã mượn";
            this.rbtnDamuon.UseVisualStyleBackColor = true;
            // 
            // lbTK
            // 
            this.lbTK.AutoSize = true;
            this.lbTK.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTK.Location = new System.Drawing.Point(16, 17);
            this.lbTK.Name = "lbTK";
            this.lbTK.Size = new System.Drawing.Size(253, 32);
            this.lbTK.TabIndex = 0;
            this.lbTK.Text = "Thống kê sách mượn";
            // 
            // dgvTK
            // 
            this.dgvTK.AllowCustomTheming = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(217)))), ((int)(((byte)(198)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dgvTK.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTK.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTK.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTK.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTK.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(84)))), ((int)(((byte)(24)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTK.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvTK.ColumnHeadersHeight = 40;
            this.dgvTK.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(217)))), ((int)(((byte)(198)))));
            this.dgvTK.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvTK.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvTK.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(165)))), ((int)(((byte)(120)))));
            this.dgvTK.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvTK.CurrentTheme.BackColor = System.Drawing.Color.Chocolate;
            this.dgvTK.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(210)))), ((int)(((byte)(187)))));
            this.dgvTK.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.Chocolate;
            this.dgvTK.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgvTK.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvTK.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(84)))), ((int)(((byte)(24)))));
            this.dgvTK.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvTK.CurrentTheme.Name = null;
            this.dgvTK.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(225)))), ((int)(((byte)(210)))));
            this.dgvTK.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvTK.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvTK.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(165)))), ((int)(((byte)(120)))));
            this.dgvTK.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(225)))), ((int)(((byte)(210)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(165)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTK.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvTK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTK.EnableHeadersVisualStyles = false;
            this.dgvTK.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(210)))), ((int)(((byte)(187)))));
            this.dgvTK.HeaderBackColor = System.Drawing.Color.Chocolate;
            this.dgvTK.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvTK.HeaderForeColor = System.Drawing.Color.White;
            this.dgvTK.Location = new System.Drawing.Point(0, 174);
            this.dgvTK.Name = "dgvTK";
            this.dgvTK.RowHeadersVisible = false;
            this.dgvTK.RowHeadersWidth = 51;
            this.dgvTK.RowTemplate.Height = 40;
            this.dgvTK.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTK.Size = new System.Drawing.Size(1093, 617);
            this.dgvTK.TabIndex = 1;
            this.dgvTK.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Chocolate;
            // 
            // TK_sachmuon_dg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvTK);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "TK_sachmuon_dg";
            this.Size = new System.Drawing.Size(1093, 791);
            this.Load += new System.EventHandler(this.TK_sachmuon_dg_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTK)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label lbTK;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.RadioButton rbtnChuaTra;
        private System.Windows.Forms.RadioButton rbtnTrehen;
        private System.Windows.Forms.RadioButton rbtnDamuon;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvTK;
    }
}

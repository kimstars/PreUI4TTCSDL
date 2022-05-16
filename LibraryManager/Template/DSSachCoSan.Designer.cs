
namespace LibraryManager.Template
{
    partial class DSSachCoSan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DSSachCoSan));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.guna2CustomGradientPanel2 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbTheLoai = new Guna.UI2.WinForms.Guna2ComboBox();
            this.flowLayoutDS = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.btnFindByTG = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnFindAll = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.lbSLBook = new System.Windows.Forms.Label();
            this.guna2CustomGradientPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2CustomGradientPanel2
            // 
            this.guna2CustomGradientPanel2.BorderRadius = 10;
            this.guna2CustomGradientPanel2.Controls.Add(this.lbSLBook);
            this.guna2CustomGradientPanel2.Controls.Add(this.btnFindByTG);
            this.guna2CustomGradientPanel2.Controls.Add(this.btnFindAll);
            this.guna2CustomGradientPanel2.Controls.Add(this.txtSearch);
            this.guna2CustomGradientPanel2.Controls.Add(this.cbTheLoai);
            this.guna2CustomGradientPanel2.Controls.Add(this.flowLayoutDS);
            this.guna2CustomGradientPanel2.Controls.Add(this.btnSearch);
            this.guna2CustomGradientPanel2.Location = new System.Drawing.Point(20, 33);
            this.guna2CustomGradientPanel2.Name = "guna2CustomGradientPanel2";
            this.guna2CustomGradientPanel2.ShadowDecoration.Parent = this.guna2CustomGradientPanel2;
            this.guna2CustomGradientPanel2.Size = new System.Drawing.Size(1074, 673);
            this.guna2CustomGradientPanel2.TabIndex = 50;
            // 
            // txtSearch
            // 
            this.txtSearch.BorderColor = System.Drawing.Color.Silver;
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
            this.txtSearch.Location = new System.Drawing.Point(212, 54);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "Nhập tên sách để tôi tìm cho bạn";
            this.txtSearch.SelectedText = "";
            this.txtSearch.ShadowDecoration.Parent = this.txtSearch;
            this.txtSearch.Size = new System.Drawing.Size(611, 40);
            this.txtSearch.TabIndex = 35;
            // 
            // cbTheLoai
            // 
            this.cbTheLoai.BackColor = System.Drawing.Color.Transparent;
            this.cbTheLoai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbTheLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTheLoai.FocusedColor = System.Drawing.Color.Empty;
            this.cbTheLoai.FocusedState.Parent = this.cbTheLoai;
            this.cbTheLoai.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbTheLoai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbTheLoai.FormattingEnabled = true;
            this.cbTheLoai.HoverState.Parent = this.cbTheLoai;
            this.cbTheLoai.ItemHeight = 30;
            this.cbTheLoai.Items.AddRange(new object[] {
            "Tất cả thể loại"});
            this.cbTheLoai.ItemsAppearance.Parent = this.cbTheLoai;
            this.cbTheLoai.Location = new System.Drawing.Point(213, 11);
            this.cbTheLoai.Name = "cbTheLoai";
            this.cbTheLoai.ShadowDecoration.Parent = this.cbTheLoai;
            this.cbTheLoai.Size = new System.Drawing.Size(179, 36);
            this.cbTheLoai.TabIndex = 37;
            // 
            // flowLayoutDS
            // 
            this.flowLayoutDS.AutoScroll = true;
            this.flowLayoutDS.Location = new System.Drawing.Point(15, 100);
            this.flowLayoutDS.Name = "flowLayoutDS";
            this.flowLayoutDS.Size = new System.Drawing.Size(1025, 547);
            this.flowLayoutDS.TabIndex = 46;
            // 
            // btnSearch
            // 
            this.btnSearch.CheckedState.Parent = this.btnSearch;
            this.btnSearch.CustomImages.Parent = this.btnSearch;
            this.btnSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(86)))), ((int)(((byte)(136)))));
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.HoverState.Parent = this.btnSearch;
            this.btnSearch.Location = new System.Drawing.Point(830, 54);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.ShadowDecoration.Parent = this.btnSearch;
            this.btnSearch.Size = new System.Drawing.Size(107, 40);
            this.btnSearch.TabIndex = 36;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnFindByTG
            // 
            this.btnFindByTG.AllowAnimations = true;
            this.btnFindByTG.AllowMouseEffects = true;
            this.btnFindByTG.AllowToggling = false;
            this.btnFindByTG.AnimationSpeed = 200;
            this.btnFindByTG.AutoGenerateColors = false;
            this.btnFindByTG.AutoRoundBorders = false;
            this.btnFindByTG.AutoSizeLeftIcon = true;
            this.btnFindByTG.AutoSizeRightIcon = true;
            this.btnFindByTG.BackColor = System.Drawing.Color.Transparent;
            this.btnFindByTG.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(198)))), ((int)(((byte)(165)))));
            this.btnFindByTG.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFindByTG.BackgroundImage")));
            this.btnFindByTG.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnFindByTG.ButtonText = "Tìm theo tên tác giả";
            this.btnFindByTG.ButtonTextMarginLeft = 0;
            this.btnFindByTG.ColorContrastOnClick = 45;
            this.btnFindByTG.ColorContrastOnHover = 45;
            this.btnFindByTG.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btnFindByTG.CustomizableEdges = borderEdges3;
            this.btnFindByTG.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnFindByTG.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnFindByTG.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnFindByTG.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnFindByTG.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnFindByTG.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFindByTG.ForeColor = System.Drawing.Color.White;
            this.btnFindByTG.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFindByTG.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnFindByTG.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnFindByTG.IconMarginLeft = 11;
            this.btnFindByTG.IconPadding = 10;
            this.btnFindByTG.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFindByTG.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnFindByTG.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnFindByTG.IconSize = 25;
            this.btnFindByTG.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(198)))), ((int)(((byte)(165)))));
            this.btnFindByTG.IdleBorderRadius = 1;
            this.btnFindByTG.IdleBorderThickness = 1;
            this.btnFindByTG.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(198)))), ((int)(((byte)(165)))));
            this.btnFindByTG.IdleIconLeftImage = null;
            this.btnFindByTG.IdleIconRightImage = null;
            this.btnFindByTG.IndicateFocus = false;
            this.btnFindByTG.Location = new System.Drawing.Point(491, 11);
            this.btnFindByTG.Name = "btnFindByTG";
            this.btnFindByTG.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnFindByTG.OnDisabledState.BorderRadius = 1;
            this.btnFindByTG.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnFindByTG.OnDisabledState.BorderThickness = 1;
            this.btnFindByTG.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnFindByTG.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnFindByTG.OnDisabledState.IconLeftImage = null;
            this.btnFindByTG.OnDisabledState.IconRightImage = null;
            this.btnFindByTG.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnFindByTG.onHoverState.BorderRadius = 1;
            this.btnFindByTG.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnFindByTG.onHoverState.BorderThickness = 1;
            this.btnFindByTG.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnFindByTG.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnFindByTG.onHoverState.IconLeftImage = null;
            this.btnFindByTG.onHoverState.IconRightImage = null;
            this.btnFindByTG.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(198)))), ((int)(((byte)(165)))));
            this.btnFindByTG.OnIdleState.BorderRadius = 1;
            this.btnFindByTG.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnFindByTG.OnIdleState.BorderThickness = 1;
            this.btnFindByTG.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(198)))), ((int)(((byte)(165)))));
            this.btnFindByTG.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnFindByTG.OnIdleState.IconLeftImage = null;
            this.btnFindByTG.OnIdleState.IconRightImage = null;
            this.btnFindByTG.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnFindByTG.OnPressedState.BorderRadius = 1;
            this.btnFindByTG.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnFindByTG.OnPressedState.BorderThickness = 1;
            this.btnFindByTG.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnFindByTG.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnFindByTG.OnPressedState.IconLeftImage = null;
            this.btnFindByTG.OnPressedState.IconRightImage = null;
            this.btnFindByTG.Size = new System.Drawing.Size(140, 36);
            this.btnFindByTG.TabIndex = 40;
            this.btnFindByTG.Tag = "Tìm theo tên tác giả";
            this.btnFindByTG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnFindByTG.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnFindByTG.TextMarginLeft = 0;
            this.btnFindByTG.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnFindByTG.UseDefaultRadiusAndThickness = true;
            this.btnFindByTG.Click += new System.EventHandler(this.btnFindByTG_Click);
            // 
            // btnFindAll
            // 
            this.btnFindAll.AllowAnimations = true;
            this.btnFindAll.AllowMouseEffects = true;
            this.btnFindAll.AllowToggling = false;
            this.btnFindAll.AnimationSpeed = 200;
            this.btnFindAll.AutoGenerateColors = false;
            this.btnFindAll.AutoRoundBorders = false;
            this.btnFindAll.AutoSizeLeftIcon = true;
            this.btnFindAll.AutoSizeRightIcon = true;
            this.btnFindAll.BackColor = System.Drawing.Color.Transparent;
            this.btnFindAll.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btnFindAll.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFindAll.BackgroundImage")));
            this.btnFindAll.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnFindAll.ButtonText = "Tất cả";
            this.btnFindAll.ButtonTextMarginLeft = 0;
            this.btnFindAll.ColorContrastOnClick = 45;
            this.btnFindAll.ColorContrastOnHover = 45;
            this.btnFindAll.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.btnFindAll.CustomizableEdges = borderEdges4;
            this.btnFindAll.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnFindAll.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnFindAll.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnFindAll.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnFindAll.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnFindAll.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFindAll.ForeColor = System.Drawing.Color.White;
            this.btnFindAll.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFindAll.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnFindAll.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnFindAll.IconMarginLeft = 11;
            this.btnFindAll.IconPadding = 10;
            this.btnFindAll.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFindAll.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnFindAll.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnFindAll.IconSize = 25;
            this.btnFindAll.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnFindAll.IdleBorderRadius = 1;
            this.btnFindAll.IdleBorderThickness = 1;
            this.btnFindAll.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btnFindAll.IdleIconLeftImage = null;
            this.btnFindAll.IdleIconRightImage = null;
            this.btnFindAll.IndicateFocus = false;
            this.btnFindAll.Location = new System.Drawing.Point(410, 11);
            this.btnFindAll.Name = "btnFindAll";
            this.btnFindAll.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnFindAll.OnDisabledState.BorderRadius = 1;
            this.btnFindAll.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnFindAll.OnDisabledState.BorderThickness = 1;
            this.btnFindAll.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnFindAll.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnFindAll.OnDisabledState.IconLeftImage = null;
            this.btnFindAll.OnDisabledState.IconRightImage = null;
            this.btnFindAll.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnFindAll.onHoverState.BorderRadius = 1;
            this.btnFindAll.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnFindAll.onHoverState.BorderThickness = 1;
            this.btnFindAll.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnFindAll.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnFindAll.onHoverState.IconLeftImage = null;
            this.btnFindAll.onHoverState.IconRightImage = null;
            this.btnFindAll.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnFindAll.OnIdleState.BorderRadius = 1;
            this.btnFindAll.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnFindAll.OnIdleState.BorderThickness = 1;
            this.btnFindAll.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnFindAll.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnFindAll.OnIdleState.IconLeftImage = null;
            this.btnFindAll.OnIdleState.IconRightImage = null;
            this.btnFindAll.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnFindAll.OnPressedState.BorderRadius = 1;
            this.btnFindAll.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnFindAll.OnPressedState.BorderThickness = 1;
            this.btnFindAll.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnFindAll.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnFindAll.OnPressedState.IconLeftImage = null;
            this.btnFindAll.OnPressedState.IconRightImage = null;
            this.btnFindAll.Size = new System.Drawing.Size(75, 36);
            this.btnFindAll.TabIndex = 39;
            this.btnFindAll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnFindAll.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnFindAll.TextMarginLeft = 0;
            this.btnFindAll.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnFindAll.UseDefaultRadiusAndThickness = true;
            this.btnFindAll.Click += new System.EventHandler(this.btnFindAll_Click);
            // 
            // lbSLBook
            // 
            this.lbSLBook.AutoSize = true;
            this.lbSLBook.BackColor = System.Drawing.Color.Transparent;
            this.lbSLBook.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold);
            this.lbSLBook.ForeColor = System.Drawing.Color.Red;
            this.lbSLBook.Location = new System.Drawing.Point(655, 28);
            this.lbSLBook.Name = "lbSLBook";
            this.lbSLBook.Size = new System.Drawing.Size(13, 19);
            this.lbSLBook.TabIndex = 47;
            this.lbSLBook.Text = ".";
            // 
            // DSSachCoSan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2CustomGradientPanel2);
            this.Name = "DSSachCoSan";
            this.Size = new System.Drawing.Size(1120, 734);
            this.Load += new System.EventHandler(this.DSSachCoSan_Load);
            this.guna2CustomGradientPanel2.ResumeLayout(false);
            this.guna2CustomGradientPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel2;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnFindByTG;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnFindAll;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2ComboBox cbTheLoai;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutDS;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private System.Windows.Forms.Label lbSLBook;
    }
}

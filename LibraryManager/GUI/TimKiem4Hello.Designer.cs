
namespace LibraryManager.GUI
{
    partial class TimKiem4Hello
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimKiem4Hello));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.flowLayoutDS = new System.Windows.Forms.FlowLayoutPanel();
            this.cbTheLoai = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnFindAll = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.dragPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.btnCreatePM = new Guna.UI2.WinForms.Guna2Button();
            this.btnClearAll = new Guna.UI2.WinForms.Guna2Button();
            this.label13 = new System.Windows.Forms.Label();
            this.btnPreview = new Guna.UI2.WinForms.Guna2Button();
            this.dgvChooseBook = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.MaDauSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDauSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remove = new System.Windows.Forms.DataGridViewButtonColumn();
            this.guna2CustomGradientPanel2 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.btnFindByTG = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.lbSLBook = new System.Windows.Forms.Label();
            this.dragPanel.SuspendLayout();
            this.guna2CustomGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChooseBook)).BeginInit();
            this.guna2CustomGradientPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutDS
            // 
            this.flowLayoutDS.AutoScroll = true;
            this.flowLayoutDS.Location = new System.Drawing.Point(20, 228);
            this.flowLayoutDS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flowLayoutDS.MaximumSize = new System.Drawing.Size(903, 673);
            this.flowLayoutDS.Name = "flowLayoutDS";
            this.flowLayoutDS.Size = new System.Drawing.Size(869, 673);
            this.flowLayoutDS.TabIndex = 41;
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
            this.cbTheLoai.Location = new System.Drawing.Point(37, 15);
            this.cbTheLoai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbTheLoai.Name = "cbTheLoai";
            this.cbTheLoai.ShadowDecoration.Parent = this.cbTheLoai;
            this.cbTheLoai.Size = new System.Drawing.Size(265, 36);
            this.cbTheLoai.TabIndex = 37;
            this.cbTheLoai.SelectedIndexChanged += new System.EventHandler(this.cbTheLoai_SelectedIndexChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.CheckedState.Parent = this.btnSearch;
            this.btnSearch.CustomImages.Parent = this.btnSearch;
            this.btnSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(86)))), ((int)(((byte)(136)))));
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.HoverState.Parent = this.btnSearch;
            this.btnSearch.Location = new System.Drawing.Point(701, 66);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.ShadowDecoration.Parent = this.btnSearch;
            this.btnSearch.Size = new System.Drawing.Size(143, 49);
            this.btnSearch.TabIndex = 36;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
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
            this.txtSearch.Location = new System.Drawing.Point(37, 66);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "Nhập tên sách để tôi tìm cho bạn";
            this.txtSearch.SelectedText = "";
            this.txtSearch.ShadowDecoration.Parent = this.txtSearch;
            this.txtSearch.Size = new System.Drawing.Size(644, 49);
            this.txtSearch.TabIndex = 35;
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
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnFindAll.CustomizableEdges = borderEdges1;
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
            this.btnFindAll.Location = new System.Drawing.Point(507, 15);
            this.btnFindAll.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.btnFindAll.Size = new System.Drawing.Size(100, 44);
            this.btnFindAll.TabIndex = 39;
            this.btnFindAll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnFindAll.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnFindAll.TextMarginLeft = 0;
            this.btnFindAll.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnFindAll.UseDefaultRadiusAndThickness = true;
            this.btnFindAll.Click += new System.EventHandler(this.btnFindAll_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.dragPanel;
            // 
            // dragPanel
            // 
            this.dragPanel.Controls.Add(this.label1);
            this.dragPanel.Controls.Add(this.guna2ControlBox2);
            this.dragPanel.Controls.Add(this.guna2ControlBox1);
            this.dragPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.dragPanel.Location = new System.Drawing.Point(0, 0);
            this.dragPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dragPanel.Name = "dragPanel";
            this.dragPanel.Size = new System.Drawing.Size(1541, 41);
            this.dragPanel.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 13F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(86)))), ((int)(((byte)(136)))));
            this.label1.Location = new System.Drawing.Point(52, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 30);
            this.label1.TabIndex = 36;
            this.label1.Text = "TÌM KIẾM ĐẦU SÁCH";
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox2.HoverState.Parent = this.guna2ControlBox2;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(1380, 4);
            this.guna2ControlBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.ShadowDecoration.Parent = this.guna2ControlBox2;
            this.guna2ControlBox2.Size = new System.Drawing.Size(60, 36);
            this.guna2ControlBox2.TabIndex = 1;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1467, 4);
            this.guna2ControlBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(60, 36);
            this.guna2ControlBox1.TabIndex = 0;
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BorderRadius = 10;
            this.guna2CustomGradientPanel1.Controls.Add(this.btnCreatePM);
            this.guna2CustomGradientPanel1.Controls.Add(this.btnClearAll);
            this.guna2CustomGradientPanel1.Controls.Add(this.label13);
            this.guna2CustomGradientPanel1.Controls.Add(this.btnPreview);
            this.guna2CustomGradientPanel1.Controls.Add(this.dgvChooseBook);
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(913, 73);
            this.guna2CustomGradientPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.ShadowDecoration.Parent = this.guna2CustomGradientPanel1;
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(593, 828);
            this.guna2CustomGradientPanel1.TabIndex = 43;
            // 
            // btnCreatePM
            // 
            this.btnCreatePM.BackColor = System.Drawing.Color.Transparent;
            this.btnCreatePM.BorderRadius = 18;
            this.btnCreatePM.CheckedState.Parent = this.btnCreatePM;
            this.btnCreatePM.CustomImages.Parent = this.btnCreatePM;
            this.btnCreatePM.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(198)))), ((int)(((byte)(165)))));
            this.btnCreatePM.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCreatePM.ForeColor = System.Drawing.Color.White;
            this.btnCreatePM.HoverState.Parent = this.btnCreatePM;
            this.btnCreatePM.Image = global::LibraryManager.Properties.Resources.icons8_preview_file_64px;
            this.btnCreatePM.Location = new System.Drawing.Point(314, 690);
            this.btnCreatePM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreatePM.Name = "btnCreatePM";
            this.btnCreatePM.ShadowDecoration.Parent = this.btnCreatePM;
            this.btnCreatePM.Size = new System.Drawing.Size(228, 44);
            this.btnCreatePM.TabIndex = 41;
            this.btnCreatePM.Text = "Tạo phiếu mượn";
            this.btnCreatePM.Click += new System.EventHandler(this.btnCreatePM_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.BackColor = System.Drawing.Color.Transparent;
            this.btnClearAll.BorderRadius = 18;
            this.btnClearAll.CheckedState.Parent = this.btnClearAll;
            this.btnClearAll.CustomImages.Parent = this.btnClearAll;
            this.btnClearAll.FillColor = System.Drawing.Color.LightCoral;
            this.btnClearAll.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClearAll.ForeColor = System.Drawing.Color.White;
            this.btnClearAll.HoverState.Parent = this.btnClearAll;
            this.btnClearAll.Image = global::LibraryManager.Properties.Resources.icons8_cross_mark_button_96px;
            this.btnClearAll.Location = new System.Drawing.Point(397, 28);
            this.btnClearAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.ShadowDecoration.Parent = this.btnClearAll;
            this.btnClearAll.Size = new System.Drawing.Size(172, 44);
            this.btnClearAll.TabIndex = 40;
            this.btnClearAll.Text = "Clear all";
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Segoe UI Black", 13F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(86)))), ((int)(((byte)(136)))));
            this.label13.Location = new System.Drawing.Point(20, 17);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(152, 30);
            this.label13.TabIndex = 39;
            this.label13.Text = "Bạn đã chọn:";
            // 
            // btnPreview
            // 
            this.btnPreview.BackColor = System.Drawing.Color.Transparent;
            this.btnPreview.BorderRadius = 18;
            this.btnPreview.CheckedState.Parent = this.btnPreview;
            this.btnPreview.CustomImages.Parent = this.btnPreview;
            this.btnPreview.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(86)))), ((int)(((byte)(136)))));
            this.btnPreview.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPreview.ForeColor = System.Drawing.Color.White;
            this.btnPreview.HoverState.Parent = this.btnPreview;
            this.btnPreview.Image = global::LibraryManager.Properties.Resources.icons8_preview_file_64px;
            this.btnPreview.Location = new System.Drawing.Point(25, 690);
            this.btnPreview.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.ShadowDecoration.Parent = this.btnPreview;
            this.btnPreview.Size = new System.Drawing.Size(228, 44);
            this.btnPreview.TabIndex = 37;
            this.btnPreview.Text = "Xem chi tiết";
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // dgvChooseBook
            // 
            this.dgvChooseBook.AllowCustomTheming = false;
            this.dgvChooseBook.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvChooseBook.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvChooseBook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChooseBook.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvChooseBook.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvChooseBook.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvChooseBook.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvChooseBook.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvChooseBook.ColumnHeadersHeight = 40;
            this.dgvChooseBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDauSach,
            this.TenDauSach,
            this.Remove});
            this.dgvChooseBook.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dgvChooseBook.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvChooseBook.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvChooseBook.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvChooseBook.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvChooseBook.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dgvChooseBook.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvChooseBook.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dgvChooseBook.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgvChooseBook.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvChooseBook.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dgvChooseBook.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvChooseBook.CurrentTheme.Name = null;
            this.dgvChooseBook.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvChooseBook.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvChooseBook.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvChooseBook.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvChooseBook.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvChooseBook.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvChooseBook.EnableHeadersVisualStyles = false;
            this.dgvChooseBook.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvChooseBook.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dgvChooseBook.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvChooseBook.HeaderForeColor = System.Drawing.Color.White;
            this.dgvChooseBook.Location = new System.Drawing.Point(27, 90);
            this.dgvChooseBook.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvChooseBook.Name = "dgvChooseBook";
            this.dgvChooseBook.RowHeadersVisible = false;
            this.dgvChooseBook.RowHeadersWidth = 51;
            this.dgvChooseBook.RowTemplate.Height = 40;
            this.dgvChooseBook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChooseBook.Size = new System.Drawing.Size(543, 524);
            this.dgvChooseBook.TabIndex = 36;
            this.dgvChooseBook.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.dgvChooseBook.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChooseBook_CellClick);
            // 
            // MaDauSach
            // 
            this.MaDauSach.HeaderText = "Mã đầu sách";
            this.MaDauSach.MinimumWidth = 6;
            this.MaDauSach.Name = "MaDauSach";
            this.MaDauSach.ReadOnly = true;
            // 
            // TenDauSach
            // 
            this.TenDauSach.HeaderText = "Tên đầu sách";
            this.TenDauSach.MinimumWidth = 6;
            this.TenDauSach.Name = "TenDauSach";
            // 
            // Remove
            // 
            this.Remove.HeaderText = "Remove";
            this.Remove.MinimumWidth = 6;
            this.Remove.Name = "Remove";
            this.Remove.Text = "Loại bỏ";
            // 
            // guna2CustomGradientPanel2
            // 
            this.guna2CustomGradientPanel2.BorderRadius = 10;
            this.guna2CustomGradientPanel2.Controls.Add(this.btnFindByTG);
            this.guna2CustomGradientPanel2.Controls.Add(this.btnFindAll);
            this.guna2CustomGradientPanel2.Controls.Add(this.txtSearch);
            this.guna2CustomGradientPanel2.Controls.Add(this.cbTheLoai);
            this.guna2CustomGradientPanel2.Controls.Add(this.btnSearch);
            this.guna2CustomGradientPanel2.Location = new System.Drawing.Point(20, 73);
            this.guna2CustomGradientPanel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2CustomGradientPanel2.Name = "guna2CustomGradientPanel2";
            this.guna2CustomGradientPanel2.ShadowDecoration.Parent = this.guna2CustomGradientPanel2;
            this.guna2CustomGradientPanel2.Size = new System.Drawing.Size(869, 135);
            this.guna2CustomGradientPanel2.TabIndex = 44;
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
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnFindByTG.CustomizableEdges = borderEdges2;
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
            this.btnFindByTG.Location = new System.Drawing.Point(312, 15);
            this.btnFindByTG.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.btnFindByTG.Size = new System.Drawing.Size(187, 44);
            this.btnFindByTG.TabIndex = 40;
            this.btnFindByTG.Tag = "Tìm theo tên tác giả";
            this.btnFindByTG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnFindByTG.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnFindByTG.TextMarginLeft = 0;
            this.btnFindByTG.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnFindByTG.UseDefaultRadiusAndThickness = true;
            this.btnFindByTG.Click += new System.EventHandler(this.btnFindByTG_Click);
            // 
            // lbSLBook
            // 
            this.lbSLBook.AutoSize = true;
            this.lbSLBook.BackColor = System.Drawing.Color.Transparent;
            this.lbSLBook.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold);
            this.lbSLBook.ForeColor = System.Drawing.Color.Red;
            this.lbSLBook.Location = new System.Drawing.Point(52, 44);
            this.lbSLBook.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSLBook.Name = "lbSLBook";
            this.lbSLBook.Size = new System.Drawing.Size(15, 23);
            this.lbSLBook.TabIndex = 41;
            this.lbSLBook.Text = ".";
            // 
            // TimKiem4Hello
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1541, 937);
            this.Controls.Add(this.lbSLBook);
            this.Controls.Add(this.guna2CustomGradientPanel2);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Controls.Add(this.dragPanel);
            this.Controls.Add(this.flowLayoutDS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TimKiem4Hello";
            this.Text = "TimKiem4Hello";
            this.Load += new System.EventHandler(this.TimKiem4Hello_Load);
            this.dragPanel.ResumeLayout(false);
            this.dragPanel.PerformLayout();
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChooseBook)).EndInit();
            this.guna2CustomGradientPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutDS;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnFindAll;
        private Guna.UI2.WinForms.Guna2ComboBox cbTheLoai;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Panel dragPanel;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel2;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private System.Windows.Forms.Label label13;
        private Guna.UI2.WinForms.Guna2Button btnPreview;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvChooseBook;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnFindByTG;
        private Guna.UI2.WinForms.Guna2Button btnCreatePM;
        private Guna.UI2.WinForms.Guna2Button btnClearAll;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDauSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDauSach;
        private System.Windows.Forms.DataGridViewButtonColumn Remove;
        private System.Windows.Forms.Label lbSLBook;
    }
}
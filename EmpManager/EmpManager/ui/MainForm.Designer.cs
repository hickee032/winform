namespace winform1219
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainTitle = new Sunny.UI.UISymbolLabel();
            this.topLayout = new System.Windows.Forms.Panel();
            this.uiSymbolButton6 = new Sunny.UI.UISymbolButton();
            this.uiSymbolButton5 = new Sunny.UI.UISymbolButton();
            this.uiSymbolButton4 = new Sunny.UI.UISymbolButton();
            this.uiSymbolButton3 = new Sunny.UI.UISymbolButton();
            this.mainExit = new Sunny.UI.UISymbolButton();
            this.mainMin = new Sunny.UI.UISymbolButton();
            this.leftLayout = new System.Windows.Forms.Panel();
            this.uiLine1 = new Sunny.UI.UILine();
            this.mainHelp = new Sunny.UI.UIHeaderButton();
            this.mainSetting = new Sunny.UI.UIHeaderButton();
            this.mainAdmin = new Sunny.UI.UIHeaderButton();
            this.mainView = new Sunny.UI.UIHeaderButton();
            this.mainSal = new Sunny.UI.UIHeaderButton();
            this.mainAdd = new Sunny.UI.UIHeaderButton();
            this.mainHome = new Sunny.UI.UIHeaderButton();
            this.centerLayout = new System.Windows.Forms.Panel();
            this.topLayout.SuspendLayout();
            this.leftLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTitle
            // 
            this.mainTitle.BackColor = System.Drawing.Color.Transparent;
            this.mainTitle.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainTitle.ForeColor = System.Drawing.Color.White;
            this.mainTitle.Location = new System.Drawing.Point(12, 14);
            this.mainTitle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mainTitle.MinimumSize = new System.Drawing.Size(1, 1);
            this.mainTitle.Name = "mainTitle";
            this.mainTitle.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.mainTitle.Size = new System.Drawing.Size(170, 41);
            this.mainTitle.Style = Sunny.UI.UIStyle.Custom;
            this.mainTitle.Symbol = 62142;
            this.mainTitle.SymbolColor = System.Drawing.Color.White;
            this.mainTitle.TabIndex = 0;
            this.mainTitle.Text = "사원관리 App 1.0";
            this.mainTitle.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // topLayout
            // 
            this.topLayout.BackColor = System.Drawing.Color.Indigo;
            this.topLayout.Controls.Add(this.uiSymbolButton6);
            this.topLayout.Controls.Add(this.uiSymbolButton5);
            this.topLayout.Controls.Add(this.uiSymbolButton4);
            this.topLayout.Controls.Add(this.uiSymbolButton3);
            this.topLayout.Controls.Add(this.mainExit);
            this.topLayout.Controls.Add(this.mainMin);
            this.topLayout.Controls.Add(this.mainTitle);
            this.topLayout.Dock = System.Windows.Forms.DockStyle.Top;
            this.topLayout.Location = new System.Drawing.Point(0, 0);
            this.topLayout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.topLayout.Name = "topLayout";
            this.topLayout.Size = new System.Drawing.Size(850, 76);
            this.topLayout.TabIndex = 1;
            this.topLayout.MouseMove += new System.Windows.Forms.MouseEventHandler(this.topLayout_MouseMove);
            // 
            // uiSymbolButton6
            // 
            this.uiSymbolButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton6.FillColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton6.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolButton6.Location = new System.Drawing.Point(445, 14);
            this.uiSymbolButton6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uiSymbolButton6.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton6.Name = "uiSymbolButton6";
            this.uiSymbolButton6.RectColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton6.Size = new System.Drawing.Size(50, 41);
            this.uiSymbolButton6.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolButton6.Symbol = 57540;
            this.uiSymbolButton6.SymbolSize = 36;
            this.uiSymbolButton6.TabIndex = 6;
            this.uiSymbolButton6.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiSymbolButton5
            // 
            this.uiSymbolButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton5.FillColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton5.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolButton5.Location = new System.Drawing.Point(501, 14);
            this.uiSymbolButton5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uiSymbolButton5.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton5.Name = "uiSymbolButton5";
            this.uiSymbolButton5.RectColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton5.Size = new System.Drawing.Size(50, 41);
            this.uiSymbolButton5.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolButton5.Symbol = 61799;
            this.uiSymbolButton5.SymbolSize = 36;
            this.uiSymbolButton5.TabIndex = 5;
            this.uiSymbolButton5.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiSymbolButton4
            // 
            this.uiSymbolButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton4.FillColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton4.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolButton4.Location = new System.Drawing.Point(389, 14);
            this.uiSymbolButton4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uiSymbolButton4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton4.Name = "uiSymbolButton4";
            this.uiSymbolButton4.RectColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton4.Size = new System.Drawing.Size(50, 41);
            this.uiSymbolButton4.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolButton4.Symbol = 61812;
            this.uiSymbolButton4.SymbolSize = 36;
            this.uiSymbolButton4.TabIndex = 4;
            this.uiSymbolButton4.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiSymbolButton3
            // 
            this.uiSymbolButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton3.FillColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton3.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolButton3.Location = new System.Drawing.Point(333, 14);
            this.uiSymbolButton3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uiSymbolButton3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton3.Name = "uiSymbolButton3";
            this.uiSymbolButton3.RectColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton3.Size = new System.Drawing.Size(50, 41);
            this.uiSymbolButton3.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolButton3.Symbol = 61593;
            this.uiSymbolButton3.SymbolSize = 36;
            this.uiSymbolButton3.TabIndex = 3;
            this.uiSymbolButton3.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // mainExit
            // 
            this.mainExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainExit.FillColor = System.Drawing.Color.Transparent;
            this.mainExit.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.mainExit.Location = new System.Drawing.Point(807, 14);
            this.mainExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mainExit.MinimumSize = new System.Drawing.Size(1, 1);
            this.mainExit.Name = "mainExit";
            this.mainExit.RectColor = System.Drawing.Color.Transparent;
            this.mainExit.Size = new System.Drawing.Size(31, 41);
            this.mainExit.Style = Sunny.UI.UIStyle.Custom;
            this.mainExit.Symbol = 61453;
            this.mainExit.SymbolColor = System.Drawing.Color.Gainsboro;
            this.mainExit.TabIndex = 2;
            this.mainExit.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.mainExit.Click += new System.EventHandler(this.mainExit_Click);
            // 
            // mainMin
            // 
            this.mainMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainMin.FillColor = System.Drawing.Color.Transparent;
            this.mainMin.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.mainMin.Location = new System.Drawing.Point(770, 14);
            this.mainMin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mainMin.MinimumSize = new System.Drawing.Size(1, 1);
            this.mainMin.Name = "mainMin";
            this.mainMin.RectColor = System.Drawing.Color.Transparent;
            this.mainMin.Size = new System.Drawing.Size(31, 41);
            this.mainMin.Style = Sunny.UI.UIStyle.Custom;
            this.mainMin.Symbol = 62161;
            this.mainMin.SymbolColor = System.Drawing.Color.Gainsboro;
            this.mainMin.TabIndex = 1;
            this.mainMin.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.mainMin.Click += new System.EventHandler(this.mainMin_Click);
            // 
            // leftLayout
            // 
            this.leftLayout.BackColor = System.Drawing.Color.Transparent;
            this.leftLayout.Controls.Add(this.uiLine1);
            this.leftLayout.Controls.Add(this.mainHelp);
            this.leftLayout.Controls.Add(this.mainSetting);
            this.leftLayout.Controls.Add(this.mainAdmin);
            this.leftLayout.Controls.Add(this.mainView);
            this.leftLayout.Controls.Add(this.mainSal);
            this.leftLayout.Controls.Add(this.mainAdd);
            this.leftLayout.Controls.Add(this.mainHome);
            this.leftLayout.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftLayout.Location = new System.Drawing.Point(0, 76);
            this.leftLayout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.leftLayout.Name = "leftLayout";
            this.leftLayout.Size = new System.Drawing.Size(142, 772);
            this.leftLayout.TabIndex = 2;
            // 
            // uiLine1
            // 
            this.uiLine1.BackColor = System.Drawing.Color.LightGray;
            this.uiLine1.Direction = Sunny.UI.UILine.LineDirection.Vertical;
            this.uiLine1.FillColor = System.Drawing.Color.LightGray;
            this.uiLine1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiLine1.LineColor = System.Drawing.Color.LightGray;
            this.uiLine1.LineColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.uiLine1.Location = new System.Drawing.Point(140, 152);
            this.uiLine1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uiLine1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLine1.Name = "uiLine1";
            this.uiLine1.Size = new System.Drawing.Size(3, 467);
            this.uiLine1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLine1.TabIndex = 0;
            this.uiLine1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // mainHelp
            // 
            this.mainHelp.CircleColor = System.Drawing.Color.Transparent;
            this.mainHelp.FillColor = System.Drawing.Color.Transparent;
            this.mainHelp.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.mainHelp.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mainHelp.ForeColor = System.Drawing.Color.Gray;
            this.mainHelp.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.mainHelp.ForePressColor = System.Drawing.Color.Red;
            this.mainHelp.ForeSelectedColor = System.Drawing.Color.Red;
            this.mainHelp.Location = new System.Drawing.Point(4, 657);
            this.mainHelp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mainHelp.MinimumSize = new System.Drawing.Size(1, 1);
            this.mainHelp.Name = "mainHelp";
            this.mainHelp.Padding = new System.Windows.Forms.Padding(0, 15, 0, 12);
            this.mainHelp.Radius = 0;
            this.mainHelp.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.mainHelp.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.mainHelp.Size = new System.Drawing.Size(139, 103);
            this.mainHelp.Style = Sunny.UI.UIStyle.Custom;
            this.mainHelp.Symbol = 61736;
            this.mainHelp.SymbolColor = System.Drawing.SystemColors.ButtonShadow;
            this.mainHelp.TabIndex = 6;
            this.mainHelp.Text = "도움말";
            this.mainHelp.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.mainHelp.Click += new System.EventHandler(this.mainHelp_Click);
            // 
            // mainSetting
            // 
            this.mainSetting.CircleColor = System.Drawing.Color.Transparent;
            this.mainSetting.FillColor = System.Drawing.Color.Transparent;
            this.mainSetting.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.mainSetting.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mainSetting.ForeColor = System.Drawing.Color.Gray;
            this.mainSetting.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.mainSetting.ForePressColor = System.Drawing.Color.Red;
            this.mainSetting.ForeSelectedColor = System.Drawing.Color.Red;
            this.mainSetting.Location = new System.Drawing.Point(4, 553);
            this.mainSetting.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mainSetting.MinimumSize = new System.Drawing.Size(1, 1);
            this.mainSetting.Name = "mainSetting";
            this.mainSetting.Padding = new System.Windows.Forms.Padding(0, 15, 0, 12);
            this.mainSetting.Radius = 0;
            this.mainSetting.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.mainSetting.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.mainSetting.Size = new System.Drawing.Size(139, 103);
            this.mainSetting.Style = Sunny.UI.UIStyle.Custom;
            this.mainSetting.Symbol = 61573;
            this.mainSetting.SymbolColor = System.Drawing.SystemColors.ButtonShadow;
            this.mainSetting.TabIndex = 5;
            this.mainSetting.Text = "환경 설정";
            this.mainSetting.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.mainSetting.Click += new System.EventHandler(this.mainSetting_Click);
            // 
            // mainAdmin
            // 
            this.mainAdmin.CircleColor = System.Drawing.Color.Transparent;
            this.mainAdmin.FillColor = System.Drawing.Color.Transparent;
            this.mainAdmin.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.mainAdmin.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mainAdmin.ForeColor = System.Drawing.Color.Gray;
            this.mainAdmin.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.mainAdmin.ForePressColor = System.Drawing.Color.Red;
            this.mainAdmin.ForeSelectedColor = System.Drawing.Color.Red;
            this.mainAdmin.Location = new System.Drawing.Point(4, 443);
            this.mainAdmin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mainAdmin.MinimumSize = new System.Drawing.Size(1, 1);
            this.mainAdmin.Name = "mainAdmin";
            this.mainAdmin.Padding = new System.Windows.Forms.Padding(0, 15, 0, 12);
            this.mainAdmin.Radius = 0;
            this.mainAdmin.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.mainAdmin.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.mainAdmin.Size = new System.Drawing.Size(139, 103);
            this.mainAdmin.Style = Sunny.UI.UIStyle.Custom;
            this.mainAdmin.Symbol = 62142;
            this.mainAdmin.SymbolColor = System.Drawing.SystemColors.ButtonShadow;
            this.mainAdmin.TabIndex = 4;
            this.mainAdmin.Text = "관리자";
            this.mainAdmin.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.mainAdmin.Click += new System.EventHandler(this.mainAdmin_Click);
            // 
            // mainView
            // 
            this.mainView.CircleColor = System.Drawing.Color.Transparent;
            this.mainView.FillColor = System.Drawing.Color.Transparent;
            this.mainView.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.mainView.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mainView.ForeColor = System.Drawing.Color.Gray;
            this.mainView.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.mainView.ForePressColor = System.Drawing.Color.Red;
            this.mainView.ForeSelectedColor = System.Drawing.Color.Red;
            this.mainView.Location = new System.Drawing.Point(4, 334);
            this.mainView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mainView.MinimumSize = new System.Drawing.Size(1, 1);
            this.mainView.Name = "mainView";
            this.mainView.Padding = new System.Windows.Forms.Padding(0, 15, 0, 12);
            this.mainView.Radius = 0;
            this.mainView.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.mainView.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.mainView.Size = new System.Drawing.Size(139, 103);
            this.mainView.Style = Sunny.UI.UIStyle.Custom;
            this.mainView.Symbol = 61454;
            this.mainView.SymbolColor = System.Drawing.SystemColors.ButtonShadow;
            this.mainView.TabIndex = 3;
            this.mainView.Text = "정보 보기";
            this.mainView.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.mainView.Click += new System.EventHandler(this.mainView_Click);
            // 
            // mainSal
            // 
            this.mainSal.CircleColor = System.Drawing.Color.Transparent;
            this.mainSal.FillColor = System.Drawing.Color.Transparent;
            this.mainSal.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.mainSal.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mainSal.ForeColor = System.Drawing.Color.Gray;
            this.mainSal.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.mainSal.ForePressColor = System.Drawing.Color.Red;
            this.mainSal.ForeSelectedColor = System.Drawing.Color.Red;
            this.mainSal.Location = new System.Drawing.Point(4, 224);
            this.mainSal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mainSal.MinimumSize = new System.Drawing.Size(1, 1);
            this.mainSal.Name = "mainSal";
            this.mainSal.Padding = new System.Windows.Forms.Padding(0, 15, 0, 12);
            this.mainSal.Radius = 0;
            this.mainSal.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.mainSal.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.mainSal.Size = new System.Drawing.Size(139, 103);
            this.mainSal.Style = Sunny.UI.UIStyle.Custom;
            this.mainSal.Symbol = 61953;
            this.mainSal.SymbolColor = System.Drawing.SystemColors.ButtonShadow;
            this.mainSal.TabIndex = 2;
            this.mainSal.Text = "급여 등급";
            this.mainSal.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.mainSal.Click += new System.EventHandler(this.mainSal_Click);
            // 
            // mainAdd
            // 
            this.mainAdd.CircleColor = System.Drawing.Color.Transparent;
            this.mainAdd.FillColor = System.Drawing.Color.Transparent;
            this.mainAdd.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.mainAdd.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mainAdd.ForeColor = System.Drawing.Color.Gray;
            this.mainAdd.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.mainAdd.ForePressColor = System.Drawing.Color.Red;
            this.mainAdd.ForeSelectedColor = System.Drawing.Color.Red;
            this.mainAdd.Location = new System.Drawing.Point(4, 114);
            this.mainAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mainAdd.MinimumSize = new System.Drawing.Size(1, 1);
            this.mainAdd.Name = "mainAdd";
            this.mainAdd.Padding = new System.Windows.Forms.Padding(0, 15, 0, 12);
            this.mainAdd.Radius = 0;
            this.mainAdd.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.mainAdd.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.mainAdd.Size = new System.Drawing.Size(139, 103);
            this.mainAdd.Style = Sunny.UI.UIStyle.Custom;
            this.mainAdd.Symbol = 62004;
            this.mainAdd.SymbolColor = System.Drawing.SystemColors.ButtonShadow;
            this.mainAdd.TabIndex = 1;
            this.mainAdd.Text = "사원 추가";
            this.mainAdd.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.mainAdd.Click += new System.EventHandler(this.mainAdd_Click);
            // 
            // mainHome
            // 
            this.mainHome.BackColor = System.Drawing.Color.Transparent;
            this.mainHome.CircleColor = System.Drawing.Color.Transparent;
            this.mainHome.FillColor = System.Drawing.Color.Transparent;
            this.mainHome.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.mainHome.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mainHome.ForeColor = System.Drawing.Color.Gray;
            this.mainHome.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.mainHome.ForePressColor = System.Drawing.Color.Red;
            this.mainHome.ForeSelectedColor = System.Drawing.Color.Red;
            this.mainHome.Location = new System.Drawing.Point(4, 5);
            this.mainHome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mainHome.MinimumSize = new System.Drawing.Size(1, 1);
            this.mainHome.Name = "mainHome";
            this.mainHome.Padding = new System.Windows.Forms.Padding(0, 15, 0, 12);
            this.mainHome.Radius = 0;
            this.mainHome.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.mainHome.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.mainHome.Size = new System.Drawing.Size(139, 103);
            this.mainHome.Style = Sunny.UI.UIStyle.Custom;
            this.mainHome.Symbol = 61952;
            this.mainHome.SymbolColor = System.Drawing.SystemColors.ButtonShadow;
            this.mainHome.TabIndex = 0;
            this.mainHome.Text = "메인 화면";
            this.mainHome.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.mainHome.Click += new System.EventHandler(this.mainHome_Click);
            // 
            // centerLayout
            // 
            this.centerLayout.BackColor = System.Drawing.Color.Transparent;
            this.centerLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.centerLayout.Location = new System.Drawing.Point(142, 76);
            this.centerLayout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.centerLayout.Name = "centerLayout";
            this.centerLayout.Size = new System.Drawing.Size(708, 772);
            this.centerLayout.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 848);
            this.ControlBox = false;
            this.Controls.Add(this.centerLayout);
            this.Controls.Add(this.leftLayout);
            this.Controls.Add(this.topLayout);
            this.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "사원관리 App 1.0";
            this.topLayout.ResumeLayout(false);
            this.leftLayout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UISymbolLabel mainTitle;
        private System.Windows.Forms.Panel topLayout;
        private System.Windows.Forms.Panel leftLayout;
        private System.Windows.Forms.Panel centerLayout;
        private Sunny.UI.UISymbolButton mainExit;
        private Sunny.UI.UISymbolButton mainMin;
        private Sunny.UI.UISymbolButton uiSymbolButton6;
        private Sunny.UI.UISymbolButton uiSymbolButton5;
        private Sunny.UI.UISymbolButton uiSymbolButton4;
        private Sunny.UI.UISymbolButton uiSymbolButton3;
        private Sunny.UI.UIHeaderButton mainHome;
        private Sunny.UI.UIHeaderButton mainSetting;
        private Sunny.UI.UIHeaderButton mainAdmin;
        private Sunny.UI.UIHeaderButton mainView;
        private Sunny.UI.UIHeaderButton mainSal;
        private Sunny.UI.UIHeaderButton mainAdd;
        private Sunny.UI.UIHeaderButton mainHelp;
        private Sunny.UI.UILine uiLine1;
    }
}


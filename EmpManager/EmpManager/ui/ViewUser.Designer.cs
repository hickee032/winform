namespace winform1219.ui
{
    partial class ViewUser
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.memLView = new System.Windows.Forms.ListView();
            this.lvNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvNickname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvBirth = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvGender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvTel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.memGView = new Sunny.UI.UIDataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uiSmoothLabel1 = new Sunny.UI.UISmoothLabel();
            this.modName = new Sunny.UI.UITextBox();
            this.uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            this.uiSymbolLabel2 = new Sunny.UI.UISymbolLabel();
            this.modNick = new Sunny.UI.UITextBox();
            this.uiSymbolLabel3 = new Sunny.UI.UISymbolLabel();
            this.modBirth = new Sunny.UI.UITextBox();
            this.uiSymbolLabel4 = new Sunny.UI.UISymbolLabel();
            this.modEmail = new Sunny.UI.UITextBox();
            this.uiSymbolLabel5 = new Sunny.UI.UISymbolLabel();
            this.modTel = new Sunny.UI.UITextBox();
            this.uiSymbolLabel6 = new Sunny.UI.UISymbolLabel();
            this.modGender = new Sunny.UI.UITextBox();
            this.modUpdate = new Sunny.UI.UISymbolButton();
            this.uiSymbolLabel7 = new Sunny.UI.UISymbolLabel();
            this.uiComboBox1 = new Sunny.UI.UIComboBox();
            this.uiTextBox1 = new Sunny.UI.UITextBox();
            this.uiSymbolButton1 = new Sunny.UI.UISymbolButton();
            this.uiSymbolButton2 = new Sunny.UI.UISymbolButton();
            this.uiSymbolButton3 = new Sunny.UI.UISymbolButton();
            ((System.ComponentModel.ISupportInitialize)(this.memGView)).BeginInit();
            this.SuspendLayout();
            // 
            // memLView
            // 
            this.memLView.BackColor = System.Drawing.Color.White;
            this.memLView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lvNum,
            this.lvName,
            this.lvNickname,
            this.lvBirth,
            this.lvGender,
            this.lvTel,
            this.lvEmail});
            this.memLView.FullRowSelect = true;
            this.memLView.GridLines = true;
            this.memLView.HideSelection = false;
            this.memLView.Location = new System.Drawing.Point(33, 145);
            this.memLView.Name = "memLView";
            this.memLView.Size = new System.Drawing.Size(637, 275);
            this.memLView.TabIndex = 0;
            this.memLView.UseCompatibleStateImageBehavior = false;
            this.memLView.View = System.Windows.Forms.View.Details;
            this.memLView.SelectedIndexChanged += new System.EventHandler(this.memLView_SelectedIndexChanged);
            // 
            // lvNum
            // 
            this.lvNum.Text = "번호";
            // 
            // lvName
            // 
            this.lvName.Text = "이름";
            // 
            // lvNickname
            // 
            this.lvNickname.Text = "닉네임";
            // 
            // lvBirth
            // 
            this.lvBirth.Text = "생년월일";
            this.lvBirth.Width = 120;
            // 
            // lvGender
            // 
            this.lvGender.Text = "성별";
            // 
            // lvTel
            // 
            this.lvTel.Text = "전화";
            this.lvTel.Width = 100;
            // 
            // lvEmail
            // 
            this.lvEmail.Text = "이메일";
            this.lvEmail.Width = 100;
            // 
            // memGView
            // 
            this.memGView.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.memGView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.memGView.BackgroundColor = System.Drawing.Color.White;
            this.memGView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.memGView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.memGView.ColumnHeadersHeight = 32;
            this.memGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.memGView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column1,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.memGView.DefaultCellStyle = dataGridViewCellStyle3;
            this.memGView.EnableHeadersVisualStyles = false;
            this.memGView.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.memGView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.memGView.Location = new System.Drawing.Point(33, 555);
            this.memGView.Name = "memGView";
            this.memGView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.memGView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.memGView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.memGView.RowTemplate.Height = 23;
            this.memGView.ScrollBarRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.memGView.SelectedIndex = -1;
            this.memGView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.memGView.Size = new System.Drawing.Size(637, 184);
            this.memGView.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.memGView.Style = Sunny.UI.UIStyle.Custom;
            this.memGView.TabIndex = 1;
            this.memGView.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.memGView.SelectIndexChange += new Sunny.UI.UIDataGridView.OnSelectIndexChange(this.memGView_SelectIndexChange);
            // 
            // Column2
            // 
            this.Column2.HeaderText = "번호";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column2.Width = 50;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "이름";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column1.Width = 80;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "닉네임";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "생년월일";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "성별";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column5.Width = 50;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "전화";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "이메일";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column7.Width = 110;
            // 
            // uiSmoothLabel1
            // 
            this.uiSmoothLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiSmoothLabel1.Location = new System.Drawing.Point(212, 9);
            this.uiSmoothLabel1.Name = "uiSmoothLabel1";
            this.uiSmoothLabel1.Size = new System.Drawing.Size(257, 49);
            this.uiSmoothLabel1.TabIndex = 27;
            this.uiSmoothLabel1.Text = "회원정보 보기";
            this.uiSmoothLabel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // modName
            // 
            this.modName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.modName.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.modName.Location = new System.Drawing.Point(110, 433);
            this.modName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.modName.MinimumSize = new System.Drawing.Size(1, 16);
            this.modName.Name = "modName";
            this.modName.ShowText = false;
            this.modName.Size = new System.Drawing.Size(98, 35);
            this.modName.TabIndex = 28;
            this.modName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.modName.Watermark = "";
            this.modName.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiSymbolLabel1
            // 
            this.uiSymbolLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel1.Location = new System.Drawing.Point(34, 433);
            this.uiSymbolLabel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel1.Name = "uiSymbolLabel1";
            this.uiSymbolLabel1.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel1.Size = new System.Drawing.Size(69, 35);
            this.uiSymbolLabel1.TabIndex = 29;
            this.uiSymbolLabel1.Text = "이름";
            this.uiSymbolLabel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiSymbolLabel2
            // 
            this.uiSymbolLabel2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel2.Location = new System.Drawing.Point(220, 433);
            this.uiSymbolLabel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel2.Name = "uiSymbolLabel2";
            this.uiSymbolLabel2.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel2.Size = new System.Drawing.Size(69, 35);
            this.uiSymbolLabel2.TabIndex = 31;
            this.uiSymbolLabel2.Text = "별명";
            this.uiSymbolLabel2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // modNick
            // 
            this.modNick.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.modNick.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.modNick.Location = new System.Drawing.Point(296, 433);
            this.modNick.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.modNick.MinimumSize = new System.Drawing.Size(1, 16);
            this.modNick.Name = "modNick";
            this.modNick.ShowText = false;
            this.modNick.Size = new System.Drawing.Size(98, 35);
            this.modNick.TabIndex = 30;
            this.modNick.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.modNick.Watermark = "";
            this.modNick.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiSymbolLabel3
            // 
            this.uiSymbolLabel3.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel3.Location = new System.Drawing.Point(405, 433);
            this.uiSymbolLabel3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel3.Name = "uiSymbolLabel3";
            this.uiSymbolLabel3.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel3.Size = new System.Drawing.Size(69, 35);
            this.uiSymbolLabel3.TabIndex = 33;
            this.uiSymbolLabel3.Text = "생일";
            this.uiSymbolLabel3.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // modBirth
            // 
            this.modBirth.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.modBirth.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.modBirth.Location = new System.Drawing.Point(481, 433);
            this.modBirth.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.modBirth.MinimumSize = new System.Drawing.Size(1, 16);
            this.modBirth.Name = "modBirth";
            this.modBirth.ShowText = false;
            this.modBirth.Size = new System.Drawing.Size(98, 35);
            this.modBirth.TabIndex = 32;
            this.modBirth.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.modBirth.Watermark = "";
            this.modBirth.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiSymbolLabel4
            // 
            this.uiSymbolLabel4.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel4.Location = new System.Drawing.Point(405, 478);
            this.uiSymbolLabel4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel4.Name = "uiSymbolLabel4";
            this.uiSymbolLabel4.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel4.Size = new System.Drawing.Size(69, 35);
            this.uiSymbolLabel4.TabIndex = 39;
            this.uiSymbolLabel4.Text = "메일";
            this.uiSymbolLabel4.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // modEmail
            // 
            this.modEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.modEmail.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.modEmail.Location = new System.Drawing.Point(481, 478);
            this.modEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.modEmail.MinimumSize = new System.Drawing.Size(1, 16);
            this.modEmail.Name = "modEmail";
            this.modEmail.ShowText = false;
            this.modEmail.Size = new System.Drawing.Size(98, 35);
            this.modEmail.TabIndex = 38;
            this.modEmail.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.modEmail.Watermark = "";
            this.modEmail.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiSymbolLabel5
            // 
            this.uiSymbolLabel5.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel5.Location = new System.Drawing.Point(220, 478);
            this.uiSymbolLabel5.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel5.Name = "uiSymbolLabel5";
            this.uiSymbolLabel5.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel5.Size = new System.Drawing.Size(69, 35);
            this.uiSymbolLabel5.TabIndex = 37;
            this.uiSymbolLabel5.Text = "전화";
            this.uiSymbolLabel5.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // modTel
            // 
            this.modTel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.modTel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.modTel.Location = new System.Drawing.Point(296, 478);
            this.modTel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.modTel.MinimumSize = new System.Drawing.Size(1, 16);
            this.modTel.Name = "modTel";
            this.modTel.ShowText = false;
            this.modTel.Size = new System.Drawing.Size(98, 35);
            this.modTel.TabIndex = 36;
            this.modTel.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.modTel.Watermark = "";
            this.modTel.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiSymbolLabel6
            // 
            this.uiSymbolLabel6.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel6.Location = new System.Drawing.Point(34, 478);
            this.uiSymbolLabel6.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel6.Name = "uiSymbolLabel6";
            this.uiSymbolLabel6.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel6.Size = new System.Drawing.Size(69, 35);
            this.uiSymbolLabel6.TabIndex = 35;
            this.uiSymbolLabel6.Text = "성별";
            this.uiSymbolLabel6.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // modGender
            // 
            this.modGender.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.modGender.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.modGender.Location = new System.Drawing.Point(110, 478);
            this.modGender.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.modGender.MinimumSize = new System.Drawing.Size(1, 16);
            this.modGender.Name = "modGender";
            this.modGender.ShowText = false;
            this.modGender.Size = new System.Drawing.Size(98, 35);
            this.modGender.TabIndex = 34;
            this.modGender.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.modGender.Watermark = "";
            this.modGender.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // modUpdate
            // 
            this.modUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.modUpdate.FillColor = System.Drawing.Color.Teal;
            this.modUpdate.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.modUpdate.Location = new System.Drawing.Point(586, 433);
            this.modUpdate.MinimumSize = new System.Drawing.Size(1, 1);
            this.modUpdate.Name = "modUpdate";
            this.modUpdate.Size = new System.Drawing.Size(84, 35);
            this.modUpdate.Style = Sunny.UI.UIStyle.Custom;
            this.modUpdate.Symbol = 61484;
            this.modUpdate.TabIndex = 40;
            this.modUpdate.Text = "수정";
            this.modUpdate.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.modUpdate.Click += new System.EventHandler(this.modUpdate_Click);
            // 
            // uiSymbolLabel7
            // 
            this.uiSymbolLabel7.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel7.Location = new System.Drawing.Point(32, 90);
            this.uiSymbolLabel7.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel7.Name = "uiSymbolLabel7";
            this.uiSymbolLabel7.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel7.Size = new System.Drawing.Size(105, 35);
            this.uiSymbolLabel7.Symbol = 61442;
            this.uiSymbolLabel7.TabIndex = 41;
            this.uiSymbolLabel7.Text = "검색항목";
            this.uiSymbolLabel7.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiComboBox1
            // 
            this.uiComboBox1.DataSource = null;
            this.uiComboBox1.FillColor = System.Drawing.Color.White;
            this.uiComboBox1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiComboBox1.Items.AddRange(new object[] {
            "이름",
            "닉네임",
            "전화"});
            this.uiComboBox1.Location = new System.Drawing.Point(151, 90);
            this.uiComboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiComboBox1.MinimumSize = new System.Drawing.Size(63, 0);
            this.uiComboBox1.Name = "uiComboBox1";
            this.uiComboBox1.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.uiComboBox1.Size = new System.Drawing.Size(125, 35);
            this.uiComboBox1.TabIndex = 42;
            this.uiComboBox1.Text = "검색 선택";
            this.uiComboBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiComboBox1.Watermark = "";
            this.uiComboBox1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiTextBox1
            // 
            this.uiTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiTextBox1.Location = new System.Drawing.Point(284, 90);
            this.uiTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox1.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTextBox1.Name = "uiTextBox1";
            this.uiTextBox1.ShowText = false;
            this.uiTextBox1.Size = new System.Drawing.Size(158, 35);
            this.uiTextBox1.TabIndex = 29;
            this.uiTextBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTextBox1.Watermark = "";
            this.uiTextBox1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiSymbolButton1
            // 
            this.uiSymbolButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton1.FillColor = System.Drawing.Color.Teal;
            this.uiSymbolButton1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolButton1.Location = new System.Drawing.Point(449, 90);
            this.uiSymbolButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton1.Name = "uiSymbolButton1";
            this.uiSymbolButton1.Size = new System.Drawing.Size(108, 35);
            this.uiSymbolButton1.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolButton1.Symbol = 61454;
            this.uiSymbolButton1.TabIndex = 43;
            this.uiSymbolButton1.Text = "검색";
            this.uiSymbolButton1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiSymbolButton2
            // 
            this.uiSymbolButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton2.FillColor = System.Drawing.Color.Teal;
            this.uiSymbolButton2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolButton2.Location = new System.Drawing.Point(586, 478);
            this.uiSymbolButton2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton2.Name = "uiSymbolButton2";
            this.uiSymbolButton2.Size = new System.Drawing.Size(84, 35);
            this.uiSymbolButton2.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolButton2.Symbol = 61453;
            this.uiSymbolButton2.TabIndex = 44;
            this.uiSymbolButton2.Text = "삭제";
            this.uiSymbolButton2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiSymbolButton3
            // 
            this.uiSymbolButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton3.FillColor = System.Drawing.Color.Teal;
            this.uiSymbolButton3.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolButton3.Location = new System.Drawing.Point(562, 90);
            this.uiSymbolButton3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton3.Name = "uiSymbolButton3";
            this.uiSymbolButton3.Size = new System.Drawing.Size(108, 35);
            this.uiSymbolButton3.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolButton3.Symbol = 61442;
            this.uiSymbolButton3.TabIndex = 45;
            this.uiSymbolButton3.Text = "전체보기";
            this.uiSymbolButton3.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // ViewUser
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.uiSymbolButton3);
            this.Controls.Add(this.uiSymbolButton2);
            this.Controls.Add(this.uiSymbolButton1);
            this.Controls.Add(this.uiTextBox1);
            this.Controls.Add(this.uiComboBox1);
            this.Controls.Add(this.uiSymbolLabel7);
            this.Controls.Add(this.modUpdate);
            this.Controls.Add(this.uiSymbolLabel4);
            this.Controls.Add(this.modEmail);
            this.Controls.Add(this.uiSymbolLabel5);
            this.Controls.Add(this.modTel);
            this.Controls.Add(this.uiSymbolLabel6);
            this.Controls.Add(this.modGender);
            this.Controls.Add(this.uiSymbolLabel3);
            this.Controls.Add(this.modBirth);
            this.Controls.Add(this.uiSymbolLabel2);
            this.Controls.Add(this.modNick);
            this.Controls.Add(this.uiSymbolLabel1);
            this.Controls.Add(this.modName);
            this.Controls.Add(this.uiSmoothLabel1);
            this.Controls.Add(this.memGView);
            this.Controls.Add(this.memLView);
            this.Name = "ViewUser";
            this.Size = new System.Drawing.Size(708, 772);
            this.Load += new System.EventHandler(this.ViewUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.memGView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView memLView;
        private Sunny.UI.UIDataGridView memGView;
        private Sunny.UI.UISmoothLabel uiSmoothLabel1;
        private System.Windows.Forms.ColumnHeader lvNum;
        private System.Windows.Forms.ColumnHeader lvName;
        private System.Windows.Forms.ColumnHeader lvNickname;
        private System.Windows.Forms.ColumnHeader lvBirth;
        private System.Windows.Forms.ColumnHeader lvGender;
        private System.Windows.Forms.ColumnHeader lvTel;
        private System.Windows.Forms.ColumnHeader lvEmail;
        private Sunny.UI.UITextBox modName;
        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
        private Sunny.UI.UISymbolLabel uiSymbolLabel2;
        private Sunny.UI.UITextBox modNick;
        private Sunny.UI.UISymbolLabel uiSymbolLabel3;
        private Sunny.UI.UITextBox modBirth;
        private Sunny.UI.UISymbolLabel uiSymbolLabel4;
        private Sunny.UI.UITextBox modEmail;
        private Sunny.UI.UISymbolLabel uiSymbolLabel5;
        private Sunny.UI.UITextBox modTel;
        private Sunny.UI.UISymbolLabel uiSymbolLabel6;
        private Sunny.UI.UITextBox modGender;
        private Sunny.UI.UISymbolButton modUpdate;
        private Sunny.UI.UISymbolLabel uiSymbolLabel7;
        private Sunny.UI.UIComboBox uiComboBox1;
        private Sunny.UI.UITextBox uiTextBox1;
        private Sunny.UI.UISymbolButton uiSymbolButton1;
        private Sunny.UI.UISymbolButton uiSymbolButton2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private Sunny.UI.UISymbolButton uiSymbolButton3;
    }
}

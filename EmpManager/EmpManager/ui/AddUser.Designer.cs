namespace winform1219.ui
{
    partial class AddUser
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
            this.uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            this.id = new Sunny.UI.UITextBox();
            this.passwd1 = new Sunny.UI.UITextBox();
            this.uiSymbolLabel2 = new Sunny.UI.UISymbolLabel();
            this.name = new Sunny.UI.UITextBox();
            this.uiSymbolLabel3 = new Sunny.UI.UISymbolLabel();
            this.passwd2 = new Sunny.UI.UITextBox();
            this.uiSymbolLabel4 = new Sunny.UI.UISymbolLabel();
            this.nickname = new Sunny.UI.UITextBox();
            this.uiSymbolLabel5 = new Sunny.UI.UISymbolLabel();
            this.uiSymbolLabel6 = new Sunny.UI.UISymbolLabel();
            this.year = new Sunny.UI.UIComboBox();
            this.month = new Sunny.UI.UIComboBox();
            this.day = new Sunny.UI.UIComboBox();
            this.uiSymbolLabel7 = new Sunny.UI.UISymbolLabel();
            this.man = new Sunny.UI.UIRadioButton();
            this.women = new Sunny.UI.UIRadioButton();
            this.uiSymbolLabel8 = new Sunny.UI.UISymbolLabel();
            this.tel = new Sunny.UI.UITextBox();
            this.uiSymbolLabel9 = new Sunny.UI.UISymbolLabel();
            this.email1 = new Sunny.UI.UITextBox();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.email2 = new Sunny.UI.UITextBox();
            this.email3 = new Sunny.UI.UIComboBox();
            this.memAdd = new Sunny.UI.UISymbolButton();
            this.memCancel = new Sunny.UI.UISymbolButton();
            this.picAdd = new Sunny.UI.UIButton();
            this.picDel = new Sunny.UI.UIButton();
            this.uiSmoothLabel1 = new Sunny.UI.UISmoothLabel();
            this.uiLine1 = new Sunny.UI.UILine();
            this.picture = new System.Windows.Forms.PictureBox();
            this.uiLine2 = new Sunny.UI.UILine();
            this.uiLine3 = new Sunny.UI.UILine();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // uiSymbolLabel1
            // 
            this.uiSymbolLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel1.Location = new System.Drawing.Point(114, 135);
            this.uiSymbolLabel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel1.Name = "uiSymbolLabel1";
            this.uiSymbolLabel1.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel1.Size = new System.Drawing.Size(143, 35);
            this.uiSymbolLabel1.Symbol = 62144;
            this.uiSymbolLabel1.TabIndex = 0;
            this.uiSymbolLabel1.Text = "아이디";
            this.uiSymbolLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiSymbolLabel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // id
            // 
            this.id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.id.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.id.Location = new System.Drawing.Point(264, 135);
            this.id.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.id.MinimumSize = new System.Drawing.Size(1, 16);
            this.id.Name = "id";
            this.id.ShowText = false;
            this.id.Size = new System.Drawing.Size(150, 29);
            this.id.TabIndex = 1;
            this.id.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.id.Watermark = "";
            this.id.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // passwd1
            // 
            this.passwd1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwd1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.passwd1.Location = new System.Drawing.Point(264, 174);
            this.passwd1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.passwd1.MinimumSize = new System.Drawing.Size(1, 16);
            this.passwd1.Name = "passwd1";
            this.passwd1.PasswordChar = '●';
            this.passwd1.ShowText = false;
            this.passwd1.Size = new System.Drawing.Size(150, 29);
            this.passwd1.TabIndex = 4;
            this.passwd1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.passwd1.Watermark = "";
            this.passwd1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiSymbolLabel2
            // 
            this.uiSymbolLabel2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel2.Location = new System.Drawing.Point(114, 174);
            this.uiSymbolLabel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel2.Name = "uiSymbolLabel2";
            this.uiSymbolLabel2.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel2.Size = new System.Drawing.Size(143, 35);
            this.uiSymbolLabel2.Symbol = 61475;
            this.uiSymbolLabel2.TabIndex = 3;
            this.uiSymbolLabel2.Text = "비밀번호";
            this.uiSymbolLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiSymbolLabel2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // name
            // 
            this.name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.name.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.name.Location = new System.Drawing.Point(264, 252);
            this.name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.name.MinimumSize = new System.Drawing.Size(1, 16);
            this.name.Name = "name";
            this.name.ShowText = false;
            this.name.Size = new System.Drawing.Size(150, 29);
            this.name.TabIndex = 8;
            this.name.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.name.Watermark = "";
            this.name.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiSymbolLabel3
            // 
            this.uiSymbolLabel3.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel3.Location = new System.Drawing.Point(114, 252);
            this.uiSymbolLabel3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel3.Name = "uiSymbolLabel3";
            this.uiSymbolLabel3.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel3.Size = new System.Drawing.Size(143, 35);
            this.uiSymbolLabel3.Symbol = 61447;
            this.uiSymbolLabel3.TabIndex = 7;
            this.uiSymbolLabel3.Text = "이 름";
            this.uiSymbolLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiSymbolLabel3.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // passwd2
            // 
            this.passwd2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwd2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.passwd2.Location = new System.Drawing.Point(264, 213);
            this.passwd2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.passwd2.MinimumSize = new System.Drawing.Size(1, 16);
            this.passwd2.Name = "passwd2";
            this.passwd2.PasswordChar = '●';
            this.passwd2.ShowText = false;
            this.passwd2.Size = new System.Drawing.Size(150, 29);
            this.passwd2.TabIndex = 6;
            this.passwd2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.passwd2.Watermark = "";
            this.passwd2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiSymbolLabel4
            // 
            this.uiSymbolLabel4.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel4.Location = new System.Drawing.Point(114, 213);
            this.uiSymbolLabel4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel4.Name = "uiSymbolLabel4";
            this.uiSymbolLabel4.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel4.Size = new System.Drawing.Size(143, 35);
            this.uiSymbolLabel4.Symbol = 61475;
            this.uiSymbolLabel4.TabIndex = 5;
            this.uiSymbolLabel4.Text = "비밀번호 확인";
            this.uiSymbolLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiSymbolLabel4.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // nickname
            // 
            this.nickname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nickname.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.nickname.Location = new System.Drawing.Point(264, 292);
            this.nickname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nickname.MinimumSize = new System.Drawing.Size(1, 16);
            this.nickname.Name = "nickname";
            this.nickname.ShowText = false;
            this.nickname.Size = new System.Drawing.Size(150, 29);
            this.nickname.TabIndex = 10;
            this.nickname.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.nickname.Watermark = "";
            this.nickname.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiSymbolLabel5
            // 
            this.uiSymbolLabel5.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel5.Location = new System.Drawing.Point(114, 292);
            this.uiSymbolLabel5.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel5.Name = "uiSymbolLabel5";
            this.uiSymbolLabel5.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel5.Size = new System.Drawing.Size(143, 35);
            this.uiSymbolLabel5.Symbol = 262873;
            this.uiSymbolLabel5.TabIndex = 9;
            this.uiSymbolLabel5.Text = "닉네임";
            this.uiSymbolLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiSymbolLabel5.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiSymbolLabel6
            // 
            this.uiSymbolLabel6.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel6.Location = new System.Drawing.Point(114, 385);
            this.uiSymbolLabel6.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel6.Name = "uiSymbolLabel6";
            this.uiSymbolLabel6.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel6.Size = new System.Drawing.Size(143, 35);
            this.uiSymbolLabel6.Symbol = 61949;
            this.uiSymbolLabel6.TabIndex = 11;
            this.uiSymbolLabel6.Text = "생년월일";
            this.uiSymbolLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiSymbolLabel6.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // year
            // 
            this.year.DataSource = null;
            this.year.FillColor = System.Drawing.Color.White;
            this.year.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.year.Location = new System.Drawing.Point(264, 391);
            this.year.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.year.MinimumSize = new System.Drawing.Size(63, 0);
            this.year.Name = "year";
            this.year.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.year.Size = new System.Drawing.Size(104, 29);
            this.year.TabIndex = 12;
            this.year.Text = "년도";
            this.year.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.year.Watermark = "";
            this.year.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // month
            // 
            this.month.DataSource = null;
            this.month.FillColor = System.Drawing.Color.White;
            this.month.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.month.Items.AddRange(new object[] {
            "1월",
            "2월",
            "3월",
            "4월",
            "5월",
            "6월",
            "7월",
            "8월",
            "9월",
            "10월",
            "11월",
            "12월"});
            this.month.Location = new System.Drawing.Point(376, 391);
            this.month.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.month.MinimumSize = new System.Drawing.Size(63, 0);
            this.month.Name = "month";
            this.month.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.month.Size = new System.Drawing.Size(85, 29);
            this.month.TabIndex = 13;
            this.month.Text = "월";
            this.month.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.month.Watermark = "";
            this.month.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // day
            // 
            this.day.DataSource = null;
            this.day.FillColor = System.Drawing.Color.White;
            this.day.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.day.Location = new System.Drawing.Point(469, 391);
            this.day.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.day.MinimumSize = new System.Drawing.Size(63, 0);
            this.day.Name = "day";
            this.day.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.day.Size = new System.Drawing.Size(63, 29);
            this.day.TabIndex = 13;
            this.day.Text = "일";
            this.day.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.day.Watermark = "";
            this.day.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiSymbolLabel7
            // 
            this.uiSymbolLabel7.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel7.Location = new System.Drawing.Point(115, 432);
            this.uiSymbolLabel7.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel7.Name = "uiSymbolLabel7";
            this.uiSymbolLabel7.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel7.Size = new System.Drawing.Size(143, 35);
            this.uiSymbolLabel7.Symbol = 362139;
            this.uiSymbolLabel7.TabIndex = 14;
            this.uiSymbolLabel7.Text = "성별";
            this.uiSymbolLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiSymbolLabel7.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // man
            // 
            this.man.Cursor = System.Windows.Forms.Cursors.Hand;
            this.man.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.man.Location = new System.Drawing.Point(265, 438);
            this.man.MinimumSize = new System.Drawing.Size(1, 1);
            this.man.Name = "man";
            this.man.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.man.Size = new System.Drawing.Size(85, 29);
            this.man.TabIndex = 15;
            this.man.Text = "남자";
            this.man.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // women
            // 
            this.women.Cursor = System.Windows.Forms.Cursors.Hand;
            this.women.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.women.Location = new System.Drawing.Point(356, 438);
            this.women.MinimumSize = new System.Drawing.Size(1, 1);
            this.women.Name = "women";
            this.women.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.women.Size = new System.Drawing.Size(79, 29);
            this.women.TabIndex = 16;
            this.women.Text = "여자";
            this.women.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiSymbolLabel8
            // 
            this.uiSymbolLabel8.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel8.Location = new System.Drawing.Point(115, 476);
            this.uiSymbolLabel8.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel8.Name = "uiSymbolLabel8";
            this.uiSymbolLabel8.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel8.Size = new System.Drawing.Size(143, 35);
            this.uiSymbolLabel8.Symbol = 61592;
            this.uiSymbolLabel8.TabIndex = 17;
            this.uiSymbolLabel8.Text = "연락처";
            this.uiSymbolLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiSymbolLabel8.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // tel
            // 
            this.tel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.tel.Location = new System.Drawing.Point(265, 476);
            this.tel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tel.MinimumSize = new System.Drawing.Size(1, 16);
            this.tel.Name = "tel";
            this.tel.ShowText = false;
            this.tel.Size = new System.Drawing.Size(150, 29);
            this.tel.TabIndex = 11;
            this.tel.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tel.Watermark = "";
            this.tel.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiSymbolLabel9
            // 
            this.uiSymbolLabel9.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel9.Location = new System.Drawing.Point(115, 517);
            this.uiSymbolLabel9.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel9.Name = "uiSymbolLabel9";
            this.uiSymbolLabel9.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel9.Size = new System.Drawing.Size(143, 35);
            this.uiSymbolLabel9.Symbol = 361458;
            this.uiSymbolLabel9.TabIndex = 18;
            this.uiSymbolLabel9.Text = "이메일";
            this.uiSymbolLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiSymbolLabel9.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // email1
            // 
            this.email1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.email1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.email1.Location = new System.Drawing.Point(265, 523);
            this.email1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.email1.MinimumSize = new System.Drawing.Size(1, 16);
            this.email1.Name = "email1";
            this.email1.ShowText = false;
            this.email1.Size = new System.Drawing.Size(128, 29);
            this.email1.TabIndex = 11;
            this.email1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.email1.Watermark = "";
            this.email1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiLabel1.Location = new System.Drawing.Point(398, 523);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(23, 29);
            this.uiLabel1.TabIndex = 19;
            this.uiLabel1.Text = "@";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // email2
            // 
            this.email2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.email2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.email2.Location = new System.Drawing.Point(428, 523);
            this.email2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.email2.MinimumSize = new System.Drawing.Size(1, 16);
            this.email2.Name = "email2";
            this.email2.ShowText = false;
            this.email2.Size = new System.Drawing.Size(116, 29);
            this.email2.TabIndex = 12;
            this.email2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.email2.Watermark = "";
            this.email2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // email3
            // 
            this.email3.DataSource = null;
            this.email3.FillColor = System.Drawing.Color.White;
            this.email3.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.email3.Items.AddRange(new object[] {
            "kakao.coom",
            "naver.com",
            "gmail.com",
            "daum.net"});
            this.email3.Location = new System.Drawing.Point(552, 523);
            this.email3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.email3.MinimumSize = new System.Drawing.Size(63, 0);
            this.email3.Name = "email3";
            this.email3.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.email3.Size = new System.Drawing.Size(104, 29);
            this.email3.TabIndex = 13;
            this.email3.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.email3.Watermark = "";
            this.email3.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.email3.SelectedIndexChanged += new System.EventHandler(this.email3_SelectedIndexChanged);
            // 
            // memAdd
            // 
            this.memAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.memAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.memAdd.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.memAdd.Location = new System.Drawing.Point(178, 624);
            this.memAdd.MinimumSize = new System.Drawing.Size(1, 1);
            this.memAdd.Name = "memAdd";
            this.memAdd.Size = new System.Drawing.Size(141, 54);
            this.memAdd.Style = Sunny.UI.UIStyle.Custom;
            this.memAdd.Symbol = 61639;
            this.memAdd.TabIndex = 20;
            this.memAdd.Text = "저 장";
            this.memAdd.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.memAdd.Click += new System.EventHandler(this.memAdd_Click);
            // 
            // memCancel
            // 
            this.memCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.memCancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.memCancel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.memCancel.Location = new System.Drawing.Point(356, 624);
            this.memCancel.MinimumSize = new System.Drawing.Size(1, 1);
            this.memCancel.Name = "memCancel";
            this.memCancel.Size = new System.Drawing.Size(141, 54);
            this.memCancel.Style = Sunny.UI.UIStyle.Custom;
            this.memCancel.Symbol = 61453;
            this.memCancel.TabIndex = 21;
            this.memCancel.Text = "취 소";
            this.memCancel.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // picAdd
            // 
            this.picAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picAdd.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.picAdd.Location = new System.Drawing.Point(498, 290);
            this.picAdd.MinimumSize = new System.Drawing.Size(1, 1);
            this.picAdd.Name = "picAdd";
            this.picAdd.Size = new System.Drawing.Size(55, 31);
            this.picAdd.TabIndex = 23;
            this.picAdd.Text = "추가";
            this.picAdd.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // picDel
            // 
            this.picDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picDel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.picDel.Location = new System.Drawing.Point(567, 290);
            this.picDel.MinimumSize = new System.Drawing.Size(1, 1);
            this.picDel.Name = "picDel";
            this.picDel.Size = new System.Drawing.Size(55, 31);
            this.picDel.TabIndex = 24;
            this.picDel.Text = "삭제";
            this.picDel.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiSmoothLabel1
            // 
            this.uiSmoothLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiSmoothLabel1.Location = new System.Drawing.Point(213, 22);
            this.uiSmoothLabel1.Name = "uiSmoothLabel1";
            this.uiSmoothLabel1.Size = new System.Drawing.Size(257, 49);
            this.uiSmoothLabel1.TabIndex = 25;
            this.uiSmoothLabel1.Text = "회원정보 추가";
            this.uiSmoothLabel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLine1
            // 
            this.uiLine1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiLine1.LineColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.uiLine1.Location = new System.Drawing.Point(76, 97);
            this.uiLine1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLine1.Name = "uiLine1";
            this.uiLine1.Size = new System.Drawing.Size(580, 2);
            this.uiLine1.TabIndex = 26;
            this.uiLine1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // picture
            // 
            this.picture.Image = global::winform1219.Properties.Resources.강아지;
            this.picture.Location = new System.Drawing.Point(498, 135);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(123, 134);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picture.TabIndex = 22;
            this.picture.TabStop = false;
            // 
            // uiLine2
            // 
            this.uiLine2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiLine2.LineColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.uiLine2.Location = new System.Drawing.Point(76, 359);
            this.uiLine2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLine2.Name = "uiLine2";
            this.uiLine2.Size = new System.Drawing.Size(580, 2);
            this.uiLine2.TabIndex = 27;
            this.uiLine2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLine3
            // 
            this.uiLine3.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiLine3.LineColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.uiLine3.Location = new System.Drawing.Point(76, 588);
            this.uiLine3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLine3.Name = "uiLine3";
            this.uiLine3.Size = new System.Drawing.Size(580, 2);
            this.uiLine3.TabIndex = 28;
            this.uiLine3.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // AddUser
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.uiLine3);
            this.Controls.Add(this.uiLine2);
            this.Controls.Add(this.uiLine1);
            this.Controls.Add(this.uiSmoothLabel1);
            this.Controls.Add(this.picDel);
            this.Controls.Add(this.picAdd);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.memCancel);
            this.Controls.Add(this.memAdd);
            this.Controls.Add(this.email3);
            this.Controls.Add(this.email2);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.email1);
            this.Controls.Add(this.uiSymbolLabel9);
            this.Controls.Add(this.tel);
            this.Controls.Add(this.uiSymbolLabel8);
            this.Controls.Add(this.women);
            this.Controls.Add(this.man);
            this.Controls.Add(this.uiSymbolLabel7);
            this.Controls.Add(this.day);
            this.Controls.Add(this.month);
            this.Controls.Add(this.year);
            this.Controls.Add(this.uiSymbolLabel6);
            this.Controls.Add(this.nickname);
            this.Controls.Add(this.uiSymbolLabel5);
            this.Controls.Add(this.name);
            this.Controls.Add(this.passwd1);
            this.Controls.Add(this.uiSymbolLabel3);
            this.Controls.Add(this.uiSymbolLabel2);
            this.Controls.Add(this.passwd2);
            this.Controls.Add(this.uiSymbolLabel4);
            this.Controls.Add(this.id);
            this.Controls.Add(this.uiSymbolLabel1);
            this.Name = "AddUser";
            this.Size = new System.Drawing.Size(708, 772);
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
        private Sunny.UI.UITextBox id;
        private Sunny.UI.UITextBox passwd1;
        private Sunny.UI.UISymbolLabel uiSymbolLabel2;
        private Sunny.UI.UITextBox name;
        private Sunny.UI.UISymbolLabel uiSymbolLabel3;
        private Sunny.UI.UITextBox passwd2;
        private Sunny.UI.UISymbolLabel uiSymbolLabel4;
        private Sunny.UI.UITextBox nickname;
        private Sunny.UI.UISymbolLabel uiSymbolLabel5;
        private Sunny.UI.UISymbolLabel uiSymbolLabel6;
        private Sunny.UI.UIComboBox year;
        private Sunny.UI.UIComboBox month;
        private Sunny.UI.UIComboBox day;
        private Sunny.UI.UISymbolLabel uiSymbolLabel7;
        private Sunny.UI.UIRadioButton man;
        private Sunny.UI.UIRadioButton women;
        private Sunny.UI.UISymbolLabel uiSymbolLabel8;
        private Sunny.UI.UITextBox tel;
        private Sunny.UI.UISymbolLabel uiSymbolLabel9;
        private Sunny.UI.UITextBox email1;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UITextBox email2;
        private Sunny.UI.UIComboBox email3;
        private Sunny.UI.UISymbolButton memAdd;
        private Sunny.UI.UISymbolButton memCancel;
        private System.Windows.Forms.PictureBox picture;
        private Sunny.UI.UIButton picAdd;
        private Sunny.UI.UIButton picDel;
        private Sunny.UI.UISmoothLabel uiSmoothLabel1;
        private Sunny.UI.UILine uiLine1;
        private Sunny.UI.UILine uiLine2;
        private Sunny.UI.UILine uiLine3;
    }
}

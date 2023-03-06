namespace winform1219.ui
{
    partial class SalUser
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
            this.picview = new System.Windows.Forms.PictureBox();
            this.saveImgName = new Sunny.UI.UITextBox();
            this.tbImgName = new Sunny.UI.UITextBox();
            this.cbImgName = new Sunny.UI.UIComboBox();
            this.saveImg = new Sunny.UI.UIButton();
            this.loadImg = new Sunny.UI.UIButton();
            this.uiLine1 = new Sunny.UI.UILine();
            this.uiSmoothLabel1 = new Sunny.UI.UISmoothLabel();
            this.openFileImg = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picview)).BeginInit();
            this.SuspendLayout();
            // 
            // picview
            // 
            this.picview.Location = new System.Drawing.Point(76, 129);
            this.picview.Name = "picview";
            this.picview.Size = new System.Drawing.Size(523, 378);
            this.picview.TabIndex = 0;
            this.picview.TabStop = false;
            // 
            // saveImgName
            // 
            this.saveImgName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.saveImgName.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.saveImgName.Location = new System.Drawing.Point(76, 584);
            this.saveImgName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.saveImgName.MinimumSize = new System.Drawing.Size(1, 16);
            this.saveImgName.Name = "saveImgName";
            this.saveImgName.ShowText = false;
            this.saveImgName.Size = new System.Drawing.Size(150, 29);
            this.saveImgName.TabIndex = 1;
            this.saveImgName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveImgName.Watermark = "";
            this.saveImgName.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // tbImgName
            // 
            this.tbImgName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbImgName.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.tbImgName.Location = new System.Drawing.Point(449, 584);
            this.tbImgName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbImgName.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbImgName.Name = "tbImgName";
            this.tbImgName.ShowText = false;
            this.tbImgName.Size = new System.Drawing.Size(150, 29);
            this.tbImgName.TabIndex = 3;
            this.tbImgName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbImgName.Watermark = "";
            this.tbImgName.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // cbImgName
            // 
            this.cbImgName.DataSource = null;
            this.cbImgName.FillColor = System.Drawing.Color.White;
            this.cbImgName.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.cbImgName.Location = new System.Drawing.Point(449, 533);
            this.cbImgName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbImgName.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbImgName.Name = "cbImgName";
            this.cbImgName.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbImgName.Size = new System.Drawing.Size(150, 29);
            this.cbImgName.TabIndex = 4;
            this.cbImgName.Text = "이미지 선택";
            this.cbImgName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbImgName.Watermark = "";
            this.cbImgName.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.cbImgName.SelectedIndexChanged += new System.EventHandler(this.cbImgName_SelectedIndexChanged);
            // 
            // saveImg
            // 
            this.saveImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveImg.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.saveImg.Location = new System.Drawing.Point(76, 621);
            this.saveImg.MinimumSize = new System.Drawing.Size(1, 1);
            this.saveImg.Name = "saveImg";
            this.saveImg.Size = new System.Drawing.Size(150, 69);
            this.saveImg.TabIndex = 5;
            this.saveImg.Text = "이미지 저장";
            this.saveImg.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.saveImg.Click += new System.EventHandler(this.saveImg_Click);
            // 
            // loadImg
            // 
            this.loadImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loadImg.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.loadImg.Location = new System.Drawing.Point(449, 621);
            this.loadImg.MinimumSize = new System.Drawing.Size(1, 1);
            this.loadImg.Name = "loadImg";
            this.loadImg.Size = new System.Drawing.Size(150, 69);
            this.loadImg.TabIndex = 6;
            this.loadImg.Text = "이미지 불러오기";
            this.loadImg.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.loadImg.Click += new System.EventHandler(this.loadImg_Click);
            // 
            // uiLine1
            // 
            this.uiLine1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiLine1.LineColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.uiLine1.Location = new System.Drawing.Point(57, 104);
            this.uiLine1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLine1.Name = "uiLine1";
            this.uiLine1.Size = new System.Drawing.Size(580, 2);
            this.uiLine1.TabIndex = 28;
            this.uiLine1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiSmoothLabel1
            // 
            this.uiSmoothLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiSmoothLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiSmoothLabel1.Location = new System.Drawing.Point(194, 29);
            this.uiSmoothLabel1.Name = "uiSmoothLabel1";
            this.uiSmoothLabel1.RectColor = System.Drawing.Color.Teal;
            this.uiSmoothLabel1.Size = new System.Drawing.Size(321, 49);
            this.uiSmoothLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiSmoothLabel1.TabIndex = 27;
            this.uiSmoothLabel1.Text = "이미지 저장 / 보기";
            this.uiSmoothLabel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // openFileImg
            // 
            this.openFileImg.FileName = "openFileDialog1";
            // 
            // SalUser
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.uiLine1);
            this.Controls.Add(this.uiSmoothLabel1);
            this.Controls.Add(this.loadImg);
            this.Controls.Add(this.saveImg);
            this.Controls.Add(this.cbImgName);
            this.Controls.Add(this.tbImgName);
            this.Controls.Add(this.saveImgName);
            this.Controls.Add(this.picview);
            this.Name = "SalUser";
            this.Size = new System.Drawing.Size(708, 772);
            this.Load += new System.EventHandler(this.SalUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picview;
        private Sunny.UI.UITextBox saveImgName;
        private Sunny.UI.UITextBox tbImgName;
        private Sunny.UI.UIComboBox cbImgName;
        private Sunny.UI.UIButton saveImg;
        private Sunny.UI.UIButton loadImg;
        private Sunny.UI.UILine uiLine1;
        private Sunny.UI.UISmoothLabel uiSmoothLabel1;
        private System.Windows.Forms.OpenFileDialog openFileImg;
    }
}

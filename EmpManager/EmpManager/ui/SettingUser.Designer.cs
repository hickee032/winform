namespace winform1219.ui
{
    partial class SettingUser
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
            this.uiPieChart1 = new Sunny.UI.UIPieChart();
            this.SuspendLayout();
            // 
            // uiSymbolLabel1
            // 
            this.uiSymbolLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel1.Location = new System.Drawing.Point(250, 231);
            this.uiSymbolLabel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel1.Name = "uiSymbolLabel1";
            this.uiSymbolLabel1.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel1.Size = new System.Drawing.Size(170, 35);
            this.uiSymbolLabel1.TabIndex = 6;
            this.uiSymbolLabel1.Text = "설정 화면";
            this.uiSymbolLabel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiPieChart1
            // 
            this.uiPieChart1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiPieChart1.LegendFont = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.uiPieChart1.Location = new System.Drawing.Point(250, 307);
            this.uiPieChart1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPieChart1.Name = "uiPieChart1";
            this.uiPieChart1.Size = new System.Drawing.Size(209, 235);
            this.uiPieChart1.SubFont = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.uiPieChart1.TabIndex = 5;
            this.uiPieChart1.Text = "df";
            this.uiPieChart1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // SettingUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.uiSymbolLabel1);
            this.Controls.Add(this.uiPieChart1);
            this.Name = "SettingUser";
            this.Size = new System.Drawing.Size(708, 772);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
        private Sunny.UI.UIPieChart uiPieChart1;
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoadingWindow {

    public partial class LoadingWindows : Form {

        delegate void stringPrameterDelegate(string Text);
        delegate void stringPrameterWithStatusDelegate(string Text, TypeOfMessage tom);
        delegate void SplashShowCloseDelegate();

        bool CloseSplashScreenFlag = false;

        public LoadingWindows() {
            InitializeComponent();

            //pictureBox1.Image = System.Drawing.Image.FromFile("");

            //pictureBox1.Image = Properties.Resources.study;

            this.label1.Parent = this.pictureBox1;
            label1.Text = "Wait";
            label1.ForeColor = Color.Green;
        }

        public void ShowSplashScreen() {
            if (InvokeRequired) {
                BeginInvoke(new SplashShowCloseDelegate(ShowSplashScreen));
                return;
            }
            this.Show();
            Application.Run(this);
        }

        public void CloseSplashScreen() {

            if (InvokeRequired) {
                BeginInvoke(new SplashShowCloseDelegate(CloseSplashScreen));
                return;
            }
            CloseSplashScreenFlag = true;
            this.Close();
        }
        public void UpdateStatusText(string Text) {
            if (InvokeRequired) {
                BeginInvoke(new stringPrameterDelegate(UpdateStatusText), new object[] { Text });
                return;
            }
            label1.ForeColor = Color.Green;
            label1.Text = Text;
        }
        public void UpdateStatusTextWithStatus(string Text, TypeOfMessage tom) {
            if (InvokeRequired) {
                BeginInvoke(new stringPrameterWithStatusDelegate(UpdateStatusTextWithStatus), new object[] { Text, tom });
                return;
            }
            switch (tom) {
                case TypeOfMessage.Error:
                    label1.ForeColor = Color.Red;
                    break;
                case TypeOfMessage.Warning:
                    label1.ForeColor = Color.Yellow;
                    break;
                case TypeOfMessage.Success:
                    label1.ForeColor = Color.Green;
                    break;
            }
            label1.Text = Text;
        }
        private void SplashForm_FormClosing(object sender, FormClosingEventArgs e) {
            if (CloseSplashScreenFlag == false) {
                e.Cancel = true;
            }
        }
    }
}

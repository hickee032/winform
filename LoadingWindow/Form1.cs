using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoadingWindow {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();

            int sleepTime = 1000;
            Thread splashthread = new Thread(new ThreadStart(LoadingScreen.ShowSplashScreen));

            splashthread.IsBackground= true;
            splashthread.Start();

            Thread.Sleep(sleepTime);

            LoadingScreen.updateStatusText("Loading 1..");

            try {
                Thread.Sleep(sleepTime);
                LoadingScreen.updateStatusTextWithStatus("Loading 1 ok", TypeOfMessage.Success);
                Thread.Sleep(sleepTime);
            }
            catch (Exception ex) {

                LoadingScreen.updateStatusTextWithStatus("Loading 1 Fail", TypeOfMessage.Error);
            }

            LoadingScreen.updateStatusText("Loading 2..");

            try {
                Thread.Sleep(sleepTime);
                LoadingScreen.updateStatusTextWithStatus("Loading 2 ok", TypeOfMessage.Success);
                Thread.Sleep(sleepTime);
            }
            catch (Exception ex) {

                LoadingScreen.updateStatusTextWithStatus("Loading 2 Fail", TypeOfMessage.Error);
            }

            LoadingScreen.CloseSplashScreen();

        }
    }
}

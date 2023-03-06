using DirectShowLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Test_Media {

    public partial class Form1 : Form {

        string filePath = "C:\\Users\\bluep\\OneDrive\\바탕 화면\\Test_Media\\video\\sample.wmv";

        IGraphBuilder pGrahpBuilder = null;
        IMediaControl pMediaControl = null;

        IMediaEvent pMediaEvent = null;
        EventCode eventCode;

        IVideoWindow pVideoWindow= null;

        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {


            if (button1.Text == "일시정지") {
                pMediaControl.Pause();

                button1.Text = "재생";
            }
            else { 

                Test();
                button1.Text = "일시정지";
            }
         }

        private void Test() {
            this.Text = filePath;
            pGrahpBuilder = (IGraphBuilder)new FilterGraph();

            pMediaControl = (IMediaControl)pGrahpBuilder;

            pMediaEvent = (IMediaEvent)pGrahpBuilder;

            pVideoWindow = (IVideoWindow)pGrahpBuilder;

            pMediaControl.RenderFile(filePath);

            //재생
            pVideoWindow.put_Owner(panel1.Handle);
            pVideoWindow.put_WindowStyle(WindowStyle.Child | WindowStyle.ClipSiblings);
            Rectangle rect = panel1.ClientRectangle;
            pVideoWindow.SetWindowPosition(0,0, rect.Right, rect.Bottom);
            pMediaControl.Run();
            Console.WriteLine(pMediaControl.Run());
            

            
        }

        private void button2_Click(object sender, EventArgs e) {

            Console.WriteLine(pMediaControl.Run());

            Marshal.ReleaseComObject(pGrahpBuilder);
            pGrahpBuilder = null;
            Marshal.ReleaseComObject(pMediaControl);
            pMediaControl = null;
            Marshal.ReleaseComObject(pMediaEvent);
            pMediaEvent = null;
            Marshal.ReleaseComObject(pVideoWindow);
            pVideoWindow = null;
        }
    }
}

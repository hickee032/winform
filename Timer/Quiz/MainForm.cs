using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_04_Quiz_01 {

    public partial class MainForm : Form {

        public MainForm() {
            InitializeComponent();
            MainForm_load();
        }

        private void MainForm_load() {
            timer1.Interval = 1000;
            timer1.Start();  
        }

        private void timer1_Tick(object sender, EventArgs e) {
            timeLabel.Text = DateTime.Now.ToString("T");
        }

        private void button1_MouseHover(object sender, EventArgs e) {
            button1.BackgroundImage = Properties.Resources.HoverSTART;
        }

        private void button1_MouseLeave(object sender, EventArgs e) {
            button1.BackgroundImage = Properties.Resources.START;
        }

        private void button1_MouseDown(object sender, MouseEventArgs e) {
            button1.BackgroundImage = Properties.Resources.PressSTART;
        }

        private void button1_MouseUp(object sender, MouseEventArgs e) {
            button1.BackgroundImage = Properties.Resources.START;
        }

        private void button2_MouseHover(object sender, EventArgs e) {
            button2.BackgroundImage = Properties.Resources.HoverEND;
        }

        private void button2_MouseLeave(object sender, EventArgs e) {
            button2.BackgroundImage = Properties.Resources.END;
        }

        private void button2_MouseUp(object sender, MouseEventArgs e) {
            button2.BackgroundImage = Properties.Resources.END;
        }

        private void button2_MouseDown(object sender, MouseEventArgs e) {
            button2.BackgroundImage = Properties.Resources.PressEND;
        }

        private void button1_Click(object sender, EventArgs e) {
            Quiz_01 quiz1 = new Quiz_01();
            quiz1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e) {
            Application.Exit();
        }


    }
}

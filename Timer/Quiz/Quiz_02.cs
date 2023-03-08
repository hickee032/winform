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
    public partial class Quiz_02 : Form {

        private int score = 0;
        private int timeLimit = 10;

        public Quiz_02() {
            InitializeComponent();
            Quiz_02_load();
        }

        public Quiz_02(int n) {
            InitializeComponent();
            Quiz_02_load();
            score = n;
            label4.Text = score.ToString();
        }

        private void Quiz_02_load() {
            timer1.Interval = 1000;
            timer1.Start();
           
        }

        private void timer1_Tick(object sender, EventArgs e) {

            if (timeLimit == 0) {
                timer1.Stop();
                MessageBox.Show("시간이 초과 되었습니다");
                Close();

            }
            else if (timeLimit > 0) {
                timeLimit--;
                label5.Text = timeLimit.ToString();

            }
        }

        private void button3_Click(object sender, EventArgs e) {
            //다음퀴즈
            Dispose();
            timer1.Stop();
            Quiz_02 quiz2 = new Quiz_02();
            quiz2.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e) {
            timer1.Stop();
            Close();
        }

    }
}

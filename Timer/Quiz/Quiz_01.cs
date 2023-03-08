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

    public partial class Quiz_01 : Form {

        private int score = 0;

        public Quiz_01() {
            InitializeComponent();
            Quiz_01_load();
        }

        private int timeLimit = 10;

        public int Score { get => score; set => score = value; }

        private void Quiz_01_load() {
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

        private void button4_Click(object sender, EventArgs e) {
            timer1.Stop();
            Close();
        }

        private void button3_Click(object sender, EventArgs e) {
            //다음퀴즈
            Dispose();
            timer1.Stop();
            Quiz_02 quiz2 = new Quiz_02(score);
            quiz2.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e) {
            MessageBox.Show("정답입니다\n다음 퀴즈로 갑시다");
            timer1.Stop();
            score += 100;
            Dispose();
            Quiz_02 quiz2 = new Quiz_02(score);
            quiz2.ShowDialog();

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_03_MultiForm {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            Form2 form2 = new Form2();
            form2.ShowDialog(); //modal 방식
        }

        private void button2_Click(object sender, EventArgs e) {
            Form2 form2 = new Form2();
            form2.Show(); //modaless 방식
        }

        private void button3_Click(object sender, EventArgs e) {
            //메세지 박스 버튼
            DialogResult res = MessageBox.Show("메세지 박스 버튼", "MBOX버튼", MessageBoxButtons.OKCancel);

            if (res == DialogResult.OK) {
                Console.WriteLine("YES버튼");
            }
            else {
                Console.WriteLine("NO버튼");
            }
        }

        private void button4_Click(object sender, EventArgs e) {
            DialogResult res = MessageBox.Show("메세지 박스 아이콘", "ICON", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (res ==DialogResult.Yes) {
                Console.WriteLine("YES버튼");
            }
            else if (res == DialogResult.No) {
                Console.WriteLine("NO버튼");
            }
            else {
                Console.WriteLine("CANCEL버튼");
            }
        }

        private void button5_Click(object sender, EventArgs e) {
            //파일 찾기
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Filter = "텍스트 파일(*.txt)|*.txt|모든파일(*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.ShowDialog();
            textBox1.Text = openFileDialog1.FileName;
        }

        private void button7_Click(object sender, EventArgs e) {
            colorDialog1.ShowDialog();
            this.BackColor = colorDialog1.Color;
            //this = form2(자기자신) 를 가리킴
        }

        private void button6_Click(object sender, EventArgs e) {
            colorDialog1.ShowDialog();
            button6.BackColor = colorDialog1.Color;
            button7.BackColor = colorDialog1.Color;
        }
    }
}

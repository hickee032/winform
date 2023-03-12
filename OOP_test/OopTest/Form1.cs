using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OopTest {
    public partial class Form1 : Form {

        DaoOracle ora = new DaoOracle();
        
        public Form1() {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e) {
            string gender = string.Empty;

            if (radioButton1.Checked) { gender = "남자"; }
            else if (radioButton2.Checked) { gender = "여자"; }

            MessageBox.Show($"아이디:{textBox1.Text}\n" +
                $"비밀번호:{textBox2.Text}\n" +
                $"이름:{textBox4.Text}\n" +
                $"별명:{textBox5.Text}\n" +
                $"생년월일:{textBox6.Text}\n" +
                $"성별:{gender}\n" +
                $"전화:{textBox7.Text}");

            ora.insertData(new Member(textBox1.Text, textBox2.Text, textBox4.Text, textBox5.Text, textBox6.Text, gender, textBox7.Text, "Email.com"));
        }

        private void button3_Click(object sender, EventArgs e) {
            Application.Exit();
        }
    }
}

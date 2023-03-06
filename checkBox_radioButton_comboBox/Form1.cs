using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform_02 {
    public partial class Form1 : Form {
        //기본 컨트롤러
        public Form1() {
            InitializeComponent();
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) {
            checkboxLabelChange(checkBox1, label1);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e) {
            checkboxLabelChange(checkBox2, label2);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e) {
            checkboxLabelChange(checkBox3, label3);
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e) {
            checkboxLabelChange(checkBox4, label4);
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e) {
            checkboxLabelChange(checkBox5, label5);
        }

        private void checkboxLabelChange (CheckBox ch, Label label) {
            if (ch.Checked == true) {
                label.Visible = true;
                label.Text = ch.Text;
            }
            else if (ch.Checked == false) {
                label.Visible = false;
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e) {
           // radioButton1.Checked = true;
            pictureBox1.Image = Properties.Resources.cat;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e) {
           // radioButton2.Checked = true;
            pictureBox1.Image = Properties.Resources.dog;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e) {
            //radioButton3.Checked = true;
            pictureBox1.Image = Properties.Resources.bird;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e) {
            //radioButton4.Checked = true;
            pictureBox1.Image = Properties.Resources.horse;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e) {
            //radioButton5.Checked = true;
            pictureBox1.Image = Properties.Resources.dino;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
            int index  = comboBox1.SelectedIndex;
            switch (index) {
                case 0 :
                    pictureBox1.Image = Properties.Resources.cat;
                    break;
                case 1:
                    pictureBox1.Image = Properties.Resources.dog;
                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources.bird;
                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources.horse;
                    break;
                case 4:
                    pictureBox1.Image = Properties.Resources.dino;
                    break;

            }

            Console.WriteLine($"index : {index}");
            Console.WriteLine($"select : {comboBox1.Items[index]}");
            Console.WriteLine($"select : {comboBox1.SelectedItem.ToString()}");
        }

    }
}

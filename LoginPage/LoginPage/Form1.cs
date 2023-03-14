using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginPage {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e) {
            Console.WriteLine(tbxUsername.Text);
            Console.WriteLine(tbxPass.Text);
        }

        private void tbxUsername_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                if (tbxUsername.Text.Length == 0) {
                    MessageBox.Show("Username 비어있습니다");
                }
                else {
                    tbxPass.Focus();
                }
            }
        }
    }
}

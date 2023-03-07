using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayerUI {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            customizeDesing();
        }
        private void customizeDesing() {

            panelMediaSubMenu.Visible = false;
            panelPlaylistSubMenu.Visible = false;
            panelToolsSideMenu.Visible = false;
            //시작시 패널을 안보이게
        }
        private void hideSubmenu() {
            if(panelMediaSubMenu.Visible == true) { 
                panelMediaSubMenu.Visible = false; 
            }

            if(panelPlaylistSubMenu.Visible == true) {
                panelPlaylistSubMenu.Visible = false;   
            }

            if(panelToolsSideMenu.Visible == true) {
                panelToolsSideMenu.Visible = false; 
            }
        }

        private void showSubmenu(Panel subMenu) {
            if(subMenu.Visible == false) {
                hideSubmenu();
                subMenu.Visible = true;
            }
            else {
                subMenu.Visible = false;
            }
        }

        private void btnMedia_Click(object sender, EventArgs e) {
            showSubmenu(panelMediaSubMenu);
        }

        #region MediaSubMenu
        private void button2_Click(object sender, EventArgs e) {
            openChildForm(new Form2());
            
            // My code
            hideSubmenu();
        }

        private void button3_Click(object sender, EventArgs e) {
            // My code
            hideSubmenu();
        }

        private void button4_Click(object sender, EventArgs e) {
            // My code
            hideSubmenu();
        }

        private void button5_Click(object sender, EventArgs e) {
            // My code
            hideSubmenu();
        }
#endregion

        private void btnPlaylist_Click(object sender, EventArgs e) {
            showSubmenu(panelPlaylistSubMenu);
        }

        #region PlaylistSubMenu
        private void button8_Click(object sender, EventArgs e) {
            // My code
            hideSubmenu();
        }

        private void button9_Click(object sender, EventArgs e) {
            // My code
            hideSubmenu();
        }

        private void button7_Click(object sender, EventArgs e) {
            // My code
            hideSubmenu();
        }

        private void button6_Click(object sender, EventArgs e) {
            // My code
            hideSubmenu();
        }
#endregion

        private void btnEqualizer_Click(object sender, EventArgs e) {
            openChildForm(new Form3());
            // My code
            hideSubmenu();
        }

        private void btnTools_Click(object sender, EventArgs e) {
            showSubmenu(panelToolsSideMenu);
        }

        #region ToolSubMenu
        private void button14_Click(object sender, EventArgs e) {
            // My code
            hideSubmenu();
        }

        private void button13_Click(object sender, EventArgs e) {
            // My code
            hideSubmenu();
        }

        private void button12_Click(object sender, EventArgs e) {
            // My code
            hideSubmenu();
        }

        private void button11_Click(object sender, EventArgs e) {
            // My code
            hideSubmenu();
        }
#endregion

        private void btnHelp_Click(object sender, EventArgs e) {
            // My code
            hideSubmenu();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm) {
            if(activeForm != null) {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle= FormBorderStyle.None;
            childForm.Dock= DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag= childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}

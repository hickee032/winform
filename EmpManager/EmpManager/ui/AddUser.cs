using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using winform1219.model;
using winform1219.adapter;
using winform1219.dao;

namespace winform1219.ui
{
    partial class AddUser : UserControl
    {
        BaseAdapter ba;
        public AddUser()
        {
            InitializeComponent();
            for (int i=1940; i<=2023; i++)
            {
                year.Items.Add(i.ToString()+"년");
            }            
            for (int i=1; i<=31; i++)
            {
                day.Items.Add(i.ToString()+"일");
            }
        }

        public AddUser(BaseAdapter ba)
        {
            InitializeComponent();
            this.ba = ba;
            for (int i = 2023; i >= 1940; i--)
            {
                year.Items.Add(i.ToString() + "년");
            }
            for (int i = 1; i <= 31; i++)
            {
                day.Items.Add(i.ToString() + "일");
            }
        }

        private void email3_SelectedIndexChanged(object sender, EventArgs e)
        {
            email2.Text = email3.SelectedItem.ToString();
        }

        private void memAdd_Click(object sender, EventArgs e)
        {
            //DaoOra ora = DaoOra.getInst();
            DaoOra ora = ba.Ora;
            string gender = string.Empty;
            if (man.Checked) { gender = "남자"; }
            else if (women.Checked) { gender = "여자"; }
            string birth = year.SelectedItem.ToString() +
                month.SelectedItem.ToString() +
                day.SelectedItem.ToString();
            string email = email1.Text + "@" + email2.Text;
            // 1. 생성자 오버로딩
            // 2. 싱글톤
            ora.insertData(new Member(id.Text, passwd2.Text,
                name.Text, nickname.Text, birth,
                gender, tel.Text, email));
            MessageBox.Show("사원정보가 저장되었습니다.");
        }
    }
}

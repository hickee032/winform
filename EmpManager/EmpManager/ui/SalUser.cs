using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using winform1219.adapter;
using winform1219.dao;

namespace winform1219.ui
{
    partial class SalUser : UserControl
    {
        BaseAdapter ba;
        public SalUser()
        {
            InitializeComponent();
        }

        public SalUser(BaseAdapter ba)
        {
            InitializeComponent();
            this.ba = ba;
        }

        private void saveImg_Click(object sender, EventArgs e)
        {
            DaoOra ora = ba.Ora;
            openFileImg.InitialDirectory = @"C:\";
            openFileImg.Filter = "jpeg 파일(*.jpg)|*.jpg|" +
                "png 파일(*.png)|*.png|" +
                "gif 파일(*.gif)|*.gif|" +
                "모든 파일(*.*)|*.*";
            openFileImg.FilterIndex = 0;
            openFileImg.RestoreDirectory = true;
            openFileImg.ShowDialog();
            string imgPath = openFileImg.FileName;
            saveImgName.Text =
                Path.GetFileNameWithoutExtension(imgPath);
            Image img = Image.FromFile(imgPath);
            picview.SizeMode = PictureBoxSizeMode.StretchImage;
            picview.Image = img;
            ora.saveImg(saveImgName.Text, openFileImg.FileName);
            List<string> list = ora.getImgName();
            cbImgName.Items.Clear();
            foreach (var n in list) cbImgName.Items.Add(n);
            cbImgName.Text = "이미지 선택";
            tbImgName.Text = "";
        }

        private void loadImg_Click(object sender, EventArgs e)
        {
            DaoOra ora = ba.Ora;
            if (tbImgName.Text == "")
            {
                MessageBox.Show("불러올 이미지를 선택하세요");
                return;
            }
            ora.getImg(picview, tbImgName.Text);
        }

        private void SalUser_Load(object sender, EventArgs e)
        {
            DaoOra ora = ba.Ora;
            List<string> list = ora.getImgName();
            foreach (var n in list) cbImgName.Items.Add(n);
        }

        private void cbImgName_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbImgName.Text = cbImgName.SelectedItem.ToString();
        }
    }
}

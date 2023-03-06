using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.ModelBinding;
using System.Windows.Forms;
using winform1219.adapter;
using winform1219.dao;
using winform1219.model;
using winform1219.util;

namespace winform1219.ui
{
    partial class ViewUser : UserControl
    {
        BaseAdapter ba;
        string originName;
        public ViewUser()
        {
            InitializeComponent();
        }

        public ViewUser(BaseAdapter ba)
        {
            InitializeComponent();
            this.ba = ba;
        }

        private void initTListView()
        {
            for (int i=0; i<100; i++)
            {
                memLView.Items.Add(new ListViewItem(
                    new string[]
                    {
                        (i+1).ToString(), "홍길동", "홍두께",
                        "1945년8월15일", "남자", 
                        "010-1234-4567", "hong@naver.com"
                    }));
            }            
        }

        private void initListView()
        {
            // DB에서 가져온 데이터 출력
            //DaoOra ora = DaoOra.getInst();
            DaoOra ora = ba.Ora;
            List<Member> list = ora.dataShow();            
            updateListView(list);
            /*
            int index = memLView.Items.Count - 1;
            memLView.Items[index].Selected = true;
            memLView.Items[index].Focused = true;
            memLView.EnsureVisible(index);
            */
        }

        private void initGridView()
        {
            DaoOra ora = ba.Ora;
            List<Member> list = ora.dataShow();
            updateGridView(list);
        }



        private void ViewUser_Load(object sender, EventArgs e)
        {
            //initTListView();
            initListView();
            initGridView();
        }

        private void memLView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (memLView.SelectedItems.Count != 0)
            {
                int n = memLView.SelectedItems[0].Index;
                string num = memLView.Items[n].SubItems[0].Text;
                string name = memLView.Items[n].SubItems[1].Text;
                string nickName = memLView.Items[n].SubItems[2].Text;
                string birth = memLView.Items[n].SubItems[3].Text;
                string gender = memLView.Items[n].SubItems[4].Text;
                string tel = memLView.Items[n].SubItems[5].Text;
                string email = memLView.Items[n].SubItems[6].Text;
                Console.WriteLine("번호:" + num);
                Console.WriteLine("이름:" + name);
                Console.WriteLine("별명:" + nickName);
                Console.WriteLine("생일:" + birth);
                modName.Text = name;
                modNick.Text = nickName;
                modBirth.Text = birth;
                modGender.Text = gender;
                modTel.Text = tel;
                modEmail.Text = email;
                originName = name;
            }
        }

        private void modUpdate_Click(object sender, EventArgs e)
        {
            List<Member> list = null;
            DaoOra ora = ba.Ora;
            if (ora != null)
            {
                list = ora.updateData(originName,
                    new Member(modName.Text, modNick.Text,
                        modBirth.Text, modGender.Text,
                        modTel.Text, modEmail.Text));
            }
            updateListView(list);
        }

        private void updateListView(List<Member> list)
        {
            memLView.BeginUpdate();
            memLView.Items.Clear();
#if true
            for (int i = 0; i < list.Count; i++)
            {
                memLView.Items.Add(new ListViewItem(
                    new string[]
                    {
                        (i+1)+"",
                        list[i].Name,
                        list[i].NickName,
                        list[i].Birth,
                        list[i].Gender,
                        list[i].Tel,
                        list[i].Email
                    }));
            }
#else
            int num = 1;
            foreach(var n in list)
            {
                memLView.Items.Add(new ListViewItem(
                    new string[]
                    {
                        (num++).ToString(),
                        n.Name,
                        n.NickName,
                        n.Birth,
                        n.Gender,
                        n.Tel,
                        n.Email
                    }));
            }
#endif
            CommUtil.setRowColor(memLView,
                Color.LightGray, Color.Ivory);
            memLView.EndUpdate();
        }

        private void updateGridView(List<Member> list)
        {
            int cnt = 1;
            foreach(var item in list)
            {
                memGView.Rows.Add(new string[]
                {
                    cnt++.ToString(),
                    item.Name, item.NickName, item.Birth,
                    item.Gender, item.Tel, item.Email
                });
            }
        }
        
        private void memGView_SelectIndexChange(object sender, int index)
        {
            // AllowUserToAddRows 속성값 true일 경우 사용
            // if ((memGView.Rows.Count - 1) == index) return;
            Console.WriteLine("cnt:"+memGView.Rows.Count);
            Sunny.UI.UITextBox[] textArr = {
                null, modName, modNick, modBirth, 
                modGender, modTel, modEmail };
            const int COL = 7;
            for (int i = 0; i < COL; i++)
            {
                string gdata = memGView.Rows[index].Cells[i].Value.ToString();
                Console.WriteLine(gdata);
                if (textArr[i] != null) textArr[i].Text = gdata;
            }
            Console.WriteLine("---------------------");
        }
    }
}

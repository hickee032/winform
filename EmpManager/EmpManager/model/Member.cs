using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winform1219.model
{
    internal class Member
    {
        string id;
        string passwd;
        string name;
        string nickName;
        string birth;
        string gender;
        string tel;
        string email;

        public Member(string name, string nickName,
            string birth, string gender,
            string tel, string email)
        {
            this.name = name;
            this.nickName = nickName;
            this.birth = birth;
            this.gender = gender;
            this.tel = tel;
            this.email = email;
        }

        public Member(string id, string passwd,
            string name, string nickName,
            string birth, string gender,
            string tel, string email)
        {
            this.id = id;
            this.passwd = passwd;
            this.name = name;
            this.nickName = nickName;
            this.birth = birth;
            this.gender = gender;
            this.tel = tel;
            this.email = email;
        }

        public string Id { get => id; set => id = value; }
        public string Passwd { get => passwd; set => passwd = value; }
        public string Name { get => name; set => name = value; }
        public string NickName { get => nickName; set => nickName = value; }
        public string Birth { get => birth; set => birth = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Tel { get => tel; set => tel = value; }
        public string Email { get => email; set => email = value; }
    }
}

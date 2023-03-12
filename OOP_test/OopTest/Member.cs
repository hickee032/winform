using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopTest {
    internal class Member {
        //모델 클래스
        //멤버를 변수로 
        string id, passwd, name, nick, birth, gender, tel, email;


        public Member(string id, string passwd, string name, string nick, string birth, string gender, string tel, string email) {
            this.id = id;
            this.passwd = passwd;
            this.name = name;
            this.nick = nick;
            this.birth = birth;
            this.gender = gender;
            this.tel = tel;
            this.email = email;
        }

        public string Id { get => id; set => id = value; }
        public string Passwd { get => passwd; set => passwd = value; }
        public string Name { get => name; set => name = value; }
        public string Nick { get => nick; set => nick = value; }
        public string Birth { get => birth; set => birth = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Tel { get => tel; set => tel = value; }
        public string Email { get => email; set => email = value; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform_01 {
    //Partial Class -- 클래스, 구조체, 인터페이스 또는 메서드의 정의를 둘 이상의 소스 파일에 분할할때
    public partial class Form1 : Form {
        DateTime curDt;


        //Form1 : Form -- 상속
        public Form1() {
            InitializeComponent();
            curDt = DateTime.Now;
            Console.WriteLine(curDt);
            
        }

        private void button1_Click(object sender, EventArgs e) {
            //button1 컨트롤과 button1_Click 이벤트 핸들러 연결시킴 ->클릭 이벤트를 감지
           // MessageBox.Show(getNowTime().ToString());
            button2.Text = getNowTime().ToString();
            
        }


        public DateTime getNowTime() {
            return DateTime.Now;
        }

        private void button3_Click(object sender, EventArgs e) {

            Console.WriteLine(textBox1.Text);
            //textBox에 입력된 정보를 Label에 출력
            label1.Text = textBox1.Text;
        }

        private void timer1_Tick(object sender, EventArgs e) {
            //1초마다 호출되어짐
            label2.Text= getNowTime().ToString();
            //timer1 객체는 반드시 스타트를 시켜줘야함 -> 속성 > enabled > true 또는 
            //timer1.Start();
        }

        //실시간 시간 정보 라벨에 출력


    }
}

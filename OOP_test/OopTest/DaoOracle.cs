using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OopTest {
    internal class DaoOracle {

        //생성자
        public DaoOracle() {

            conn = new OracleConnection(ORA_ADDR);
            cmd = new OracleCommand();
            connectDB();
        }

        //파괴자
        ~DaoOracle() { 
            disconnectDB(); 
        }


        string ORA_ADDR =
            "Data Source=(DESCRIPTION=(ADDRESS_LIST=" +
            "(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)" +
            "(PORT=1521)))" +
            "(CONNECT_DATA=(SERVER=DEDICATED)" +
            "(SERVICE_NAME=XE)));" +
            "User Id=test;Password=1234;";
        // 오라클 접속, sql명령어 객체 생성
        OracleConnection conn;
        OracleCommand cmd;

        public void connectDB() {
            // try ~ catch : 객체지향 프로그래밍에서 예외처리
            try {
                conn.Open(); // db 접속
                Console.WriteLine("오라클 접속 성공!");
            }
            catch (OracleException e) {
                Console.WriteLine("접속에러: " + e.Message);
            }
        }

        public void disconnectDB() {
            try {
                if (conn != null) {
                    conn.Close();
                    Console.WriteLine("오라클 해제 성공!");
                }
            }
            catch (OracleException e) {
                Console.WriteLine("종료 에러:" + e.Message);
            }
        }

        public void insertData(Member me) {
            Console.WriteLine("테이블 데이터 추가");

            try {

                string sql = string.Format("insert into join_t values(" +
                    "'{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')", me.Id,me.Passwd, me.Name, me.Nick, me.Birth, me.Gender, me.Tel,me.Email);

                Console.WriteLine(sql);

                cmd.Transaction = conn.BeginTransaction();

                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();

                cmd.Transaction.Commit();
            }
            catch (Exception e) {

                Console.WriteLine("데이터 추가 오류 : " + e.Message);
            }
        }
    }
}

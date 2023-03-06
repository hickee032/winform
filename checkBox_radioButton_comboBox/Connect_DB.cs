using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winform_02 {
    internal class Connect_DB {

        static string ORA_ADDR =
            "Data Source=(DESCRIPTION=(ADDRESS_LIST=" +
            "(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)" +
            "(PORT=1521)))" +
            "(CONNECT_DATA=(SERVER=DEDICATED)" +
            "(SERVICE_NAME=XE)));" +
            "user Id=test;Password=1234;";

        static OracleConnection conn = new OracleConnection(ORA_ADDR);
        static OracleCommand cmd = new OracleCommand();

        public Connect_DB() {
            connectDB();
        }

        static void connectDB() {
            try {
                conn.Open(); //DB 접속
                Console.WriteLine("오라클 DB 접속 성공");
            }
            catch (OracleException oe) {
                Console.WriteLine("오라클 DB 접속 에러 : " + oe.Message);
            }
        }

        static void disconnectDB() {
            try {
                if (conn != null) {
                    conn.Close(); //DB 접속 해제
                    Console.WriteLine("오라클 DB 접속 해제");
                }
            }
            catch (OracleException oe) {

                Console.WriteLine("오라클 DB 접속 해제 오류 : " + oe.Message);
            }


        }

        static void createTable() {          
            Console.WriteLine("테이블 생성");
            try {
                //사용할 SQL문 -> 문자열
                string sql = "create table login(" +
                             "id varchar2(20) primary key," +
                             "pass varchar2(20) not null," +
                             "name varchar2(20) not null," +
                             "gender varchar2(5) not null," +
                             "email varchar2(20) not null," +
                             "addr varchar2(20) not null," +
                             "call varchar2(20) not null," +
                             "intro varchar2(50) not null)";

                cmd.Transaction = conn.BeginTransaction();

                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                cmd.Transaction.Commit();

            }
            catch (OracleException e) {

                Console.WriteLine("테이블 생성 오류 :" + e.Message);

                cmd.Transaction.Rollback();
            }
        }
        static void insertTable(string id,string pass, string name, string gender, string email, string addr, string call, string intro) {
            Console.WriteLine("테이블 데이터 추가");

            try {
              
                string sql = string.Format("insert into stud_t values(" +
                    "{0},'{1}',{2},'{3}','{4}',{5},'{6}','{7}',{8})",id,pass,name,gender,email,addr,call,intro);

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

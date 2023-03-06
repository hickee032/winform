using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using winform1219.model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace winform1219.dao
{
    internal class DaoOra
    {
        string ORA_ADDR =
            "Data Source=(DESCRIPTION=(ADDRESS_LIST=" +
            "(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)" +
            "(PORT=1521)))" +
            "(CONNECT_DATA=(SERVER=DEDICATED)" +
            "(SERVICE_NAME=XE)));" +
            //"User Id=c##scott;Password=1234;";
            "User Id=test;Password=1234;";
        // 오라클 접속, sql명령어 객체 생성
        OracleConnection conn;
        OracleCommand cmd;

        static DaoOra inst;

        public static DaoOra getInst()
        {
            if (inst == null)
            {
                inst = new DaoOra();
            }
            return inst;
        }
        public DaoOra()
        {
            conn = new OracleConnection(ORA_ADDR);
            cmd = new OracleCommand();
            connectDB();
        }

        ~DaoOra()
        {
            disconnectDB();
        }

        public void connectDB()
        {
            // try ~ catch : 객체지향 프로그래밍에서 예외처리
            try
            {
                conn.Open(); // db 접속
                Console.WriteLine("오라클 접속 성공!");
            }
            catch (OracleException e)
            {
                Console.WriteLine("접속에러: " + e.Message);
            }
        }

        public void disconnectDB()
        {
            try
            {
                if (conn != null)
                {
                    conn.Close();
                    Console.WriteLine("오라클 해제 성공!");
                }
            }
            catch (OracleException e)
            {
                Console.WriteLine("종료 에러:" + e.Message);
            }
        }

        public void insertData(string id, string passwd, string name, string nick,
            string birth, string gender, string tel)
        {
            try
            {
                string sql = "insert into join_t values " +
                    $"('{id}', '{passwd}', '{name}', '{nick}', " +
                    $"'{birth}', '{gender}', '{tel}', '이메일')";
                cmd.Transaction = conn.BeginTransaction();
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                cmd.Transaction.Commit();
                Console.WriteLine("데이터 추가 성공!");
            }
            catch (OracleException e)
            {
                Console.WriteLine("데이터 추가:" + e.Message);
                cmd.Transaction.Rollback();
            }
        }

        public void insertData(Member mem)
        {
            try
            {
                string sql = "insert into join_t values " +
                    $"('{mem.Id}', '{mem.Passwd}', '{mem.Name}', " +
                    $"'{mem.NickName}', '{mem.Birth}', '{mem.Gender}', " +
                    $"'{mem.Tel}', '{mem.Email}')";
                cmd.Transaction = conn.BeginTransaction();
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                cmd.Transaction.Commit();
                Console.WriteLine("데이터 추가 성공!");
            }
            catch (OracleException e)
            {
                Console.WriteLine("데이터 추가 Err:" + e.Message);
                cmd.Transaction.Rollback();
            }
        }

        public List<Member> dataShow()
        {
            string query = "select * from join_t";
            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            List<Member> memList = new List<Member>();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    //Console.WriteLine($"ID:{dr["id"]}");
                    //Console.WriteLine($"이름:{dr["name"]}");
                    //Console.WriteLine($"별명:{dr["nick_name"]}");
                    //Console.WriteLine($"생년월일:{dr["birth"]}");
                    //Console.WriteLine($"성별:{dr["gender"]}");
                    //Console.WriteLine($"전화번호:{dr["tel"]}");
                    //Console.WriteLine($"이메일:{dr["email"]}");
                    //Console.WriteLine("-------------------");
                    memList.Add(new Member(
                        dr["name"].ToString(),
                        dr["nick_name"].ToString(), 
                        dr["birth"].ToString(),
                        dr["gender"].ToString(), 
                        dr["tel"].ToString(), 
                        dr["email"].ToString()));
                }
            }
            else
            {
                Console.WriteLine("데이터가 존재하지 않음!");
            }
            dr.Close();
            return memList;
        }

        public List<Member> updateData(string name, Member mem)
        {
            try
            {
                string sql = "update join_t set " +
                    $"name='{mem.Name}', " +
                    $"nick_name='{mem.NickName}', " +
                    $"birth='{mem.Birth}', " +
                    $"gender='{mem.Gender}', " +
                    $"tel='{mem.Tel}', " +
                    $"email='{mem.Email}'" +
                    $"where name='{name}'";
                cmd.Transaction = conn.BeginTransaction();
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                cmd.Transaction.Commit();
                Console.WriteLine("데이터 수정 성공!");
            }
            catch (OracleException e)
            {
                Console.WriteLine("데이터 수정 Err:" + e.Message);
                cmd.Transaction.Rollback();
            }
            List<Member> list = dataShow();
            return list;
        }

        public void saveImg(string name, string path)
        {            
            string sql = $"insert into saveimg_t " +
                $"values ('{name}', :image)";
            try
            {
                cmd.Connection = conn;
                cmd.Transaction = conn.BeginTransaction();
                cmd.CommandText = sql;
                FileStream fs = 
                    new FileStream(path, FileMode.Open, 
                        FileAccess.Read);
                byte[] buffer = new byte[fs.Length-1];
                fs.Read(buffer, 0, buffer.Length);
                fs.Close();
                OracleParameter op =
                    new OracleParameter();
                op.ParameterName = ":image";
                op.OracleDbType = OracleDbType.Blob;
                op.Direction = ParameterDirection.Input;
                op.Size= buffer.Length;
                op.Value = buffer;
                cmd.Parameters.Add(op);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                cmd.Transaction.Commit();
                Console.WriteLine("이미지 추가 성공!");
            }
            catch (OracleException e)
            {
                Console.WriteLine("이미지 추가 Err:" + e.Message);
                cmd.Transaction.Rollback();
            }

        }

        public List<string> getImgName()
        {
            cmd.Connection = conn;
            cmd.CommandText = "select filename from saveimg_t";
            cmd.CommandType= CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            List<string> list = new List<string>();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    list.Add(dr["filename"].ToString());
                }
            }
            else
            {
                Console.WriteLine("데이터가 존재하지 않음!");
            }
            dr.Close();
            return list;
        }

        public void getImg(PictureBox pic, string name)
        {
            cmd.Connection= conn;
            cmd.CommandText = "select * from saveimg_t " +
                $"where filename='{name}'";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    byte[] byteData = (byte[])dr["image"];
                    if (byteData.Length > 0)
                    {
                        MemoryStream ms = new MemoryStream(byteData);
                        pic.Image = Image.FromStream(ms);
                    }
                    else
                    {
                        pic.Image = null;
                    }
                }
            }
            else
            {
                Console.WriteLine("데이터가 존재하지 않음!");
            }
            dr.Close();
        }
    }
}

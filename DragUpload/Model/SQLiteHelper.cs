using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SQLite;
using System.Linq;
using System.Text;

namespace DragUpload.Model
{
    public class SQLiteHelper
    {
        /// <summary>
        /// ConnectionString样例：Data Source=Test.db3;Pooling=true;FailIfMissing=false
        /// </summary>
        public static string ConnectionString { get; set; }

        private static void PrepareCommand(SQLiteCommand cmd, SQLiteConnection conn, string cmdText, params object[] p)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            cmd.Parameters.Clear();
            cmd.Connection = conn;
            cmd.CommandText = cmdText;
            cmd.CommandType = CommandType.Text;
            cmd.CommandTimeout = 30;
            if (p != null)
            {
                foreach (object parm in p)
                    cmd.Parameters.AddWithValue(string.Empty, parm);
            }
        }


        public static void CreateTable()
        {
            ExecuteNonQuery(@"CREATE TABLE IF NOT EXISTS Img 
(
id integer PRIMARY KEY AUTOINCREMENT,
name varchar(100),
url varchar(255),
deletion varchar(255)
)");
        }



        public static DataTable GetData()
        {
            return ExecuteDataTable("select * from Img");
        }

        public static void Test()
        {
            var dat = ExecuteDataTable("select * from Img");
        }


        public static void Add(ImgRecord data)
        {
            SQLiteParameter[] parameter = new SQLiteParameter[] {
                new SQLiteParameter("@name",DbType.String),
                new SQLiteParameter("@url",DbType.String),
                new SQLiteParameter("@deletion",DbType.String)
            };

            parameter[0].Value = data.name;
            parameter[1].Value = data.url;
            parameter[2].Value = data.deleteUrl;

            string sql = "INSERT INTO Img VALUES (NULL,@name,@url,@deletion);";

            ExecuteNonQuery(sql, parameter);

        }

        public static void Remove(int id)
        {
            SQLiteParameter[] parameter = new SQLiteParameter[] {
                new SQLiteParameter("@id",DbType.Int32)
            };

            parameter[0].Value = id;

            ExecuteNonQuery("DELETE FROM Img WHERE id = @id", parameter);
        }


        /// <summary> 
        /// 对 SQLite 数据库执行增删改操作，返回受影响的行数。 
        /// </summary> 
        /// <param name="sql"> 要执行的增删改的 SQL 语句 </param> 
        /// <param name="parameters"> 执行增删改语句所需要的参数，参数必须以它们在 SQL 语句中的顺序为准 </param> 
        /// <returns></returns> 
        public static int ExecuteNonQuery(string sql, SQLiteParameter[] parameters = null)
        {
            int affectedRows = 0;
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                using (DbTransaction transaction = connection.BeginTransaction())
                {
                    using (SQLiteCommand command = new SQLiteCommand(connection))
                    {
                        command.CommandText = sql;
                        if (parameters != null)
                        {
                            command.Parameters.AddRange(parameters);
                        }
                        affectedRows = command.ExecuteNonQuery();
                    }
                    transaction.Commit();
                }
            }
            return affectedRows;
        }



        /// <summary> 
        /// 执行一个查询语句，返回一个包含查询结果的 DataTable 
        /// </summary> 
        /// <param name="sql"> 要执行的查询语句 </param> 
        /// <param name="parameters"> 执行 SQL 查询语句所需要的参数，参数必须以它们在 SQL 语句中的顺序为准 </param> 
        /// <returns></returns> 
        public static DataTable ExecuteDataTable(string sql, SQLiteParameter[] parameters = null)
        {
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                {
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                    DataTable data = new DataTable();
                    adapter.Fill(data);
                    return data;
                }
            }

        }


        public static void test()
        {


            using (SQLiteConnection conn = new SQLiteConnection(ConnectionString))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    if (conn.State != ConnectionState.Open)
                        conn.Open();

                    cmd.Connection = conn;
                    //                    cmd.CommandText = @"
                    //
                    //INSERT INTO Book(ID, BookName) VALUES(1, '飞狐外传')
                    //
                    //";



                    //cmd.CommandText = "drop table Book";
                    cmd.CommandText = "select * from Book";
                    cmd.CommandType = CommandType.Text;

                    //int i = cmd.ExecuteNonQuery();

                    SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                    DataSet ds = new DataSet();

                    da.Fill(ds);

                }
            }





        }

        public static DataSet ExecuteQuery(string cmdText, params object[] p)
        {
            using (SQLiteConnection conn = new SQLiteConnection(ConnectionString))
            {
                using (SQLiteCommand command = new SQLiteCommand())
                {
                    DataSet ds = new DataSet();
                    PrepareCommand(command, conn, cmdText, p);
                    SQLiteDataAdapter da = new SQLiteDataAdapter(command);
                    da.Fill(ds);
                    return ds;
                }
            }
        }

        //public static int ExecuteNonQuery(string cmdText, params object[] p)
        //{
        //    using (SQLiteConnection conn = new SQLiteConnection(ConnectionString))
        //    {
        //        using (SQLiteCommand command = new SQLiteCommand())
        //        {
        //            PrepareCommand(command, conn, cmdText, p);
        //            return command.ExecuteNonQuery();
        //        }
        //    }
        //}

        public static SQLiteDataReader ExecuteReader(string cmdText, params object[] p)
        {
            using (SQLiteConnection conn = new SQLiteConnection(ConnectionString))
            {
                using (SQLiteCommand command = new SQLiteCommand())
                {
                    PrepareCommand(command, conn, cmdText, p);
                    return command.ExecuteReader(CommandBehavior.CloseConnection);
                }
            }
        }

        public static object ExecuteScalar(string cmdText, params object[] p)
        {
            using (SQLiteConnection conn = new SQLiteConnection(ConnectionString))
            {
                using (SQLiteCommand command = new SQLiteCommand())
                {
                    PrepareCommand(command, conn, cmdText, p);
                    return command.ExecuteScalar();
                }
            }
        }

    }
}

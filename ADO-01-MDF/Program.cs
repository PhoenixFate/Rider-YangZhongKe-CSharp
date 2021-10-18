using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_01_MDF
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            String dataDir = AppDomain.CurrentDomain.BaseDirectory;
            Console.WriteLine(dataDir);
            Console.WriteLine(dataDir.EndsWith(@"\bin\Debug\"));
            if (dataDir.EndsWith(@"\bin\Debug\") || dataDir.EndsWith(@"\bin\Release\"))
            {
                dataDir = System.IO.Directory.GetParent(dataDir).Parent.Parent.FullName;
                Console.WriteLine(dataDir);
                AppDomain.CurrentDomain.SetData("DataDirectory", dataDir);
                Object temp = AppDomain.CurrentDomain.GetData("DataDirectory");
                Console.WriteLine(temp.ToString());
            }

            string address1 =
                @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";

            //老式
            try
            {
            }
            catch (Exception e)
            {
            }
            finally
            {
                //conn.Close(); //关闭之后还可以open
                //conn.Dispose(); //销毁，不能再次使用
            }

            //新式
            //使用using，会自动dispose，并且dispose内部会自动判断是否close，如果没有close，会close
            using (SqlConnection connection = new SqlConnection(address1))
            {
                connection.Open();
                Console.WriteLine("连接数据库成功！");
                using (SqlCommand sqlCommand = connection.CreateCommand())
                {
                    //新增修改删除ExecuteNonQuery
                    sqlCommand.CommandText = "Update Student set Name=N'rider骑手' where id=3";
                    int affectCount = sqlCommand.ExecuteNonQuery();
                    Console.WriteLine("更新的行数: " + affectCount);

                    sqlCommand.CommandText = "Insert into Student(Name) output inserted.Id values('骑手')";
                    int id = Convert.ToInt32(sqlCommand.ExecuteScalar());
                    Console.WriteLine("插入返回的id: " + id);

                    sqlCommand.CommandText = "delete Student where id=" + id;
                    affectCount = sqlCommand.ExecuteNonQuery();
                    Console.WriteLine("删除的行数: " + affectCount);

                    //ExecuteScalar()返回第一行第一列数据
                    sqlCommand.CommandText = "select count(*) from Student";
                    int totalCount = Convert.ToInt32(sqlCommand.ExecuteScalar());
                    Console.WriteLine("总行数: " + totalCount);

                    //返回数组
                    sqlCommand.CommandText = "select * from Student";
                    using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                    {
                        while (sqlDataReader.Read())
                        {
                            int studentId = sqlDataReader.GetInt32(0);
                            String studentName = sqlDataReader.GetString(1);
                            Console.WriteLine("学生Id: {0}, 姓名: {1}", studentId, studentName);
                            studentId = sqlDataReader.GetInt32(sqlDataReader.GetOrdinal("id"));
                            studentName = sqlDataReader.GetString(sqlDataReader.GetOrdinal("Name"));
                            Console.WriteLine("学生Id: {0}, 姓名: {1}", studentId, studentName);
                        }
                    }
                }
            }
        }
    }
}
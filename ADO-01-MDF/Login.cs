using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_01_MDF
{
    class Login
    {
        static void Main2(string[] args)
        {
            Console.WriteLine("login");
            String dataDir = AppDomain.CurrentDomain.BaseDirectory;
            if (dataDir.EndsWith(@"\bin\Debug\") || dataDir.EndsWith(@"\bin\Release\"))
            {
                dataDir = System.IO.Directory.GetParent(dataDir).Parent.Parent.FullName;
                AppDomain.CurrentDomain.SetData("DataDirectory", dataDir);
            }
            string address1 = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";

            Console.WriteLine("请输入用户名: ");
            string username = Console.ReadLine();
            Console.WriteLine("用户名: {0}", username);
            Console.WriteLine("请输入密码: ");
            string password = Console.ReadLine();
            Console.WriteLine("密码: {0}", password);
            //新式
            using (SqlConnection conn = new SqlConnection(address1))
            {
                //会自动释放资源
                conn.Open();
                Console.WriteLine("连接数据库成功！");
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select * from Tb_User where Username='"+username+"'";
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            //用户名存在
                            String originalPassword = reader.GetString(reader.GetOrdinal("Password"));
                            if (originalPassword.Equals(password))
                            {
                                //密码一致，登录成功！
                            }else
                            {
                                Console.WriteLine("密码错误！");
                            }
                        }else
                        {
                            //用户名不存在
                            Console.WriteLine("用户名不存在!");
                        }
                    }
                    cmd.CommandText = "select count(*) from tb_user";
                    //ExecuteScalar() 返回第一行第一列的数据
                    int count=Convert.ToInt32(cmd.ExecuteScalar());
                    Console.WriteLine("总共多少行数据： " + count);
                }
                Console.ReadLine();
            }

        }
    }
}

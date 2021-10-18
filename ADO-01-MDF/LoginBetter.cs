using System;
using System.Data.SqlClient;

namespace ADO_01_MDF
{
    public class LoginBetter
    {
        static void Main3(string[] args)
        {
            String baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            if(baseDirectory.EndsWith(@"\bin\Debug\") || baseDirectory.EndsWith(@"\bin\Release\"))
            {
                baseDirectory = System.IO.Directory.GetParent(baseDirectory).Parent.Parent.FullName;
                AppDomain.CurrentDomain.SetData("DataDirectory",baseDirectory);
            }
            string address1 = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";
            Console.WriteLine("请输入用户名: ");
            string username = Console.ReadLine();
            Console.WriteLine("请输入密码: ");
            string password = Console.ReadLine();
            using (SqlConnection sqlConnection = new SqlConnection(address1))
            {
                sqlConnection.Open();
                using (SqlCommand sqlCommand = sqlConnection.CreateCommand())
                {
                    sqlCommand.CommandText =
                        "select count(*) from Tb_User where username=@username and password=@password";
                    sqlCommand.Parameters.Add(new SqlParameter("username", username));
                    sqlCommand.Parameters.Add(new SqlParameter("password", password));
                    int count = Convert.ToInt32(sqlCommand.ExecuteScalar());
                    if (count > 0)
                    {
                        Console.WriteLine("登录成功！");
                    }
                    else
                    {
                        Console.WriteLine("用户名或者密码错误！");
                    }
                }
            }
        }
    }
}
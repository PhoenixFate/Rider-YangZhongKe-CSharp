using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO_02_Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void importButton_Click(object sender, EventArgs e)
        {
            //点击选择文件导入到数据库
            if (importFileDialog.ShowDialog() == DialogResult.OK)
            {
                //已经选了文件
                //获得文件流
                MessageBox.Show(importFileDialog.FileName);
                using (FileStream fileStream = File.OpenRead(importFileDialog.FileName))
                {
                    using (StreamReader streamReader = new StreamReader(fileStream))
                    {
                        //通过App.Config应用配置文件来配置数据库连接地址
                        //如果项目中没有App.Config，则通过添加->新建项->常规->应用程序配置文件来添加
                        //项目引用中导入System.Configuration
                        string databaseUrl=ConfigurationManager.ConnectionStrings["databaseUrl"].ConnectionString;
                        //创建连接是非常耗时的，因此不能放while中，每次都创建连接
                        using (SqlConnection sqlConnection = new SqlConnection(databaseUrl))
                        {
                            sqlConnection.Open();
                            String lineData = null;
                            while ((lineData = streamReader.ReadLine())!=null)
                            {
                                string[] strs = lineData.Split('|');
                                string name = strs[0];
                                string passwrod = strs[1];
                                int age = Convert.ToInt32(strs[2]);
                                using (SqlCommand sqlCommand = sqlConnection.CreateCommand())
                                {
                                    sqlCommand.CommandText = "insert into Customer(username,password,age) values(@username,@password,@age)";
                                    sqlCommand.Parameters.Clear();
                                    sqlCommand.Parameters.Add("username", name);
                                    sqlCommand.Parameters.Add("password", passwrod);
                                    sqlCommand.Parameters.Add("age", age);
                                    sqlCommand.ExecuteNonQuery();
                                }
                            }
                        }
                    }
                }

                MessageBox.Show("导入成功！");
            }
        }
    }
}
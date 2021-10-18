using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO_03_SqlHelper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            string sql = "insert into Customer(username,password,age) values(@username,@password,@age)";
            int affectCount = SqlHelper.ExecuteNonQuery(sql, new SqlParameter("username", "sqlHelper"), new SqlParameter("password", "sdfsdf"), new SqlParameter("age", 30));
            MessageBox.Show("影响行数:" + Convert.ToString(affectCount));
            
        }

        private void totalCountButton_Click(object sender, EventArgs e)
        {
            string sql = "select count(*) from customer";
            int totalCount = (int)SqlHelper.ExecuteScalar(sql);
            MessageBox.Show("总行数: " + Convert.ToString(totalCount));
        }

        private void allDataButton_Click(object sender, EventArgs e)
        {
            string sql = "select * from customer";
            DataTable table = SqlHelper.ExecuteDataTable(sql);
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                DataRow row = table.Rows[i];
                string name = Convert.ToString(row["username"]);
                string password = Convert.ToString(row["password"]);
                //int age = Convert.ToInt32(row["age"]);
                stringBuilder.Append(name).Append("|");
                stringBuilder.Append(password).Append("\n");
                //stringBuilder.Append(age).Append("\n");
            }
            MessageBox.Show(stringBuilder.ToString());
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            DataSet dataSet = new DataSet();
            string databaseUrl = ConfigurationManager.ConnectionStrings["databaseUrl"].ConnectionString;
            using (SqlConnection sqlConnection = new SqlConnection(databaseUrl))
            {
                sqlConnection.Open();
                using (SqlCommand sqlCommand = sqlConnection.CreateCommand())
                {
                    sqlCommand.CommandText = "select * from Customer";
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                   

                    sqlDataAdapter.Fill(dataSet,"Customer");
                    DataTable dataTable = dataSet.Tables["Customer"];
                    //修改第六行的数据
                    DataRow row = dataTable.Rows[5];
                    row["username"] = "udpate3436688";

                    // DataRow tempRow = dataTable.NewRow();
                    // tempRow["Username"] = "temp";
                    // tempRow["Password"] = "password";
                    // tempRow["age"] = 10;
                    // dataTable.Rows.Add(tempRow);
                    //删除最后一行;
                    //这种写法无效
                    //dataTable.Rows.RemoveAt(8);
                    dataTable.Rows[dataTable.Rows.Count-1].Delete();

                    //sqlDataAdapter.InsertCommand = sqlConnection.CreateCommand();
                    //sqlDataAdapter.InsertCommand.CommandText = "insert into Customer(Username,Password) values(@Username,@Password)";
                    //对整个DataRow进行修改，然后将修改后的数据提交给数据库
                    SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
                    //sqlCommandBuilder会自动生成修改删除的sql
                    //也可以通过sqlDataAdapter.UpdateCommand/DeleteCommond/InsertCommond来指定sql
                    //对内存中修改的的dataSet提交到数据库
                    int count = sqlDataAdapter.Update(dataSet, "Customer");
                }
            }
            MessageBox.Show("成功！");
            
            
            
        }
    }
}
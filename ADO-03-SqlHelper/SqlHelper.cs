using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_03_SqlHelper
{
    class SqlHelper
    {
        public static int ExecuteNonQuery(string sql,params SqlParameter[] parameters)
        {
            string databaseUrl = ConfigurationManager.ConnectionStrings["databaseUrl"].ConnectionString;
            using(SqlConnection sqlConnection=new SqlConnection(databaseUrl))
            {
                sqlConnection.Open();
                using(SqlCommand sqlCommand = sqlConnection.CreateCommand())
                {
                    sqlCommand.CommandText = sql;
                    foreach(SqlParameter parameter in parameters)
                    {
                        sqlCommand.Parameters.Add(parameter);
                    }
                    return sqlCommand.ExecuteNonQuery();
                }
            }
        }

        public static object ExecuteScalar(string sql, params SqlParameter[] parameters)
        {
            string databaseUrl = ConfigurationManager.ConnectionStrings["databaseUrl"].ConnectionString;
            using (SqlConnection sqlConnection = new SqlConnection(databaseUrl))
            {
                sqlConnection.Open();
                using (SqlCommand sqlCommand = sqlConnection.CreateCommand())
                {
                    sqlCommand.CommandText = sql;
                    foreach (SqlParameter parameter in parameters)
                    {
                        sqlCommand.Parameters.Add(parameter);
                    }
                    return sqlCommand.ExecuteScalar();
                }
            }
        }

        public static DataTable ExecuteDataTable(string sql, params SqlParameter[] parameters)
        {
            string databaseUrl = ConfigurationManager.ConnectionStrings["databaseUrl"].ConnectionString;
            using (SqlConnection sqlConnection = new SqlConnection(databaseUrl))
            {
                sqlConnection.Open();
                using (SqlCommand sqlCommand = sqlConnection.CreateCommand())
                {
                    sqlCommand.CommandText = sql;
                    foreach (SqlParameter parameter in parameters)
                    {
                        sqlCommand.Parameters.Add(parameter);
                    }
                    //直接返回SqlDataReader是不行的，reader是指向数据库数据的指针，返回reader之后，连接已经断开，无法再访问数据
                    //return sqlCommand.ExecuteReader();
                    DataSet dataSet = new DataSet();
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                    sqlDataAdapter.Fill(dataSet);
                    return dataSet.Tables[0];
                }
            }
        }
    }
}

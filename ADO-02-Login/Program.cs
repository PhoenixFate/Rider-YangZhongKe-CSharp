using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO_02_Login
{
    static class Program
    {
        public static string databaseAddress = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Shop.mdf;Integrated Security=True";
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //加载本地数据库
            string dataDir = AppDomain.CurrentDomain.BaseDirectory;
            Console.WriteLine(dataDir);
            Console.WriteLine(dataDir.EndsWith(@"\bin\Debug"));
            if (dataDir.EndsWith(@"\bin\Debug\") || dataDir.EndsWith(@"\bin\Release\"))
            {
                dataDir = System.IO.Directory.GetParent(dataDir).Parent.Parent.FullName;
                Console.WriteLine(dataDir);
                AppDomain.CurrentDomain.SetData("DataDirectory", dataDir);
                object temp = AppDomain.CurrentDomain.GetData("DataDirectory");
                Console.WriteLine(temp.ToString());
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO_03_SqlHelper
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
        
            //可空数值类型
            string s1 = null;
            //这句话有语法错误，值类型不能=null
            //int i1 = null;
            //可空数据类型，在值类型后面加?  然后变量可以赋为null
            int? i2 = null;
            //可以通过是否为null来判断是否有值
            if (i2 == null)
            {
                Console.WriteLine("i2为空");
            }else
            {
                //可以通过强制类型转换，将int?类型赋值给int类型
                int i4 = (int)i2;
                Console.WriteLine("i2不为空");
            }

            //也可以通过HasValue来判断是否有值
            if (i2.HasValue)
            {
                int i4 = i2.Value;
                Console.WriteLine("i2不为空");
            }else
            {
                Console.WriteLine("i2为空");
            }


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
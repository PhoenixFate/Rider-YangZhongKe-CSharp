using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation_01_FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.OutputEncoding = System.Text.Encoding.Unicode;
            //Console.OutputEncoding = Encoding.GetEncoding("gbk");
            Console.WriteLine("hello world");
            int i1 = 10;
            int i2 = 20;
            Console.WriteLine(i1 + "+" + i2 + "=" + (i1 + i2));
            Console.WriteLine("{0}+{1}={2}", i1, i2, i1 + i2);

            ZhuanYi();
            MyConvert();
            Person p = new Person();
            p.Name = "小王";
            Console.WriteLine(p.Name);
            p.Speak();

            MyWhile();
            MyFor();
            MyCast();
            Console.WriteLine("请随便输入你向说的话");
            string s = Console.ReadLine();
            Console.WriteLine("刚才输出的 是: " + s);
            Console.ReadKey();
        }

        static void ZhuanYi()
        {
            //转义符：方式一
            Console.WriteLine("c:\\\"abc\".txt");
            //转义符：方式二
            //@表示字符串中的\不当成转义符
            Console.WriteLine(@"c:\bcd.txt");
        }

        static void MyConvert()
        {
            string s1 = "10";
            //将字符串转换为整数
            int a = Convert.ToInt32(s1);
            Console.WriteLine("Convert.ToInt32: " + a);
        }

        static void MyBool()
        {
            int a = 10;
            Console.WriteLine("{0}", a == 2);
            bool b = true;
            Console.WriteLine(b);
        }

        static void MyIf()
        {
            int a = 10;
            if (a > 10)
            {
                Console.WriteLine("if");
            }
            else
            {
                Console.WriteLine("else");
            }

            if (a > 10)
            {
                Console.WriteLine("if");
            }
            else if (a > 20)
            {
                Console.WriteLine("else if");
            }
            else
            {
                Console.WriteLine("if-else if-else");
            }
        }

        static void MySwitchCase()
        {
            int i = 1;
            switch (i)
            {
                case 1:
                    Console.WriteLine("case 1");
                    break;
                case 2:
                    Console.WriteLine("case 2");
                    break;
                //唯一一种可以不写break的情况，其他都要写
                case 3:
                case 4:
                    Console.WriteLine("case 3");
                    break;

                default:
                    Console.WriteLine("default");
                    break;
            }

        }

        static void MyWhile()
        {
            int i = 0;
            int sum = 0;
            while (i < 100)
            {
                sum += i;
                i++;
            }
        }

        static void MyFor()
        {
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("thi is for {0}:", i);
            }
        }


        static void MyCast()
        {
            Console.WriteLine("int min:{0}; int max:{1}", int.MinValue, int.MaxValue);
            Console.WriteLine("byte min:{0}; byte max:{1}", byte.MinValue, byte.MaxValue);
            int a = -20;
            byte c = (byte)a;
            Console.WriteLine(c);
        }

        static void CastAndConvert()
        {
            string s = "123";
            int a = Convert.ToInt32(s);
        }
    }
}

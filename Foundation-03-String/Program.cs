using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation_03_String
{
    class Program
    {
        static void Main(string[] args)
        {
            char c1 = 'a';
            Console.WriteLine(c1);
            string s1 = "hello";
            Console.WriteLine(s1.Length);
            Console.WriteLine(s1[1]);

            char[] charArray = s1.ToCharArray();
            Console.WriteLine(charArray);

            string s2 = new string(charArray);

            StringUtils();
            StringReplace();
            SubString();
            StringContains();
            StringStartsWith();
            StringEndWith();
            StringIndexOf();
        }

        static void StringUtils()
        {
            string s = "Hello";
            Console.WriteLine(s);
            string lower=s.ToLower();
            Console.WriteLine("ToLower: {0}", lower);
            string upper = s.ToUpper();
            Console.WriteLine("Upper: {0}", upper);
            string s2 = "Hello";
            Console.WriteLine("equals: {0}", s.Equals(s2));
            Console.WriteLine("equals ignore case:{0}", s.Equals(s2, StringComparison.OrdinalIgnoreCase));
            Boolean b = true;
            Console.WriteLine(b);

            string stringTrim = " abc ";
            Console.WriteLine(stringTrim.Trim());
            int i = s.CompareTo("china"); //大 返回大于0的数；小 返回小于零的数； 等于返回0；
            Console.WriteLine("CompareTo: {0}", i);

            Console.WriteLine("------------1-----------");
            string ss = "abc;edf;ghi;.hhh|ggg";
            string[] strArray = ss.Split(';','.','|');
            foreach(string str in strArray)
            {
                Console.WriteLine(str);
            }

            Console.WriteLine("------------2-----------");
            string ss2 = "abc;edf;ghi,.hhh";
            string[] strArray2 = ss2.Split(new char[] { ';', '.', ',' },StringSplitOptions.RemoveEmptyEntries);
            foreach (string str in strArray2)
            {
                Console.WriteLine(str);
            }

            Console.WriteLine("------------3-----------");
            string ss3 = "abc;;edf;;ghi,.hhh";
            string[] strArray3 = ss3.Split(new string[] { ";;","."}, StringSplitOptions.RemoveEmptyEntries);
            foreach (string str in strArray3)
            {
                Console.WriteLine(str);
            }
        }


        static void StringReplace()
        {
            Console.WriteLine("---------------replace---------------");
            string s = "aa;bb;cc;";
            Console.WriteLine(s.Replace(';', '.'));
        }

        static void SubString()
        {
            Console.WriteLine("-----------------substring-------------");
            string s = "http://www.baidu.com";
            Console.WriteLine(s.Substring(7));
            Console.WriteLine(s.Substring(7,4));
        }

        static void StringContains()
        {
            Console.WriteLine("-----------------Contains-------------");
            string s = "http://www.baidu.com";
            Console.WriteLine(s.Contains("baidu.com"));
        }

        static void StringStartsWith()
        {
            Console.WriteLine("-----------------startswith-------------");
            string s = "http://www.baidu.com";
            Console.WriteLine(s.StartsWith("http:"));
        }

        static void StringEndWith()
        {
            Console.WriteLine("-----------------endwith-------------");
            string s = "http://www.baidu.com";
            Console.WriteLine(s.EndsWith(".com"));
        }

        static void StringIndexOf()
        {
            Console.WriteLine("-----------------indexOf-------------");
            string s = "http://www.baidu.com";
            Console.WriteLine(s.IndexOf("www"));//第一次出现的位置，如果不存在，则返回-1
        }
    }
}

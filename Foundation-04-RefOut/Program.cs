using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation_04_RefOut
{
    class Program 
    {
        static void Main(string[] args)
        {
            int age = 20;
            //IncreaseAge2(ref age);
            IncreaseAge3(out age);
            Console.WriteLine(age);

            string s = "123";
            int result;
            int.TryParse(s, out result);
            Console.WriteLine(result);

            int a = 20;
            int b = 30;
            MySwap(ref a, ref b);
            Console.WriteLine("swap: {0}:{1}", a, b);
        }

        static void IncreaseAge1(int age)
        {
            age++;
        }

        //传的是引用，不是形参
        //ref传入的参数，必须先初始化
        static void IncreaseAge2(ref int age)
        {
            age++;
        }


        static void IncreaseAge3(out int age)
        {
            //out 必须在函数内部给参数赋值
            age = 30;
        }

        static void MySwap(ref int a,ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
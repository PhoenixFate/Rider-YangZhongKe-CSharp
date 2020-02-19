using System;
using System.Collections.Generic;
using System.Text;

/*
 * 静态成员
 * 静态方法
 * 静态类
 */
namespace Object_03_Exception
{
    public class MyStatic
    {
        public static int totalCount;

        public int age;

        public static void Main(string[] args)
        {
            //在static方法中可以调用其他static成员，但不能调用非static成员
            //age = 30;
            totalCount = 30;
            Console.WriteLine("totalCount: {0}", totalCount);
            //静态类不能new
            //ConsoleHelper consoleHelper = new ConsoleHelper();
            Console.WriteLine("请输入一个整数");
            int readInt = ConsoleHelper.ReadInt();
            Console.WriteLine("刚才输入的整数是: {0}", readInt);
        }
    }

    //静态类
    static class ConsoleHelper
    {
        public static int ReadInt()
        {
            String str = Console.ReadLine();
            return Convert.ToInt32(str);
        }

        //静态类中只能写静态方法
        //public void SayHello()
        //{

        //}
    }


}
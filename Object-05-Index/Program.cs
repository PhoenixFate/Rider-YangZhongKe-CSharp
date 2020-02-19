using System;
using System.Collections;

/*
 * 对象索引器
 */
namespace Object_05_Index
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ArrayList list = new ArrayList();
            list.Add("a");
            list.Add("b");
            Console.WriteLine(list[0]);


            Person p1 = new Person();
            p1[0] = "小名";
            p1[1] = "王";
            Console.WriteLine("{0} {1}", p1[0], p1[1]);
            string s2 = p1[1, 2, 3];
            Console.WriteLine(s2);
        }
    }

    class Person
    {
        private string firstName = "phoenix";
        private string lastName = "fate";

        public string this[int a, int b, int c]
        {
            get
            {
                return a + "-" + b + "-" + c;
            }
        }


        //对象索引器
        public string this[int index]
        {
            set
            {
                Console.WriteLine("[index] set");
                if (index == 0)
                {
                    firstName = value;
                }
                else if (index == 1)
                {
                    lastName = value;
                }
                else
                {
                    throw new Exception("error index");
                }
            }
            get
            {
                Console.WriteLine("[index] get");
                if (index == 0)
                {
                    return firstName;
                }
                else if (index == 1)
                {
                    return lastName;
                }
                else
                {
                    throw new Exception("error index");
                }
            }
        }
    }
}
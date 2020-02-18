using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation_02_Enum
{
    //枚举的意义在于限定 变量的取值范围
    enum Gender { Male, Female, Unknown }
    class Program
    {
        static void Main(string[] args)
        {
            Gender female = Gender.Female;
            Console.WriteLine(female);

            int[] value = { 1, 2, 3 };
            Console.WriteLine(string.Join(",",value));
            Console.WriteLine("length: {0}", value.Length);
            Console.WriteLine("value[0]: {0}", value[0]);
            for(int i = 0; i < value.Length; i++)
            {
                Console.WriteLine(value[i]);
            }

            MyForEach();
        }

        static void MyForEach()
        {
            string[] myList = new string[5];
            myList[0] = "abc";
            myList[1] = "bcd";
            myList[2] = "def";
            myList[3] = "hil";
            foreach(string temp in myList)
            {
                Console.WriteLine(temp);
            }

            string[] names = { "tom", "jerry", "cat", "monkey" };
            foreach(string name in names)
            {
                Console.WriteLine(name);
            }

            string name1 = "abc";
            string name2 = "def";
            //ChangableParameters(name1,name2);
            ChangableParameters2(name1, name2);

            SayHello("tomcat");
        }

        //可变参数
        static void ChangableParameters(String[]values)
        {
            foreach(string s in values)
            {
                Console.WriteLine(s);
            }
        }

        //可变参数2
        static void ChangableParameters2(params String[] values)
        {
            foreach (string s in values)
            {
                Console.WriteLine(s);
            }
        }

        //函数重载
        static void SayHello(String name)
        {
            Console.WriteLine("name: {0};", name);
        }

        //函数参数默认值
        static void SayHello(String name,int age=20)
        {
            Console.WriteLine("name: {0}; age: {1}", name, age);
        }
    }
}

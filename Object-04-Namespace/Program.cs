using System;
using System.Collections;
using Object_04_Namespace.Phoenix;

namespace Object_04_Namespace
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            IList list = new ArrayList();
            list.Add("a");
            list.Add("b");
            list.Add("c");
            foreach (Object o in list)
            {
                Console.WriteLine(o);
            }

            Person p1 = new Person();
            Console.WriteLine(p1);
            Phoenix.Person p2 = new Phoenix.Person();
            Console.WriteLine(p2);

            //如果需要使用的类和当前类不在同一个namespace，则需要using Object_04_Namespace.Phoenix;
            Dog dog = new Dog();
            Console.WriteLine(dog);
        }
    }

    class Person
    {

    }
}
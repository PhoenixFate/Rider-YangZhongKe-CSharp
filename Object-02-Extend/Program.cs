using System;

namespace Object_02_Extend
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.Name = "普通人";
            p1.SayHello();

            Chinese chinese = new Chinese();
            chinese.Name = "李小龙";
            chinese.SayHello();
            chinese.KongFu();

            Person p2 = chinese;
            p2.SayHello();

            Chinese c2 = (Chinese)p2;
            c2.SayHello();
        }
    }

    class Person
    {
        public string Name { set; get; }
        public int Age { set; get; }
        public int Height { set; get; }


        public void SayHello()
        {
            Console.WriteLine("hello , my name is {0}", Name);
        }
    }

    class Chinese : Person
    {
        public void KongFu()
        {
            Console.WriteLine("hello i'm a chinese ,i can play kongfu");
        }
    }
}
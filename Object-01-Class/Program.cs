using System;

namespace Object_01_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            // unsafe
            // {
            //     int number = 27;
            //     int* pointerToNumber = &number;
            //     int number2 = 27;
            //     int* pointerToNumber2 = &number2;
            //     Console.WriteLine($"Value of the variable: {number}");
            //     Console.WriteLine($"Address of the variable: {(long)pointerToNumber:X}");
            //     Console.WriteLine($"Address of the variable: {(long)pointerToNumber2:X}");
            // }


            Person p1 = new Person();
            p1.Name = "abc";
            Console.WriteLine(p1.Name);
            p1.Age = 10;
            Console.WriteLine(p1.Age);

            p1.SayHello();

            Console.WriteLine("----------------constructor----------------");
            Person p2 = new Person("constructor");
            Person p3 = new Person("constructor2",20);
            Console.WriteLine(p2.Name);
            Console.WriteLine("{0},{1}",p3.Name,p3.Age);
        }
    }


    class Person
    {

        public int Height { get; set; }

        private int age;
        public int Age
        {
            set
            {
                //value就是传入的值
                Console.WriteLine("set age");
                age = value;
            }
            get
            {
                Console.WriteLine("get age");
                return age;
            }
        }
        public string Name { get; set; }


        public Person()
        {

        }

        public Person(string name)
        {
            Name = name;
        }

        public Person(string name,int age)
        {
            Name = name;
            Age = age;
        }



        public void SayHello()
        {
            Console.WriteLine("person say hello");
        }
    }
}
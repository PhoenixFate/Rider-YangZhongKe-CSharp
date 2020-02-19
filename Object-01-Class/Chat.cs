using System;
using System.Collections.Generic;
using System.Text;

namespace Object_01_Class
{
    class Chat
    {
        static void Main2(string[] args)
        {
            Console.WriteLine("-----chat-----");
            Machine machine1 = new Machine();
            machine1.Name = "robot";
            machine1.Eat(5);
            while (true)
            {
                String word = Console.ReadLine();
                machine1.Speak(word);
            }

        }
    }

    class Machine
    {
        public string Name { set; get; }
        private int FullLevel { set; get; }

        public void SayHello()
        {
            Console.WriteLine("hello, my name is {0}", this.Name);
        }

        public void Eat(int level)
        {
            if (this.FullLevel > 10)
            {
                return;
            }
            FullLevel += level;
        }

        public void Speak(string str)
        {
            if (FullLevel <= 0)
            {
                Console.WriteLine("i need to eat something");
                return;
            }
            if (str.Contains("姓名") || str.Contains("名字") || str.Contains("name"))
            {
                SayHello();
            }
            else if (str.Contains("女朋友"))
            {
                Console.WriteLine("机器人不谈恋爱");
            }
            else
            {
                Console.WriteLine("不知道你在说什么");
            }
            FullLevel--;
        }

    }
}
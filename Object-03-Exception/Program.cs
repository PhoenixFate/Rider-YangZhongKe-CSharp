using System;

/*
 * 异常
 * 
 */
namespace Object_03_Exception
{
    class Program
    {
        public static double CLASS_PI = 3.14;

        static void Main1(string[] args)
        {
            Console.WriteLine("Hello World!");

            const double PI = 3.1415;
            double r = 5;
            double area = PI * r * r;
            // {0:f3} 限制小数点位数
            Console.WriteLine("area: {0:f3}", area);
            double area2 = Math.PI * r * r;
            Console.WriteLine("area2: {0:f3}", area2);
            double area3 = CLASS_PI * r * r;
            Console.WriteLine("area3: {0:f3}", area3);

            try
            {
                int i = Convert.ToInt32("abc");
            }
            catch (Exception ex)
            {
                Console.WriteLine("----Message----");
                Console.WriteLine(ex.Message);
                Console.WriteLine("----StackTrace----");
                Console.WriteLine(ex.StackTrace);
            }

            try
            {
                int age = -10;
                string ageType = GetAgeType(age);
                Console.WriteLine(ageType);
            }
            catch (Exception ex)
            {
                Console.WriteLine("----Message----");
                Console.WriteLine(ex.Message);
                Console.WriteLine("----StackTrace----");
                Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                Console.WriteLine("finally");
            }
        }

        static string GetAgeType(int age)
        {
            if (age >= 0 && age < 3)
            {
                return "婴幼儿";
            }

            else if (age >= 3 && age < 18)
            {
                return "青少年";
            }
            else if (age >= 18 && age <= 130)
            {
                return "成年人";
            }
            else if (age < 0)
            {
                throw new Exception("年龄不能小于0");
            }

            throw new Exception("年龄太大");
        }
    }
}
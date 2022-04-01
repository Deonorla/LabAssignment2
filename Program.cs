using System;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 10 different dataTypes
            string name = "Emmanuel";
            char track = 'A';
            int age = 22;
            long num21 = 45000000;
            short num30 = 702;
            float num = 24;
            double num2 = 67.567;
            var message = "Hello, am learning backend development at WellaHealth";
            dynamic goals ="Became a certified fullstack developer by the end of my training";
            Nullable<int> months = null;

            
            // Examples of implicit conversions
                int newAge = (int)num;
                Console.WriteLine(newAge + " " + "This is an example of an explicit conversion");

                int newNum = (int)num2;
                 Console.WriteLine(newNum + " " + "This is an example of an explicit conversion");
            
            // Examples of explicit conversions
                float number = age;
                 Console.WriteLine(number + " " + "This is an example of an implicit conversion");
                  
                  int year = 65;
                 double dobNum = year;
                 Console.WriteLine(dobNum + " " + "This is an example of an implicit conversion");




                

                


            
        }
    }
}

using System;
namespace mohirdev_basics
{
    class CalculatR
    {
        static void NotMain(string[] args)
        {

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}! What is your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            int ageKescha = 7;
            Console.WriteLine($"Your age is {age}, you are greater than Kescha");
            Console.WriteLine($"You are older or equal to Kescha: {age >= ageKescha}");
            Console.WriteLine($"You are younger or equal to Kescha: {age <= ageKescha}");
            Console.WriteLine($"You are older to Kescha: {age > ageKescha}");
            Console.WriteLine($"You are equal to Kescha: {age == ageKescha}");
            Console.WriteLine($"You are not equal to Kescha: {age != ageKescha}");

            //Console.Write("Enter your name: ");
            //string name = Console.ReadLine();
            //string greeting = $"Hello {name}, nice to meet you!";
            //Console.WriteLine(greeting);

            //Console.Write("Enter your age: ");
            //int age = Convert.ToInt32(Console.ReadLine());
            //int keschaAge = 4;
            //Console.WriteLine($"You are {age - keschaAge} years older than Kescha");
            //Console.WriteLine("Here is some changes");
            //Console.WriteLine("This line comes from New Branch");


        }
    }
}
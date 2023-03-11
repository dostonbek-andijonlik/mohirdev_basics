using System;
namespace mohirdev_basics
{
    class CalculatR
    {
        static void Main(string[] args)
        {

            //Console.Write("Enter your name: ");
            //string name = Console.ReadLine();
            //Console.WriteLine($"Hello, {name}! What is your age: ");
            //int age = Convert.ToInt32(Console.ReadLine());
            //int ageKescha = 7;
            //Console.WriteLine($"Your age is {age}, you are greater than Kescha");
            //Console.WriteLine($"You are older or equal to Kescha: {age >= ageKescha}");
            //Console.WriteLine($"You are younger or equal to Kescha: {age <= ageKescha}");
            //Console.WriteLine($"You are older to Kescha: {age > ageKescha}");
            //Console.WriteLine($"You are equal to Kescha: {age == ageKescha}");
            //Console.WriteLine($"You are not equal to Kescha: {age != ageKescha}");

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

            Console.Write("Enter first number: ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter one of these operations: (+, -, *, /, %) => ");
            string operation = Console.ReadLine();
            Console.Write("Enter second number: ");
            int secondNumber = int.Parse(Console.ReadLine());

            if(firstNumber > secondNumber)
            {
                Console.WriteLine($"{firstNumber} is greater than {secondNumber}");
            }
            else if(firstNumber == secondNumber)
            {
                Console.WriteLine($"{firstNumber} is equal to {secondNumber}");
            }

            else
            {
                Console.WriteLine($"{firstNumber} is less than {secondNumber}");
            }

            string result = operation switch
            {

                "+" => $"{firstNumber} + {secondNumber} is equal to {firstNumber + secondNumber}",
                "-" => $"{firstNumber} - {secondNumber} is equal to {firstNumber - secondNumber}",
                "*" => $"{firstNumber} * {secondNumber} is equal to {firstNumber * secondNumber}",
                "/" => $"{firstNumber} / {secondNumber} is equal to {firstNumber / secondNumber}",
                "%" => $"{firstNumber} % {secondNumber} is equal to {firstNumber % secondNumber}",
                _   => "Operation not found."
            };

            Console.WriteLine(result);

            //if(firstNumber > 0)
            //{
            //    int counter = 0;
            //    while( counter <= firstNumber) {
            //        Console.WriteLine(counter);
            //        counter+=2;
            //    }
            //}

            //string password = "";
            //do
            //{
            //    Console.Write("Enter Password: ");
            //    password = Console.ReadLine();
            //} while (password != "pa$$w0rd");
            
            //switch(operation)
            //{
            //    case "+":
            //        Console.WriteLine($"{firstNumber} + {secondNumber} is equal to {firstNumber + secondNumber}");
            //        break;
            //    case "-":
            //        Console.WriteLine($"{firstNumber} - {secondNumber} is equal to {firstNumber - secondNumber}");
            //        break;
            //    case "*":
            //        Console.WriteLine($"{firstNumber} * {secondNumber} is equal to {firstNumber * secondNumber}");
            //        break;
            //    case "/":
            //        Console.WriteLine($"{firstNumber} / {secondNumber} is equal to {firstNumber / secondNumber}");
            //        break;
            //    case "%":
            //        Console.WriteLine($"{firstNumber} % {secondNumber} is equal to {firstNumber % secondNumber}");
            //        break;

            //    default: Console.WriteLine("Opeartor not found.");
            //        break;

            //}

            for(int iteration = 1; iteration < 11; iteration++)
            {
                Console.WriteLine(iteration);
            } 


        }
    }
}



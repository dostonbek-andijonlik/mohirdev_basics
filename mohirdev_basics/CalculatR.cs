Console.Write("Enter your name: ");
string name = Console.ReadLine();
string greeting = $"Hello {name}, nice to meet you!";
Console.WriteLine(greeting);

Console.Write("Enter your age: ");
int age = Convert.ToInt32(Console.ReadLine());
int keschaAge = 4;
Console.WriteLine($"You are {age - keschaAge} years older than Kescha");
Console.WriteLine("Here is some changes");
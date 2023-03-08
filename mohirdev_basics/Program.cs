//string user = "New User. How old are you?";
//Console.WriteLine(user);
//string myname = Console.ReadLine();
//Console.WriteLine("Hello, this is new user. His name is " + myname);
//Console.WriteLine("\t\"Polyglot\"\n\"Keen on learning\"");
//string filePath = @"C: \television";
////Console.WriteLine(filePath);
//Console.WriteLine($"Keep this filepath, named {filePath}");

//var jh = (firstName: "Jammon", lastName: "Hammon", born: 1233, published: 1278);
//Console.WriteLine($@"{jh.firstName} {jh.lastName} was born in {jh.born}");
//Console.WriteLine($@"His first poet published at his {jh.published - jh.born}");

//string password = "Let's do it now";
//Console.WriteLine(password.ToLower());

//Console.WriteLine($"The size of short data type is: {sizeof(ushort)}");
//Console.WriteLine($"The Minimum value of short data type is: { ushort.MinValue}");
//Console.WriteLine($"The Maximum value of shhort data type is: {ushort.MaxValue}");
//Console.WriteLine($"The Minimum value of Integer data type is: {uint.MinValue}");
//Console.WriteLine($"The Maximum value of Integer data type is: {uint.MaxValue}");
//Console.WriteLine($"The Minimum Long data type is: {ulong.MinValue}");
//Console.WriteLine($"The Maximum value of Long data type is: {ulong.MaxValue}");

//string name = "Doston";
//string greeting = $"Hello {name}";
//Console.WriteLine(greeting);
//int age = 22;
//string filePath = "C:\\Users\\Doston\\source\\repos\\mohirdev_basics\\mohirdev_basics\\Program.cs";
//Console.WriteLine($"Your age is probably {age}");
//Console.WriteLine(@$"{filePath}");

//string name = "Doston";
//int yearOld = 24;
//string greeting = $"Hello {name}. You probably {yearOld} now.";
//Console.WriteLine(greeting);

//string student = "Hakim";
//int classStudy = 12;
//string greetingNew = $"Hello {student}. You are studying {classStudy}-B";
//Console.WriteLine(greetingNew);

//decimal derra = 1.5m;
//float der = 4.9f;
//double lor = 4.3;

//bool isBoy = false;
//bool isGirl = true;

//bool check = true;
//Console.WriteLine(check? "Checked": "Not Checked");
//Console.WriteLine(false? "Checked": "Not Checked");
//bool holidays = true;
//Console.WriteLine(holidays? "You can take day-offs": "You have to come to work");
//Console.WriteLine(false? "You can take day-offs": "You have to come to work");

//float pi = 3.14f;
//double bigPi = pi;
//Console.WriteLine(bigPi);
//Console.WriteLine(pi);

//int floraTypes = 2222;
//short floras = (short)floraTypes;
//Console.WriteLine(floras);

//int studNum = 12500;
//short studNum2 = (short)studNum;

//int randomNum = Convert.ToInt32("32");
//Console.WriteLine(randomNum);

//Console.Write("Enter your name: ");
//string name = Console.ReadLine();
//string greeting = $"Hello {name}";
//Console.WriteLine(greeting);

//Console.Write("Enter your age: ");
//string ageAsString = Console.ReadLine();
//int age = Convert.ToInt32(ageAsString);
//Console.WriteLine($"Your age is {age}, {name}.Length Welcome to the club!");

//Console.Write("Enter your username: ");
//string username = Console.ReadLine();
//Console.Write("Enter your password: ");
//string password = Console.ReadLine();
//Console.WriteLine($"Your password is correct :)");
//Console.WriteLine("How much money do you want to withdraw?");
//string cashMoney = Console.ReadLine();
//int cash = Convert.ToInt32(cashMoney);
//Console.WriteLine($"Here is your {cash} $, {username}. Thank you for choosing us :)");

//int firstNumber = 21;
//int secondNumber = 13;
//Console.WriteLine($"Adding {firstNumber + secondNumber}");
//Console.WriteLine($"Subtracting {firstNumber - secondNumber}");
//Console.WriteLine($"Multiplying {firstNumber * secondNumber}");
//Console.WriteLine($"Divisioning {firstNumber / secondNumber}");
//Console.WriteLine($"Left {firstNumber % secondNumber}");

Console.Write("Enter first number: ");
string firstNumberAsString = Console.ReadLine();
int firstNumber = Convert.ToInt32(firstNumberAsString);


Console.Write("Enter second number: ");
string secondNumberAsString = Console.ReadLine();
int secondNumber = Convert.ToInt32(secondNumberAsString);

Console.WriteLine($"The first Number is greater than or equals to the second number: {firstNumber >= secondNumber}");
Console.WriteLine($"The first Number is less than or equals to the second number: {firstNumber <= secondNumber}");
Console.WriteLine($"The first Number equals to the second number: {firstNumber == secondNumber}");
Console.WriteLine($"The first Number is not equals to the second number: {firstNumber != secondNumber}");
Console.WriteLine($"The first Number is greter than or equals to the second number: {firstNumber %= secondNumber}");

//Console.WriteLine($"Adding {firstNumber + secondNumber}");
//Console.WriteLine($"Subtracting {firstNumber - secondNumber}");
//Console.WriteLine($"Multiplying {firstNumber * secondNumber}");
//Console.WriteLine($"Divisioning {firstNumber / secondNumber}");
//Console.WriteLine($"Modulus  {firstNumber % secondNumber}");

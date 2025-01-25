



Console.Write("give me your name and age ( like this : ali 15)");
string input = Console.ReadLine();
string[] parts = input.Split(' '); // جدا کردن ورودی
string name = parts[0];
int age = int.Parse(parts[1]);
Console.WriteLine($"Hi {name} You have {age} years old.");
Console.ReadKey();
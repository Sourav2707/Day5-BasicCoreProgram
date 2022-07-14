using BasicCoreProgram;
Console.WriteLine("Welcome to basic core program");
Basic basic = new Basic();
Console.WriteLine($"Enter any number within 31");
int a = Convert.ToInt32(Console.ReadLine());
basic.Core(a);


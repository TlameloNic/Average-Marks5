// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int mark1;
int mark2;
int mark3;
int mark4;
int mark5;
int averagE;

Console.WriteLine("========================================================================");
Console.WriteLine(" ");
Console.WriteLine("Please enter the First Mark ");
mark1 = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Please enter the Second Mark ");
mark2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please enter the Third Mark ");
mark3 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please enter the Fourth Mark ");
mark4 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please enter the Fifth Mark ");
mark5 = Convert.ToInt32(Console.ReadLine());

averagE= (mark1 + mark2 + mark3 + mark4 + mark5)/5;


Console.WriteLine("Average is = "+ averagE);


int firstNumber;
int secondNumber;
int result;
string option;

Console.WriteLine("Hello!");
Console.WriteLine("Input the first number:");
firstNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Input the second number:");
secondNumber = int.Parse(Console.ReadLine());

Console.WriteLine("What do you want to do with those numbers?");
Console.WriteLine("[A]dd");
Console.WriteLine("[S]ubtract");
Console.WriteLine("[M]ultiply");
option = Console.ReadLine();

Calculation(firstNumber, secondNumber, option);

void CloseApp()
{
	Console.WriteLine("Press any key to close.");
	Console.ReadLine();
}

void Calculation(int a, int b, string selection)
{
	int result;
	if (selection.ToUpper() == "A")
	{
		result = a + b;
		Console.WriteLine($"{a} + {b} = {result}");
	}
	else if (selection.ToUpper() == "S")
	{
		result = a - b;
		Console.WriteLine($"{a} - {b} = {result}");
	}
	else if (selection.ToUpper() == "M")
	{
		result = a * b;
		Console.WriteLine($"{a} * {b} = {result}");
	}
	else
	{
		Console.WriteLine("Invalid option");
	}
	CloseApp();
}
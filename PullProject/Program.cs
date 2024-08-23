int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

Printnumbers("Numbers", numbers);
Printnumbers("Numbers", numbers.Where(x => IsEven(x)).ToArray());
Printnumbers("Numbers", numbers.Where(x => IsOdd(x)).ToArray());

static void Printnumbers ( string Title, int[] numbers )
{
	Console.WriteLine();
	Console.Write($"{Title}: [ ");
	foreach (int i in numbers)
	{
		if (numbers.Last() == i)
		{
			Console.Write(i);
			break;
		}
		Console.Write(i + " , ");
	}
	Console.Write(" ]");
	Console.WriteLine();
}
static bool IsEven ( int n )
{
	return n % 2 == 0;
}
static bool IsOdd ( int n )
{
	return n % 2 != 0;
}
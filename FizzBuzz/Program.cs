
FizzBuzz();

Console.ReadLine();



void FizzBuzz()
{
	foreach (var number in Enumerable.Range(1, 100))
	{
		string word = number % 3 == 0 ? "Fizz" : "";
		word += number % 5 == 0 ? "Buzz" : "";

		Console.WriteLine(string.IsNullOrEmpty(word) ? number.ToString() : word);
	}
}

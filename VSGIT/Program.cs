namespace VSGIT
{
	public class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello from GIT World!");
			string name = "master";
            Console.WriteLine(name + " ,and my age is 25 years old");

			var date = DateTime.Now;
            Console.WriteLine($"we are in the year of {date.Year} and month is {date.Month}");

            Console.WriteLine(capitaliseWord("mostafa"));
        }
		static string capitaliseWord( string word )
		{
			return word[0].ToString().ToUpperInvariant() + word.Substring(1);
		}
	}
}
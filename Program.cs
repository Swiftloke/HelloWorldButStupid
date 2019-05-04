using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorldButStupid
{
	class Program
    {
        static void Main(string[] args)
        {
			const string helloworld = @"int main ( )
{
std :: cout << ""SomeString"" ;
return 0 ;
}";
			const string iostream = "#include <iostream>";
			string[] tokens = helloworld.Split(new char[] { ' ', '\n' });

			Console.Write("Enter a value to transform Hello World into: ");
			string value = Console.ReadLine();
			if (value.Length < 4)
			{
				Console.WriteLine("Please input a longer value to account for all permutations necessary. Please try again.");
				Environment.Exit(1);
			}
			else if (value.Contains(" "))
			{
				Console.WriteLine("You cannot have a space in preprocessor definitions. Please try again.");
				Environment.Exit(1);
			}
			var defines = new List<string>();
			var permutations = new List<string>();
			Random charcase = new Random();
			foreach (var token in tokens)
			{
				char[] chars = value.ToCharArray();
				int attempts = 0;
				while (permutations.Contains(new string(chars)))
				{
					for (int i = 0; i < chars.Length; i++)
					{
						bool isUpper = charcase.Next(0, 2) == 1;
						if (isUpper)
							chars[i] = Char.ToUpper(chars[i]);
						else
							chars[i] = char.ToLower(chars[i]);
					}
					attempts++;
					if (attempts == 50) //We clearly don't have a possible permutation; bail
					{
						Console.WriteLine("It appears you have entered a string that is impossible to mutate enough times" +
							" to create Hello World. Please try again.");
						Environment.Exit(1);
					}
				}
				permutations.Add(new string(chars));
				string defined = token;
				if (defined == "\"SomeString\"") //Need to fix what gets printed
					defined = $"\"{value}\"";
				defines.Add($"#define {new string(chars)} {defined}");
			}
			var final = new StringBuilder();
			final.Append(iostream + "\n\n");
			foreach (var define in defines)
				final.Append(define + '\n');
			final.Append('\n');
			//We should only write 5 at a time, as all of them on one line could get pretty long.
			int tokenswritten = 0;
			foreach (var permutation in permutations)
			{
				final.Append(permutation + ' ');
				tokenswritten++;
				if (tokenswritten == 5)
				{
					final.Append('\n');
					tokenswritten = 0;
				}
			}
			Console.WriteLine(final.ToString());
			Console.ReadKey();
		}
    }
}
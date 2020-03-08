using System;

namespace caracterosos
{
	class Program
	{
		public static void Main(string[] args)
		{
			char chA = 'A';
			char ch1 = '1';
			string cad = "cadena probadora"; 

			Console.WriteLine(chA.CompareTo('B'));          //-----------  -1 (significa que A es menor que B, 0 igual y 1 es >)
			Console.WriteLine(chA.Equals('A'));             //-----------  True
			Console.WriteLine(Char.GetNumericValue(ch1));   //-----------  1
			Console.WriteLine(Char.IsControl('\t'));        //-----------  True
			Console.WriteLine(Char.IsDigit(ch1));           //-----------  True
			Console.WriteLine(Char.IsLetter(','));          //-----------  False
			Console.WriteLine(Char.IsLower('u'));           //-----------  True
			Console.WriteLine(Char.IsNumber(ch1));          //-----------  True
			Console.WriteLine(Char.IsPunctuation('.'));     //-----------  True
			Console.WriteLine(Char.IsSeparator(cad, 6));    //-----------  True
			Console.WriteLine(Char.IsSymbol('+'));          //-----------  True
			Console.WriteLine(Char.IsWhiteSpace(cad, 6));   //-----------  True
			Console.WriteLine(Char.ToLower('M'));           //-----------  m
			Console.WriteLine('x'.ToString());              //-----------  x
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
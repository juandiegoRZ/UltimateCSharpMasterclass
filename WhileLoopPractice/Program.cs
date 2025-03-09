using System;

namespace Excercises
{
	public class Exercises
	{
		public static int CalculateSumOfNumbersBetween(int firstNumber, int lastNumber)
		{
			int sum = 0;
			while (firstNumber <= lastNumber)
			{
				if (firstNumber == lastNumber)
				{
					sum = firstNumber;
					return sum;
				}
				else
				{
					sum += firstNumber + lastNumber;
					firstNumber++;
					lastNumber--;
				}
			}
			return sum;
		}
		public static string RepeatCharacter(char character, int targetLength)
		{
			string sum = "";
			do
			{
				sum += character.ToString();
			}
			while (sum.Length < targetLength);
			return sum;
		}
		public static int Factorial(int number)
		{
			int total = 1;
			for (int i = 1; i <= number; i++)
			{
				total *= i;
			}
			return total;
		}
		public static string BuildHelloString()
		{
			char[] letters = {'h','e','l','l','o'};
			var result = "";
			for (int i = 0; i < letters.Length; i++)
			{
				result += letters[i];
			}
			return result;
		}
		public static bool IsWordPresentInCollection(string[] words, string wordToBeChecked)
		{
			for (int i = 0; i < words.Length; i++)
			{
				if (words[i] == wordToBeChecked)
				{
					return true;
				}
			}
			return false;
		}
		public static int FindMax(int[,] numbers)
		{
			var arrayRow = numbers.GetLength(0);
			var arrayColumn = numbers.GetLength(1);
			var maxValue = 0;
			var currentValue = 0;
			if (arrayRow == 0 || arrayColumn == 0)
			{
				return -1;
			}
			else
			{
				maxValue = numbers[0, 0];
				for (var i = 0; i < arrayRow; i++)
				{
					for (var j = 0; j < arrayColumn; j++)
					{
						currentValue = numbers[i, j];
						if (currentValue > maxValue)
						{
							maxValue = currentValue;
						}
					}
				}
			}
			return maxValue;
		}
		public static bool IsAnyWordLongerThan(int length, string[] words)
		{
			var wordsLength = words.GetLength(0);
			bool result = true;
			if (wordsLength == 0)
			{
				result = false;
			}
			else
			{
				foreach (var word in words)
				{
					if (Convert.ToInt32(word.Length) > length)
						result = true;
					else
						result = false;
				}
			}
			return result;
		}
		public List<string> GetOnlyUpperCaseWords(List<string> words)
		{
			var newWords = new List<string>();
			foreach (var word in words)
			{
				if (newWords.Contains(word))
				{
					continue;
				}
				bool isUpperCase = true;
				foreach (char c in word)
				{
					if (!char.IsUpper(c))
					{
						isUpperCase = false;
					}
				}
				if (isUpperCase)
				{
					newWords.Add(word);
				}
			}
			return newWords;
		}
	}
}
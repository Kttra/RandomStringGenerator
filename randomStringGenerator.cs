using System;
using System.Linq;
/*	Created by Kttra
	
	C# version of my random string generator program. 
*/

public class Program
{
	public static void Main()
	{   //Create random string filled with numbers/letters
		Console.Write("Enter how long you want the string to be (consists of numbers): ");
		int num = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("The random string generated is: " + randomString(num));

		//Create random string filled with only numbers
		Console.Write("Enter how long you want the string to be (integer addition): ");
		num = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("The random string generated is: " + randomNumber(num));

		//Create random string filled with only letters
		Console.Write("Enter how long you want the string to be (only letters): ");
		num = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("The random string generated is: " + randomLetters(num));

		//Create random string filled with only numbers
		Console.Write("Enter how long you want the string to be (only numbers): ");
		num = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("The random string generated is: " + randomNumbers(num));


	}
	private static Random random = new Random();
	//Generate fully random string with letters & numbers
	public static string randomString(int length)
	{
		const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
		return new string(Enumerable.Repeat(chars, length)
			.Select(s => s[random.Next(s.Length)]).ToArray());
	}
	//Generate random string with only letters
	public static string randomLetters(int length)
	{
		const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
		return new string(Enumerable.Repeat(chars, length)
			.Select(s => s[random.Next(s.Length)]).ToArray());
	}
	//Generate random string with only numbers
	public static string randomNumbers(int length)
	{
		const string chars = "0123456789";
		return new string(Enumerable.Repeat(chars, length)
			.Select(s => s[random.Next(s.Length)]).ToArray());
	}
	//Generate random integer with addition and power function
	public static int randomNumber(int length)
	{
		int num = 0;
		for (int i = 0; i < length; i++)
		{
			num += random.Next(0, 9) * (int)Math.Pow(10, i);
		}

		return num;
	}
}
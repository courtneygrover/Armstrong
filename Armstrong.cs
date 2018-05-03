/*
Name: Courtney Grover

This program prints out Armstrong numbers from 10 through 999999.

*/

using System;

public class Armstrong
{
	public static void Main()
	{
		int sum = 0, count = 0;
		double num = 0, n = 0;
		
		Console.WriteLine("ARMSTRONG NUMBERS FOUND FROM 10 THROUGH 999999\n");
		
		for(int x = 10; x < 1000000; x++)
		{
			n = Math.Floor(Math.Log10(x) + 1);
			num = x;
			
			while (num > 0)
			{
				sum += (int) Math.Pow((num%10), n);
				num = (int) (num/10);
			}
			
			if(sum == x)
			{
				Console.WriteLine(x);
				count++;
			}
			
			sum = 0;
			
		}
		
		Console.WriteLine("\nTOTAL NUMBER OF ARMSTRONG NUMBERS FOUND WAS " + count);
			
	}
}
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public static class TwoSum
    {
		public static void Run()
		{
			Console.WriteLine("Hello World");

			var array = new int[] { 2, 5, 3, 6, 8 };
			const int k = 8;

			for (int i = 0; i < array.Length; i++)
			{
				int v1 = array[i];
				int searchValue = k - v1;
				var foundPair = false;
				int v2 = 0;
				for (int j = i + 1; j < array.Length; j++)
				{
					if (i != j && searchValue == array[j])
					{
						foundPair = true;
						v2 = array[j];
						break;
					}
				}

				if (foundPair)
				{
					Console.WriteLine($"v1: {v1} v2: {v2}");

				}
			}

		}
	}
}

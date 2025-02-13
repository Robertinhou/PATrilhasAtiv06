
using System;

namespace exH
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			int[] arr = {2, 4, 7 ,1 ,3, 5, 6};
			int n = arr.Length;
			
			for (int i = 0; i < n - 1; i++)
			{
				for (int j = 0; j < n - i - 1; j++)
				{
					if (arr[j] > arr[j + 1])
					{
						int temp = arr[j];
						arr[j] = arr[j + 1];
						arr[j + 1] = temp;
					}
					
				}
				Console.WriteLine(arr[i]);
				
				
			}
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
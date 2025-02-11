/*
 * Created by SharpDevelop.
 * User: Aluno_Manha
 * Date: 11/02/2025
 * Time: 07:39
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace a
{
	class Program
	{
		public static void Main(string[] args)
		{
			int[] nums = {1, 2, 3 ,4 };
			
			for(int i = 0; i < nums.Length; i++){
				
				Console.WriteLine(nums[i]);
				
			}
			
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
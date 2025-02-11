/*
 * Created by SharpDevelop.
 * User: Aluno_Manha
 * Date: 11/02/2025
 * Time: 09:17
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace e
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			int[] nums = {99999,7,12,24,5};
			int menor = 999999999;
			
			for(int i = 0; i < nums.Length; i++){
				
				for(int j = 1; j < nums.Length; j++){
					
					if(nums[i] < menor ){
						
						menor = nums[i];
						
					}
					
				}
				
			}
			
			Console.WriteLine("O menor é: " + menor);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
			
		}
	}
}
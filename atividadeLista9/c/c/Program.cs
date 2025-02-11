/*
 * Created by SharpDevelop.
 * User: Aluno_Manha
 * Date: 11/02/2025
 * Time: 08:44
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace c
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			double[] nums = {0.5 , 23.5, 50.6};
			double soma = 0;
		
			for(int i = 0; i < nums.Length; i++){
				
				soma += nums[i];
				
			}
			
			double media = soma / nums.Length;
			
			
			Console.WriteLine("A média é: "+ media);
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
/*
 * Created by SharpDevelop.
 * User: Aluno_Manha
 * Date: 10/02/2025
 * Time: 10:27
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace h
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Insira um número:");
			
			int num = int.Parse( Console.ReadLine() );
			
			Console.WriteLine("Divisores: ");
			for(int i = num; i > 0; i --){
				
				if(num%i == 0){
					Console.WriteLine(i);
				}
				
			}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
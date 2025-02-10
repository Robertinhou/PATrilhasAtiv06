/*
 * Created by SharpDevelop.
 * User: Aluno_Manha
 * Date: 10/02/2025
 * Time: 08:36
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace f
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			Console.WriteLine("Insira 5 números: ");
			
			int num = 0;
			
			int maior = 0;
			
			for (int i = 0 ; i < 5  ; i++){
				
			
				
				num = int.Parse(Console.ReadLine());
				
				if(num > maior){
					
					maior = num;
					
				}
				
			}
			
			Console.WriteLine("O maior é "+ maior);
			
			Console.ReadKey();
		
		}
	}
}
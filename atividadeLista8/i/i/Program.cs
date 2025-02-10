/*
 * Created by SharpDevelop.
 * User: Aluno_Manha
 * Date: 10/02/2025
 * Time: 10:34
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace i
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Primos:");
			
			int divisores = 0;
			int j = 0;
			
			for(int i = 2; i <=100; i ++){
				
				for(j = 1; j<= i; j++){
					
					if(i % j == 0 || i % j == i){
						divisores++;
					}
					
				}
				
				if(divisores > 2){
					Console.WriteLine(i +" não é primo!");
				} else{
					Console.WriteLine(i+" é primo");
				}
				
				divisores = 0;
				
			}
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
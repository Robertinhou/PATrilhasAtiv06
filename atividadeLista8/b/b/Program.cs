/*
 * Created by SharpDevelop.
 * User: Aluno_Manha
 * Date: 10/02/2025
 * Time: 07:51
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace b
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Digite um número: ");
			
			int num = int.Parse(Console.ReadLine());
			
			for (int i= 0; i<=num; i++){
	
				if(i % 2 == 0){
					
					Console.WriteLine(i);
					
				}

			}
			
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
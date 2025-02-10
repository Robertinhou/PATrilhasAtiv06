/*
 * Created by SharpDevelop.
 * User: Aluno_Manha
 * Date: 10/02/2025
 * Time: 10:16
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace g
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			int i = 1;
			int j = 5;
			
			Console.WriteLine("A tabuada do 5: ");
			
			for(j = 5 ; j <= 10; j++){
				Console.WriteLine("----------- Tabuada do "+ j + " -------------");
				for (i = 1; i<=10; i++){
					Console.WriteLine(j+ " X "+ i + " = " + j*i);
				}
				
				i = 1;
				
			}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
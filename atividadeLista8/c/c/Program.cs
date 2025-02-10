/*
 * Created by SharpDevelop.
 * User: Aluno_Manha
 * Date: 10/02/2025
 * Time: 08:04
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
						
			Console.WriteLine("Insira uma palavra: ");
			
			string palavra = Console.ReadLine();
			
			char[] letras = new char[palavra.Length] ;
			
			for(int i = 0; i < palavra.Length; i++){
				
				letras[i] = palavra[i];
				
				Console.WriteLine(letras[i]);
				
			}
			
			
			
			
			
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
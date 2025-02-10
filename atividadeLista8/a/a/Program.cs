/*
 * Created by SharpDevelop.
 * User: Aluno_Manha
 * Date: 10/02/2025
 * Time: 07:44
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
			
			Console.WriteLine("Os números pares entre 0 e 100 são: ");
			
			for(int i = 0; i<= 100;i++){
				
				if(i % 2 == 0){
					Console.WriteLine(i);
				}
				
			}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
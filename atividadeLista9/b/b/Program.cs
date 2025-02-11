/*
 * Created by SharpDevelop.
 * User: Aluno_Manha
 * Date: 11/02/2025
 * Time: 08:09
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
			
			
			string[] nome = new string[5];
			
			float[] notaPrimBimestre = new float[5];
			
			float[] notaSegBimestre = new float[5];
			
			float[] medias = new float[5];
			
			
			Console.WriteLine("Bem vindo!");
			
			
			for(int i = 0; i < nome.Length; i++){
				
				Console.Write("Nome: ");
				nome[i] = Console.ReadLine();
				
				Console.Write("Nota 1: ");
				notaPrimBimestre[i] = int.Parse(Console.ReadLine());
				
				Console.Write("Nota 2: ");
				notaSegBimestre[i] = int.Parse(Console.ReadLine());
				
				medias[i] = (notaPrimBimestre[i] + notaSegBimestre[i]) / 2;
				
				Console.Clear();
				
				
			}
			
			Console.Clear();
			
			for(int j = 0; j < nome.Length; j++){
				
				Console.WriteLine("Nome: {0}", nome[j]);
				Console.WriteLine("Nota primeiro bimestre: {0}", notaPrimBimestre[j]);
				Console.WriteLine("Nota primeiro bimestre: {0}", notaSegBimestre[j]);
				Console.WriteLine("Média: {0}", medias[j]);
				Console.WriteLine("------------------------------------------------------------");
			}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
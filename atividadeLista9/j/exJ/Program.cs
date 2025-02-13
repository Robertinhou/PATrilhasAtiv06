using System;

class Program
{
	class Mercadoria
	{
		public string Nome;
		public int Quantidade;
		public double Preco;
	}

	static void Main(string[] args)
	{
		Mercadoria[] produtos = new Mercadoria[40];
		int contador = 0;
		int opcao;

		do
		{
			Console.WriteLine("\n====================== OPÇÕES ======================");
			Console.WriteLine("1_ Cadastrar mercadorias");
			Console.WriteLine("2_ Preço total em mercadoria da empresa");
			Console.WriteLine("3_ Sair");
			Console.WriteLine("Escolha uma opção:");
			opcao = int.Parse(Console.ReadLine());

			switch (opcao)
			{
				case 1:
					while (contador < 40)
					{
						Console.WriteLine("Informe o nome do produto:");
						string nome = Console.ReadLine();

						Console.WriteLine("Informe o preço do {0}:", nome);
						double preco;
						if (!double.TryParse(Console.ReadLine(), out preco)) continue;

						Console.WriteLine("Informe a quantidade do {0}:", nome);
						int quantidade;
						if (!int.TryParse(Console.ReadLine(), out quantidade)) continue;

						produtos[contador++] = new Mercadoria { Nome = nome, Preco = preco, Quantidade = quantidade };

						Console.WriteLine("Deseja continuar? (s/n): ");
						if (Console.ReadLine().ToLower() != "s") break;
					}
					break;

				case 2:
					double precoTotal = 0;
					for (int i = 0; i < contador; i++)
					{
						precoTotal += produtos[i].Preco * produtos[i].Quantidade;
					}
					Console.WriteLine("Valor total em mercadorias: {0}", precoTotal);
					break;

				case 3:
					Console.WriteLine("Saindo...");
					break;

				default:
					Console.WriteLine("Opção inválida. Tente novamente.");
					break;
			}

		} while (opcao != 3);
	}
}

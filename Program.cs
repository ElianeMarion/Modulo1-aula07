namespace Aula07_MetodosFuncoes
{
	internal class Program
	{

		public static double n1, n2;
		public static double resultado;
		public static int opcao;

		//procedimento  |   função sem retorno | método sem retorno  
		public static void exibirMenu()
		{
			Console.WriteLine("Agora, selecione a operação:\n\n" +
				"1 - Adição\n" +
				"2 - Subtração\n" +
				"3 - Multiplicação\n" +
				"4 - Divisão\n");
			opcao = Convert.ToInt32(Console.ReadLine());
		}
		//variável global
		

		//Passagem de argumento é feita dentro dos parênteses (informação)
		public static void exibirResultado()
		{
			Console.WriteLine("O resultado foi " + resultado + "!");
		}

		public static void entradaDados()
		{
			Console.WriteLine("Digite o primeiro número: ");
			n1 = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Digite o primeiro número: ");
			n2 = Convert.ToDouble(Console.ReadLine());
		}

		public static void exibirResultadoComArgumento(double r)
		{
			Console.WriteLine("O resultado foi " + r + "!");
		}
		
		static void Main(string[] args)
		{
			double res=0;
			Console.WriteLine("Minha Super Calculadora\n\n");
			entradaDados();
			exibirMenu();
			
			switch (opcao)
			{
				case 1:
					res = n1 + n2;
					//Console.WriteLine("Soma {0}", res.ToString());
					break;
				case 2:
					res = n1 - n2;
					//Console.WriteLine("Subtração {0}", res.ToString());
					break;
				case 3:
					res = n1 * n2;
					//Console.WriteLine("Multiplicação {0}", res.ToString());
					break;
				case 4:
					if (n2 != 0)
					{
						res = n1 / n2;
				//		Console.WriteLine("Divisão {0}", res.ToString());
					}
					else
					{
						Console.WriteLine("Impossível dividir por zero!");
					}
					break;
				default:
					Console.WriteLine("Opção inválida");
					break;

			}
			resultado = res;
			exibirResultado();
			exibirResultadoComArgumento(res);

		}

		
	}
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodo_burbuja
{
	class Program
	{
		static void Main(string[] args)
		{

			int n = 0, m = 0;
			int[] numeros;

			Console.WriteLine("escriba la cantidad de numeros");
			n = int.Parse(Console.ReadLine());
			numeros = new int[n];
			for (int a = 0; a < n; a++)
			{
				Console.Write("escriba el numero [{0}]:", a);
				numeros[a] = int.Parse(Console.ReadLine());
			}
			for (int b = 1; b < n; b++)
			{
				for (int c = 0; c < n - 1; c++)
				{
					if (numeros[b] < numeros[c])
					{
						m = numeros[b];
						numeros[b] = numeros[c];
						numeros[c] = m;
					}
				}
			}
			for (int r = 0; r < n; r++)
				Console.WriteLine("{0}.-{1}", r + 1, numeros[r]);
			Console.Read();
		}
	}
}


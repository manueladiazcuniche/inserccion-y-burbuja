using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodo_inserccion
{
	class 
		Program
	{
		static void Main(string[] args)
		{
			//metodo de inserccion


            int[] numeros = new int[5] { 10, 25, 05, 01, 100 };
			int longitud = 5;//cinco datos incluidos en el vector
			Console.WriteLine("programa metodo de insercion");
			int auxiliar;
			int x;
			for (int i = 0; i < numeros.Length; i++)
			{
				auxiliar = numeros[i];
				x = i - 1;
				while (x >= 0 && numeros[x] > auxiliar)
				{
					numeros[x + 1] = numeros[x];
					x--;
				}
				numeros[x + 1] = auxiliar;
			}
			for (int i = 0; i < longitud; i++)
				Console.WriteLine(" " + numeros[i]);
			Console.Read();

		}
	}
}







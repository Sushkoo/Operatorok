using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Operatorok
{
	internal class Program
	{
		static List<Operatorok> lista = new List<Operatorok>();
		static void Main(string[] args)
		{
			StreamReader sr = new StreamReader("kifejezesek.txt");

			sr.ReadLine();

			while (sr.EndOfStream)
			{
				var sorok = sr.ReadLine().Split(' ');

				Operatorok uj = new Operatorok(int.Parse(sorok[0]), sorok[1], int.Parse(sorok[2]));
			}
			sr.Close();

			//2.feladat

			int ossz = lista.Count();
			Console.WriteLine(ossz);

			//3.feladat

			int modok = lista.Where(x=>x.OOperator=="mod").Count();
			Console.WriteLine(modok);

			//4.feladat

			bool vane = lista.Any(x => x.ElsoOperandus % 10 == 0 && x.MasodikOperandus % 10 == 0);
			Console.WriteLine(vane);

			//5.feladat


			
		}
	}
}
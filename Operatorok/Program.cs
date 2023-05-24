using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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

			Console.WriteLine($"mod ->{lista.Count(x => x.OOperator == "mod")}db");
			Console.WriteLine($"/ ->{lista.Count(x => x.OOperator == "/")}db");
			Console.WriteLine($"div ->{lista.Count(x => x.OOperator == "div")}db");
			Console.WriteLine($"- ->{lista.Count(x => x.OOperator == "-")}db");
			Console.WriteLine($"* ->{lista.Count(x => x.OOperator == "*")}db");
			Console.WriteLine($"+ ->{lista.Count(x => x.OOperator == "+")}db");

			//6.feladat

			//7.feladat (kell hozzá a 6 os)

			//8.feladat

			string seged = "";

			StreamWriter sw = new StreamWriter("eredmenyek.txt");
				foreach( var x in lista )
				{
					seged=x.ElsoOperandus+x.OOperator+x.MasodikOperandus;
					sw.WriteLine(seged);
				}
				sw.Close();

		}
	}
}
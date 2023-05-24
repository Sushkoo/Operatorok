using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operatorok
{
	public class Operatorok
	{
		int elsoOperandus;
		string oOperator;
		int masodikOperandus;

		public Operatorok(int elsoOperandus, string oOperator, int masodikOperandus)
		{
			this.elsoOperandus = elsoOperandus;
			this.oOperator = oOperator;
			this.masodikOperandus = masodikOperandus;
		}

		public int ElsoOperandus { get => elsoOperandus; }
		public string OOperator { get => oOperator; }
		public int MasodikOperandus { get => masodikOperandus; }
	}
}

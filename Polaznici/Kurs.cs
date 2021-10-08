using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polaznici
{
	public class Kurs
	{
		public string Naziv { get; set; }

		public List<Polaznik> Polaznici { get; set; } = new();
	}
}

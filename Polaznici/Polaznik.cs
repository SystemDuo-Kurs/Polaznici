using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polaznici
{
	public class Polaznik
	{
		public string Ime { get; set; }
		public string Prezime { get; set; }

		public string PrezimeIIme 
		{ 
			get => $"{Prezime} {Ime}";
		}

		public List<Kurs> Kursevi { get; set; } = new();

		public override string ToString()
			=> PrezimeIIme;
		
	}
}

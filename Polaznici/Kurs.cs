using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polaznici
{
	public class Kurs
	{
		public string Naziv { get; set; }

		public ObservableCollection<Polaznik> Polaznici { get; set; } = new();

		public DateTime? Pocinje { get; set; } = null;
		public DateTime? Zavrsava { get; set; } = null;
		public TimeSpan Traje { get; set; }
		public bool[] Dani { get; set; } = new bool[7];
	}
}

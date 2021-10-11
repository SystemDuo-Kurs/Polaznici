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
	}
}

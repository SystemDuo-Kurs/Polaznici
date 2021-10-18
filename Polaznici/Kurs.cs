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

		public DateTime? DatumPocetka { get; set; }
		public DateTime? DatumKraja { get; set; }

		public bool ProveraDatuma(DateTime datum)
			=> DatumPocetka.HasValue && DatumKraja.HasValue && 
			datum.Date >= DatumPocetka.Value.Date && datum.Date <= DatumKraja.Value.Date;
		public bool ProveraDana(DateTime datum)
			=> Dani.Contains(datum.DayOfWeek);

		public TimeSpan VremePocetka { get; set; }
		public TimeSpan Trajanje { get; set; }

		public bool ProveraVremena(TimeSpan vreme)
			=> vreme >= VremePocetka && vreme <= VremePocetka + Trajanje;

		public bool Provera(DateTime vreme)
			=> ProveraDatuma(vreme) && ProveraDana(vreme) && ProveraVremena(vreme.TimeOfDay);

		public List<DayOfWeek> Dani { get; set; } = new();
	}
}

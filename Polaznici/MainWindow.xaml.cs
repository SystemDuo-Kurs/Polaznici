using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Polaznici
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public ObservableCollection<Kurs> Kursevi { get; set; } = new();
		public Kurs Kurs { get; set; } = new();

		public ObservableCollection<Polaznik> Polaznici { get; set; } = new();
		public Kurs Polaznik { get; set; } = new();

		public MainWindow()
		{
			InitializeComponent();

			Kursevi.Add(new Kurs { Naziv = "asd" });
			Kursevi.Add(new Kurs { Naziv = "qwe" });
			Kursevi.Add(new Kurs { Naziv = "zxc" });
			Kursevi.Add(new Kurs { Naziv = "fgh" });

			Polaznici.Add(new Polaznik { Ime = "Pera", Prezime = "Peric" });
			Polaznici.Add(new Polaznik { Ime = "Neko", Prezime = "Nekic" });
			Polaznici.Add(new Polaznik { Ime = "Asd", Prezime = "Qwe" });
			Polaznici.Add(new Polaznik { Ime = "Ideje", Prezime = "Nemam" });

		
			dgKurs.ItemsSource = Kursevi;
			spKurs.DataContext = Kurs;
			dgPolaznici.ItemsSource = Polaznici;
			spPolaznici.DataContext = Polaznik;

			
		}

		private void Unos(object sender, RoutedEventArgs e)
		{
			Kurs k = spKurs.DataContext as Kurs;
			if (!(string.IsNullOrEmpty(k.Naziv) ||
				string.IsNullOrWhiteSpace(k.Naziv)))
			{
				k.Naziv = k.Naziv.Trim();

				//Pretraga iteracijom
				//bool nadjenDuplikat = false;
				//foreach (Kurs ku in Kursevi)
				//{
				//	if (ku.Naziv.ToLower() == k.Naziv.ToLower())
				//	{
				//		nadjenDuplikat = true;
				//		break;
				//	}
				//}

				//Provera sa LINQ-om :)
				if (!Kursevi.
						Where(ku => ku.Naziv.ToLower() == k.Naziv.ToLower()).
						Any())
				{
					Kursevi.Add(spKurs.DataContext as Kurs);
					spKurs.DataContext = new Kurs();
				} else
				{
					MessageBox.Show("Jok!");
				}

				//Star koliko dinosaursi
				//for (int indeks = 0; indeks < Kursevi.Count; indeks++)
				//	MessageBox.Show(Kursevi[indeks].Naziv);

				//Moderniji nacin
				//foreach (Kurs ku in Kursevi)
				//	MessageBox.Show(ku.Naziv);

				//Ultra moderan nacin
				//Kursevi.ToList().ForEach(k => MessageBox.Show(k.Naziv));

				
			}
			else
				MessageBox.Show("Jok!");
		}

		private void Brisanje(object sender, RoutedEventArgs e)
		{
			Kursevi.Remove((dgKurs.SelectedItem as Kurs));
		}

		private void DupliKlik(object sender, MouseButtonEventArgs e)
		{
			if (dgPolaznici.SelectedItem is not null)
			{
				PolaznikInfo pi = new(dgPolaznici.SelectedItem as Polaznik);
				pi.Owner = this;
				pi.ShowDialog();
			}
			
		}

		private void KursDupli(object sender, MouseButtonEventArgs e)
		{
			if (dgKurs.SelectedItem is not null)
			{
				Upis u = new(dgKurs.SelectedItem as Kurs, Polaznici);
				u.Owner = this;
				u.ShowDialog();
			}
		}
	}

	
}

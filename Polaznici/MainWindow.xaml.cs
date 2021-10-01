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

		public MainWindow()
		{
			InitializeComponent();
			dgKurs.ItemsSource = Kursevi;
			spKurs.DataContext = Kurs;
		}

		private void Unos(object sender, RoutedEventArgs e)
		{
			Kursevi.Add(spKurs.DataContext as Kurs);
			spKurs.DataContext = new Kurs();
		}
	}

	
}

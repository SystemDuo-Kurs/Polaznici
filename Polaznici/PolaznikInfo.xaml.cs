using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace Polaznici
{
	/// <summary>
	/// Interaction logic for PolaznikInfo.xaml
	/// </summary>
	public partial class PolaznikInfo : Window
	{
		public PolaznikInfo(Polaznik p)
		{
			InitializeComponent();
			DataContext = p;
			BindingGroup = new();
		}

		private void Ok(object sender, RoutedEventArgs e)
		{
			BindingGroup.UpdateSources();
			Close();
		}

		private void Otkazi(object sender, RoutedEventArgs e)
			=> Close();
		
	}
}

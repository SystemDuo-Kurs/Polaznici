﻿using System;
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
using System.Windows.Shapes;

namespace Polaznici
{
	/// <summary>
	/// Interaction logic for Upis.xaml
	/// </summary>
	public partial class Upis : Window
	{
		public Kurs Kurs { get; set; }
		public ObservableCollection<Polaznik> Polaznici { get; set; } = new();
		public Upis(Kurs k, ObservableCollection<Polaznik> p)
		{
			InitializeComponent();
			DataContext = Kurs = k;
			
			Polaznici = p;
			lbPolaznici.ItemsSource = Polaznici;
			tamo.Content = "-->";
			ovamo.Content = "<--";
		}
	}
}

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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Demo {
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window {
		public MainWindow() {
			InitializeComponent();
		}

		private void btn_bcdisplay_click(object sender, RoutedEventArgs e) {
			btn_bcdisplay.IsChecked = true;
			btn_panelsdisplay.IsChecked = false;
			btn_controlsdisplay.IsChecked = false;
			btn_textareadisplay.IsChecked = false;
			this.Page_Content.Source = new Uri("DisplayBasicColor.xaml", UriKind.Relative);
		}

		private void btn_panelsdisplay_click(object sender, RoutedEventArgs e) {
			btn_bcdisplay.IsChecked = false;
			btn_panelsdisplay.IsChecked = true;
			btn_controlsdisplay.IsChecked = false;
			btn_textareadisplay.IsChecked = false;
			this.Page_Content.Source = new Uri("DisplayPanel.xaml", UriKind.Relative);
		}

		private void btn_controlsdisplay_Click(object sender, RoutedEventArgs e) {
			btn_bcdisplay.IsChecked = false;
			btn_panelsdisplay.IsChecked = false;
			btn_controlsdisplay.IsChecked = true;
			btn_textareadisplay.IsChecked = false;
			this.Page_Content.Source = new Uri("DisplayControl.xaml", UriKind.Relative);
		}

		private void btn_textareadisplay_Click(object sender, RoutedEventArgs e) {
			btn_bcdisplay.IsChecked = false;
			btn_panelsdisplay.IsChecked = false;
			btn_controlsdisplay.IsChecked = false;
			btn_textareadisplay.IsChecked = true;
			this.Page_Content.Source = new Uri("DisplayTextarea.xaml", UriKind.Relative);
		}
	}
}

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

namespace Tools {
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window {
		public MainWindow() {
			InitializeComponent();
		}

		private void Button_T2XC_Convert_Click(object sender, RoutedEventArgs e) {
			string stext = text_T2XC_Source.Text;
			StringBuilder sb = new StringBuilder(stext.Length);
			foreach (var item in stext) {
				switch (item) {
					case '\r': continue;
					case '\n': sb.Append("&#x0a;\r\n"); break;
					case '<': sb.Append("&lt;"); break;
					case '>': sb.Append("&gt;"); break;
					case '&': sb.Append("&amp;"); break;
					case '\"': sb.Append("&quot;"); break;
					default: sb.Append(item); break;
				}

			}

			text_T2XC_Output.Text = sb.ToString();
		}
	}
}
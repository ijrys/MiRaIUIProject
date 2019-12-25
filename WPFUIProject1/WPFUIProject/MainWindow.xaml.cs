using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFUIProject {
	/// <summary>
	/// MainWindow.xaml 的交互逻辑
	/// </summary>
	public partial class MainWindow : Window {
		public MainWindow() {
			InitializeComponent();

			BitmapImage icon1 = new BitmapImage(new Uri("pack://application:,,,/res/Dark_Icon_Pro.png", UriKind.RelativeOrAbsolute));
			BitmapImage icon2 = new BitmapImage(new Uri("pack://application:,,,/res/Dark_Icon_Gra.png", UriKind.RelativeOrAbsolute));

			ObservableCollection<TreeViewNode> tviewnodes = new ObservableCollection<TreeViewNode>();
			tview.ItemsSource = tviewnodes;

			TreeViewNode root1 = new TreeViewNode() { NodeName = "root node", Icon = icon1 };
			root1.Childrens.Add(new TreeViewNode() { NodeName = "node 1.1", Icon = icon2 });
			root1.Childrens.Add(new TreeViewNode() { NodeName = "node 1.2", Icon = icon2 });
			tviewnodes.Add(root1);
			TreeViewNode root2 = new TreeViewNode() { NodeName = "root node", Icon = icon1 };
			root2.Childrens.Add(new TreeViewNode() { NodeName = "node 2.1", Icon = icon2 });
			root2.Childrens.Add(new TreeViewNode() { NodeName = "node 2.2", Icon = icon2 });
			tviewnodes.Add(root2);

			//ScrollViewer sv = new ScrollViewer();
			//sv.Visibility = Visibility.
		}

		private void Button_Click(object sender, RoutedEventArgs e) {
			//ToggleButton tbtn = new ToggleButton();
		}
	}

	public class TreeViewNode {
		public ObservableCollection<TreeViewNode> Childrens { get; set; } = new ObservableCollection<TreeViewNode>();

		public BitmapImage Icon { get; set; }
		public string NodeName { get; set; }
	}
}

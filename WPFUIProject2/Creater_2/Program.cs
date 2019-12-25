using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creater {
	class Program {
		static void Main(string[] args) {
			//<SolidColorBrush x:Key="Brush_Control_BG_Normal_Normal" Color="#000"/>
			string[] ObjType = new string[] { "Control", "Panel", "Textarea" };
			string[] ObjPropety = new string[] { "BG", "FG", "Border" };
			string[] ObjInfoState = new string[] { "Normal", "Disable", "Toggle"}; //"Normal", "Disable", "Toggle", "Imp", "Warning", "Error"
			string[] ObjUIState = new string[] { "Normal", "PointIn", "FocusOn", "PandF", "Pressed" };

			foreach (string titem in ObjType) {
				foreach (var iitem in ObjInfoState) {
					foreach (var uitem in ObjUIState) {
						foreach (var pitem in ObjPropety) {
							//if (iitem == "Disable" && uitem == "Pressed") continue;
							Console.WriteLine("<SolidColorBrush x:Key=\"Brush_{0}_{1}_{2}_{3}\" Color=\"#F00\"/>", titem, pitem, iitem, uitem);
						}
						Console.WriteLine();
					}
				}
			}

			Console.ReadLine();
		}
	}
}

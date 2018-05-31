using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry4 {
	class Rectangle {

		public double height { get; set; }
		public double width { get; set; }

		public double GetArea() {
			return height * width;
		}

		public double GetPerimeter() {
			return 2 * (height + width);
		}

		public void Print() {
			Console.WriteLine($"A rectangle with height {height} and width {width} has an area of {GetArea()} and a perimeter of {GetPerimeter()}");
		}
	}
}

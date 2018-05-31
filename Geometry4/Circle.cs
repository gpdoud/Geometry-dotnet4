using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry4 {
	class Circle {

		private double Pi = 3.1415;
		public double Radius { get; set; }

		public double GetArea() {
			return Pi * Radius * Radius;
		}

		public double GetPerimeter() {
			return 2 * Pi * Radius;
		}

		public void Print() {
			Console.WriteLine($"A circle with radius {Radius} has an area of {GetArea()} and a perimeter of {GetPerimeter()}");
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry4 {
	class Square {

		public double LengthOfSides { get; set; }

		public double GetArea() {
			return LengthOfSides * LengthOfSides;
		}

		public double GetPerimeter() {
			return 4 * LengthOfSides;
		}

		public void Print() {
			Console.WriteLine($"A square with length {LengthOfSides} has an area of {GetArea()} and a perimeter of {GetPerimeter()}");
		}
	}
}

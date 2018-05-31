using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry4 {
	class Program {
		static void Main(string[] args) {

			Circle c1 = new Circle();
			c1.Radius = 1.0;
			c1.Print();

			Rectangle rect1 = new Rectangle();
			rect1.height = 1.2;
			rect1.width = 8.2;
			rect1.Print();

			Square sqr = new Square();
			sqr.LengthOfSides = 1.5;
			sqr.Print();
			//double area = sqr.GetArea();
			//double perimeter = sqr.GetPerimeter();
			//Console.WriteLine("Area is {0}, Perimeter is {1}", area, perimeter);

			Square sqr2 = new Square();
			sqr2.LengthOfSides = 3.3;
			sqr2.Print();

		}
	}
}

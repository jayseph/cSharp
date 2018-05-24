/*
	C# program #02
	variables
*/

using System;
//using Math;

class UseVars {
	static void Main() {
		int length;
		int width;
		int area;
		
		length = 9;
		width = 7;
		area = length * width;
		Console.WriteLine("the length is " + length);
		Console.WriteLine("the width is " + width);
		Console.Write("the area is: ");
		Console.WriteLine(area);
//		Console.WriteLine(Math.Pi);
		Console.WriteLine(Math.Sqrt(9));
		
	}
}
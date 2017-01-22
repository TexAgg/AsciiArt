using System;
using System.Drawing;
using System.IO;

namespace AsciiArt
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			if (args.Length == 0)
			{
				Console.WriteLine("Please enter a filename");
				return;
			}

			string filename = args[0];
			AsciiArt ascii = new AsciiArt(Image.FromFile(filename), 100, 100);
			string result = ascii.Generate();
			StreamWriter fwriter = new StreamWriter(Path.GetFileNameWithoutExtension(filename) + ".txt");
			fwriter.WriteLine(result);
		}
	}
}

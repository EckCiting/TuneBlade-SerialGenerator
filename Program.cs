using System;

namespace BreakFreeAudioKeyMaker
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			var generatorTuneBlade = new TuneBlade();
			var resultTuneBlade = "";
	                Console.WriteLine("Input your lisence ID (your email) here");
			while (true){
				var email = Console.ReadLine();
				resultTuneBlade = generatorTuneBlade.Generate(email);
				Console.WriteLine("TuneBlade: " + resultTuneBlade);
			};
			
			//var generatorTuneAero = new TuneAero();
			//var resultTuneAero = generatorTuneAero.Generate();

			//Console.WriteLine("TuneAero: " + resultTuneAero);
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text.RegularExpressions;

namespace CelestialBodyThing
{
	public class Program
	{
		public static void Main(string[] args)
		{
			//intordcution so the user enters the first two variables, radius and density after beign told so
			Console.WriteLine("Please enter your parent body's radius in meters and press enter when done: ");
			//set up variables
			decimal parentBodyRadius = Convert.ToDecimal(Console.ReadLine());
			//new question
			Console.WriteLine("Enter the density of your parent body in kg/m and press enter when done:");
			decimal parentBodyDensity = Convert.ToDecimal(Console.ReadLine());
			//the rest are automatic
			decimal parentBodyVolume;
			decimal pi = 3.141592m;
			double parentBodyMass;
			double gravitationConstant = 0.0000000000667384;
			double parentBodyGravity;

			//initialize variables
			//parentBodyRadius = 695700000; //in meters
			//parentBodyDensity = 1408;

			//math it out
			parentBodyVolume = 4m / 3m * pi * (parentBodyRadius * parentBodyRadius * parentBodyRadius);
			double parentBodyDensityDouble = Decimal.ToDouble(parentBodyDensity);
			double parentBodyVolumeDouble = Decimal.ToDouble(parentBodyVolume);
			double parentBodyRadiusDouble = Decimal.ToDouble(parentBodyRadius);
			parentBodyMass = parentBodyDensityDouble * parentBodyVolumeDouble;
			parentBodyGravity = ((gravitationConstant * parentBodyMass)/(parentBodyRadiusDouble * parentBodyRadiusDouble))/ 9.8;

			//debug and output
			Console.WriteLine($"Radius: {parentBodyRadius}"); 
			Console.WriteLine($"Volume: {parentBodyVolume}");
			Console.WriteLine($"Mass: {parentBodyMass}");
			Console.WriteLine($"Gravity in Gees: {parentBodyGravity}");
		}
	}
}
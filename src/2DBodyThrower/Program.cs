using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace CelestialBodyThing
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hiiiii so just press enter to start this stupid program");
			Console.ReadLine();
			//intordcution so the user enters the first two variables, radius and density after beign told so
			Console.WriteLine("Please enter your  body's radius in meters and press enter when done: ");
			//set up variables
			decimal BodyRadius = Convert.ToDecimal(Console.ReadLine());
			//new question
			Console.WriteLine("Enter the density of your  body in kg/m and press enter when done:");
			decimal BodyDensity = Convert.ToDecimal(Console.ReadLine());
			//the rest are automatic
			decimal BodyVolume;
			decimal pi = 3.141592m;
			double BodyMass;
			double gravitationConstant = 0.0000000000667384;
			double BodyGravity;

			//initialize variables	//test variables for the sun
			//BodyRadius = 695700000; //in meters
			//BodyDensity = 1408;

			//math it out
			BodyVolume = 4m / 3m * pi * (BodyRadius * BodyRadius * BodyRadius);
			double BodyDensityDouble = Decimal.ToDouble(BodyDensity);
			double BodyVolumeDouble = Decimal.ToDouble(BodyVolume);
			double BodyRadiusDouble = Decimal.ToDouble(BodyRadius);
			BodyMass = BodyDensityDouble * BodyVolumeDouble;
			BodyGravity = ((gravitationConstant * BodyMass)/(BodyRadiusDouble * BodyRadiusDouble))/ 9.8;

			//debug and output
			Console.WriteLine($"Radius: {BodyRadius}"); 
			Console.WriteLine($"Volume: {BodyVolume}");
			Console.WriteLine($"Mass: {BodyMass}");
			Console.WriteLine($"Gravity in Gees: {BodyGravity}");


			//ok so now for the space moving stuff
			double x = 6;
			double y = 1984;
			Console.WriteLine($"Starting position: {x}, {y}");
			double vx = 96;
			double vy = 19444.444;
			Console.WriteLine($"Starting Velocity: {vx}, {vy}");
			int i = 0;
			int dayNumber = 0; 

			while (i < 15) 
			{
				dayNumber++;
				i++;
				double ivx = vx * i;
				double ivy = vy * i;
				Console.WriteLine($"Day{dayNumber}: {x + ivx}, {y + ivy}");
			}
		}
	}
}
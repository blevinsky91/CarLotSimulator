using System;
using System.Collections.Generic;
namespace CarLotSimulator
{
	public class Car
	{
		//public Car()
		//{
		//}

		public string Make { get; set; } //field
		public string Model { get; set; }
		public int Year { get; set; }
		public string EngineNoise { get; set; }
		public string HonkNoise { get; set; }
		public bool IsDriveable { get; set; }
		public bool Convertible { get; set; }

		public void MakeEngineNoise(string engineNoise)
        {
			
		}

		public void MakeHonkNoise(string honkNoise)
		{

		}

		//BONUS
		//public Car(string name, string color)
		//{
			//Name = name;
			//Color = color;
		//}

		//public string Name { get; set; }
		//public string Color { get; set; }

	}
}


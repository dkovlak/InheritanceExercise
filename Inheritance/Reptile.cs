using System;
namespace Inheritance
{
	public class Reptile : Animal
	{
		public Reptile()
		{
		}

        public bool Eats { get; set; }
        public string Species { get; set; }
        public string ScaleType { get; set; }
        public int PreferredTemperatureRange { get; set; }

        // Constructor
        public Reptile(bool eats, string species, string scaleType, int preferredTemperatureRange)
        {
            Eats = true;
            Species = species;
            ScaleType = scaleType;
            PreferredTemperatureRange = preferredTemperatureRange;
        }
    }
}


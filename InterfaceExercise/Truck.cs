using System;
namespace InterfaceExercise
{
	public class Truck : IVehicle, ICompany
    {
		public Truck()
		{
		}
		public bool Is4WheelDrive { get; set; }
		public double TowCapacity { get; set; }

        public bool InDrive { get; set; }
        public bool InReverse { get; set; }
        public string Model { get; set; }
        public string Make { get; set; }
        public int Year { get; set; }

        public string Logo { get; set; }
        public string CompanyName { get; set; }

        public void HonkNoise()
        {
            Console.WriteLine("HONKY TONKY");
        }
    }
}


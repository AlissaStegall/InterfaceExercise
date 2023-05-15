using System;
namespace InterfaceExercise
{
	public class Car : IVehicle, ICompany
	{
		public Car()
		{
		}
		public bool HasTrunk { get; set; }
		public bool IsHatchback { get; set; }

        public bool InDrive { get; set; }
        public bool InReverse { get; set; }
        public string Model { get; set; }
        public string Make { get; set; }
        public int Year { get; set; }

        public string Logo { get; set; }
        public string CompanyName { get; set; }

        public void HonkNoise()
        {
            Console.WriteLine("HONK HONK");
        }
    }
}


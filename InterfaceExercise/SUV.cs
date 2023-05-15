using System;
namespace InterfaceExercise
{
	public class SUV : IVehicle, ICompany
    {
		public SUV()
		{
		}
		public bool ThirdRowSeating { get; set; }
		public int NumberOfSeats { get; set; }

        public bool InDrive { get; set; }
        public bool InReverse { get; set; }
        public string Model { get; set; }
        public string Make { get; set; }
        public int Year { get; set; }

        public string Logo { get; set; }
        public string CompanyName { get; set; }

        public void HonkNoise()
        {
            Console.WriteLine("BEEP BEEP");
        }
    }
}


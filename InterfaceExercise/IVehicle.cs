using System;
namespace InterfaceExercise
{
	public interface IVehicle
	{
		public bool InDrive { get; set; }
		public bool InReverse { get; set; }
		public string Model { get; set; }
		public string Make { get; set; }
		public int Year { get; set; }

		public void HonkNoise();

	}
}


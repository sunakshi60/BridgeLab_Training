using System;

namespace PracticeProblems
{
	class Vehicle
	{
		private int MaxSpeed;
		private string FuelType;

		public Vehicle(int maxSpeed, string fuelType)
		{
			MaxSpeed = maxSpeed;
			FuelType = fuelType;
		}

		public virtual void DisplayInfo()
		{
			Console.WriteLine($"Max Speed : {MaxSpeed} km/h");
			Console.WriteLine($"Fuel Type : {FuelType}");
		}
	}

	class Car : Vehicle
	{
		private int SeatCapacity;

		public Car(int maxSpeed, string fuelType, int seatCapacity) : base(maxSpeed, fuelType)
		{
			SeatCapacity = seatCapacity;
		}

		public override void DisplayInfo()
		{
			Console.WriteLine("----- Car -----");
			base.DisplayInfo();
			Console.WriteLine($"Seat Capacity : {SeatCapacity}");
		}
	}

	class Truck : Vehicle
	{
		private int PayloadCapacity;

		public Truck(int maxSpeed, string fuelType, int payloadCapacity) : base(maxSpeed, fuelType)
		{
			PayloadCapacity = payloadCapacity;
		}

		public override void DisplayInfo()
		{
			Console.WriteLine("----- Truck -----");
			base.DisplayInfo();
			Console.WriteLine($"Payload Capacity : {PayloadCapacity} kg");
		}
	}

	class Motorcycle : Vehicle
	{
		private bool HasSidecar;

		public Motorcycle(int maxSpeed, string fuelType, bool hasSidecar) : base(maxSpeed, fuelType)
		{
			HasSidecar = hasSidecar;
		}

		public override void DisplayInfo()
		{
			Console.WriteLine("----- Motorcycle -----");
			base.DisplayInfo();
			Console.WriteLine($"Has Sidecar : {HasSidecar}");
		}
	}
}
namespace ClassLibrary1
{
	public class Car
	{
		private string make;
		private string model;
		private decimal rentalPrice;
		private bool rented;

		public bool Rent()
		{
			if (!rented)
			{
				rented = true;
				return true;
			}
			else
			{
				Console.WriteLine("The Car is already rented");
				return false;
			}
		}

		public bool Return()
		{
			if (rented)
			{
				rented = false;
				return true;
			}
			else
			{
				Console.WriteLine("The Car is not currently rented");
				return false;
			}
		}

		public void PrintInfo()
		{
			Console.Write(make + " " + model + "(Rental price: " + rentalPrice + ")" + " - ");
			if(rented)
			{
				Console.WriteLine("available");
			}
			else
			{
				Console.WriteLine("not available");
			}
		}
	}
}

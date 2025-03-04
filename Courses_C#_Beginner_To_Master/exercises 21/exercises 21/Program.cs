using System;

namespace exercises_21
{
	internal class Program
	{
		static void printMenu()
		{
			Console.WriteLine("********** MENU *********");
			Console.WriteLine("* 1. Rent a car         *");
			Console.WriteLine("* 2. Return a car       *");
			Console.WriteLine("* 3. View available car *");
			Console.WriteLine("* 4. Exit               *");
			Console.WriteLine("*************************");

			Console.Write("Your choice: ");
		}

		static void HandleMenu(string choice, Car[] inventory)
		{
			if(choice == "1")
			{
				foreach(Car c in inventory)
				{
					c.PrintInfo();
				}
				Console.Write("Please enter the ID of the car you want to rent: ");
				string choose;
				choose = Console.ReadLine();
				if (inventory[int.Parse(choose) - 1].getRented())
				{
					Console.WriteLine("Sorry, the selected car is not available for rent.");
				}	
				else
				{
					Console.WriteLine("Rented successful");
					inventory[int.Parse(choose) - 1].Rent();
				}
			}
            else if (choice == "2")
            {
				foreach (Car c in inventory)
				{
					c.PrintInfo();
				}
				Console.Write("Please enter the ID of the car you want to return: ");
				string choose;
				choose = Console.ReadLine();
				inventory[int.Parse(choose) - 1].Return();
			}
			else
			{
				foreach(Car c in inventory)
				{
					if(!c.getRented())
					{
						c.PrintInfo();
					}	
				}
			}
        }
		public class Car
		{
			private string make;
			private string model;
			private decimal rentalPrice;
			private bool rented;

			public Car(string make, string model, decimal rentalPrice, bool rented)
			{
				this.make = make;
				this.model = model;
				this.rentalPrice = rentalPrice;
				this.rented = rented;
			}

			public bool getRented()
			{
				return rented;
			}

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
				Console.Write(make + " " + model + "(Rental price: " + rentalPrice + "/day)" + " - ");
				if (rented)
				{
					Console.WriteLine("rented");
				}
				else
				{
					Console.WriteLine("available");
				}
			}
		}

		
		static void Main(string[] args)
		{
			Car[] inventory = new Car[]
			{
				new Car("Toyota", "Corolla", 50M, false),
				new Car("Honda", "Civic", 60, false),
				new Car("Ford", "Mustang", 80, false)
			};
			while(true)
			{
				printMenu();
				string choice = null;
				choice = Console.ReadLine();
				if (choice == "4") break;
				else if (choice != "1" && choice != "2" && choice != "3")
				{
					continue;
				}
				else { HandleMenu(choice, inventory); }
				Console.WriteLine();
			}
		}
	}
}

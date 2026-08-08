using System;
using System.Collections.Generic;

namespace AssignmentQuestion
{
	public abstract class WareHouseItem
	{
		public int Id;
		public string Name;
		public double Price;

		public WareHouseItem(int id, string name, double price)
		{
			this.Id = id;
			this.Name = name;
			this.Price = price;
		}

		public abstract void DisplayDetails();
	}

	public class Electronics : WareHouseItem
	{
		public int WarrantyMonths;

		public Electronics(int id, string name, double price, int warrantyMonths) : base(id, name, price)
		{
			WarrantyMonths = warrantyMonths;
		}

		public override void DisplayDetails() 
		{
			Console.WriteLine($"ID: {Id}, Name: {Name}, Price: Rs.{Price}, " + $"Warranty: {WarrantyMonths} months"); 
		}
	}

	public class Groceries : WareHouseItem
	{
		public string ExpiryDate;

		public Groceries(int id, string name, double price, string expiryDate) : base(id, name, price)
		{
			this.ExpiryDate = expiryDate;
		}
		public override void DisplayDetails()
		{
			Console.WriteLine($"ID: {Id}, Name: {Name}, Price: Rs.{Price}, " + $"Expiry Date: {ExpiryDate}");
		}
	}

	public class Furniture : WareHouseItem
	{
		public string Material;
		public Furniture(int id, string name, double price, string material) : base(id, name, price)
		{
			Material = material;
		}
		public override void DisplayDetails()
		{
			Console.WriteLine($"ID: {Id}, Name: {Name}, Price: Rs.{Price}, " + $"Material: {Material}");
		}
	}

	public class Storage<T> where T : WareHouseItem
	{
		private List<T> items = new List<T>();
		public void AddItem(T item)
		{
			items.Add(item);
		}
		public void DisplayAllItems()
		{
			foreach (T item in items)
			{
				item.DisplayDetails();
			}
		}
	}

	public interface IWarehouseProvider<out T>
	{
		T GetItem();
	}

	public class WarehouseProvider<T> : IWarehouseProvider<T>
		where T : WareHouseItem
	{
		private T item;

		public WarehouseProvider(T item)
		{
			this.item = item;
		}
		public T GetItem()
		{
			return item;
		}
	}
	public class Question1
	{
		public static void Run()
		{
			Console.WriteLine("\n===== SMART WAREHOUSE MANAGEMENT SYSTEM =====\n");

			//Electronics Storage
			Storage<Electronics> electronicsStorage = new Storage<Electronics>(); 
			electronicsStorage.AddItem( new Electronics( 1, "Laptop", 75000, 24)); 
			electronicsStorage.AddItem( new Electronics( 2, "Smartphone", 45000, 12));

			// Grocery Storage
			Storage<Groceries> groceryStorage = new Storage<Groceries>(); 
			groceryStorage.AddItem( new Groceries( 3, "Rice", 1200, "15-09-2026")); 
			groceryStorage.AddItem( new Groceries( 4, "Milk", 70, "10-08-2026"));

			// Furniture Storage
			Storage<Furniture> furnitureStorage = new Storage<Furniture>(); 
			furnitureStorage.AddItem( new Furniture( 5, "Office Chair", 5000, "Wood")); 
			furnitureStorage.AddItem( new Furniture( 6, "Dining Table", 15000, "Teak Wood"));

			// Display items
			Console.WriteLine("--- Electronics ---");
			electronicsStorage.DisplayAllItems(); 
			Console.WriteLine("\n--- Groceries ---");
			groceryStorage.DisplayAllItems(); 
			Console.WriteLine("\n--- Furniture ---"); 
			furnitureStorage.DisplayAllItems(); 
			
			Console.WriteLine("\n--- Variance ---"); 
			
			IWarehouseProvider<Electronics> electronicsProvider = new WarehouseProvider<Electronics>( new Electronics( 7, "Tablet", 30000, 18)); 
			IWarehouseProvider<WareHouseItem> warehouseProvider = electronicsProvider;
			WareHouseItem item = warehouseProvider.GetItem(); 
			item.DisplayDetails(); 
		}
	}
}
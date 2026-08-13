using System;

class CafeteriaMenu
{
	static string[] menu =
	{
		"Burger",
		"Pizza",
		"Sandwich",
		"Pasta",
		"Momos",
		"French Fries",
		"Cold Coffee",
		"Tea",
		"Chowmein",
		"Ice Cream"
	};

	public static void DisplayMenu()
	{
		Console.WriteLine("----- CAFETERIA MENU -----");

		for (int i = 0; i < menu.Length; i++)
		{
			Console.WriteLine(i + " - " + menu[i]);
		}
	}

	public static string GetItemByIndex(int index)
	{
		if (index >= 0 && index < menu.Length)
		{
			return menu[index];
		}

		return "Invalid item index";
	}
}
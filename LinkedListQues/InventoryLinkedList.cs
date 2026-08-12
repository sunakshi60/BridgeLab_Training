using System;

namespace LinkedLinkQues
{
    public class Item
    {
        public int ItemId;
        public string ItemName;
        public int Quantity;
        public double Price;

        public Item(int itemId, string itemName, int quantity, double price)
        {
            ItemId = itemId;
            ItemName = itemName;
            Quantity = quantity;
            Price = price;
        }

        public void Display()
        {
            Console.WriteLine(
                $"Item ID: {ItemId}, " +
                $"Item Name: {ItemName}, " +
                $"Quantity: {Quantity}, " +
                $"Price: {Price:F2}"
            );
        }
    }
    public class ItemNode
    {
        public Item Data;
        public ItemNode Next;
        public ItemNode(Item data)
        {
            Data = data;
            Next = null;
        }
    }

    public class InventoryLinkedList
    {
        private ItemNode head;
        public void AddAtBeginning(Item item)
        {
            ItemNode newNode = new ItemNode(item);
            newNode.Next = head;
            head = newNode;
            Console.WriteLine("Item added at beginning.");
        }

        public void AddAtEnd(Item item)
        {
            ItemNode newNode = new ItemNode(item);
            if (head == null)
            {
                head = newNode;
                Console.WriteLine("Item added at end.");
                return;
            }
            ItemNode current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
            Console.WriteLine("Item added at end.");
        }

        public void AddAtPosition(Item item, int position)
        {
            if (position < 1)
            {
                Console.WriteLine("Invalid position.");
                return;
            }
            if (position == 1)
            {
                AddAtBeginning(item);
                return;
            }
            ItemNode current = head;
            for (int i = 1; i < position - 1 && current != null; i++)
            {
                current = current.Next;
            }
            if (current == null)
            {
                Console.WriteLine("Position out of range.");
                return;
            }
            ItemNode newNode = new ItemNode(item);
            newNode.Next = current.Next;
            current.Next = newNode;
            Console.WriteLine($"Item added at position {position}.");
        }

        public void RemoveByItemId(int itemId)
        {
            if (head == null)
            {
                Console.WriteLine("Inventory is empty.");
                return;
            }
            if (head.Data.ItemId == itemId)
            {
                head = head.Next;

                Console.WriteLine("Item removed successfully.");
                return;
            }
            ItemNode current = head;
            while (current.Next != null)
            {
                if (current.Next.Data.ItemId == itemId)
                {
                    current.Next = current.Next.Next;
                    Console.WriteLine("Item removed successfully.");
                    return;
                }
                current = current.Next;
            }
            Console.WriteLine("Item not found.");
        }

        public void UpdateQuantity(int itemId, int newQuantity)
        {
            ItemNode current = head;
            while (current != null)
            {
                if (current.Data.ItemId == itemId)
                {
                    current.Data.Quantity = newQuantity;
                    Console.WriteLine("Quantity updated successfully.");
                    return;
                }
                current = current.Next;
            }
            Console.WriteLine("Item not found.");
        }

        public Item SearchByItemId(int itemId)
        {
            ItemNode current = head;
            while (current != null)
            {
                if (current.Data.ItemId == itemId)
                {
                    return current.Data;
                }
                current = current.Next;
            }
            return null;
        }

        public void SearchByItemName(string itemName)
        {
            ItemNode current = head;
            bool found = false;
            while (current != null)
            {
                if (current.Data.ItemName.Equals(
                    itemName,
                    StringComparison.OrdinalIgnoreCase))
                {
                    current.Data.Display();
                    found = true;
                }
                current = current.Next;
            }
            if (!found)
            {
                Console.WriteLine("Item not found.");
            }
        }

        public double CalculateTotalValue()
        {
            ItemNode current = head;
            double totalValue = 0;
            while (current != null)
            {
                totalValue += current.Data.Price * current.Data.Quantity;
                current = current.Next;
            }
            return totalValue;
        }

        public void DisplayTotalValue()
        {
            double totalValue = CalculateTotalValue();
            Console.WriteLine($"Total Inventory Value: {totalValue:F2}");
        }

        public void SortByName(bool ascending)
        {
            if (head == null || head.Next == null)
            {
                return;
            }
            ItemNode current = head;
            while (current != null)
            {
                ItemNode next = current.Next;
                while (next != null)
                {
                    int comparison = string.Compare(
                        current.Data.ItemName,
                        next.Data.ItemName,
                        StringComparison.OrdinalIgnoreCase
                    );

                    bool shouldSwap = ascending
                        ? comparison > 0
                        : comparison < 0;

                    if (shouldSwap)
                    {
                        Item temp = current.Data;
                        current.Data = next.Data;
                        next.Data = temp;
                    }
                    next = next.Next;
                }
                current = current.Next;
            }

            Console.WriteLine(ascending
                    ? "Inventory sorted by name in ascending order."
                    : "Inventory sorted by name in descending order."
            );
        }
        public void SortByPrice(bool ascending)
        {
            if (head == null || head.Next == null)
            {
                return;
            }

            ItemNode current = head;
            while (current != null)
            {
                ItemNode next = current.Next;
                while (next != null)
                {
                    bool shouldSwap = ascending
                        ? current.Data.Price > next.Data.Price
                        : current.Data.Price < next.Data.Price;

                    if (shouldSwap)
                    {
                        Item temp = current.Data;
                        current.Data = next.Data;
                        next.Data = temp;
                    }
                    next = next.Next;
                }
                current = current.Next;
            }
            Console.WriteLine(ascending
                    ? "Inventory sorted by price in ascending order."
                    : "Inventory sorted by price in descending order."
            );
        }

        public void DisplayAll()
        {
            if (head == null)
            {
                Console.WriteLine("Inventory is empty.");
                return;
            }
            ItemNode current = head;
            Console.WriteLine("\n----- Inventory -----");
            while (current != null)
            {
                current.Data.Display();
                current = current.Next;
            }
        }
    }
}
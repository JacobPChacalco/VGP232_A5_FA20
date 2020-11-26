using System;
using System.Collections.Generic;

namespace Assignment5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Adventure of Assignment 5!");

            // DONE: Create an inventory
            Inventory myInventory = new Inventory(10);

            // DONE: Add 2 items to the inventory
            Item ancientKey = new Item("Ancient Key", 100, ItemGroup.Key);
            Item chocolateBar = new Item("Chocolate Bar", 200, ItemGroup.Consumable);

            if (myInventory.AddItem(ancientKey) == true && myInventory.AddItem(chocolateBar) == true)
            {
                List<Item> myItemList = myInventory.ListAllItems();

                // DONE: Verify the number of items in the inventory.
                Console.WriteLine("The number of items included in the inventory are {0}", myItemList.Count);
            }
        }
    }
}

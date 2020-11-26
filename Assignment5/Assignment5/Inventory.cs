using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment5
{
    // Inventory class
    public class Inventory
    {
        // The dictionary items consist of the item and the quantity
        private Dictionary<Item, int> items;

        // The available slots to add item, once it's 0, you cannot add any more items.
        private int availableSlots;

        // The max available slots which is set only in the constructor.
        private int maxSlots;

        // Return the availableSlots number we have
        public int AvailableSlots 
        { 
            get
            {
                return availableSlots;
            } 
        }

        // Return the maxSlots number we can have
        public int MaxSlots
        {
            get
            {
                return maxSlots;
            }
        }

        // Constructor
        public Inventory(int slots)
        {
            maxSlots = slots;
            availableSlots = maxSlots;

            // Create our new dictionary
            items = new Dictionary<Item, int>();
        }

        // Removes all the items, and restore the original number of slots
        public void Reset()
        {
            items.Clear();
            availableSlots = maxSlots;
        }

        // Removes the item from the items dictionary if the count is 1 otherwise decrease the quantity.
        public bool TakeItem(string name, out Item found)
        {
            // Make sure the inventory is not empty, if it is then set the found item to null and return false
            if (availableSlots == maxSlots)
            {
                Console.WriteLine("The inventory is empty. No items can be selected");
                found = null;
                return false;
            }

            // Go through the dictionary looking for a key with the same name as the string parameter
            foreach(KeyValuePair<Item, int> kvp in items)
            {
                // If we find it
                if (kvp.Key.mName == name)
                {
                    // Set our found object to be the same as the one in the inventory
                    found = kvp.Key;

                    // If there is only one item of that type, remove it from the inventory completely
                    if(items[kvp.Key] == 1)
                    {
                        items.Remove(kvp.Key);
                    }

                    // If there is more than one lower the KeyValuePair.Value by one
                    else
                    {
                        items[kvp.Key]--;
                    }

                    // Increase the availableSlots by one
                    availableSlots++;
                    // Return true
                    return true;
                }
            }

            // If the item is not found, set found item to null and return false
            found = null;
            return false;
        }


        // Checks if there is space for a unique item
        public bool AddItem(Item item)
        {
            // If the inventory is full, return false
            if (availableSlots == 0)
            {
                Console.WriteLine("The inventory is full and can not hold any more items");
                return false;
            }

            // If the key does not exist then add the new key Item with quantity = 1
            if(items.ContainsKey(item) == false)
            {
                items.Add(item, 1);

            }

            // Else increase the KeyValuePair.Value by one
            else
            {
                items[item] += 1;
            }

            // Decrease the available slots by one
            availableSlots--;

            // Return true
            return true;
        }

        // Iterates through the dictionary and create a list of all the items.
        public List<Item> ListAllItems()
        {
            if (items.Count == 0)
            {
                Console.WriteLine("The inventory is empty");
                return null;
            }

            // Create a new list of items
            List<Item> itemList = new List<Item>();

            // Use a foreach loop to iterate through the key value pairs 
            foreach (KeyValuePair<Item, int> kvp in items)
            {
                // Duplicate the item base on the quantity.
                for (int x = 0; x < kvp.Value; x++)
                {
                    itemList.Add(kvp.Key);
                }
            }
            
            // Return created list
            return itemList;
        }
    }
}

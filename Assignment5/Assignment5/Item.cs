using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment5
{
    // Item group enum
    public enum ItemGroup 
    { 
        Consumable,
        Key,
        Equipment
    };

    // Item class
    public class Item
    {
        public string mName { get; set; }
        public int mAmount { get; set; }

        public ItemGroup mGroup { get; set; }

        // Constructor
        public Item(string name, int amount, ItemGroup group)
        {
            mName = name;
            mAmount = amount;
            mGroup = group;
        }

        // Display the item name, amount and 
        public override string ToString()
        {
            // DONE: display the output like this Axe 
            return string.Format("{0}({1}): Amount({2})", mName, mGroup, mAmount);
        }
    }
}

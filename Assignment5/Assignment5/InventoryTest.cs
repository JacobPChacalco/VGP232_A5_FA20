using System;
using System.Collections.Generic;
using System.Text;
using NuGet.Frameworks;
using NUnit.Framework;

namespace Assignment5
{
    [TestFixture]
    public class InventoryTest
    {
        // Create our testInventory
        private Inventory testInventory;

        // Create a testItem
        private Item testItem;

        [SetUp]
        public void SetUp()
        {
            testInventory = new Inventory(20);
            testItem = new Item("Ancient Key", 300, ItemGroup.Key);
        }

        [TearDown]
        public void CleanUp()
        {
            testInventory.Reset();
            testInventory = null;

            testItem = null;
        }

        [TestCase(18)]
        public void RemoveItemAvailableSlotsIncrease(int finalSlots)
        {
            for(int x = 0; x < 3; x++)
            {
                testInventory.AddItem(testItem);
            }

            testInventory.TakeItem("Ancient Key", out Item item);

            // Check if the availableSlots changed at the end
            Assert.AreEqual(testInventory.AvailableSlots, finalSlots);
        }

        [TestCase(17)]
        public void RemoveItemAvailableSlotsUnchanged(int finalSlots)
        {
            for (int x = 0; x < 3; x++)
            {
                testInventory.AddItem(testItem);
            }

            testInventory.TakeItem("Village key", out Item item);

            // Check if the availableSlots remain unchanged at the end
            Assert.AreEqual(testInventory.AvailableSlots, finalSlots);
        }

        [TestCase(17)]
        public void AddItemAvailableSlotsDecrease_ItemsExist(int finalSlots)
        {
            for (int x = 0; x < 3; x++)
            {
                testInventory.AddItem(testItem);
            }

            List<Item> items = testInventory.ListAllItems();

            // Check if the availableSlots changed depending on the items inserted
            Assert.AreEqual(testInventory.AvailableSlots, finalSlots);
            // Check if the list created contains the testItem we are looking for
            Assert.IsTrue(items.Contains(testItem));
        }

        [TestCase(20)]
        public void ResetAllSlotsRestored(int finalSlots)
        {
            for (int x = 0; x < 3; x++)
            {
                testInventory.AddItem(testItem);
            }

            testInventory.Reset();

            // Check if the availableSlots go back to 20 when the Inventory is reseted
            Assert.AreEqual(testInventory.AvailableSlots, finalSlots)
        }

    }
}

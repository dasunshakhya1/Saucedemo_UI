using OpenQA.Selenium;
using Saucedemo_UI.src.core;
using Saucedemo_UI.src.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saucedemo_UI.src.pages.inventory
{
    internal class InventorySteps
    {

        public static string GetHeading()
        {
            return UIHandler.GetElementText(InventoryPage.heading);
        }

        public static List<Item> GetInvenotry(string[] items)
        {
            List<Item> addedItems = [];
            IList<IWebElement> inventories = UIHandler.FindElements(InventoryPage.inventoryItems);

            for (int j = 0; j < items.Length; j++)
            {
                for (int i = 0; i < inventories.Count; i++)
                {
                    string itemName = inventories[i].FindElement(InventoryPage.itemName).Text;

                    if (itemName.Equals(items[j]))
                    {
                        string itemPrice = inventories[i].FindElement(InventoryPage.itemPrice).Text;
                        Item item = new(itemName, itemPrice);
                        addedItems.Add(item);
                        UIHandler.Click(inventories[i].FindElement(InventoryPage.addButton));
                        break;
                    }



                }
            }
            return addedItems;
        }
    }


}
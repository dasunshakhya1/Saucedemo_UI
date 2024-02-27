using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saucedemo_UI.src.pages.inventory
{
    internal class InventoryPage
    {
        public static readonly By heading = By.ClassName("product_label");
        public static readonly By inventoryItems = By.ClassName("inventory_item");
        public static readonly By itemName = By.ClassName("inventory_item_name");
        public static readonly By itemPrice = By.ClassName("inventory_item_price");
        public static readonly By addButton = By.ClassName("btn_inventory");
    }
}

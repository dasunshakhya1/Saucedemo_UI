using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saucedemo_UI.src.models
{
    public class Item
    {
        private string itemName { get; set; }
        private string itemPric { get; set; }


        public Item(string itemName, string itemPric)
        {
            this.itemName = itemName;
            this.itemPric = itemPric;
        }
    }
}

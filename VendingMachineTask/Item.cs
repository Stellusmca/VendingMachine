﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineTask
{
    public class Item
    {
        public string name;
        public decimal price;
        public int quantityToVend;

        public Item(string itemName, decimal itemPrice)
        {
            name = itemName;
            price = itemPrice;
        }
    }
}

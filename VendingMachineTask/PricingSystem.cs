using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineTask
{
    public class PricingSystem
    {
        public decimal balance = 0;
        public decimal change = 0;
        public decimal totalAmount = 0;
        public bool transactionComplete = false;

        public void insertCoins(decimal amount, decimal priceOfItem)
        {
            balance += amount;
            checkPurchace(balance, priceOfItem);
        }

        public void checkPurchace(decimal currentBalance, decimal priceOfItem)
        {
            if (currentBalance >= priceOfItem)
            {
                change = currentBalance - priceOfItem;
                Console.WriteLine($"Change due ---> £{change}");
                Console.WriteLine($"***Thank you for your Order***"
                + Environment.NewLine + "Please take your items:-");
                //  Printer.vendRequestedItems();
                transactionComplete = true;
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine($"Remainder to pay ---> £{priceOfItem - balance} more!");
            }
        }
    }
}

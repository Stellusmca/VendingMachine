using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineTask
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var vendingMachineRunner = new Controller();
            vendingMachineRunner.selectYourItem();
            vendingMachineRunner.mainMenu();
        }
    }
}

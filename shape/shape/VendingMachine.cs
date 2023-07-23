using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shape
{
    internal class VendingMachine
    {
        //properties
        public string Location { get; set; }
        public Dictionary<string, int> Inventory { get; set; }
        public float Balance { get; set; }

        //constructor
        public VendingMachine(string location, Dictionary<string, int> inventory, float balance)
        {
            Location = location;
            Inventory = inventory;
            Balance = balance;
        }

        //methods
        public int CheckInventory(string itemName)
        {
            int quantity = Inventory[itemName];
            return (quantity);
        }

        public string Dispense(string itemName, float amountPaid)
        {
            int quantityAvailableInInventory = Inventory[itemName];
            //price is not included in a proper way so doing it in a not proper way
            float cokePrice = 3.0f;
            string message = string.Empty;

            if (amountPaid >= cokePrice)
            {
                int customerNeed = Convert.ToInt32(amountPaid / cokePrice);

                if (customerNeed <= quantityAvailableInInventory)
                {
                    message = "Please take your item.";
                    Inventory[itemName] = quantityAvailableInInventory - customerNeed;
                }
                else
                {
                    message = "Item not available.";
                }
            }
            else
            {
                message = "Amount paid is not enough.";
            }
            return (message);
        }

        public float CheckBalance()
        {
            return (Balance);
        }

        public void AddFunds(float amount)
        {
            Balance += amount;
        }

        public void Restock(string itemName, int quantity)
        {
            Inventory[itemName] += quantity;
        }
    }
}

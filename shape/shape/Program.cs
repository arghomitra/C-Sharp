namespace shape
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> inventory1 = new Dictionary<string, int>
        {
          { "Coke", 5 },
          { "Pepsi", 3 },
          { "Sprite", 10 }
        };

            Dictionary<string, int> inventory2 = new Dictionary<string, int>
        {
          { "Coke", 10 },
          { "Fanta", 4 },
          { "Tea", 7 }
        };

            VendingMachine vm1 = new VendingMachine("De Vest", inventory1, 100.0f);
            VendingMachine vm2 = new VendingMachine("De Ham", inventory2, 200.0f);
            VendingMachine vm3 = new VendingMachine("Kru", inventory1, 150.0f);


            //int a = vm2.CheckInventory("Pepsi");
            //Console.WriteLine(a);
            string item = "Pepsi";
            int a = vm1.CheckInventory(item);
            Console.WriteLine($"this machine has {a} {item}");
            vm1.Dispense("Pepsi", 10);
            //vm1.AddFunds(200);
            Console.WriteLine(vm1.CheckBalance());
            vm1.Restock("Pepsi", 10);
            int b = vm1.CheckInventory("Pepsi");
            Console.WriteLine(b);
        }
    }
}
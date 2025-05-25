using Packing_Inventory;
using Packing_Inventory.Items;
internal class Program
{
    private static void Main()
    {
        Pack Pack = new(10, 10.23, 14.24);

        while (true)
        {

            Console.WriteLine("Choose which items to add to your pack. Choose from: Arrow, Bow, Rope, Water, Food, or Sword. Hit enter after choosing your item.");

            InventoryItem Item = Console.ReadLine() switch
            {
                "Arrow" => new Arrow(),
                "Bow" => new Bow(),
                "Rope" => new Rope(),
                "Water" => new Water(),
                "Food" => new Food(),
                "Sword" => new Sword()
            };

            Pack.AddInventoryItem(Item);
            
        }
    }
}
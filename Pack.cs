
namespace Packing_Inventory
{
    internal class Pack (int TotalItems, double MaximumWeight, double MaximumVolume)
    {
        private int TotalItems { get; } = TotalItems;
        private double MaximumWeight { get; } = MaximumWeight;
        private double MaximumVolume { get; } = MaximumVolume;

        private readonly InventoryItem[] CurrentInventoryItems = new InventoryItem[TotalItems];
        private int CurrentItemCount { get; set; } = 0;
        private double CurrentPackVolume { get; set; } = 0;
        private double CurrentPackWeight { get; set; } = 0;


        public bool AddInventoryItem(InventoryItem Item)
        {
            if (CurrentItemCount + 1 > TotalItems || CurrentPackVolume + Item.ItemVolume > MaximumVolume || CurrentPackWeight + Item.ItemWeight > MaximumWeight)
            {
                Console.WriteLine("This item exceeds the pack limits.");
                return false;
            }
            CurrentInventoryItems[CurrentItemCount] = Item;
            CurrentItemCount++;
            CurrentPackVolume += Item.ItemVolume;
            CurrentPackWeight += Item.ItemWeight;
            return true;
        }

        public override string ToString()
        {
            if (CurrentInventoryItems[0] == null) return "Pack currently contains nothing.";

            string Result = "";
            foreach (InventoryItem Item in CurrentInventoryItems)
            {
                Result += Item?.ToString() ?? "";
                Result += " ";
            }

            return $"Pack currently contains: {Result}";
        }

    }
}

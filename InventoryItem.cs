
namespace Packing_Inventory
{
    internal class InventoryItem(double ItemWeight, double ItemVolume)
    {
        public double ItemWeight { get; set; } = ItemWeight;
        public double ItemVolume { get; set; } = ItemVolume;
    }
}

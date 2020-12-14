using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Fmod.Items.TileItems.Furniture
{
    public class SkiGateBlueItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Blu ski gate");
            Tooltip.SetDefault("A blue ski gate");
        }
        public override void SetDefaults()
        {
            item.width = 22;
            item.height = 32;
            item.maxStack = 999;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.consumable = true;
            item.rare = ItemRarityID.Red;
            item.value = Item.buyPrice(0, 0, 10, 0);
            item.createTile = mod.TileType("SkiGateBlue");
        }
    }
}
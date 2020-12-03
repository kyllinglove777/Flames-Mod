using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace FMod.Items.TileItems.Blocks
{
    public class TestTileItemForTruffle : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Test tile for Truffle's sprites");
        }
        public override void SetDefaults()
        {
            item.maxStack = 999;
            item.consumable = true;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.useTime = 10;
            item.useAnimation = 10;
            item.createTile = mod.TileType("TestTileForTruffle");
            item.autoReuse = true;
        }
    }
}

using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Fmod.Items.TileItems.Blocks
{
    class TrufflesTestBlock : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Truffle's test blcok, going to be renamed later");
            Tooltip.SetDefault("This block is a block, when I'm writing this, it doesn't have a sprite, but I'm going to give it a placeholder, and Truffle's gonna draw a sprite");
        }
    }
}

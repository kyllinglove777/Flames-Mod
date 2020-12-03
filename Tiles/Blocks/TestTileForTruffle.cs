using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace FMod.Tiles.Blocks
{
    public class TestTileForTruffle : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileSolid[Type] = true;
            drop = mod.ItemType("TestTileItemForTruffle");
            minPick = 50;
            AddMapEntry(new Color(128, 0, 128));
        }
    }
}

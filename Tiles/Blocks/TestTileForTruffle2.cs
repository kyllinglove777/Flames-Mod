using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace FMod.Tiles.Blocks
{
    public class TestTileForTruffle2 : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileSolid[Type] = true;
            drop = mod.ItemType("TestTileItemForTruffle2");
            minPick = 50;
            AddMapEntry(new Color(128, 0, 128));
        }
    }
}

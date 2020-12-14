using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;
using Terraria.ObjectData;
 
namespace Fmod.Tiles.Furniture
{
    public class SkiGateBlue : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileLighted[Type] = false;
            Main.tileFrameImportant[Type] = true;
            TileObjectData.newTile.CopyFrom(TileObjectData.Style2xX);
            TileObjectData.newTile.Height = 3;
            TileObjectData.newTile.Width = 2;
            TileObjectData.newTile.Origin = new Point16(1, 1);
            TileObjectData.newTile.CoordinateHeights = new int[] { 16, 16, 16};
            TileObjectData.addTile(Type);
            AddMapEntry(new Color(175, 13, 166));
            animationFrameHeight = 72; //this is the sprite frame height
        }

        public override void KillMultiTile(int i, int j, int frameX, int frameY)
        {
            Item.NewItem(i * 16, j * 16, 32, 48, mod.ItemType("SkiGateBlueItem")); //this defines what to drop when this tile is destroyed
        }

        public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b) //this adds light to the tile
        {                    //light  color
            r = 0.33f;   //red
            g = 0f;    // green
            b = 0.32f;   //blue
        }

        public override void AnimateTile(ref int frame, ref int frameCounter)
        {
            frameCounter++;
            if (frameCounter > 10)
            {
                frameCounter = 0;
                frame++;
                if (frame > 7)
                {
                    frame = 0;
                }
            }
        }
    }
}
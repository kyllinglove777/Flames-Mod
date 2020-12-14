using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Fmod.Items.ArmorAndVanity.Vanity
{
    [AutoloadEquip(EquipType.Head)]
    public class SkiHelmet : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ski helmet");
            Tooltip.SetDefault("Warms your head while skiing");
        }
        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.rare = ItemRarityID.LightRed;
            item.vanity = true;
        }
        public override bool DrawHead()
        {
            return true;
        }
    }
}
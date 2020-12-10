using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Fmod.Items.ArmorAndVanity.Vanity
{
    [AutoloadEquip(EquipType.Legs)]
    public class SkiLeggings : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ski leggings");
            Tooltip.SetDefault("Warms your body while skiing");
        }
        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.rare = ItemRarityID.LightRed;
            item.vanity = true;
        }
    }
}

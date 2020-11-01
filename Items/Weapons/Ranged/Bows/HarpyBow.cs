using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Fmod.Items.Weapons.Ranged.Bows
{
    class HarpyBow : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Shoots arrows and feathers");
        }
        public override void SetDefaults()
        {
            item.damage = 255;
            item.noMelee = true;
            item.ranged = true;
            item.width = 11;
            item.height = 32;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.useAmmo = AmmoID.Arrow;
            item.useTime = 50;
            item.useAnimation= 50;
            item.shootSpeed = 2f;
            item.autoReuse = true;
            item.shoot = AmmoID.Arrow;
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            Projectile.NewProjectile(position.X, position.Y, speedX, speedY, mod.ProjectileType("HarpyBowProjectile"), 300, 2f, player.whoAmI);
            return true;
        }
    }
}

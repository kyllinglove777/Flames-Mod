using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Fmod.Projectiles.WeaponProjectiles.Ranged
{
    class HarpyBowProjectile : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Feather");
        }
        public override void SetDefaults()
        {
            projectile.width = 16;
            projectile.height = 12;
            projectile.ranged = true;
            projectile.aiStyle = 0;
            aiType = ProjectileID.HarpyFeather;
            projectile.timeLeft = 1200;
            projectile.friendly = true;
        }
    }
}

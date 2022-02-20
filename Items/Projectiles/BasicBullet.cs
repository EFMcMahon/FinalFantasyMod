using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace XIV.Items.Projectiles
{
    public class BasicBullet : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Basic Bullet");
		}

		public override void SetDefaults()
		{
			projectile.arrow = false;
			projectile.width = 7;
			projectile.height = 7;
			projectile.friendly = true;
			projectile.ranged = true;
            projectile.aiStyle = 0;
            projectile.penetrate = 1;
            
		}
	}
}
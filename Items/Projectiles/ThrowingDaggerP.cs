using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace XIV.Items.Projectiles
{
    public class ThrowingDaggerP : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Throwing Dagger");
		}

		public override void SetDefaults()
		{
			projectile.arrow = true;
			projectile.width = 10;
			projectile.height = 10;
			projectile.friendly = true;
			projectile.ranged = true;
            projectile.aiStyle = 0;
            projectile.penetrate = 1;
            
		}
        public override void AI(){
            projectile.velocity.Y = projectile.velocity.Y + 0.15f;
            projectile.rotation += 0.4f * (float)projectile.direction;
        }
		// Additional hooks/methods here.
	}
}
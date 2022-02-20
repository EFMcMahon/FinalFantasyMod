using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace XIV.Items.Projectiles
{
    public class ScytheP : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Scythe Blade");
		}

		public override void SetDefaults()
		{
			projectile.arrow = false;
			projectile.width = 21;
			projectile.height = 60;
			projectile.friendly = true;
			projectile.ranged = true;
            projectile.aiStyle = 0;
            projectile.timeLeft = 20;
            projectile.tileCollide = false;
		}
        public override void AI(){
            projectile.rotation = projectile.velocity.ToRotation();
            projectile.damage = 5;
        }
	}
}
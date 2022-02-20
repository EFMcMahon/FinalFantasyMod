using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace XIV.Items.Projectiles
{
    public class BookP : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Book");
		}

		public override void SetDefaults() {
			projectile.arrow = false;
			projectile.width = 25;
			projectile.height = 13;
			projectile.friendly = true;
			projectile.ranged = true;
            projectile.aiStyle = 0;
            projectile.tileCollide = true;
            projectile.light = .2f;
		}
         public override void AI(){
            projectile.rotation = projectile.velocity.ToRotation();
            projectile.damage = 13;
        }

		public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)                //HERE
        {
            target.AddBuff(BuffID.OnFire, 30 * 60);
            target.AddBuff(BuffID.Ichor, 30 * 60);
        }
		
	}
}
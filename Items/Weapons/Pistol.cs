using Terraria.ID;
using Terraria.ModLoader;

namespace XIV.Items.Weapons
{
	public class Pistol : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("Pistol"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Basic pistol.");
		}

		public override void SetDefaults() 
		{
			item.damage = 13;
			item.melee = true;
            item.shoot = mod.ProjectileType("BasicBullet");
			item.crit = 15;
			item.width = 29;
			item.height = 30;
			item.useTime = 15;
			item.useAnimation = 15;
			item.useStyle = 3;
			item.knockBack = 2;
			item.value = 100;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock, 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
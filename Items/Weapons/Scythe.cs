using Terraria.ID;
using Terraria.ModLoader;

namespace XIV.Items.Weapons
{
	public class Scythe : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("Scythe"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Basic Scythe");
		}

		public override void SetDefaults() 
		{
			item.damage = 20;
			item.melee = true;
            item.shoot = mod.ProjectileType("ScytheP");
            item.shootSpeed = 4f;
			item.width = 40;
			item.height = 35;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 3;
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
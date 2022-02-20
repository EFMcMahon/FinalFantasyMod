using Terraria.ID;
using Terraria.ModLoader;

namespace XIV.Items.Weapons
{
	public class ThrowingDagger : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("ThrowingDagger"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Basic throwing weapon.");
		}

		public override void SetDefaults() 
		{
			item.damage = 13;
            item.thrown = true;
			item.crit = 15;
			item.width = 22;
			item.height = 22;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 2;
			item.value = 100;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
            item.shoot = mod.ProjectileType("ThrowingDaggerP");
            item.shootSpeed = 8f;
            item.useTurn = true;
            item.maxStack = 999;
            item.consumable = true;
            item.noUseGraphic = true;
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
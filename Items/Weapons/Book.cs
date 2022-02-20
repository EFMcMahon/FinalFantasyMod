using Terraria.ID;
using Terraria.ModLoader;

namespace XIV.Items.Weapons
{
	public class Book : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("Book"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Basic Book.");
		}

		public override void SetDefaults() 
		{
			item.magic = true;
            item.shoot = mod.ProjectileType("BookP");
			item.width = 26;
			item.height = 28;
			item.useTime = 40;
			item.useAnimation = 40;
			item.useStyle = 5;
			item.knockBack = 2;
			item.value = 100;
			item.rare = 2;
            item.shootSpeed = 4f;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.mana = 2;
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
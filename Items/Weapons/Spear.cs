using Terraria.ID;
using Terraria.ModLoader;

namespace XIV.Items.Weapons
{
	public class Spear : ModItem
	{
		public override void SetStaticDefaults() 
		{
			Tooltip.SetDefault("This is a basic modded spear.");
		}

		public override void SetDefaults() 
		{
			item.damage = 15;
			item.melee = true;
			item.width = 39;
			item.height = 39;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.knockBack = 6;
			item.value = 100;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = false;
            item.noMelee = true;
            item.shoot = mod.ProjectileType("SpearP");
            item.shootSpeed = 4f;
            item.noUseGraphic = true;
            item.scale = 1f;
		}
        // public override bool CanUseItem(Player player){
        //     return player.ownedProjectileCounts[item.shoot] < 1;
        // }

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
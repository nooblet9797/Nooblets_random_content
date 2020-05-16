using Terraria.ID;
using Terraria.ModLoader;

namespace absolutechaos.Items
{
	public class lostscroll : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("torn page"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Day 1, i have found some strange scythe i feel the power radiating off of it the power... i want more. (you can no longer read the contents of this page).");
		}

		public override void SetDefaults() 
		{
			item.width = 30;
			item.height = 30;
			item.useTime = 10;
			item.value = 1000;
			item.rare =12;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SoulofNight, 10);
			recipe.AddIngredient(ItemID.Silk, 10);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
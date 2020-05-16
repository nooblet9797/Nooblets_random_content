using Terraria.ID;
using Terraria.ModLoader;

namespace absolutechaos.Items
{
	public class bluefire : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Blue fire"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Your eyes burn just looking at it.");
		}

		public override void SetDefaults() 
		{
			item.width = 16;
			item.height = 16;
			item.useStyle = 1;
			item.value = 150;
			item.rare =8;
			item.UseSound = SoundID.Item1;
			item.maxStack = 999;

		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.CursedFlame, 1000);
			recipe.AddIngredient(ItemID.SoulofLight, 1000);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
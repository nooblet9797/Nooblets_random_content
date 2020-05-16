using Terraria.ID;
using Terraria.ModLoader;

namespace absolutechaos.Items
{
	public class bluefireblade : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Blue Fire Blade");
			Tooltip.SetDefault("This blade is made out of a strange blue fire.");
		}

		public override void SetDefaults() 
		{
			item.damage = 100;
			item.melee = true;
			item.width = 60;
			item.height = 136;
			item.useTime = 25;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 9;
			item.value = 150;
			item.rare =3;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "bluefire", 100);
			recipe.AddIngredient(ItemID.IronBar, 1000);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
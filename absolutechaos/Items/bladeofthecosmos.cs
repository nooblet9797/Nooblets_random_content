using Terraria.ID;
using Terraria.ModLoader;

namespace absolutechaos.Items
{
	public class bladeofthecosmos : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Blade of the cosmos"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("This blade houses the power of 10000 gods...");
		}

		public override void SetDefaults() 
		{
			item.damage = 2430576;
			item.melee = true;
			item.width = 60;
			item.height = 270;
			item.useTime = 10;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 1;
			item.value = 1000;
			item.rare =12;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SoulofNight, 1000);
			recipe.AddIngredient(ItemID.TerraBlade, 1);
			recipe.AddIngredient(ItemID.StarWrath, 1);
			recipe.AddIngredient(ItemID.TrueExcalibur, 1);
			recipe.AddIngredient(ItemID.TrueNightsEdge, 1);
			recipe.AddIngredient(ItemID.Meowmere, 1);
			recipe.AddIngredient(ItemID.DeathSickle, 1);
			recipe.AddIngredient(ItemID.FieryGreatsword, 1);
			recipe.AddIngredient(mod, "bluefire", 100);
			recipe.AddIngredient(mod, "scythofdivinity", 5);
			recipe.AddIngredient(mod, "scythofdesolation", 5);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
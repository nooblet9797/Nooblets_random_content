using Terraria.ID;
using Terraria.ModLoader;

namespace absolutechaos.Items
{
	public class scythofdivinity : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Scythe of Divinity"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("The power of the galexy will soon be in your hands.");
		}

		public override void SetDefaults() 
		{
			item.damage = 20000;
			item.melee = true;
			item.width = 60;
			item.height = 60;
			item.useTime = 0;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 1;
			item.value = 10000;
			item.rare =12;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "scythofdesolation", 2);
			recipe.AddIngredient(ItemID.SoulofFlight, 1000);
			recipe.AddIngredient(ItemID.SoulofMight, 1000);
			recipe.AddIngredient(ItemID.WarriorEmblem, 2);
			recipe.AddIngredient(ItemID.DestroyerEmblem, 2);
			recipe.AddIngredient(ItemID.Meowmere, 2);
			recipe.AddIngredient(ItemID.StarWrath, 2);
			recipe.AddIngredient(ItemID.TerraBlade, 1);
			recipe.AddIngredient(ItemID.BrokenHeroSword, 1);
			recipe.AddIngredient(ItemID.DemonHeart, 1);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
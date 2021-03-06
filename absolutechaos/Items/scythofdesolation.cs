using Terraria.ID;
using Terraria.ModLoader;

namespace absolutechaos.Items
{
	public class scythofdesolation : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Scythe of Desolation"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("This blade is a fragment of something powerfull...");
		}

		public override void SetDefaults() 
		{
			item.damage = 1632;
			item.melee = true;
			item.width = 60;
			item.height = 60;
			item.useTime = 10;
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
			recipe.AddIngredient(ItemID.SoulofNight, 1000);
			recipe.AddIngredient(ItemID.SoulofLight, 1000);
			recipe.AddIngredient(ItemID.WarriorEmblem, 1);
			recipe.AddIngredient(ItemID.DestroyerEmblem, 1);
			recipe.AddIngredient(ItemID.Meowmere, 1);
			recipe.AddIngredient(ItemID.StarWrath, 1);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace absolutechaos.Items
{
	public class pickaxeofchaos : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("This pickaxe can break a star.");
			DisplayName.SetDefault("pickaxe of chaos");
		}

		public override void SetDefaults() {
			item.damage = 20;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 0;
			item.useAnimation = 10;
			item.pick = 23745935;
			item.axe = 87387;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemType<bluefire>(), 10);
			recipe.AddIngredient(ItemID.Meowmere, 1);
			recipe.AddIngredient(ItemID.StarWrath, 1);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}


		
	}
}
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace absolutechaos.Items.Placeable.ores
{
	public class Cosmicore : ModItem
	{
		public override void SetStaticDefaults()
		{
			ItemID.Sets.SortingPriorityMaterials[item.type] = 58;
			DisplayName.SetDefault("Cosmic Ore");
		}

		public override void SetDefaults()
		{
			item.useStyle = 1;
			item.useTurn = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.autoReuse = true;
			item.maxStack = 999;
			item.consumable = true;
			item.createTile = TileType<Tiles.Ores.Cosmicore>();
			item.width = 12;
			item.height = 12;
			item.value = 3000;
		}
	}
}

using Terraria.ID;
using Terraria.ModLoader;

namespace absolutechaos.Items
{
	public class blackmagiccharm : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Black magic charm"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("The embodyment of the reapers power.");
		}

		public override void SetDefaults() 
		{
			item.width = 30;
			item.height = 30;
			item.useTime = 10;
			item.value = 100000000;
			item.rare =12;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			
		}
	}
}
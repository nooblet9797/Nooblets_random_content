using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace absolutechaos.Tiles.Ores
{
	public class Cosmicore : ModTile
	{
		public override void SetDefaults()
		{
			Main.tileSolid[Type] = true;
			Main.tileMergeDirt[Type] = true;
			Main.tileBlockLight[Type] = true;
			Main.tileLighted[Type] = true;
			dustType = mod.DustType("Sparkle");
			drop = mod.ItemType("Cosmicore");
			AddMapEntry(new Color(200, 200, 200));
			// Set other values here
		}
	}
}
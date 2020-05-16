using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace absolutechaos.npc.bosses.eye_boss_ex
{
	
	public class eye_boss_ex : ModNPC
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Eye of desolation");
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.EyeofCthulhu];
		}

		public override void SetDefaults() {
			npc.width = 120;
			npc.height = 120;
			npc.damage = 90;
			npc.defense = 36;
			npc.lifeMax = 10920;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath2;
			npc.value = 60f;
			npc.boss = true;
			npc.knockBackResist = 0.5f;
			npc.aiStyle = 4;
			npc.noGravity = true;
			npc.lavaImmune = true;
			npc.noTileCollide = true;
			music = mod.GetSoundSlot(SoundType.Music, "Sounds/Music/cosmicdestroyer");
		}

		public override void ScaleExpertStats(int numPlayers, float bossLifeScale) {
			npc.lifeMax = (int)(npc.lifeMax * 0.625f * bossLifeScale);
			npc.damage = (int)(npc.damage * 0.6f);
		}
		
	}
}

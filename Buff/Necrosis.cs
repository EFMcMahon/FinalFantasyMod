using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace XIV.Buff
{
     public class Necrosis : ModBuff
    {
		public override void SetDefaults() {
			DisplayName.SetDefault("Necrosis");
			Description.SetDefault("Losing life");
			Main.buffNoTimeDisplay[Type] = false;
			Main.debuff[Type] = true;
			Main.pvpBuff[Type] = true;
			Main.buffNoSave[Type] = true;
			longerExpertDebuff = true;	
		}

		public override void Update(NPC npc, ref int buffIndex)
		{
			if (!npc.friendly) {
				if (npc.lifeRegen > 0) {
					npc.lifeRegen = 0;
				}
				npc.lifeRegen -= 5;
		}
		}

		public override void Update(Player player, ref int buffIndex)
		{
			if (player.lifeRegen > 0) {
				player.lifeRegen = 0;
			}
			player.lifeRegen -= 5;
		}
    }
}
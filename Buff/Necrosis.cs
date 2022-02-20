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
		}

		public override void Update(Player player, ref int buffIndex) {
			player.Necrosis = true;
		}

		public override void Update(NPC npc, ref int buffIndex) {
			npc.Necrosis = true;
		}
    }
}
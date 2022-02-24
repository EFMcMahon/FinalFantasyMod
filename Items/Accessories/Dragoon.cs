using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace XIV.Items.Accessories
{
    public class Dragoon : ModItem
    {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Dragoon Crystal");
            Tooltip.SetDefault("YOU CAN DO SOME COOL ASS JUMPS NOW YO!!!");
        }
         
         public override void SetDefaults(){
            item.width = 30;
            item.height = 30;
            item.accessory = true;
            item.rare = ItemRarityID.Blue;
            item.value = Item.sellPrice(gold: 1);
         }
        
        public override void UpdateAccessory(Player player, bool hideVisual){
            Player.jumpHeight += 5;
            Player.jumpSpeed += 2;
        }
    }
}
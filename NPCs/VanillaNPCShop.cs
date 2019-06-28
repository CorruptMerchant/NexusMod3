using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System;

namespace NexusMod3.NPCs
{
    public class VanillaNPCShop : GlobalNPC
    {
        public override void SetupShop(int type, Chest shop, ref int nextSlot)
        {
            switch (type)
            {
                case NPCID.TravellingMerchant:
 
                    if (random.Next(5) == 1)
                    {
                        shop.item[nextSlot].SetDefaults(mod.ItemType("MerchantGuildBanner"));
                        nextSlot++;
					}
                    if (random.Next(20) == 1 && NPC.downedMechBoss1 && NPC.downedMechBoss2 && NPC.downedMechBoss3)
                    {
                        shop.item[nextSlot].SetDefaults(mod.ItemType("Edgerick"));
                        nextSlot++;
                    }
					break;
            }
        }
    }
}
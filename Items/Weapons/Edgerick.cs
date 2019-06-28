using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System;

namespace NexusMod3.Items.Weapons
{
	public class Edgerick : ModItem
	{
		Random random = new Random();
		public override void SetStaticDefaults() {

			DisplayName.SetDefault("Edgerick");
			Tooltip.SetDefault("A weapon of fluctuating damage and effect.");
		}

		public override void SetDefaults() {

			item.damage = 100;
			item.width = 100;
			item.height = 100;
			item.useTime = 15;
			item.useAnimation = 15;
			item.useStyle = 1;
			item.knockback = 5;
			item.melee = true;
			item.value = Item.buyPrice(platinum: 5);
			item.rare = ItemRarityID.Yellow;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;

		}

		public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit) {
			item.damage = 100 + (random.Next(50) - 25);
			int[] buffIDs = new int[] {24, 31, 73, 76, 72, 79, 71, 44, 153};
			target.AddBuff(buffIDs[random.next(9)], 180);
			int use = random.Next(20);
			item.useTime = use;
			item.useAnimation = use;
			item.knockback = random.next(20);
		}

		public override void AddRecipes() {
			
		}
	}
}

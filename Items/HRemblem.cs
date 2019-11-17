using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace DayshadowsMod.Items
{
    public class HRemblem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Hard Rock Emblem"); // DisplayName.SetDefault("FirstSword"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
            Tooltip.SetDefault("13% increased damage \r\n" 
                + "50% increased melee speed \r\n"
                + "HONESTYYYYY!!!!");
        }

        public override void SetDefaults()
        {
            item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.allDamage += 0.13f;
        }
    }
}
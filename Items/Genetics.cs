using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace DayshadowsMod.Items
{
    public class Genetics : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Genetics"); // DisplayName.SetDefault("FirstSword"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
            Tooltip.SetDefault("50% increased movement speed \r\n" 
                + "50% increased melee speed \r\n"
                + "Grants you the power of Doubletime.");
        }

        public override void SetDefaults()
        {
            item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.moveSpeed += 0.5f;
            player.meleeSpeed += 0.5f;
        }
    }
}
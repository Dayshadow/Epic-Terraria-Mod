using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;

namespace DayshadowsMod.Items
{
    public class XPTablet : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("XP Pen Star G640"); // DisplayName.SetDefault("FirstSword"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
            Tooltip.SetDefault("A standard tablet, decent for playing osu!");
        }

        public override void SetDefaults()
        {
            item.width = 30;
            item.height = 30;
            item.rare = 4;
            item.useStyle = 5;
            item.useTime = 10;
            item.useAnimation = 10;
            item.value = 1000;
            item.useTurn = false;

            item.UseSound = SoundID.Item9;

            item.ranged = true; // used for ranged weapons

            item.damage = 22;
            item.crit = 6;
            item.knockBack = 2f;

            // item.shoot = mod.ProjectileType("XPTabletPen");
            item.shoot = ProjectileID.WoodenArrowFriendly;

            item.shootSpeed = 10f;

            item.useAmmo = AmmoID.Arrow;

            item.noMelee = true;
        }

        //stolen somewhere from youtube
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            Projectile.NewProjectile(position.X, position.Y, speedX, speedY, mod.ProjectileType("XPTabletPenPro"), damage, knockBack, player.whoAmI, 0f, 0f);
            return false;
        }
    }
}
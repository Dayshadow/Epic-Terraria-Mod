using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace FirstMod.Projectiles
{
    public class XPTabletPenPro : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            //name that displays when killed by this projectile
            DisplayName.SetDefault("Tablet Pen Star G640");
        }

        public override void SetDefaults()
        {
            projectile.width = 8;
            projectile.height = 12;

            // The AI style of the projectile (-1 for custom AI)
            // 1 = Arrow
            // 2 = Shuriken
            // 3 = Boomerang
            // check spreadsheet for more
            projectile.aiStyle = 1;

            //friendly
            projectile.friendly = true;

            // the amount of enemies penetrated
            projectile.penetrate = -1;

            projectile.ranged = true;

            // projectile.timeLeft = 100

            projectile.arrow = true;
        }

        public override void Kill(int timeLeft)
        {
            if(projectile.owner == Main.myPlayer)
            {
                int item = Main.rand.NextBool(5) ? Item.NewItem(projectile.getRect(), mod.ItemType("ArrowPro")) : 0;
            }
        }
    }
}

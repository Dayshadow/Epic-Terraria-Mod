using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace FirstMod.Projectiles
{
    public class YoyoPro : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            //name that displays when killed by this projectile
            DisplayName.SetDefault("The Zenith");

            // The following sets are only applicable to yoyo that use aiStyle 99.
            // YoyosLifeTimeMultiplier is how long in seconds the yoyo will stay out before automatically returning to the player. 
            // Vanilla values range from 3f(Wood) to 16f(Chik), and defaults to -1f. Leaving as -1 will make the time infinite.
            ProjectileID.Sets.YoyosLifeTimeMultiplier[projectile.type] = -1f;
            // YoyosMaximumRange is the maximum distance the yoyo sleep away from the player. 
            // Vanilla values range from 130f(Wood) to 400f(Terrarian), and defaults to 200f
            ProjectileID.Sets.YoyosMaximumRange[projectile.type] = 272f;
            // YoyosTopSpeed is top speed of the yoyo projectile. 
            // Vanilla values range from 9f(Wood) to 17.5f(Terrarian), and defaults to 10f
            ProjectileID.Sets.YoyosTopSpeed[projectile.type] = 14.5f;
        }

        public override void SetDefaults()
        {
            // clones the default properties of the wooden yoyo (really useful)
            // projectile.CloneDefaults(ProjectileID.WoodYoyo);

            projectile.extraUpdates = 0;
            projectile.width = 16;
            projectile.height = 16;
            // aiStyle 99 is used for all yoyos, and is Extremely suggested, as yoyo are extremely difficult without them
            projectile.aiStyle = 99;
            projectile.friendly = true;
            projectile.penetrate = -1;
            projectile.melee = true;
            projectile.scale = 1f;
        }

        /*
        public override void PostAI()
        {
            if (Main.rand.NextBool())
            {
                Dust dust = Dust.NewDustDirect(projectile.position, projectile.width, projectile.height, 16);
                dust.noGravity = true;
                dust.scale = 1.6f;
            }
        }
        */

    }
}

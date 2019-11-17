using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;


namespace DayshadowsMod.Projectiles
{
    class HitcircleProjectile : ModProjectile // have them act as the bubble gun projectiles
    {
        public override void SetStaticDefaults() // o
        {
            
        }

        public override void SetDefaults()
        {
            projectile.width = 16;
            projectile.height = 16;
            projectile.timeLeft = 300;
            // aiStyle 99 is used for all yoyos, and is Extremely suggested, as yoyo are extremely difficult without them
            projectile.aiStyle = 99;
            projectile.friendly = true;
            projectile.penetrate = -1;
            projectile.melee = true;
            projectile.scale = 1f;
        }
        /*
         * garhu:
         * 
         * dayshadow: k add the image oh push it to github ig
         * */
        public override void AI()
        {
            projectile.rotation += 0.02; // done just makes it spin
        }
    }
}
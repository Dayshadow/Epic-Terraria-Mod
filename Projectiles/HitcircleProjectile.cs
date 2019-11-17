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
            DisplayName.SetDefault("Hitcircle");
        }

        public override void SetDefaults()
        {
            projectile.alpha = 0;

            projectile.width = 16;
            projectile.height = 16;
            projectile.timeLeft = 300;
            // aiStyle 99 is used for all yoyos, and is Extremely suggested, as yoyo are extremely difficult without them
            projectile.aiStyle = 72;
            projectile.friendly = true;
            projectile.penetrate = -1;
            projectile.melee = true;
            projectile.scale = 1f;
        }
        /*
         * garhu: pushed also yeah the image is 16x16
         * 
         * dayshadow: is the image 16x16
         * */

            public float Timer
        {
            get => projectile.ai[0];
            set => projectile.ai[0] = value;
        }

        public override void AI()
        {
            Timer++;
            projectile.rotation += 0.02f; // done just makes it spin
            projectile.position += projectile.velocity;
            /*
            if(Timer > 200)
            {
                projectile.alpha += 255/100;
            }*/

            if (Timer > 200) // For making the projectile fade in
            {
                projectile.alpha = (int)(255.0f * (1 - (Timer / 200)));
            }
        }
    }
}
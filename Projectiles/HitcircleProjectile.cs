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
            projectile.timeLeft = lifeTime;
            // aiStyle 99 is used for all yoyos, and is Extremely suggested, as yoyo are extremely difficult without them
            projectile.aiStyle = 72;
            projectile.friendly = true;
            projectile.penetrate = -1;
            projectile.melee = true;
            projectile.tileCollide = false;
            projectile.scale = 1f;
        }

            public float Timer
        {
            get => projectile.ai[0];
            set => projectile.ai[0] = value;
        }

        int fadeTime = 100;
        int lifeTime = 300;
        public override void AI()
        {
            Timer++;
            projectile.rotation += 0.02f; // makes it spin
            projectile.position += projectile.velocity;

            int fadeStart = lifeTime - fadeTime; // (300 - 100 = frame 200 when it should start fading) 
            if (Timer >= fadeStart) // For making the projectile fade in. 
            {
                projectile.alpha = (int)(255.0f * ((Timer - fadeStart) / fadeTime)); // (Timer = 200 here so we need to shift it over to 0 then divide it by the amount of frames until lifeTime is reached
                // at Timer = 200
                // projectile.alpha = (int) (255.0f * ((200 - 200) / 100)) = 255.0f * 0 = 0

                // at Timer = 250
                // projectile.alpha = (int) (255.0f * ((250 - 200) / 100)) = 255.0f * 0.5 = 127.5

                // at Timer = 300
                // projectile.alpha = (int) (255.0f * ((300 - 200) / 100)) = 255.0f * 1 = 255
            }
        }
    }
}
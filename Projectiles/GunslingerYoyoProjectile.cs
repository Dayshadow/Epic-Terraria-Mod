﻿using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;


namespace DayshadowsMod.Projectiles
{
    class GunslingerYoyoProjectile : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            // The following sets are only applicable to yoyo that use aiStyle 99.
            // YoyosLifeTimeMultiplier is how long in seconds the yoyo will stay out before automatically returning to the player. 
            // Vanilla values range from 3f(Wood) to 16f(Chik), and defaults to -1f. Leaving as -1 will make the time infinite.
            ProjectileID.Sets.YoyosLifeTimeMultiplier[projectile.type] = 16f;
            // YoyosMaximumRange is the maximum distance the yoyo sleep away from the player. 
            // Vanilla values range from 130f(Wood) to 400f(Terrarian), and defaults to 200f
            ProjectileID.Sets.YoyosMaximumRange[projectile.type] = 320f;
            // YoyosTopSpeed is top speed of the yoyo projectile. 
            // Vanilla values range from 9f(Wood) to 17.5f(Terrarian), and defaults to 10f
            ProjectileID.Sets.YoyosTopSpeed[projectile.type] = 13f;
        }

        public override void SetDefaults()
        {
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
        // notes for aiStyle 99: 
        // localAI[0] is used for timing up to YoyosLifeTimeMultiplier
        // localAI[1] can be used freely by specific types
        // ai[0] and ai[1] usually point towards the x and y world coordinate hover point
        // ai[0] is -1f once YoyosLifeTimeMultiplier is reached, when the player is stoned/frozen, when the yoyo is too far away, or the player is no longer clicking the shoot button.
        // ai[0] being negative makes the yoyo move back towards the player
        // Any AI method can be used for dust, spawning projectiles, etc specific to your yoyo.

        // ~~dayshadow wrote it from here on~~
        public float Timer // stand-in variable for projectile.localAI[0] (increases by one each tick starting at 0 when the yoyo is spawned)
        {
            get => projectile.localAI[0]; 
            // set => projectile.localAI[0] = value; <- unused because the default code relies on it and we wouldn't want to change the value
        }
        public override void PostAI() 
        {
            if (Timer % 7 == 0) // every 7th frame
            {
                
                float shootDirection = 
                    (float)Math.Atan2( // get angle between player and yoyo
                        projectile.position.Y - Main.player[projectile.owner].position.Y,
                        projectile.position.X - Main.player[projectile.owner].position.X
                        )
                    + Main.rand.NextFloat(-(float)Math.PI / 32, (float)Math.PI / 32); // bullet spread

                Projectile.NewProjectile(
                    projectile.position, // pos
                    new Vector2( // x and y velocity
                        (float)Math.Cos(shootDirection) * 8, 
                        (float)Math.Sin(shootDirection) * 8
                        ),
                    ProjectileID.Bullet, // Type
                    40, // Damage
                    4f, // Knockback
                    projectile.owner // owner
                    );

            }
        }


    }
}

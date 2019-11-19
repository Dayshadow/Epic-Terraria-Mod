using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System;
using static Terraria.ModLoader.ModContent;
using Microsoft.Xna.Framework.Graphics;

namespace DayshadowsMod.Projectiles
{
    // Code adapted from the vanilla's magic missile.
    public class osuCursorProjectile : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.width = 14;
            projectile.height = 14;
            projectile.velocity = new Vector2(0, 0);
            projectile.friendly = true;
            projectile.tileCollide = false;
            projectile.penetrate = -1;
            projectile.magic = true;
            projectile.timeLeft = 600;
            projectile.alpha = 255;
            projectile.scale = 1.0f;

        }

        private float Timer
        {
            get => projectile.ai[0];
            set => projectile.ai[0] = value;
        }

        public override bool PreAI()
        {
            if (Main.myPlayer == projectile.owner)
            {
                projectile.position = Main.MouseWorld;
            }
            return true;
        }
        public override void AI()
        {
            Dust.NewDustPerfect(Main.MouseWorld, DustType<Dusts.osuCursorDust>());

            Lighting.AddLight(Main.MouseWorld, 1f, 1f, 1f);
        }

    }
}
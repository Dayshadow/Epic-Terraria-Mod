using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System;

namespace DayshadowsMod.Projectiles
{
    class PrismancerProjectileSplit : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Prismancer Projectile Split");
        }

        public override void SetDefaults()
        {
            projectile.width = 9;
            projectile.height = 9;
            projectile.timeLeft = 100;
            projectile.penetrate = 15;
            projectile.aiStyle = -1;
            projectile.scale = 1.5f;
            projectile.friendly = true;
            projectile.magic = true;
            projectile.tileCollide = true;
            projectile.ignoreWater = true;
        }
        public override void AI()
        {
            projectile.rotation += (float)Math.PI / 6;
            projectile.velocity = RotateVector2d(projectile.velocity, MathHelper.Pi / 30);
            CreateDust();
        }
        public virtual void CreateDust()
        {
            Dust.NewDustPerfect(projectile.position, mod.DustType("PrismancerDust"));
        }
        public override void Kill(int timeLeft)
        {
            Dust.NewDust(projectile.oldPosition, 30, 30, mod.DustType("PrismancerDust"), projectile.velocity.X, projectile.velocity.Y);
        }

        static Vector2 RotateVector2d(Vector2 vector, float radians)
        {
            Vector2 result = vector;
            result.X = result.X * (float)Math.Cos(radians) - result.Y * (float)Math.Sin(radians);
            result.Y = result.X * (float)Math.Sin(radians) + result.Y * (float)Math.Cos(radians);
            return result;
        }
    }
}

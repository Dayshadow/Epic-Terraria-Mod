using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System;
using static Terraria.ModLoader.ModContent;

namespace DayshadowsMod.Projectiles
{
    class PrismancerProjectile : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Prismancer Projectile");
        }
        public float RandomSeed
        {
            get => projectile.ai[1];
            set => projectile.ai[1] = value;
        }
        public override void SetDefaults()
        {
            projectile.width = 25;
            projectile.height = 9;
            projectile.timeLeft = lifetime;
            projectile.penetrate = 15;
            projectile.aiStyle = -1;
            projectile.scale = 1.5f;
            projectile.friendly = true;
            projectile.magic = true;
            projectile.tileCollide = true;
            projectile.ignoreWater = true;

            //drawOriginOffsetX = -16;
            //drawOriginOffsetY = 8;

        }
        public float Timer
        {
            get => projectile.ai[0];
            set => projectile.ai[0] = value;
        }

        public int fadeIn = 30;
        public int lifetime = 100;
        public float RPS; // rotations per second ~~maybe idk~~
        public float spinVelocity;
        public float maxRotSpeed = MathHelper.Pi / 16; // the fastest it will spin
        public float rotAccelerationTime = 1; // how many seconds it takes to reach max speed
        public override void AI()
        {
            Timer++;
            if (Timer == 1)
            {
                RandomSeed = Main.rand.NextFloat(-1, 1) - 0.5f;
            }
            if (Timer <= fadeIn) // For making the projectile fade in
            {
                projectile.alpha = (int)(255.0f * (1 - (Timer / fadeIn)));
            }
            Lighting.AddLight(projectile.position, 1f, 0, 1f);

            spinVelocity = MathHelper.Clamp((Timer / (60 * rotAccelerationTime)) * maxRotSpeed, 0, maxRotSpeed);
            RPS = (spinVelocity / MathHelper.TwoPi) * 60;
            projectile.rotation += spinVelocity;
            if (Timer % 20 == 0)
            {
                PlaySound();
            }

            CreateDust();

        }
        public override void Kill(int timeLeft)
        {
            Projectile.NewProjectile(
                projectile.oldPosition + new Vector2((float)Math.Cos(projectile.rotation) * 10, (float)Math.Sin(projectile.rotation) * 10),
                new Vector2((float)Math.Cos(projectile.rotation + (float)Math.PI / 2) * 4.5f, (float)Math.Sin(projectile.rotation + (float)Math.PI / 2) * 4.5f),
                ProjectileType<PrismancerProjectileSplit>(),
                70,
                6f,
                projectile.owner
                );
            Projectile.NewProjectile(
                projectile.oldPosition - new Vector2((float)Math.Cos(projectile.rotation) * 10, (float)Math.Sin(projectile.rotation) * 10), // position
                new Vector2(-(float)Math.Cos(projectile.rotation + (float)Math.PI / 2) * 4.5f, -(float)Math.Sin(projectile.rotation + (float)Math.PI / 2) * 4.5f), // velocity
                ProjectileType<PrismancerProjectileSplit>(), // type
                70, // damage
                6f, // knockback
                projectile.owner
                );
        }

        public virtual void PlaySound()
        {
            Main.PlaySound(SoundID.Item46, projectile.position);
        }
        public virtual void CreateDust()
        {
            Dust.NewDustPerfect(projectile.position + new Vector2(12.5f + (float)Math.Cos(projectile.rotation) * 10, 4.5f + (float)Math.Sin(projectile.rotation) * 10), mod.DustType("PrismancerDust"));
            Dust.NewDustPerfect(projectile.position + new Vector2(12.5f - (float)Math.Cos(projectile.rotation) * 10, 4.5f - (float)Math.Sin(projectile.rotation) * 10), mod.DustType("PrismancerDust"));
        }
    }
}

using Terraria;
using Terraria.ModLoader;

namespace DayshadowsMod.Dusts {
    public class PrismancerDust : ModDust
    {
        public override void OnSpawn(Dust dust)
        {
            dust.noGravity = true;
            dust.scale = 2f;
        }

        public override bool Update(Dust dust)
        {
            dust.rotation += 0.1f;
            dust.scale *=  0.97f;
            if (dust.scale < 0.25f)
            {
                dust.active = false;
            }
            return false;
        }
    }
}
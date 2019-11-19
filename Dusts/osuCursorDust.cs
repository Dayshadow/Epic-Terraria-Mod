using Terraria;
using Terraria.ModLoader;

namespace DayshadowsMod.Dusts {
    public class osuCursorDust : ModDust
    {
        public override void OnSpawn(Dust dust)
        {
            dust.noGravity = true;
            dust.scale = 4.2f;
        }

        public override bool Update(Dust dust)
        {
            dust.alpha += (int)255f / 10;
            if (dust.alpha >= 255)
            {
                dust.active = false;
            }
            return false;
        }
    }
}
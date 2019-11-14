using DayshadowsMod.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace DayshadowsMod.Items
{
    class PrismancerGrimoire : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("It emits a purple light...");
        }

        public override void SetDefaults()
        {
            item.damage = 65;
            item.noMelee = true;
            item.magic = true;
            item.channel = true; //Channel so that you can held the weapon [Important]
            item.mana = 0;
            item.rare = 7;
            item.width = 32;
            item.height = 32;
            item.useTime = 20;
            item.useAnimation = 20;
            item.UseSound = SoundID.Item20;
            item.useStyle = 5;
            item.shootSpeed = 4.5f;
            item.shoot = mod.ProjectileType("PrismancerProjectile");
            item.value = Item.sellPrice(silver: 3);
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DirtBlock, 1);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}

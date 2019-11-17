using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace FirstMod.Items
{
    public class XPTabletPen : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Tablet Pen Star G640");
        }

        public override void SetDefaults()
        {
            item.damage = 30;
            item.ranged = true;
            item.width = 10;
            item.height = 10;
            item.maxStack = 999;
            item.consumable = true;
            item.knockBack = 1f;
            item.rare = 4;

            item.shoot = mod.ProjectileType("XPTabletPenPro");

            // velocity of the projectile
            item.shootSpeed = 4.5f;

            item.ammo = AmmoID.Arrow;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);

            recipe.AddIngredient(ItemID.DirtBlock);

            // recipe.AddTile(TileID.WorkBenches);

            recipe.SetResult(this, 3);

            recipe.AddRecipe();
        }
    }
    
}
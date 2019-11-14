using DayshadowsMod.Projectiles;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
namespace DayshadowsMod.Items
{
    class FactoryStaff : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Launches drones at your foes.");
            Item.staff[item.type] = true; //this makes the useStyle animate as a staff instead of as a gun
        }
        public override void SetDefaults()
        {
            item.damage = 40;
            item.magic = true;
            item.mana = 1;
            item.width = 40;
            item.height = 40;
            item.useTime = 25;
            item.useAnimation = 25;
            item.useStyle = 5;
            item.noMelee = true; //so the item's animation doesn't do damage
            item.knockBack = 5;
            item.value = 10000;
            item.rare = 2;
            item.UseSound = SoundID.Item20;
            item.autoReuse = false;
            item.shoot = ProjectileType<FactoryDrone>();
            item.shootSpeed = 5f;
            
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DirtBlock, 10);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}

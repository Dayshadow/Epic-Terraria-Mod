using System;
using DayshadowsMod.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace DayshadowsMod.Items
{
    public class WacomCTH480: ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Wacom CTH-480");
            Tooltip.SetDefault("Gives you a cursor to 300 enemies with");
        }

        public override void SetDefaults()
        {
            item.damage = 75;
            item.magic = true;
            item.mana = 10;
            item.width = 30;
            item.height = 30;
            item.useTime = 600;
            item.useAnimation = 600;
            item.rare = 7;
            item.useStyle = 5;
            item.noMelee = true;
            item.channel = true; //Channel so that you can hold the weapon down [Important]
            item.knockBack = 8;
            item.value = Item.sellPrice(gold: 10);
            item.rare = 3;
            item.shoot = ProjectileType<osuCursorProjectile>();
            item.shootSpeed = 10f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemType<XPTablet>(), 1);
            recipe.AddIngredient(ItemID.HallowedBar, 10);
            recipe.AddIngredient(ItemID.SoulofLight, 10);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
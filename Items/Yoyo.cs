using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace DayshadowsMod.Items
{
	public class Yoyo : ModItem
	{
		public override void SetStaticDefaults() 
		{
            DisplayName.SetDefault("The Zenith"); // DisplayName.SetDefault("FirstSword"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Blue Zenith 727 lol.");
		}

		public override void SetDefaults() 
		{
            item.useStyle = 5;
            item.width = 24;
            item.height = 24;
            item.useAnimation = 25; //garhu commented
            item.useTime = 25;
            item.shootSpeed = 16f;
            item.knockBack = 1f;
            item.damage = 72;
            item.rare = 12;

            item.melee = true;
            item.channel = true;
            item.noMelee = true;
            item.noUseGraphic = true;

            item.UseSound = SoundID.Item1;
            item.value = Item.sellPrice(silver: 1);
            item.shoot = mod.ProjectileType("YoyoPro");
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
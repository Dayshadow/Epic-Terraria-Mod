using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace DayshadowsMod.Items
{
	public class PeppyYoyo : ModItem
	{
		public override void SetStaticDefaults() 
		{
            DisplayName.SetDefault("Peppy's Throw"); // DisplayName.SetDefault("FirstSword"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("osu!");
		}

		public override void SetDefaults() 
		{
            item.useStyle = 5;
            item.width = 24; // one last comment
            item.height = 24;
            item.useAnimation = 25; //garhu commented
            item.useTime = 25; // another gahru comment
            item.shootSpeed = 16f;
            item.knockBack = 2.4f;
            item.damage = 69;
            item.rare = 9;

            item.melee = true;
            item.channel = true;
            // item.noMelee = true;
            item.noUseGraphic = true;

            item.UseSound = SoundID.Item1;
            item.value = Item.sellPrice(gold: 1);
            item.shoot = mod.ProjectileType("PeppyYoyoPro");
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DirtBlock, 2);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
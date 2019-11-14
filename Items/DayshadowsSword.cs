using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace DayshadowsMod.Items
{
	public class DayshadowsSword : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Long Boi"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("For when you don't want to get too close");
		}

		public override void SetDefaults() 
		{
			item.damage = 500;
			item.melee = true;
			item.width = 94;
			item.height = 94;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 20f;
			item.value = 10000;
			item.rare = 13;
            item.crit = 100;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

        public override void MeleeEffects(Player player, Rectangle hitbox)
        {
            Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, 21, 0f, 0f, 0, default(Color), 1); // dust 63
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
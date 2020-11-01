
using Terraria.ID;
using Terraria.ModLoader;

namespace Fmod.Items.Weapons.Melee.Swords
{
	public class Sword : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("sword"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("this is a relic...");
		}

		public override void SetDefaults() 
		{
			item.damage = 305;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 2;
			item.useAnimation = 20;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.knockBack = 6;
            item.value = 10000;
			item.rare = ItemRarityID.Pink;
			item.UseSound = SoundID.Item105;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.FragmentSolar, 15);
            recipe.AddIngredient(ItemID.FragmentStardust, 10);
            recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
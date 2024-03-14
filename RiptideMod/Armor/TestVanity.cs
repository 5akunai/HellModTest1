using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace RiptideMod.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class Garland : ModItem
	{
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Garland"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
            Tooltip.SetDefault("'It smells like prettiness.'");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.value = 100;
            item.rare = 1;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Daybloom);
            recipe.AddIngredient(ItemID.Moonglow);
            recipe.AddIngredient(ItemID.Blinkroot);
            recipe.AddIngredient(ItemID.Waterleaf);
            recipe.AddIngredient(ItemID.Deathweed);
            recipe.AddIngredient(ItemID.Shiverthorn);
            recipe.AddIngredient(ItemID.Fireblossom);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
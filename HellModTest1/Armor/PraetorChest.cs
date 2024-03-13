using System;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace HellModTest1.Items.Armor
{
    [AutoloadEquip(EquipType.Body)]
    public class PraetorSuitBody : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Praetor Suit Chestpiece");
            Tooltip.SetDefault("Increases maximum health and defense\n5% increased melee critical strike chance");
        }

        public override void SetDefaults()
        {
            item.width = 30;
            item.height = 20;
            item.value = 5000;
            item.rare = 4;
            item.defense = 20;
        }

        public override void UpdateEquip(Player player)
        {
            player.statLifeMax2 += 125;
            player.statDefense += 25;
            player.meleeCrit += 5;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Hellstone, 35);
            recipe.AddIngredient(ItemID.Obsidian, 10);
            recipe.AddTile(TileID.Hellforge);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
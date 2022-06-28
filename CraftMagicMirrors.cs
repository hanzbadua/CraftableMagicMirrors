using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CraftMagicMirrors
{
    public class CraftMagicMirrors : Mod
    {
        public override void AddRecipes()
        {
            _ = Recipe.Create(ItemID.MagicMirror, 1)
                .AddRecipeGroup("IronBar", 4)
                .AddIngredient(ItemID.Glass, 6)
                .AddIngredient(ItemID.RecallPotion, 10)
                .AddTile(TileID.Anvils)
                .Register();

            _ = Recipe.Create(ItemID.IceMirror, 1)
                .AddIngredient(ItemID.MagicMirror, 1)
                .AddIngredient(ItemID.IceBlock, 10)
                .Register();
        }
    }
}
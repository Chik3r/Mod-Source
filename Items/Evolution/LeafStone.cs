using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Terraria.ModLoader;

namespace Terramon.Items.Evolution
{
    public class LeafStone : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Leaf Stone");
            Tooltip.SetDefault(
                "A stone used for making certain kinds of Pokémon evolve.\nIt has an unmistakable leaf pattern.");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 20;
            item.maxStack = 99;
            item.value = 20000;
            item.rare = 0;
            // Set other item.X values here
        }

        public override void ModifyTooltips(List<TooltipLine> tooltips)
        {
            TooltipLine nameLine = tooltips.FirstOrDefault(t => t.Name == "ItemName" && t.mod == "Terraria");

            foreach (TooltipLine line2 in tooltips)
                if (line2.mod == "Terraria" && line2.Name == "ItemName")
                    line2.overrideColor = new Color(55, 176, 115);
        }
    }
}
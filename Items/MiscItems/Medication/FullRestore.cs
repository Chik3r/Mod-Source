﻿using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Terraria.ModLoader;
using static Terramon.Pokemon.Utilities.ID;

namespace Terramon.Items.MiscItems.Medication
{
    public class FullRestore : ModItem
    {
        public ItemGroup itemGroup = ItemGroup.StatusConditionHealing;
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Full Restore");
            Tooltip.SetDefault("A spray-type medicine for treating wounds."
                               + "\nHold it and left click a Pokémon in your party to use."
                               + "\nCompletely restores Max HP."
                               + "\nCures all status conditions.");
        }

        public override void SetDefaults()
        {
            item.width = 24;
            item.height = 32;
            item.maxStack = 99;
            item.value = 3000;
            item.rare = 0;
            // Set other item.X values here
        }

        public override void ModifyTooltips(List<TooltipLine> tooltips)
        {
            TooltipLine nameLine = tooltips.FirstOrDefault(t => t.Name == "ItemName" && t.mod == "Terraria");

            foreach (TooltipLine line2 in tooltips)
                if (line2.mod == "Terraria" && line2.Name == "ItemName")
                    line2.overrideColor = new Color(105, 207, 112);
        }

        public override bool CanBurnInLava()
        {
            return false;
        }
    }
}
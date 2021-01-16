using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using Terramon.Players;
using Terramon.Pokemon.Moves;
using Terraria;
using Terraria.ModLoader;
using static Terramon.Pokemon.ExpGroups;

namespace Terramon.Pokemon.FirstGeneration.Normal.Nidoranf
{
    public class Nidoranf : ParentPokemon
    {
        public override int EvolveCost => 11;

        public override Type EvolveTo => typeof(Nidorina.Nidorina);

        public override PokemonType[] PokemonTypes => new[] { PokemonType.Poison };

        public override ExpGroup ExpGroup => ExpGroup.MediumSlow;public override int MaxHP => 55; public override int PhysicalDamage => 47; public override int PhysicalDefence => 52; public override int SpecialDamage => 40; public override int SpecialDefence => 40; public override int Speed => 41;

        public override void SetDefaults()
        {
            base.SetDefaults();

            
            
        }
    }
}
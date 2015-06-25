﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UltimaXNA.Ultima.Data
{
    static class Magery
    {
        public static SpellDefinition[] Spells;

        static Magery()
        {
            Spells = new SpellDefinition[] {
                // first circle
                new SpellDefinition("Clumsy", 0, Reagents.Bloodmoss, Reagents.Nightshade),
                new SpellDefinition("Create Food", 0, Reagents.Garlic, Reagents.Ginseng, Reagents.MandrakeRoot),
                new SpellDefinition("Feeblemind", 0, Reagents.Nightshade, Reagents.Ginseng),
                new SpellDefinition("Heal", 0, Reagents.Garlic, Reagents.Ginseng, Reagents.SpidersSilk),
                new SpellDefinition("Magic Arrow", 0, Reagents.SulfurousAsh),
                new SpellDefinition("Night Sight", 0, Reagents.SpidersSilk, Reagents.SulfurousAsh),
                new SpellDefinition("Reactive Armor", 0, Reagents.Garlic, Reagents.SpidersSilk, Reagents.SulfurousAsh),
                new SpellDefinition("Weaken", 0, Reagents.Garlic, Reagents.Nightshade),
                // second circle
                new SpellDefinition("Agility", 0, Reagents.Bloodmoss, Reagents.MandrakeRoot),
                new SpellDefinition("Cunning", 0, Reagents.Nightshade, Reagents.MandrakeRoot),
                new SpellDefinition("Cure", 0, Reagents.Garlic, Reagents.Ginseng),
                new SpellDefinition("Harm", 0, Reagents.Nightshade, Reagents.SpidersSilk),
                new SpellDefinition("Magic Trap", 0, Reagents.Garlic, Reagents.SpidersSilk, Reagents.SulfurousAsh),
                new SpellDefinition("Magic Untrap", 0, Reagents.Bloodmoss, Reagents.SulfurousAsh),
                new SpellDefinition("Protection", 0, Reagents.Garlic, Reagents.Ginseng, Reagents.SulfurousAsh),
                new SpellDefinition("Strength", 0, Reagents.MandrakeRoot, Reagents.Nightshade),
                // third circle
                new SpellDefinition("Bless", 0, Reagents.Garlic, Reagents.MandrakeRoot),
                new SpellDefinition("Fireball", 0, Reagents.BlackPearl),
                new SpellDefinition("Magic Lock", 0, Reagents.Bloodmoss, Reagents.Garlic, Reagents.SulfurousAsh),
                new SpellDefinition("Poison", 0, Reagents.Nightshade),
                new SpellDefinition("Telekinesis", 0, Reagents.Bloodmoss, Reagents.MandrakeRoot),
                new SpellDefinition("Teleport", 0, Reagents.Bloodmoss, Reagents.MandrakeRoot),
                new SpellDefinition("Unlock", 0, Reagents.Bloodmoss, Reagents.SulfurousAsh),
                new SpellDefinition("Wall of Stone", 0, Reagents.Bloodmoss, Reagents.Garlic),
                // fourth circle
                new SpellDefinition("Arch Cure", 0, Reagents.Garlic, Reagents.Ginseng, Reagents.MandrakeRoot),
                new SpellDefinition("Arch Protection", 0, Reagents.Garlic, Reagents.Ginseng, Reagents.MandrakeRoot, Reagents.SulfurousAsh),
                new SpellDefinition("Curse", 0, Reagents.Garlic, Reagents.Nightshade, Reagents.SulfurousAsh),
                new SpellDefinition("Fire Field", 0, Reagents.BlackPearl, Reagents.SpidersSilk, Reagents.SulfurousAsh),
                new SpellDefinition("Greater Heal", 0, Reagents.Garlic, Reagents.Ginseng, Reagents.MandrakeRoot, Reagents.SpidersSilk),
                new SpellDefinition("Lightning", 0, Reagents.MandrakeRoot, Reagents.SulfurousAsh),
                new SpellDefinition("Mana Drain", 0, Reagents.BlackPearl, Reagents.MandrakeRoot, Reagents.SpidersSilk),
                new SpellDefinition("Recall", 0, Reagents.BlackPearl, Reagents.Bloodmoss, Reagents.MandrakeRoot),
                // fifth circle
                
                // sixth circle

                // seventh circle

                // eighth circle

            };
        }

        public static string[] CircleNames = new string[] {
            "First Circle", "Second Circle", "Third Circle", "Fourth Circle",
            "Fifth Circle", "Sixth Circle", "Seventh Circle", "Eighth Circle" };
    }
}

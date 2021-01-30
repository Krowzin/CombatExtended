﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RimWorld;
using Verse;
using UnityEngine;

namespace CombatExtended
{
    public class ProjectilePropertiesCE : ProjectileProperties
    {
        // public float armorPenetration = 0;
        public int pelletCount = 1;
        public float spreadMult = 1;
        public List<SecondaryDamage> secondaryDamage = new List<SecondaryDamage>();
        public bool damageAdjacentTiles = false;
        public bool dropsCasings = false;
        public string casingMoteDefname = "Mote_EmptyCasing";
        public float gravityFactor = 1;
        public bool isInstant = false;
        public float armorPenetrationSharp;
        public float armorPenetrationBlunt;
        
        public float empShieldBreakChance = 1f;
        public float Gravity => CE_Utility.GravityConst * gravityFactor;
    }
}

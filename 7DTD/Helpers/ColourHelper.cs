﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Cheat.Helpers
{
    class ColourHelper
    {
        public static void AddColours()
        {


            AddColour("ZombieColour", Color.blue);
            AddColour("PlayerColour", Color.white);
            AddColour("AnimalColour", Color.cyan);
        }
        public static Color32 GetColour(string identifier)
        {
            if (Globals.Config.Colours.GlobalColors.TryGetValue(identifier, out var toret))
                return toret;
            return Color.magenta;
        }

        public static void AddColour(string id, Color32 c)
        {
            if (!Globals.Config.Colours.GlobalColors.ContainsKey(id))
                Globals.Config.Colours.GlobalColors.Add(id, c);
        }

        public static void SetColour(string id, Color32 c) => Globals.Config.Colours.GlobalColors[id] = c;

        public static string ColourToHex(Color32 color)
        {
            string hex = color.r.ToString("X2") + color.g.ToString("X2") + color.b.ToString("X2");
            return hex;
        }
    }
}
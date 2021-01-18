using System;
using System.Collections.Generic;
using System.Text;

namespace MordhauSuggestionGenerator
{
    class MechanicObject
    {
        public string[] suggestions = new string[]
        {
            "Add",
            "Add new",
            "Allow for",
            "Introduce",
            "Make",
            "Develop",
            "Create"
        };

        public string[] mechanics = new string[]
        {
            "Morph",
            "Feint",
            "Kick",
            "Overhead",
            "Chamber",
            "Riposte",
            "Parry",
            "Underhand",
            "Reverse",
            "Slash",
            "Stab",
            "Flinch",
            "Active Parry",
            "Hitstop",
            "Drag",
            "Accel",
            "Hyper Armour",
            "Clash",
            "Windup",
            "Release",
            "Recovery",
            "Lunge",
            "Turncap",
            "Gamble"
        };

        public string[] types = new string[]
        {
            "mechanic",
            "move",
            "ability",
            ""
        };

        public string WriteShitpost()
        {
            Random r = new Random();
            int a = r.Next(0, suggestions.Length);
            int b = r.Next(0, types.Length);
            int c = r.Next(2, 5);
            string s = suggestions[a];
            string m = "";
            string e = types[b];
            for (int i = 0; i < c; i++)
            {
                m += " " + mechanics[r.Next(0, mechanics.Length)];
            }
            //no space between s and m, as that's handled in the loop
            return s + m + " " + e;
        }
    }
}

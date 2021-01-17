using System;
using System.Collections.Generic;
using System.Text;

namespace MordhauSuggestionGenerator
{
    class BullshitBuilder
    {
        string[] suggestions = new string[]
        {
            "Change",
            "Set",
            "Adjust",
            "Revert",
            "Force"
        };

        public string WriteShitpost()
        {
            MeleeObject m = new MeleeObject();
            Random r = new Random();
            int a = r.Next(0, suggestions.Length);
            int b = r.Next(0, m.objects.Length);
            int c = r.Next(0, m.properties.Length);
            int d;
            //timings
            if (m.properties[c].Contains(" ms")) {
                d = r.Next(150, 1000);
            }
            //lengths
            else if (m.properties[c].Contains(" cm"))
            {
                d = r.Next(25, 200);
            }
            //stam or damage values
            else
            {
                d = r.Next(0, 100);
            }
            return suggestions[a] + " " + m.objects[b] + " " + m.properties[c] + " to " + d;
        }
    }
}

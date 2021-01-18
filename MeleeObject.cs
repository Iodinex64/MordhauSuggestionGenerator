using System;

public class MeleeObject
{
	string[] suggestions = new string[]
	{
		"Change",
		"Set",
		"Adjust",
		"Make",
		"Buff",
		"Nerf"
	};

	public string[] objects = new string[]
	{
		"Broken Longsword",
		"Carrot",
		"Fists",
		"Fists with Brawler perk",
		"Kick",
		"Kick with T3 legs",
		"Lute",
		"Rusty Longsword",
		"Short Sword",
		"Training Sword", 
		"Wooden Mallet", 
		"Dagger",
		"Heavy Branch",
		"Quarterstaff",
		"Wooden Shovel",
		"Broken Arming Sword",
		"Carving Knife",
		"Cleaver",
		"Pitchfork",
		"Rake",
		"Rusty Arming Sword",
		"Blacksmith Hammer",
		"Warhammer",
		"Axe",
		"Sickle",
		"Arming Sword",
		"Frying Pan",
		"Falchion",
		"Heavy Handaxe", 
		"Short Spear", 
		"Mace",
		"Bastard Sword",
		"Hoe",
		"Rapier",
		"Rusty Fork",
		"Billhook",
		"Longsword",
		"Battle Axe",
		"Club",
		"Messer",
		"Pickaxe",
		"Rusty Shovel",
		"Scythe",
		"Sledgehammer",
		"War Axe",
		"Estoc",
		"Falx",
		"Pole Axe",
		"Eveningstar",
		"Executioner's Sword",
		"Greatsword",
		"Maul",
		"Bardiche",
		"Halberd",
		"Polehammer",
		"Zweihander",
		"Spear"
	};

	public string[] properties = new string[]
	{
		"windup ms",
		"release ms",
		"recovery ms",
		"combo time in ms",
		"length in cm",
		"wood damage",
		"stone damage",
		"damage to t0 head",
		"damage to t0 torso",
		"damage to t0 legs",
		"damage to t1 head",
		"damage to t1 torso",
		"damage to t1 legs",
		"damage to t2 head",
		"damage to t2 torso",
		"damage to t2 legs",
		"damage to t3 head",
		"damage to t3 torso",
		"damage to t3 legs",
		"stamina negation",
		"stamina damage"
	};

	public string WriteShitpost()
    {
		Random r = new Random();
		int a, b, c, d, e;
		a = r.Next(0, suggestions.Length);
		b = r.Next(0, objects.Length);
		c = r.Next(0, properties.Length);
		d = r.Next(0, 5);

		//timings
		if (properties[c].Contains(" ms"))
		{
			e = r.Next(0, 1000);
		}
		//lengths
		else if (properties[c].Contains(" cm"))
		{
			e = r.Next(0, 200);
		}
		//stam or damage values
		else
		{
			e = r.Next(0, 100);
		}

		//alt mode
		string dS = "";
		if (d == 0)
		{
			dS = "alt mode ";
		}
		return suggestions[a] + " " + dS + objects[b] + " " + properties[c] + " to " + e;
	}
}

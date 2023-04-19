using Jogo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo.Factories
{
    internal class WorldFactory
    {
        internal World CreateWorld()
        {
            World newWorld = new World();
            newWorld.AddLocation("Home", "This is your home", -1, 0);
            newWorld.AddLocation("City", "Here you can find quests, weapon and healing potions", 0, 0);
            newWorld.AddLocation("Hospital", "Here you can buy healing potions", 1, 0);
            newWorld.AddLocation("Blacksmith", "Here you can buy Weapons", 1, 1);
            newWorld.AddLocation("Pub", "Here you can pick your quest", 1, -1);
            newWorld.AddLocation("Beach", "Giant Crab nest", 0, -1);
            newWorld.AddLocation("Abandoned Amusement Park", "Creepy Clown's House", 0, 1);
            newWorld.AddLocation("Forest", "Biggest Monster in the world", -2, 0);

            return newWorld;


        }
    }
}

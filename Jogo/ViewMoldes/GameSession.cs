using Jogo.Factories;
using Jogo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo.ViewMoldes
{
    public class GameSession
    {
        Player CurrentPlayer { get; set; }
        Location CurrentLocation { get; set; }

        World CurrentWorld { get; set; }
        
        public GameSession()
        {
            CurrentPlayer = new Player();
            CurrentLocation = new Location();
            CurrentWorld = new World();

            Console.WriteLine("Bem Vindo ao Jogo!");

            Console.WriteLine("Escreva o nome do seu Jogador:");
            CurrentPlayer.Name = Console.ReadLine();

            CurrentPlayer.Level = 1;
            CurrentPlayer.HitPoints = 10;
            CurrentPlayer.ExperiencePoints = 0;

            WorldFactory factory = new WorldFactory();
            CurrentWorld = factory.CreateWorld();

            CurrentLocation = CurrentWorld.LocationAt(-1, 0);

        }
    }
}

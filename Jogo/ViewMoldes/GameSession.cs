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
        
        public GameSession()
        {
            CurrentPlayer = new Player();
            Console.WriteLine("Bem Vindo ao Jogo!");

            Console.WriteLine("Escreva o nome do seu Jogador:");
            CurrentPlayer.Name = Console.ReadLine();

            CurrentPlayer.Level = 1;
            CurrentPlayer.HitPoints = 10;
            CurrentPlayer.ExperiencePoints = 0;
        }
    }
}

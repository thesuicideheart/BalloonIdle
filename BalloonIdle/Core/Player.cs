using Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalloonIdle.Core
{
    public class Player
    {
        public int Points { get; set; }

        public int Level { get; set; }
        public int Exp { get; set; }
        public int ExpRemaining { get; set; }

        public int WaveCooldown { get; set; } = 600; //TODO: Make it based on WaveCooldownLevel
        public int SpawnAmount { get; set; } = 1; //TODO: Based on SpawnAmountLevel;



        public Player()
        {
            Points = 0;
        }
    }
}

using Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalloonIdle.Core
{
    public static class Ext
    {
        public static GameLayer GetGameLayer(this Handler handler)
        {
            Game1 game = (Game1)handler.Game;
            return game.gameLayer;
        }
    }
}

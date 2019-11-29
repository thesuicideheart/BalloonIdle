using Engine.UI;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalloonIdle.Core
{
    public class GameLayer : Layer
    {
        public Player player;

        int timer;
        public GameLayer()
        {
            player = new Player();
            AddEntity(new Balloon(100, 600));
            timer = player.WaveCooldown;
        }

        public override void Draw(SpriteBatch batch)
        {
            base.Draw(batch);
            Game1.DrawString($"Points: {player.Points}", 1, 1, Color.Black);
        }

        public override void Update()
        {
            base.Update();
            timer--;

            if(timer <= 0)
            {
                //Lets spawn a balloon
                Balloon b = new Balloon(Handler.GenerateRandomNumber(0, Handler.GetWindowWidth()), -60);
                AddEntity(b);
                timer = player.WaveCooldown;
            }
        }

    }
}

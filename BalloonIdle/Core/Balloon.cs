using Engine;
using Engine.Input;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MonoGame.Extended;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalloonIdle.Core
{
    public class Balloon : Entity
    {
        public int PointsRewarded { get; set; }
        public int Health { get; set; }
        public float Speed { get; set; } = .5f;

        public Balloon(float x, float y) : base(x, y)
        {
            Width = 30;
            Height = 30;
            Health = 3;
        }

        public override void Draw(SpriteBatch batch)
        {
            batch.FillRectangle(Bounds, Color.Blue);
            batch.DrawRectangle(Bounds, Color.Black, 2);
            batch.FillRectangle(new RectangleF(X + Width / 2 - 1, Y + Width, 3, 30), Color.Black);
        }

        public override void Update()
        {
            Y -= Speed;
            if (Clicked())
            {
                TakeDamage(1);
            }
        }

        public void TakeDamage(int amt)
        {
            Health -= amt;
            if(Health <= 0)
            {
                IsDead = true;
                Handler.GetGameLayer().player.Points += 1;
            }
        }

        private bool Clicked()
        {
            return Bounds.Contains(Handler.GetInputManager().GetMousePosition()) 
                && Handler.GetInputManager().JustPressed(MouseInput.LeftButton);
        }

    }
}

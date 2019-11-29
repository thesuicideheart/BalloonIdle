using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MonoGame.Extended;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Entity
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float Width { get; set; }
        public float Height { get; set; }
        public RectangleF Bounds {
            get
            {
                return new RectangleF(X, Y, Width, Height);
            }
        }
        public bool IsDead { get; set; }
        public Handler Handler { get; set; }

        public Entity(float x, float y)
        {
            X = x;
            Y = y;
            Handler = CustomGame.Instance.Handler;
            
        }

        public virtual void Update()
        {

        }

        public virtual void OnCollisionWithEntity(Entity other)
        {

        }

        public virtual void Draw(SpriteBatch batch)
        {

        }

    }
}

using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.UI
{
    public class UIObject
    {
        public int X;
        public int Y;

        protected Handler Handler;
        
        public UIObject(int x, int y)
        {
            X = x;
            Y = y;
            Handler = CustomGame.Instance.Handler;
        }

        public virtual void Draw(SpriteBatch batch)
        {

        }

    }
}

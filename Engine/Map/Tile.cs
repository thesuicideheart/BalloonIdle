using Engine.Input;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MonoGame.Extended;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Map
{
    public class Tile
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int TileID { get; set; }

        public RectangleF Bounds { get; set; }

        public Handler Handler { get; set; }

        public Entity EntityOnTile;

        public Tile(int x, int y, int w, int h, int tileId)
        {
            X = x;
            Y = y;
            Width = w;
            Height = h;
            TileID = tileId;
            Bounds = new RectangleF(X, Y, Width, Height);
            Handler = CustomGame.Instance.Handler;
        }

        public bool Hovering()
        {
            return Bounds.Contains(Handler.GetInputManager().GetMousePosition());
        }

        protected virtual void OnClicked()
        {

        }

        public bool Clicked()
        {
            if (Hovering() && Handler.GetInputManager().JustPressed(MouseInput.LeftButton))
            {
                return true;
            }
            return false;
        }

        public virtual void Update()
        {
            if (EntityOnTile != null) EntityOnTile.Update();
            if (Clicked()) OnClicked();
        }

        public virtual void Draw(SpriteBatch batch)
        {

        }
    }
}

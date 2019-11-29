using Engine.Input;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MonoGame.Extended;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.UI
{
    public class Button : UIObject
    {

        public float Width;
        public float Height;
        public Color Color;

        private RectangleF rect;


        public int Right { get { return (int)(X + Width); } }
        public int Top { get { return Y; } }
        public int Left { get { return X; } }
        public int Bottom { get { return (int)(Y + Height); } }
        public string Text { get; set; }

        public Button(int x, int y, int width, int height, Color color, string text = "") : base(x, y)
        {
            Width = width;
            Height = height;
            Color = color;
            rect = new RectangleF(x, y, width, height);
            Text = text;
        }

        public override void Draw(SpriteBatch batch)
        {
            batch.FillRectangle(rect, Color);
            batch.DrawRectangle(rect, Color.Black, 2);
        }

        public bool HoverOver()
        {
            return rect.Contains(Handler.GetInputManager().GetMousePosition());
        }

        public bool Clicked()
        {
            return HoverOver() && Handler.GetInputManager().JustPressed(MouseInput.LeftButton);
        }

    }
}

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
    public class Panel : UIObject
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public List<UIObject> Children { get; set; }
        public Color BorderColor { get; set; }
        public Color BackgroundColor { get; set; }
        public int BorderSize { get; set; }


        public Panel(int x, int y, int width, int height, Color bColor, Color bgColor, int bSize) : base(x, y)
        {
            Width = width;
            Height = height;
            Children = new List<UIObject>();
            BorderColor = bColor;
            BackgroundColor = bgColor;
            BorderSize = bSize <= 0 ? 1 : bSize;
        }

        public override void Draw(SpriteBatch batch)
        {

            batch.FillRectangle(new RectangleF(X, Y, Width, Height), BackgroundColor);
            batch.DrawRectangle(new RectangleF(X, Y, Width, Height), BorderColor, BorderSize);
            foreach(var child in Children)
            {
                child.Draw(batch);
            }

        }

        public void AddChild(UIObject obj)
        {
            Children.Add(obj);
        }

    }
}

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
    public class ProgressBar : UIObject
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public float Value { get; set; } = 0;
        public float MaxValue { get; set; }
        public float MinValue { get; set; }
        public Color BackgroundColor { get; set; }
        public Color FillColor { get; set; }

        public ProgressBar(int x, int y, int width, int height, float max, float min, Color bgColor, Color fColor) : base(x, y)
        {
            Width = width;
            Height = height;
            MaxValue = max;
            MinValue = min;
            BackgroundColor = bgColor;
            FillColor = fColor;
        }

        public override void Draw(SpriteBatch batch)
        {

            if (Value > MaxValue) Value = MaxValue;

            batch.FillRectangle(new RectangleF(X, Y, Width, Height), BackgroundColor);
            batch.FillRectangle(new RectangleF(X, Y, (float)(Value / MaxValue * Width), Height), FillColor);
            batch.DrawRectangle(new RectangleF(X, Y, Width, Height), Color.Black, 2);
        }


    }
}

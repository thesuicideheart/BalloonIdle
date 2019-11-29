using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.UI
{
    public class Label : UIObject
    {
        public string Text { get; set; }
        public SpriteFont Font { get; set; }
        public Color Color { get; set; }

        public Vector2 CenterOrigin;

        public Label(int x, int y, string text, SpriteFont font, Color color, bool centered) : base(x, y)
        {
            Text = text;
            Font = font;
            Color = color;
            if (centered)
                CenterOrigin = font.MeasureString(Text) / 2;
            
        }

        public override void Draw(SpriteBatch batch)
        {
            batch.DrawString(Font, Text, new Vector2(X, Y), Color, 0, CenterOrigin, 1.0f, SpriteEffects.None, 0.5f);
        }

    }
}

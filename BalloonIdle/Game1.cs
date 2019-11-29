using BalloonIdle.Core;
using Engine;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using SpriteFontPlus;
using System.IO;

namespace BalloonIdle
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : CustomGame
    {

        public GameLayer gameLayer;
        public static SpriteFont font;

        public static void DrawString(string text, int x, int y, Color color)
        {
            Instance.batch.DrawString(font, text, new Vector2(x, y), color);
        }

        public Game1()
        {

        }

        protected override void Initialize()
        {
            Width = 800;
            Height = 600;
            SetSize();
            this.IsMouseVisible = true;
            AddLayer(gameLayer = new GameLayer());

            base.Init();
        }

        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            base.LoadContent();

            var bigFontBake = TtfFontBaker.Bake(
                File.ReadAllBytes("./Content/Font/pixelated.ttf"),
                32,
                512,
                512,
                new[]
                {
                                CharacterRange.BasicLatin,
                                CharacterRange.Latin1Supplement,
                                CharacterRange.LatinExtendedA,
                                CharacterRange.Cyrillic
                });

            font = bigFontBake.CreateSpriteFont(GraphicsDevice);
            // TODO: use this.Content to load your game content here
        }

        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}

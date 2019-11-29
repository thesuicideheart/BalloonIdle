using Engine.Input;
using Engine.UI;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class CustomGame : Game
    {
        public GraphicsDeviceManager graphics;
        public SpriteBatch batch;

        public int Width;
        public int Height;

        private ResourceManager resourceManager;

        public static CustomGame Instance;

        public Handler Handler { get; set; }

        public InputManager InputManager;

        private List<UI.Layer> Layers;

        public static Handler GetHandler()
        {
            return Instance.Handler;
        }

        public CustomGame()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            Instance = this;
            Handler = new Handler(this);
            Layers = new List<UI.Layer>();
            resourceManager = new ResourceManager();
        }

        protected virtual void Init()
        {
            this.IsMouseVisible = true;

            Components.Add(InputManager = new InputManager(this));
            
            base.Initialize();
        }

        public void AddTexture(Texture2D texture, string id)
        {
            resourceManager.AddResource(texture, id);
        }

        public Texture2D GetTexture(string id)
        {
            return resourceManager.GetTexture(id);
        }

        public ResourceManager GetResourceManager()
        {
            return resourceManager;
        }

        protected override void Draw(GameTime gameTime)
        {
            batch.Begin(samplerState: SamplerState.PointWrap);

            foreach(var layer in Layers)
            {
                layer.Draw(batch);
            }

            batch.End();

            base.Draw(gameTime);
        }

        protected override void Update(GameTime gameTime)
        {

            foreach(var layer in Layers)
            {
                layer.Update();
            }

            base.Update(gameTime);
        }

        protected override void LoadContent()
        {
            batch = new SpriteBatch(GraphicsDevice);
        }

        public void AddLayer(Layer layer)
        {
            Layers.Add(layer);
        }

        protected void SetSize()
        {
            graphics.PreferredBackBufferWidth = Width;
            graphics.PreferredBackBufferHeight = Height;
            graphics.ApplyChanges();
        }

    }
}

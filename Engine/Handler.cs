using Engine.Input;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Handler
    {
        public CustomGame Game;
        public Handler(CustomGame game)
        {
            this.Game = game;
        }
    
        public int GetWindowWidth()
        {
            return Game.Width;
        }

        public int GenerateRandomNumber(int min, int max)
        {
            return new Random().Next(min, max);
        }

        public InputManager GetInputManager()
        {
            return Game.InputManager;
        }

        public Texture2D GetTexture(string id)
        {
            return GetResourceManager().GetTexture(id);
        }

        public ResourceManager GetResourceManager()
        {
            return Game.GetResourceManager();
        }

    }
}

using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class ResourceManager
    {
        private Dictionary<string, Texture2D> resources;


        public ResourceManager()
        {
            resources = new Dictionary<string, Texture2D>();
        }

        public void AddResource(Texture2D texture, string id)
        {
            if (!resources.ContainsKey(id))
            {
                resources.Add(id, texture);
            }
        }

        public Texture2D GetTexture(string id)
        {
            if (resources.ContainsKey(id))
            {
                return resources[id];
            }
            return null;
        }
    }
}

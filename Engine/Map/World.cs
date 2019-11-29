using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Map
{
    public class World
    {
        public Tile[,] Tiles;
        public int Width { get; set; }
        public int Height { get; set; }

        public World(int size)
        {
            Width = size;
            Height = size;
            Tiles = new Tile[Width, Height];
        }

        public World(int w, int h)
        {
            Width = w;
            Height = h;
            Tiles = new Tile[Width, Height];
        }

        public Tile GetTile(int x, int y)
        {
            if (x < 0) x = 0;
            if (y < 0) y = 0;
            if (x > Width - 1) x = Width - 1;
            if (y > Width - 1) y = Width - 1;

            return Tiles[x, y];
        }

        public void SetTile(int x, int y, Tile tile)
        {
            if (x < 0) x = 0;
            if (y < 0) y = 0;
            if (x > Width - 1) x = Width - 1;
            if (y > Width - 1) y = Width - 1;

            Tiles[x, y] = tile;
        }

        public void DrawTiles(SpriteBatch batch)
        {
            for(var x = 0; x < Width; x++)
            {
                for(var y = 0; y < Height; y++)
                {
                    Tiles[x, y].Draw(batch);
                }
            }
        }

    }
}

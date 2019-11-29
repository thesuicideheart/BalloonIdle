using Microsoft.Xna.Framework.Graphics;
using MonoGame.Extended;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.UI
{
    public class Layer
    {
        public List<Entity> Entities;
        public List<UIObject> UIObjects;

        public Handler Handler { get; set; }

        public Layer()
        {
            Entities = new List<Entity>();
            UIObjects = new List<UIObject>();
            Handler = CustomGame.Instance.Handler;
        }

        public void AddEntity(Entity e)
        {
            Entities.Add(e);
        }

        public void AddUIObject(UIObject obj)
        {
            UIObjects.Add(obj);
        }

        public virtual void Update()
        {
            for (var i = 0; i < Entities.Count; i++)
            {
                Entity ent = Entities[i];
                ent.Update();
                if (ent.IsDead)
                {
                    Entities.RemoveAt(i);
                }
            }
        }

        public virtual void Draw(SpriteBatch batch)
        {
            foreach (var entity in Entities)
            {
                entity.Draw(batch);
            }

            foreach (var obj in UIObjects)
            {
                obj.Draw(batch);
            }

        }

    }
}

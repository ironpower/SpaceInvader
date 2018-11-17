using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonogameTemplate5
{
    class AnimetedSprite : Sprite
    {
        public AnimetedSprite(Vector2 position) : base(position)
        {
            throw new NotImplementedException();
            dictAnimation = new Dictionary<string, List<int>>();
        }
        Dictionary<string, List<int>> dictAnimation;
        bool isLooping;
        string currentAnimation;
        int currentFrame;
        float speedFramePerSecond;

        public void AddAnimation(string name, List<int> listFrame)
        {
            if (!dictAnimation.ContainsKey(name))
            {
                dictAnimation.Add(name, listFrame);
            }
            else
            {
                throw new Exception("L'animation " + name + " existe deja.");
            }
        }
        public void PlayAnimation(string name, bool isLooping, float animationSpeedFramePerSecond)
        {
            if (dictAnimation.ContainsKey(name))
            {
                this.isLooping = isLooping;
                currentAnimation = name;
                currentFrame = 0;
                speedFramePerSecond = animationSpeedFramePerSecond;

            }
            else
            {
                throw new Exception("L'animation " + name + " n'existe pas");
            }
        }
        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);

        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            base.Draw(spriteBatch);
        }
    }
}

/*
 * Created by SharpDevelop.
 * User: Antoine
 * Date: 09/11/2018
 * Time: 17:55
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MonogameTemplate5
{
    /// <summary>
    /// Description of Sprite.
    /// </summary>
    public class Sprite
    {
        public Sprite(Vector2 position)
        {
            this.position = position;
            color = Color.White;
            scale = Vector2.One;
            spriteEffect = SpriteEffects.None;
            rotation = 0;
            origin = Vector2.Zero;
            opacity = 1;
        }
        protected Texture2D texture;
        public Texture2D Texture
        {
            get
            {
                return texture;
            }
            set
            {
                texture = value;
            }
        }

        protected Color color;
        public Color Color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
            }
        }

        protected float rotation;
        public float Rotation
        {
            get
            {
                return rotation;
            }
            set
            {
                rotation = value;
            }
        }

        protected Rectangle hitbox;
        public Rectangle Hitbox
        {
            get
            {
                return hitbox;
            }
            set
            {
                hitbox = value;
            }
        }

        protected Vector2 scale;
        public Vector2 Scale
        {
            get
            {
                return scale;
            }
            set
            {
                scale = value;
            }
        }

        protected SpriteEffects spriteEffect;
        public SpriteEffects SpriteEffect
        {
            get
            {
                return spriteEffect;
            }
            set
            {
                spriteEffect = value;
            }
        }

        protected Vector2 origin;
        public Vector2 Origin
        {
            get
            {
                return origin;
            }
            set
            {
                origin = value;
            }
        }

        protected Rectangle sourceRectangle;
        public Rectangle SourceRectangle
        {
            get
            {
                return sourceRectangle;
            }
            set
            {
                sourceRectangle = value;
            }
        }

        protected Vector2 position;
        public Vector2 Position
        {
            get
            {
                return position;
            }
            set
            {
                position.X = value.X;
                position.Y = value.Y;
            }
        }
        protected float opacity;
        public float Opacity
        {
            get
            {
                return opacity;
            }
            set
            {
                opacity = value;
            }
        }


        public virtual void Load(Texture2D texture)
        {
            this.Texture = texture;
            SourceRectangle = new Rectangle(0, 0, (int)(texture.Width * Scale.X), (int)(texture.Height * Scale.Y));
        }
        public virtual void Update(GameTime gameTime)
        {
            hitbox.X = (int)position.X;
            hitbox.Y = (int)position.Y;
        }

        public virtual void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, position, sourceRectangle, color * opacity, rotation, origin, scale, spriteEffect, 1);
        }
    }
}

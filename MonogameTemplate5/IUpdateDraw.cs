/*
 * Created by SharpDevelop.
 * User: Antoine
 * Date: 29/10/2018
 * Time: 16:52
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MonogameTemplate5
{
    /// <summary>
    /// Description of IUpdateDraw.
    /// </summary>
    public interface IUpdateDraw
    {
        void Update(GameTime gameTime);
        void Draw(SpriteBatch spriteBatch);
    }
}

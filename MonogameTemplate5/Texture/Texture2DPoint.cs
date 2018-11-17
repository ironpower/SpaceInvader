/*
 * Created by SharpDevelop.
 * User: Antoine
 * Date: 29/10/2018
 * Time: 16:17
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MonogameTemplate5
{
    /// <summary>
    /// Description of Texture2DPoint.
    /// </summary>
    public class Texture2DPoint : Texture2D
    {
        public Texture2DPoint(GraphicsDevice graphicsDevice) : base(graphicsDevice, 1, 1)
        {
            base.SetData<Color>(new Color[] { Color.White });
        }
    }
}

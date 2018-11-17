/*
 * Created by SharpDevelop.
 * User: Antoine
 * Date: 06/11/2018
 * Time: 19:38
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using Microsoft.Xna.Framework;

namespace MonogameTemplate5
{
    /// <summary>
    /// Description of Window.
    /// </summary>
    public class Window
    {
        public Window(GameWindow window, GraphicsDeviceManager graphics)
        {
            this.window = window ?? throw new ArgumentNullException();
            this.graphics = graphics?? throw new ArgumentNullException();
            this.ClearScreenColor = Color.CornflowerBlue;

        }
        readonly GraphicsDeviceManager graphics;
        readonly GameWindow window;

        public string Name
        {
            get
            {
                return window.Title;
            }
            set
            {
                window.Title = value;
            }
        }
        public void Size(uint width, uint height)
        {
            graphics.PreferredBackBufferWidth = (int)width;
            graphics.PreferredBackBufferHeight = (int)height;
            graphics.ApplyChanges();
        }
        public Point Size()
        {
            return new Point(graphics.PreferredBackBufferWidth, graphics.PreferredBackBufferHeight);
        }
        public Color ClearScreenColor
        {
            get; set;
        }
        public GraphicsDeviceManager graphicsDevice
        {
            get
            {
                return graphics;
            }
        }
    }
}

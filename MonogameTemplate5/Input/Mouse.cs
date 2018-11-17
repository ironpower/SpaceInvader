/*
 * Created by SharpDevelop.
 * User: Antoine
 * Date: 06/11/2018
 * Time: 20:39
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using Microsoft.Xna.Framework;

namespace MonogameTemplate5
{
    /// <summary>
    /// Description of Mouse.
    /// </summary>
    public static class Mouse
    {
        public static void Initialize(Game1 game1)
        {
            game = game1;
            currentMouseState = Microsoft.Xna.Framework.Input.Mouse.GetState();
            oldMouseState = Microsoft.Xna.Framework.Input.Mouse.GetState();
        }

        static Game1 game;
        static Microsoft.Xna.Framework.Input.MouseState currentMouseState;
        static Microsoft.Xna.Framework.Input.MouseState oldMouseState;
        public static bool isVisible
        {
            get
            {
                return game.IsMouseVisible;
            }
            set
            {
                game.IsMouseVisible = value;
            }
        }
        public static bool RightButtonDown()
        {
            return (currentMouseState.RightButton == Microsoft.Xna.Framework.Input.ButtonState.Pressed);
        }
        public static bool RightButtonUp()
        {
            return (currentMouseState.RightButton == Microsoft.Xna.Framework.Input.ButtonState.Released);
        }
        public static bool RightButtonReleased()
        {
            return (currentMouseState.RightButton == Microsoft.Xna.Framework.Input.ButtonState.Released
                && oldMouseState.RightButton == Microsoft.Xna.Framework.Input.ButtonState.Pressed);
        }
        public static bool RightButtonPressed()
        {
            return (oldMouseState.RightButton == Microsoft.Xna.Framework.Input.ButtonState.Released
                && currentMouseState.RightButton == Microsoft.Xna.Framework.Input.ButtonState.Pressed);
        }
        public static bool LeftButtonDown()
        {
            return (currentMouseState.LeftButton == Microsoft.Xna.Framework.Input.ButtonState.Pressed);
        }
        public static bool LeftButttonUp()
        {
            return (currentMouseState.LeftButton == Microsoft.Xna.Framework.Input.ButtonState.Released);
        }
        public static bool LeftButtonReleased()
        {
            return (currentMouseState.LeftButton == Microsoft.Xna.Framework.Input.ButtonState.Released
                && oldMouseState.LeftButton == Microsoft.Xna.Framework.Input.ButtonState.Pressed);
        }
        public static bool LeftButtonPressed()
        {
            return (oldMouseState.LeftButton == Microsoft.Xna.Framework.Input.ButtonState.Released
                && currentMouseState.LeftButton == Microsoft.Xna.Framework.Input.ButtonState.Pressed);
        }
        public static Point Position()
        {
            return Microsoft.Xna.Framework.Input.Mouse.GetState().Position;
        }
        public static void Position(int x, int y)
        {
            Microsoft.Xna.Framework.Input.Mouse.SetPosition(x, y);
        }
        public static void Update()
        {
            oldMouseState = currentMouseState;
            currentMouseState = Microsoft.Xna.Framework.Input.Mouse.GetState();
        }
    }
}

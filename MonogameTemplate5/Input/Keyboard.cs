/*
 * Created by SharpDevelop.
 * User: Antoine
 * Date: 09/11/2018
 * Time: 01:40
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using input = Microsoft.Xna.Framework.Input;
namespace MonogameTemplate5
{
    /// <summary>
    /// Description of Keyboard.
    /// </summary>
    public static class Keyboard
    {
        static Keyboard()
        {
            oldKeyboard = input.Keyboard.GetState();
            currentKeyboard = input.Keyboard.GetState();
        }
        static input.KeyboardState oldKeyboard;
        static input.KeyboardState currentKeyboard;

        public static void Update()
        {
            oldKeyboard = currentKeyboard;
            currentKeyboard = input.Keyboard.GetState();
        }

        public static bool IsKeyDown(input.Keys key)
        {
            return currentKeyboard.IsKeyDown(key);
        }
        public static bool IsKeyUp(input.Keys key)
        {
            return currentKeyboard.IsKeyUp(key);
        }
        public static bool IsKeyReleased(input.Keys key)
        {
            return (currentKeyboard.IsKeyDown(key) && oldKeyboard.IsKeyUp(key));
        }
        public static bool IsKeyPressed(input.Keys key)
        {
            return (currentKeyboard.IsKeyDown(key) && oldKeyboard.IsKeyUp(key));
        }
        public static input.Keys[] GetPressedKeys()
        {
            return currentKeyboard.GetPressedKeys();
        }
    }
}

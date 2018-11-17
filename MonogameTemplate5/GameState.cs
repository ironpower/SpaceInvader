/*
 * Created by SharpDevelop.
 * User: Antoine
 * Date: 08/11/2018
 * Time: 21:52
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MonogameTemplate5
{
    /// <summary>
    /// Description of GameState.
    /// </summary>
    public sealed class GameState
    {
        public GameState()
        {

        }
        private Scene currentScene;

        public void ChangeScene(Scene scene)
        {
            if (currentScene != null)
            {
                currentScene.Unload();
            }
            currentScene = scene ?? throw new ArgumentNullException();
            currentScene.Initialize();
            currentScene.Load();
        }

        public void Update(GameTime gameTime)
        {
            currentScene.Update(gameTime);
        }
        public void Draw()
        {
            currentScene.Draw();
        }
    }
}

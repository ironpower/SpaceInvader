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
    /// Description of Scene.
    /// </summary>
    public abstract class Scene
    {
        protected Scene(Window window, SpriteBatch spriteBatch, GameState gameState, GameData gameData,
                        RessourceManager ressourceManager, SoundManager soundManager)
        {
            this.window = window ?? throw new ArgumentNullException();
            this.spriteBatch = spriteBatch ?? throw new ArgumentNullException();
            this.gameState = gameState ?? throw new ArgumentNullException();
            this.gameData = gameData ?? throw new ArgumentNullException();
            this.ressourceManager = ressourceManager ?? throw new ArgumentNullException();
            this.soundManager = soundManager ?? throw new ArgumentNullException();
        }
        protected Window window;
        protected SpriteBatch spriteBatch;
        protected GameState gameState;
        protected GameData gameData;
        protected RessourceManager ressourceManager;
        protected SoundManager soundManager;
        public abstract void Initialize();
        public abstract void Load();
        public abstract void Unload();
        public abstract void Update(GameTime gameTime);
        public abstract void Draw();
    }
}

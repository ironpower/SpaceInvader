/*
 * Created by SharpDevelop.
 * User: Antoine
 * Date: 29/10/2018
 * Time: 15:16
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;


namespace MonogameTemplate5
{
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        RessourceManager ressourceManager;
        Window win;
        GameState gameState;
        GameData gameData;
        SoundManager soundManager;
        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        protected override void Initialize()
        {
            win = new Window(Window, graphics);
            gameState = new GameState();
            gameData = new GameData();

            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            ressourceManager = new RessourceManager(Content);
            soundManager = new SoundManager(Content);
            gameState.ChangeScene(new SceneGame(win, spriteBatch, gameState, gameData, ressourceManager, soundManager));
        }

        protected override void UnloadContent()
        {

        }

        protected override void Update(GameTime gameTime)
        {
            Keyboard.Update();
            Mouse.Update();
            gameState.Update(gameTime);

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(win.ClearScreenColor);

            gameState.Draw();

            base.Draw(gameTime);
        }
    }
}
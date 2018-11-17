/*
 * Created by SharpDevelop.
 * User: Antoine
 * Date: 29/10/2018
 * Time: 15:30
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System.Diagnostics;

namespace MonogameTemplate5
{
    public sealed class RessourceManager
    {
        public RessourceManager(ContentManager content)
        {
            this.content = content ?? throw new ArgumentNullException();
            dictTexture = new Dictionary<string, Texture2D>();
        }
        private readonly ContentManager content;
        private readonly Dictionary<string, Texture2D> dictTexture;

        public void LoadTexture2D(string name, string path = "")
        {
            if (!dictTexture.ContainsKey(name))
            {
                dictTexture.Add(name, content.Load<Texture2D>(path + name));
            }
        }
        public void UnloadTexture2D(string name)
        {
            if (dictTexture.ContainsKey(name))
            {
                dictTexture.Remove(name);
            }
            else
            {
                throw new Exception("Cette image " + name + " n'existe pas.");
            }
        }
        public void UnloadAllTexture2D()
        {
            dictTexture.Clear();
        }
        public Texture2D GetTexture2D(string name, string path = "")
        {
            Texture2D texture = null;
            if (!dictTexture.ContainsKey(name))
            {
                texture = content.Load<Texture2D>(path+name);
                dictTexture.Add(name, texture);
            }
            else
            {
                return dictTexture[name];
            }
            return texture;
        }
        public void AddTexture2D(string name, Texture2D texture)
        {
            if (!dictTexture.ContainsKey(name) && texture != null)
            {
                dictTexture.Add(name, texture);
            }
            else
            {
                if(texture == null)
                {
                    throw new ArgumentNullException("La texture " + name + " est null.");
                }
                else
                {
                    throw new Exception("Le nom " + name + " existe deja");
                }
            }
        }
    }
}

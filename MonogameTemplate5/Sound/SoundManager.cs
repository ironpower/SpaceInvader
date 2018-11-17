using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Media;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonogameTemplate5
{
    public class SoundManager
    {
        public SoundManager(ContentManager content)
        {
            this.content = content ?? throw new ArgumentNullException("Le ContentManager ne peut pas etre null.");
            dictSoundEffect = new Dictionary<string, SoundEffect>();
        }
        ContentManager content;
        Dictionary<string, SoundEffect> dictSoundEffect;
        public void PlaySong(string name, string path = "")
        {
            MediaPlayer.Play(content.Load<Song>(path + name));
        }
        public void LoadSoundEffect(string name, string path = "")
        {
            if (!dictSoundEffect.ContainsKey(name))
            {
                dictSoundEffect.Add(name, content.Load<SoundEffect>(path + name));
            }
            else
            {
                throw new Exception("Le nom " + name + " du SoundEffect existe deja.");
            }
        }
        public void AddSoundEffect(string name, SoundEffect soundEffect)
        {
            if (!dictSoundEffect.ContainsKey(name) && soundEffect != null)
            {
                dictSoundEffect.Add(name, soundEffect);
            }
            else
            {
                if(soundEffect == null)
                {
                    throw new ArgumentNullException("Le SoundEffect " + name + " est null.");
                }
                else
                {
                    throw new Exception("Le nom " + name + " du SoundEffect existe deja.");
                }
            }
        }
        public void UnloadSoundEffect(string name)
        {
            if (dictSoundEffect.ContainsKey(name))
            {
                dictSoundEffect.Remove(name);
            }
            else
            {
                throw new Exception("Le nom " + name + " du SoundEffect n'existe pas");
            }
        }
    }
}

using System;
using System.IO;
using System.Media;
using System.Windows.Media;
using System.Collections.Generic;
using Microsoft.DirectX.DirectSound;
using DS = Microsoft.DirectX.DirectSound;
using System.Windows.Forms;

namespace KeyboardClick
{
    class SoundController
    {
        private MediaPlayer[] soundPlayers;
        private int current_index = 0;

        public SoundController(Control owner, string path, int count=1)
        {
            SetFile(path, count);
        }

        public void Play()
        {
            try
            {
                soundPlayers[current_index].Position = TimeSpan.Zero;
                soundPlayers[current_index].Play();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            current_index = (current_index + 1) % soundPlayers.Length;
        }

        public void SetFile(string path, int count=-1)
        {
            if(count != -1)
            {
                soundPlayers = new MediaPlayer[count];

                for(int i = 0; i < soundPlayers.Length; i++)
                {
                    soundPlayers[i] = new MediaPlayer();
                }
            }

            for(int i = 0; i < soundPlayers.Length; i++)
            {
                try
                {
                    soundPlayers[i].Open(new Uri(path));
                }
                catch(Exception)
                {

                }
            }
        }
    }
}

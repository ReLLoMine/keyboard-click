using System;
using System.Windows.Forms;

namespace KeyboardClick
{
    static class OptionsController
    {
        static public string DownSoundFilePath { get; set; }
        static public string ReleaseSoundFilePath { get; set; }
        static public bool SingleMode { get; set; }
        static public bool IsMuted { get; set; }

        static public Form optionsForm;
        static public event EventHandler OptionsSaved;

        static public void LoadOptions()
        {
            DownSoundFilePath = Properties.Settings.Default.down_sound_file_path;
            ReleaseSoundFilePath = Properties.Settings.Default.release_sound_file_path;
            SingleMode = Properties.Settings.Default.single_mode;
            IsMuted = Properties.Settings.Default.is_muted;
        }

        static public void SaveOptions()
        {
            Properties.Settings.Default.down_sound_file_path = DownSoundFilePath;
            Properties.Settings.Default.release_sound_file_path = ReleaseSoundFilePath;
            Properties.Settings.Default.single_mode = SingleMode;
            Properties.Settings.Default.is_muted = IsMuted;

            Properties.Settings.Default.Save();
            OptionsSaved?.Invoke(new object(), new EventArgs());
        }

        static public void ShowForm()
        {
            optionsForm = new Options();
            optionsForm.Show();
        }
    }
}

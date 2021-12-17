using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace KeyboardClick
{
    public partial class Options : Form
    {
        public Options()
        {
            InitializeComponent();
        }

        private void Options_Load(object sender, EventArgs e)
        {
            downFilePath.Text = OptionsController.DownSoundFilePath;
            releaseFilePath.Text = OptionsController.ReleaseSoundFilePath;
            single_mode.Checked = OptionsController.SingleMode;

            Set_Mode(!OptionsController.SingleMode);

            apply_settings.Enabled = false;
        }

        private void Set_Mode(bool state=true)
        {
            releaseFilePath.Enabled = state;
            test_r_sound_file.Enabled = state;
            choose_r_file_sound.Enabled = state;
        }

        private void choose_file_sound_Click(object sender, EventArgs e)
        {
            // Show the dialog and get result.
            DialogResult result = OpenDownSoundFile.ShowDialog();

            if (result == DialogResult.OK) // Test result.
            {
                OptionsController.DownSoundFilePath = OpenDownSoundFile.InitialDirectory + OpenDownSoundFile.FileName;
                downFilePath.Text = OptionsController.DownSoundFilePath;

                apply_settings.Enabled = true;

                Console.WriteLine(OptionsController.DownSoundFilePath);
            }
            Console.WriteLine(result); // <-- For debugging use
        }
        private void choose_r_file_sound_Click(object sender, EventArgs e)
        {
            // Show the dialog and get result.
            DialogResult result = OpenReleaseSoundFile.ShowDialog();

            if (result == DialogResult.OK) // Test result.
            {
                OptionsController.ReleaseSoundFilePath = OpenReleaseSoundFile.InitialDirectory + OpenReleaseSoundFile.FileName;
                releaseFilePath.Text = OptionsController.ReleaseSoundFilePath;

                apply_settings.Enabled = true;

                Console.WriteLine(OptionsController.ReleaseSoundFilePath);
            }
            Console.WriteLine(result); // <-- For debugging use
        }

        private void test_d_sound_file_Click(object sender, EventArgs e)
        {
            try
            {
                SoundPlayer soundPlayer = new SoundPlayer(OptionsController.DownSoundFilePath);
                soundPlayer.Play();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void test_r_sound_file_Click(object sender, EventArgs e)
        {
            try
            {
                SoundPlayer soundPlayer = new SoundPlayer(OptionsController.ReleaseSoundFilePath);
                soundPlayer.Play();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void apply_settings_Click(object sender, EventArgs e)
        {
            OptionsController.SaveOptions();
            apply_settings.Enabled = false;
        }

        private void cancel_settings_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ok_settings_Click(object sender, EventArgs e)
        {
            if(apply_settings.Enabled)
            {
                OptionsController.SaveOptions();
            }
            Close();
        }

        private void single_mode_CheckedChanged(object sender, EventArgs e)
        {
            Set_Mode(!single_mode.Checked);
            OptionsController.SingleMode = single_mode.Checked;
            apply_settings.Enabled = true;
        }

        private void OpenSoundFile_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void OpenReleaseSoundFile_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}

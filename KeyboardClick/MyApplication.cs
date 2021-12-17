using System;
using System.Windows.Forms;

namespace KeyboardClick
{

    class MyApplication : ApplicationContext
    {
        private Notifier notifier;
        private KeyHandler keyHandler;
        private Control control = new Control();
        public SoundController downSoundController;
        public SoundController releaseSoundController;

        public MyApplication()
        {
            OptionsController.LoadOptions();
            OptionsController.OptionsSaved += UpdateOptions;

            downSoundController = new SoundController(control, OptionsController.DownSoundFilePath, 3);
            releaseSoundController = new SoundController(control, OptionsController.ReleaseSoundFilePath, 3);

            notifier = new Notifier();
            notifier.Options += OpenOptions;

            keyHandler = new KeyHandler();
            keyHandler.DownClick += DownPlaySound;
            keyHandler.ReleaseClick += ReleasePlaySound;
        }

        void DownPlaySound(object sender, EventArgs e)
        {
            if(!OptionsController.IsMuted)
            {
                try
                {
                    downSoundController.Play();
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        void ReleasePlaySound(object sender, EventArgs e)
        {
            if (!OptionsController.IsMuted && !OptionsController.SingleMode)
            {
                try
                {
                    releaseSoundController.Play();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        void OpenOptions(object sender, EventArgs e)
        {
            OptionsController.ShowForm();
        }

        void UpdateOptions(object sender, EventArgs e)
        {
            downSoundController.SetFile(OptionsController.DownSoundFilePath);
            releaseSoundController.SetFile(OptionsController.ReleaseSoundFilePath);
        }
    }
}

using System;
using System.Windows.Forms;
using System.Drawing;
using System.Reflection;

namespace CLICK_SOUND
{
    public class Notifier
    {
        private NotifyIcon icon;
        private ContextMenu contextMenu;
        private MenuItem muteItem, unmuteItem;
        public event EventHandler Options;

        public Notifier()
        {
            muteItem = new MenuItem("Mute", Mute);
            unmuteItem = new MenuItem("Unmute", UnMute);

            contextMenu = new ContextMenu(new MenuItem[] {
                    OptionsController.IsMuted ? unmuteItem : muteItem,
                    new MenuItem("Options", OptionsHandler),
                    new MenuItem("Exit", Exit)
                });
            
            icon = new NotifyIcon()
            {
                Icon = Icon.ExtractAssociatedIcon(Assembly.GetExecutingAssembly().Location), ///Resources.AppIcon,
                ContextMenu = contextMenu,
                Visible = true
            };
        }

        public void Mute(object sender, EventArgs e)
        {
            contextMenu = new ContextMenu(new MenuItem[] {
                    unmuteItem,
                    new MenuItem("Options", OptionsHandler),
                    new MenuItem("Exit", Exit)
                });

            icon.ContextMenu = contextMenu;

            OptionsController.IsMuted = true;
            OptionsController.SaveOptions();
        }
        public void UnMute(object sender, EventArgs e)
        {
            contextMenu = new ContextMenu(new MenuItem[] {
                    muteItem,
                    new MenuItem("Options", OptionsHandler),
                    new MenuItem("Exit", Exit)
                });

            icon.ContextMenu = contextMenu;

            OptionsController.IsMuted = false;
            OptionsController.SaveOptions();
        }

        void Exit(object sender, EventArgs e)
        {
            // Hide tray icon, otherwise it will remain shown until user mouses over it
            icon.Visible = false;

            Application.Exit();
        }

        void OptionsHandler(object sender, EventArgs e)
        {
            Options?.Invoke(this, new EventArgs());
        }
    }
}

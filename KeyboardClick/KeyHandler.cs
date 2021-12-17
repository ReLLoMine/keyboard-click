using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Linq;

namespace KeyboardClick
{
    public class KeyHandler
    {
        [DllImport("User32.dll")]
        private static extern short GetAsyncKeyState(int vKey);
        private Timer timer = new Timer();
        private bool[] keys_state = new bool[256];
        private short[] ignored_keys = { (int)Keys.LButton, (int)Keys.RButton, (int)Keys.MButton, (int)Keys.XButton1, (int)Keys.XButton2, (int)Keys.ShiftKey, (int)Keys.ControlKey, (int)Keys.Menu };
        public event EventHandler AnyClick;
        public event EventHandler DownClick;
        public event EventHandler ReleaseClick;
        private bool DownClickIsActivated = false;
        private bool ReleaseClickIsActivated = false;

        public KeyHandler()
        {
            for (int i = 0; i < keys_state.Length; ++i)
            {
                keys_state[i] = false;
            }

            timer.Interval = 35;
            timer.Enabled = true;
            timer.Tick += timer_Tick;
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            bool is_pressed = false;
            ResetInvokers();

            for (short i = 0; i < 255; i++)
            {
                if (ignored_keys.Contains(i))
                {
                    continue;
                }

                short keyState = GetAsyncKeyState(i);

                is_pressed = ((keyState >> 15) & 0x0001) == 0x0001;

                if (!keys_state[i] && is_pressed)
                {
                    keys_state[i] = is_pressed; // down
                    DownClickInvoker();
                }
                else if (keys_state[i] && !is_pressed)
                {
                    keys_state[i] = is_pressed; // release
                    ReleaseClickInvoker();
                }
            }
        }

        private void DownClickInvoker()
        {
            if(!DownClickIsActivated)
            {
                DownClickIsActivated = true;
                AnyClick?.Invoke(this, new EventArgs());
                DownClick?.Invoke(this, new EventArgs());
            }
        }

        private void ReleaseClickInvoker()
        {
            if(!ReleaseClickIsActivated)
            {
                ReleaseClickIsActivated = true;
                AnyClick?.Invoke(this, new EventArgs());
                ReleaseClick?.Invoke(this, new EventArgs());
            }
        }

        private void ResetInvokers()
        {
            DownClickIsActivated = false;
            ReleaseClickIsActivated = false;
        }
    }
}

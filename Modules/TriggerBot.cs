
using System.Threading;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Client.Modules
{
    public class TriggerBot
    {
        public static string Name = "TriggerBot";
        public static Keys key = Keys.V;
        public static bool toggeld;

        public static bool isPressed;

        private const int LEFTUP = 0x0004;
        private const int LEFTDOWN = 0x0002;
        public const int interval = 20;

        public static void Toggle()
        {
            toggeld = !toggeld;

            if (toggeld)
            {
                onEnable();
            }
            else
            {
                onDisable();
            }
        }

        public static void onEnable()
        {

        }
        public static void onDisable()
        {

        }
        public static void onTick()
        {
            if(SDK.Level.MultiPlayer.lookingActor != 0)
            {
                Thread.Sleep(interval);
                SDK.Imports.mouse_event(dwFlags: LEFTUP, dx: 0, dy: 0, cButtons: 0, dwExtraInfo: 0);
                Thread.Sleep(25);
                SDK.Imports.mouse_event(dwFlags: LEFTDOWN, dx: 0, dy: 0, cButtons: 0, dwExtraInfo: 0);
            }
        }
    }
}

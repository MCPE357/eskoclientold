using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Modules
{
    public class AirJump
    {
        public static string Name = "AirJump";
        public static int key;
        public static bool toggeld;

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
            SDK.Entity.LocalPlayer.onGround = true;
        }
    }
}

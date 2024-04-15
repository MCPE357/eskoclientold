
using Memory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    
    public partial class Form1 : Form
    {
        public static Mem m = new Mem();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            m.OpenProcess("Minecraft.Windows.exe");
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Modules.AirWalk.toggeld)
            {
                Modules.AirWalk.onTick();
            }
            if (Modules.AirJump.toggeld)
            {
                Modules.AirJump.onTick();
            }
            if (Modules.Step.toggeld)
            {
                Modules.Step.onTick();
            }
            if (Modules.TriggerBot.toggeld)
            {
                Modules.TriggerBot.onTick();
            }

            onLoop();
        }
        private void AirWalk_Click(object sender, EventArgs e)
        {
            Modules.AirWalk.Toggle();
            AirWalkLabel.Visible = !AirWalkLabel.Visible;
        }
        private void AirJump_Click(object sender, EventArgs e)
        {
            Modules.AirJump.Toggle();
            AirJumpLabel.Visible = !AirJumpLabel.Visible;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void onLoop()
        {
            //Close();
            
        }

        private void Step_Click(object sender, EventArgs e)
        {
            Modules.Step.Toggle();
            StepLabel.Visible = !StepLabel.Visible;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void TriggerBot_Click(object sender, EventArgs e)
        {
            Modules.TriggerBot.Toggle();
            TriggerBotLabel.Visible = !TriggerBotLabel.Visible;
        }
    }
}

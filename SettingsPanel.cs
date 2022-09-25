using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using EclipseWare;
using WeAreDevs_API;
using Newtonsoft.Json;

namespace EclipseWare
{
    public partial class SettingsPanel : Form
    {
        ExploitAPI api = new ExploitAPI();
        public SettingsPanel()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            Hide();
        }

        private void bunifuImageButton7_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void bunifuImageButton8_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // topmost
            EclipseWare eclipse = new EclipseWare();
            if (checkBox1.Checked)
            {
                eclipse.TopMost = true;
            }
            else
            {
                eclipse.TopMost = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            // fps unlocker
            if (checkBox3.Checked == true)
            {

                Process.Start(@".\settings\rbxfpsunlocker.exe");
            }
            else if (checkBox3.Checked == false)
            {
                foreach (Process proc in Process.GetProcessesByName("rbxfpsunlocker"))
                {
                    proc.Kill();
                }
            }
        }
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            // kill roblox
            Functions2.Show("Killing Roblox Process...", "EclipseWare Exploit", 2000);

            foreach (Process proc in Process.GetProcessesByName("RobloxPlayerBeta"))
            {
                proc.Kill();
            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            // speed set
            string speed = "loadstring(game:HttpGet('https://raw.githubusercontent.com/localext/speedgui/main/walkspeed%20gui.lua'))()";
            api.SendLuaScript(speed);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            // multi roblox
            string message = "Multi Roblox Under Development!";
            string title = "EclipseWare Exploit";
            MessageBox.Show(message, title);
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            // jump set
            string jump = "loadstring(game:HttpGet('https://pastebin.com/raw/FrTgibVH'))()";
            api.SendLuaScript(jump);
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            //GameHub
            GameHub gameHub = new GameHub();

            gameHub.Show();
        }
    }
}

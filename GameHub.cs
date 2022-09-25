using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeAreDevs_API;
using Bunifu.Framework.UI;
using Newtonsoft.Json;

namespace EclipseWare
{
    public partial class GameHub : Form
    {
        ExploitAPI api = new ExploitAPI();
        public GameHub()
        {
            InitializeComponent();
        }

        private void GameHub_Load(object sender, EventArgs e)
        {
            Hide();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            //darkhub
            string darkhub = "loadstring(game:HttpGet('https://raw.githubusercontent.com/RandomAdamYT/DarkHub/master/Init', true))()";

            api.SendLuaScript(darkhub);
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            //owlhub
            string owlhub = "loadstring(game:HttpGet('https://raw.githubusercontent.com/CriShoux/OwlHub/master/OwlHub.txt'))()";

            api.SendLuaScript(owlhub);
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

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            //eclipsehub
            EclipseHub eclipseHub = new EclipseHub();

            eclipseHub.Show();
        }
    }
}

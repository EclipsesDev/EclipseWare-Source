using EclipseWare.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeAreDevs_API;
using Bunifu.Framework.UI;
using System.Net;
using EclipseWare;
using System.Diagnostics;
using FastColoredTextBoxNS;
using System.Threading;
using System.Timers;
using Newtonsoft.Json;

// EclipseWare Exploit Lua 8
// Roblox Exploit Made By Eclipse!#6582
// Version 1.4

namespace EclipseWare
{
    public partial class EclipseWare : Form
    {
        ExploitAPI api = new ExploitAPI();
        public static bool isTopMost = false;


        public EclipseWare()
        {
            InitializeComponent();
            Functions2.Show("EXPLOIT LOADED", "EclipseWare Exploit", 2000);
            listBox1.Items.Clear();//Clear Items in the LuaScriptList
            Functions.PopulateListBox(listBox1, @".\Settings\Scripts", "*.txt");
            Functions.PopulateListBox(listBox1, @".\Settings\Scripts", "*.lua");
        }
        Point lastPoint;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (api.isAPIAttached() == true)
            {
                label3.Text = "Attached!";
                label3.ForeColor = Color.FromArgb(34, 139, 34);
                label3.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            }
            else
            {
                label3.Text = "Not Attached";
                label3.ForeColor = Color.FromArgb(238, 75, 43);
                label3.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            api.LaunchExploit();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (Stream s = File.Open(saveFileDialog1.FileName, FileMode.CreateNew))
                using (StreamWriter sw = new StreamWriter(s))
                {
                    sw.Write(fastColoredTextBox1.Text);
                }
            }
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                openFileDialog1.Title = "Eclipseware | Open a File";
                fastColoredTextBox1.Text = File.ReadAllText(openFileDialog1.FileName);
            }
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Clear();
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            api.SendLuaScript(fastColoredTextBox1.Text);
        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            SettingsPanel settings = new SettingsPanel();
            
            settings.Show();
        }

        private void bunifuImageButton7_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void bunifuImageButton8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuImageButton9_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.me/eclipseware");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            fastColoredTextBox1.Text = File.ReadAllText($"./Settings/Scripts/{listBox1.SelectedItem}");
        }

        private void bunifuImageButton10_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();//Clear Items in the LuaScriptList
            Functions.PopulateListBox(listBox1, @".\Settings\Scripts", "*.txt");
            Functions.PopulateListBox(listBox1, @".\Settings\Scripts", "*.lua");
        }
    }
}
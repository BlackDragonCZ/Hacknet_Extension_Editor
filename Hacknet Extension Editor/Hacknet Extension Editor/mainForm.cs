using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.VisualBasic;

namespace Hacknet_Extension_Editor
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void ButtonNew_Click(object sender, EventArgs e)
        {

        }

        private void ButtonOpen_Click(object sender, EventArgs e)
        {

        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {

        }

        private void ButtonActions_Click(object sender, EventArgs e)
        {
            string actions_name = Interaction.InputBox("Name", "Actions");
            if (actions_name != "")
            {
                ListViewItem actions = new ListViewItem();
                actions.Text = actions_name;
                actions.ImageIndex = 0;
                actions.Group = viewProyect.Groups[0];

                viewProyect.Items.Add(actions);
            }
        }

        private void ButtonFactions_Click(object sender, EventArgs e)
        {
            string factions_name = Interaction.InputBox("Name", "Factions");
            if (factions_name != "")
            {
                ListViewItem factions = new ListViewItem();
                factions.Text = factions_name;
                factions.ImageIndex = 1;
                factions.Group = viewProyect.Groups[1];

                viewProyect.Items.Add(factions);
            }
        }

        private void ButtonImages_Click(object sender, EventArgs e)
        {
            string images_name = Interaction.InputBox("Name", "Images");
            if (images_name != "")
            {
                ListViewItem images = new ListViewItem();
                images.Text = images_name;
                images.ImageIndex = 2;
                images.Group = viewProyect.Groups[2];

                viewProyect.Items.Add(images);
            }
        }

        private void ButtonMissions_Click(object sender, EventArgs e)
        {
            string missions_name = Interaction.InputBox("Name", "Missions");
            if (missions_name != "")
            {
                ListViewItem missions = new ListViewItem();
                missions.Text = missions_name;
                missions.ImageIndex = 3;
                missions.Group = viewProyect.Groups[3];

                viewProyect.Items.Add(missions);
            }
        }

        private void ButtonMusic_Click(object sender, EventArgs e)
        {
            string music_name = Interaction.InputBox("Name", "Music");
            if (music_name != "")
            {
                ListViewItem music = new ListViewItem();
                music.Text = music_name;
                music.ImageIndex = 4;
                music.Group = viewProyect.Groups[4];

                viewProyect.Items.Add(music);
            }
        }

        private void ButtonNodes_Click(object sender, EventArgs e)
        {
            string nodes_name = Interaction.InputBox("Name", "Nodes");
            if (nodes_name != "")
            {
                ListViewItem node = new ListViewItem();
                node.Text = nodes_name;
                node.ImageIndex = 5;
                node.Group = viewProyect.Groups[5];

                viewProyect.Items.Add(node);
            }
        }

        private void ButtonPeoples_Click(object sender, EventArgs e)
        {
            string peoples_name = Interaction.InputBox("Name", "Peoples");
            if (peoples_name != "")
            {
                ListViewItem peoples = new ListViewItem();
                peoples.Text = peoples_name;
                peoples.ImageIndex = 6;
                peoples.Group = viewProyect.Groups[6];

                viewProyect.Items.Add(peoples);
            }
        }

        private void ButtonScripts_Click(object sender, EventArgs e)
        {
            string scripts_name = Interaction.InputBox("Name", "Scripts");
            if (scripts_name != "")
            {
                ListViewItem scripts = new ListViewItem();
                scripts.Text = scripts_name;
                scripts.ImageIndex = 7;
                scripts.Group = viewProyect.Groups[7];

                viewProyect.Items.Add(scripts);
            }
        }

        private void ButtonThemes_Click(object sender, EventArgs e)
        {
            string themes_name = Interaction.InputBox("Name", "Themes");
            if (themes_name != "")
            {
                ListViewItem themes = new ListViewItem();
                themes.Text = themes_name;
                themes.ImageIndex = 8;
                themes.Group = viewProyect.Groups[8];

                viewProyect.Items.Add(themes);
            }
        }

        private void ButtonWeb_Click(object sender, EventArgs e)
        {
            string web_names = Interaction.InputBox("Name", "Web");
            if (web_names != "")
            {
                ListViewItem web = new ListViewItem();
                web.Text = web_names;
                web.ImageIndex = 9;
                web.Group = viewProyect.Groups[9];

                viewProyect.Items.Add(web);
            }
        }
    }
}

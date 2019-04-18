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

using Microsoft.VisualBasic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using hec;

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
            if (dialogSaveProyect.ShowDialog() == DialogResult.OK)
            {
                if (dialogFolderProyect.ShowDialog() == DialogResult.OK)
                {
                    string proyect_name = Path.GetFileName(dialogSaveProyect.FileName).Replace(Path.GetExtension(dialogSaveProyect.FileName), "");
                    string compile_folder = dialogFolderProyect.SelectedPath;

                    dynamic json_settings = new JObject();
                    dynamic json_info = new JObject();

                    json_info.Language = "language";
                    json_info.Name = "name";
                    json_info.AllowSaves = "allowsaves";
                    json_info.StartingVisibleNodes = "StartingVisibleNodes";
                    json_info.StartingMission = "StartingMission";
                    json_info.Description = "Description";
                    json_info.StartsWithTutorial = "StartsWithTutorial";
                    json_info.HasIntroStartup = "HasIntroStartup";
                    json_info.StartingTheme = "StatingTheme";
                    json_info.IntroStartupSong = "IntroStartupSong";
                    json_info.SequencerTargetID = "SequencerTargetID";
                    json_info.SequencerSpinUpTime = "SequencerSpinUpTime";
                    json_info.SequencerFlagRequiredForStart = "SequencerFlagRequiredForStart";
                    json_info.ActionsToRunOnSequencerStart = "ActionsToRunOnSequencerStart";
                    json_info.WorkshopDescription = "WorkshopDescription";
                    json_info.WorkshopLanguage = "WorkshopLanguage";
                    json_info.WorkshopVisibility = "WorkshopVisibility";
                    json_info.WorkshopTags = "WorkshopTags";
                    json_info.WorkshopPreviewImagePath = "WorkshopPreviewImagePath";
                    json_info.WorkshopPublishID = "WorkshopPublishID";

                    json_settings.proyect_name = proyect_name;
                    json_settings.compile_folder = compile_folder;

                    ListViewItem proyect = new ListViewItem();
                    proyect.Text = "Proyect Settings";
                    proyect.ImageIndex = 0;
                    proyect.Group = viewProyect.Groups[0];

                    ListViewItem extensionInfo = new ListViewItem();
                    extensionInfo.Text = "Extension Info";
                    extensionInfo.ImageIndex = 0;
                    extensionInfo.Group = viewProyect.Groups[0];

                    viewProyect.Items.Add(proyect);
                    viewProyect.Items.Add(extensionInfo);

                    //Directory.CreateDirectory(String.Format(@"{0}\{1}", dialogSaveProyect.RestoreDirectory, proyect_name));
                    StreamWriter file_settings = new StreamWriter(String.Format("{0}", Path.GetFullPath(dialogSaveProyect.FileName)), false);
                    StreamWriter file_info = new StreamWriter(String.Format(@"{0}\ExtensionInfo.uep", Path.GetDirectoryName(dialogSaveProyect.FileName)), false);
                    StreamWriter file_readme = new StreamWriter(String.Format(@"{0}\README.txt", Path.GetDirectoryName(dialogSaveProyect.FileName)), false);

                    file_settings.Write(json_settings.ToString());
                    file_settings.Close();
                    file_info.Write(json_info.ToString());
                    file_info.Close();
                    file_readme.Write("hi");
                    file_readme.Close();
                }
            }
        }

        private void ButtonOpen_Click(object sender, EventArgs e)
        {
            string uDatos = File.ReadAllText(String.Format(@"{0}\{1}\{1}.hep", Application.StartupPath, "hola"));
            dynamic rPersona = JsonConvert.DeserializeObject(uDatos);

            MessageBox.Show(rPersona.hola.ToString());
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            hee gg = new hee();

            gg.extensionInfo();
        }

        private void ButtonActions_Click(object sender, EventArgs e)
        {
            string actions_name = Interaction.InputBox("Name", "Actions");
            if (actions_name != "")
            {
                ListViewItem actions = new ListViewItem();
                actions.Text = actions_name;
                actions.ImageIndex = 1;
                actions.Group = viewProyect.Groups[1];

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
                factions.ImageIndex = 2;
                factions.Group = viewProyect.Groups[2];

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
                images.ImageIndex = 3;
                images.Group = viewProyect.Groups[3];

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
                missions.ImageIndex = 4;
                missions.Group = viewProyect.Groups[4];

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
                music.ImageIndex = 5;
                music.Group = viewProyect.Groups[5];

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
                node.ImageIndex = 6;
                node.Group = viewProyect.Groups[6];

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
                peoples.ImageIndex = 7;
                peoples.Group = viewProyect.Groups[7];

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
                scripts.ImageIndex = 8;
                scripts.Group = viewProyect.Groups[8];

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
                themes.ImageIndex = 9;
                themes.Group = viewProyect.Groups[9];

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
                web.ImageIndex = 10;
                web.Group = viewProyect.Groups[10];

                viewProyect.Items.Add(web);
            }
        }
    }
}

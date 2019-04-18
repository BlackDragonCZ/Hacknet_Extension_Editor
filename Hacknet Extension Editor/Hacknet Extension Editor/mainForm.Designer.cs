namespace Hacknet_Extension_Editor
{
    partial class mainForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewGroup listViewGroup12 = new System.Windows.Forms.ListViewGroup("General Settings", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup13 = new System.Windows.Forms.ListViewGroup("Actions", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup14 = new System.Windows.Forms.ListViewGroup("Factions", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup15 = new System.Windows.Forms.ListViewGroup("Images", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup16 = new System.Windows.Forms.ListViewGroup("Missions", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup17 = new System.Windows.Forms.ListViewGroup("Music", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup18 = new System.Windows.Forms.ListViewGroup("Nodes", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup19 = new System.Windows.Forms.ListViewGroup("Peoples", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup20 = new System.Windows.Forms.ListViewGroup("Scripts", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup21 = new System.Windows.Forms.ListViewGroup("Themes", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup22 = new System.Windows.Forms.ListViewGroup("Web", System.Windows.Forms.HorizontalAlignment.Left);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.buttonNew = new System.Windows.Forms.ToolStripButton();
            this.buttonOpen = new System.Windows.Forms.ToolStripButton();
            this.buttonSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.buttonActions = new System.Windows.Forms.ToolStripButton();
            this.buttonFactions = new System.Windows.Forms.ToolStripButton();
            this.buttonImages = new System.Windows.Forms.ToolStripButton();
            this.buttonMissions = new System.Windows.Forms.ToolStripButton();
            this.buttonMusic = new System.Windows.Forms.ToolStripButton();
            this.buttonNodes = new System.Windows.Forms.ToolStripButton();
            this.buttonPeoples = new System.Windows.Forms.ToolStripButton();
            this.buttonScripts = new System.Windows.Forms.ToolStripButton();
            this.buttonThemes = new System.Windows.Forms.ToolStripButton();
            this.buttonWeb = new System.Windows.Forms.ToolStripButton();
            this.buttonTranslate = new System.Windows.Forms.ToolStripDropDownButton();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.españolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonAbout = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.buttonCompile = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.viewProyect = new System.Windows.Forms.ListView();
            this.icons = new System.Windows.Forms.ImageList(this.components);
            this.messageInfo = new System.Windows.Forms.ToolTip(this.components);
            this.dialogSaveProyect = new System.Windows.Forms.SaveFileDialog();
            this.dialogFolderProyect = new System.Windows.Forms.FolderBrowserDialog();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonNew,
            this.buttonOpen,
            this.buttonSave,
            this.toolStripSeparator1,
            this.buttonActions,
            this.buttonFactions,
            this.buttonImages,
            this.buttonMissions,
            this.buttonMusic,
            this.buttonNodes,
            this.buttonPeoples,
            this.buttonScripts,
            this.buttonThemes,
            this.buttonWeb,
            this.buttonTranslate,
            this.buttonAbout,
            this.toolStripSeparator2,
            this.buttonCompile});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(795, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // buttonNew
            // 
            this.buttonNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonNew.Image = global::Hacknet_Extension_Editor.Properties.Resources.new_project;
            this.buttonNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(23, 22);
            this.buttonNew.Text = "New Proyect";
            this.buttonNew.Click += new System.EventHandler(this.ButtonNew_Click);
            // 
            // buttonOpen
            // 
            this.buttonOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonOpen.Image = global::Hacknet_Extension_Editor.Properties.Resources.open_proyect;
            this.buttonOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(23, 22);
            this.buttonOpen.Text = "Open Proyect";
            this.buttonOpen.Click += new System.EventHandler(this.ButtonOpen_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonSave.Image = global::Hacknet_Extension_Editor.Properties.Resources.save_proyect;
            this.buttonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(23, 22);
            this.buttonSave.Text = "Save Proyect";
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // buttonActions
            // 
            this.buttonActions.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonActions.Image = global::Hacknet_Extension_Editor.Properties.Resources.new_actions;
            this.buttonActions.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonActions.Name = "buttonActions";
            this.buttonActions.Size = new System.Drawing.Size(23, 22);
            this.buttonActions.Text = "New Actions";
            this.buttonActions.Click += new System.EventHandler(this.ButtonActions_Click);
            // 
            // buttonFactions
            // 
            this.buttonFactions.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonFactions.Image = global::Hacknet_Extension_Editor.Properties.Resources.new_factions;
            this.buttonFactions.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonFactions.Name = "buttonFactions";
            this.buttonFactions.Size = new System.Drawing.Size(23, 22);
            this.buttonFactions.Text = "New Factions";
            this.buttonFactions.Click += new System.EventHandler(this.ButtonFactions_Click);
            // 
            // buttonImages
            // 
            this.buttonImages.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonImages.Image = global::Hacknet_Extension_Editor.Properties.Resources.new_images;
            this.buttonImages.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonImages.Name = "buttonImages";
            this.buttonImages.Size = new System.Drawing.Size(23, 22);
            this.buttonImages.Text = "New Images";
            this.buttonImages.Click += new System.EventHandler(this.ButtonImages_Click);
            // 
            // buttonMissions
            // 
            this.buttonMissions.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonMissions.Image = global::Hacknet_Extension_Editor.Properties.Resources.new_missions;
            this.buttonMissions.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonMissions.Name = "buttonMissions";
            this.buttonMissions.Size = new System.Drawing.Size(23, 22);
            this.buttonMissions.Text = "New Missions";
            this.buttonMissions.Click += new System.EventHandler(this.ButtonMissions_Click);
            // 
            // buttonMusic
            // 
            this.buttonMusic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonMusic.Image = global::Hacknet_Extension_Editor.Properties.Resources.new_music;
            this.buttonMusic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonMusic.Name = "buttonMusic";
            this.buttonMusic.Size = new System.Drawing.Size(23, 22);
            this.buttonMusic.Text = "New Music";
            this.buttonMusic.Click += new System.EventHandler(this.ButtonMusic_Click);
            // 
            // buttonNodes
            // 
            this.buttonNodes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonNodes.Image = global::Hacknet_Extension_Editor.Properties.Resources.new_nodes;
            this.buttonNodes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonNodes.Name = "buttonNodes";
            this.buttonNodes.Size = new System.Drawing.Size(23, 22);
            this.buttonNodes.Text = "New Nodes";
            this.buttonNodes.Click += new System.EventHandler(this.ButtonNodes_Click);
            // 
            // buttonPeoples
            // 
            this.buttonPeoples.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonPeoples.Image = global::Hacknet_Extension_Editor.Properties.Resources.new_peoples;
            this.buttonPeoples.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonPeoples.Name = "buttonPeoples";
            this.buttonPeoples.Size = new System.Drawing.Size(23, 22);
            this.buttonPeoples.Text = "New Peoples";
            this.buttonPeoples.Click += new System.EventHandler(this.ButtonPeoples_Click);
            // 
            // buttonScripts
            // 
            this.buttonScripts.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonScripts.Image = global::Hacknet_Extension_Editor.Properties.Resources.new_scripts;
            this.buttonScripts.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonScripts.Name = "buttonScripts";
            this.buttonScripts.Size = new System.Drawing.Size(23, 22);
            this.buttonScripts.Text = "New Scripts";
            this.buttonScripts.Click += new System.EventHandler(this.ButtonScripts_Click);
            // 
            // buttonThemes
            // 
            this.buttonThemes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonThemes.Image = global::Hacknet_Extension_Editor.Properties.Resources.new_themes;
            this.buttonThemes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonThemes.Name = "buttonThemes";
            this.buttonThemes.Size = new System.Drawing.Size(23, 22);
            this.buttonThemes.Text = "New Themes";
            this.buttonThemes.Click += new System.EventHandler(this.ButtonThemes_Click);
            // 
            // buttonWeb
            // 
            this.buttonWeb.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonWeb.Image = global::Hacknet_Extension_Editor.Properties.Resources.new_web;
            this.buttonWeb.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonWeb.Name = "buttonWeb";
            this.buttonWeb.Size = new System.Drawing.Size(23, 22);
            this.buttonWeb.Text = "New Web";
            this.buttonWeb.Click += new System.EventHandler(this.ButtonWeb_Click);
            // 
            // buttonTranslate
            // 
            this.buttonTranslate.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.buttonTranslate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonTranslate.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishToolStripMenuItem,
            this.españolToolStripMenuItem,
            this.meowToolStripMenuItem});
            this.buttonTranslate.Image = global::Hacknet_Extension_Editor.Properties.Resources.translate;
            this.buttonTranslate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonTranslate.Name = "buttonTranslate";
            this.buttonTranslate.Size = new System.Drawing.Size(29, 22);
            this.buttonTranslate.Text = "Translate";
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.englishToolStripMenuItem.Text = "en - English";
            // 
            // españolToolStripMenuItem
            // 
            this.españolToolStripMenuItem.Name = "españolToolStripMenuItem";
            this.españolToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.españolToolStripMenuItem.Text = "es - Español";
            // 
            // meowToolStripMenuItem
            // 
            this.meowToolStripMenuItem.Name = "meowToolStripMenuItem";
            this.meowToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.meowToolStripMenuItem.Text = "cat - Meow";
            // 
            // buttonAbout
            // 
            this.buttonAbout.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.buttonAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonAbout.Image = global::Hacknet_Extension_Editor.Properties.Resources.about;
            this.buttonAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(23, 22);
            this.buttonAbout.Text = "About";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // buttonCompile
            // 
            this.buttonCompile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonCompile.Image = global::Hacknet_Extension_Editor.Properties.Resources.compile;
            this.buttonCompile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonCompile.Name = "buttonCompile";
            this.buttonCompile.Size = new System.Drawing.Size(23, 22);
            this.buttonCompile.Text = "Compile Extension";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 500);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(795, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // viewProyect
            // 
            this.viewProyect.Dock = System.Windows.Forms.DockStyle.Left;
            this.viewProyect.FullRowSelect = true;
            listViewGroup12.Header = "General Settings";
            listViewGroup12.Name = "generalGroup";
            listViewGroup13.Header = "Actions";
            listViewGroup13.Name = "actionsGroup";
            listViewGroup14.Header = "Factions";
            listViewGroup14.Name = "factionsGroup";
            listViewGroup15.Header = "Images";
            listViewGroup15.Name = "imagesGroup";
            listViewGroup16.Header = "Missions";
            listViewGroup16.Name = "missionsGroup";
            listViewGroup17.Header = "Music";
            listViewGroup17.Name = "musicGroup";
            listViewGroup18.Header = "Nodes";
            listViewGroup18.Name = "nodesGroup";
            listViewGroup19.Header = "Peoples";
            listViewGroup19.Name = "peoplesGroup";
            listViewGroup20.Header = "Scripts";
            listViewGroup20.Name = "scriptsGroup";
            listViewGroup21.Header = "Themes";
            listViewGroup21.Name = "themesGroup";
            listViewGroup22.Header = "Web";
            listViewGroup22.Name = "webGroup";
            this.viewProyect.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup12,
            listViewGroup13,
            listViewGroup14,
            listViewGroup15,
            listViewGroup16,
            listViewGroup17,
            listViewGroup18,
            listViewGroup19,
            listViewGroup20,
            listViewGroup21,
            listViewGroup22});
            this.viewProyect.LabelWrap = false;
            this.viewProyect.Location = new System.Drawing.Point(0, 25);
            this.viewProyect.MultiSelect = false;
            this.viewProyect.Name = "viewProyect";
            this.viewProyect.Size = new System.Drawing.Size(200, 475);
            this.viewProyect.SmallImageList = this.icons;
            this.viewProyect.TabIndex = 3;
            this.viewProyect.UseCompatibleStateImageBehavior = false;
            this.viewProyect.View = System.Windows.Forms.View.SmallIcon;
            // 
            // icons
            // 
            this.icons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("icons.ImageStream")));
            this.icons.TransparentColor = System.Drawing.Color.Transparent;
            this.icons.Images.SetKeyName(0, "settings.png");
            this.icons.Images.SetKeyName(1, "actions.png");
            this.icons.Images.SetKeyName(2, "factions.png");
            this.icons.Images.SetKeyName(3, "images.png");
            this.icons.Images.SetKeyName(4, "missions.png");
            this.icons.Images.SetKeyName(5, "music.png");
            this.icons.Images.SetKeyName(6, "nodes.png");
            this.icons.Images.SetKeyName(7, "peoples.png");
            this.icons.Images.SetKeyName(8, "scripts.png");
            this.icons.Images.SetKeyName(9, "themes.png");
            this.icons.Images.SetKeyName(10, "web.png");
            // 
            // messageInfo
            // 
            this.messageInfo.IsBalloon = true;
            // 
            // dialogSaveProyect
            // 
            this.dialogSaveProyect.Filter = "Hacknet Extension Proyect|*.hep";
            // 
            // dialogFolderProyect
            // 
            this.dialogFolderProyect.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 522);
            this.Controls.Add(this.viewProyect);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.IsMdiContainer = true;
            this.Name = "mainForm";
            this.Text = "Hacknet Extension Editor";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton buttonNew;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ListView viewProyect;
        private System.Windows.Forms.ToolStripButton buttonOpen;
        private System.Windows.Forms.ToolStripButton buttonSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton buttonActions;
        private System.Windows.Forms.ToolStripButton buttonFactions;
        private System.Windows.Forms.ToolStripButton buttonImages;
        private System.Windows.Forms.ToolStripButton buttonMissions;
        private System.Windows.Forms.ToolStripButton buttonMusic;
        private System.Windows.Forms.ToolStripButton buttonNodes;
        private System.Windows.Forms.ToolStripButton buttonPeoples;
        private System.Windows.Forms.ToolStripButton buttonScripts;
        private System.Windows.Forms.ToolStripButton buttonThemes;
        private System.Windows.Forms.ToolStripButton buttonWeb;
        private System.Windows.Forms.ImageList icons;
        private System.Windows.Forms.ToolStripButton buttonAbout;
        private System.Windows.Forms.ToolTip messageInfo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton buttonCompile;
        private System.Windows.Forms.ToolStripDropDownButton buttonTranslate;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem españolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem meowToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog dialogSaveProyect;
        private System.Windows.Forms.FolderBrowserDialog dialogFolderProyect;
    }
}


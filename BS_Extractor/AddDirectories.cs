using System;
using System.IO;
using System.Windows.Forms;
using BS_Extractor;

namespace BeatSaber_SongExtractor
{
    public partial class AddDirectories : UserControl
    {
        public string BSDirectory { get { return this.BSPath.Text; } }
        public string STEDirectory { get { return this.STEPath.Text; } }

        public bool ClickedClose = false;

        public Extractor t_parent;
        private void SavePaths()
        {
            string[] paths =
            {
             BSDirectory, STEDirectory
            };

            File.WriteAllLines("Paths.txt", paths);
        }
        public AddDirectories()
        {
            InitializeComponent();
        }

        private void SelectBSFolder_Click(object sender, EventArgs e)
        {
            BSFolder.ShowDialog();
            BSPath.Text = BSFolder.SelectedPath;
        }

        private void SelectSTE_Click(object sender, EventArgs e)
        {
            STEFolder.ShowDialog();
            STEPath.Text = STEFolder.SelectedPath;
        }
        private void Close_Click(object sender, EventArgs e)
        {
            ClickedClose = true;
            Visible = false;
        }

        private void Done_Click(object sender, EventArgs e)
        {
            if(BSPath.Text != "" && STEPath.Text != "")
            {
                ClickedClose = false;
                SavePaths();
                ErrorLabel.Visible = false;
                lblLoadedCorrectly.Visible = true;
                Done.Visible = false;
                Close.Visible = false;
                Next.Visible = true;
            }
            else
            {
                ErrorLabel.Visible = true;
            }
        }

        private void Next_Click(object sender, EventArgs e)
        {
            t_parent.LoadMainMenu();
        }
    }
}

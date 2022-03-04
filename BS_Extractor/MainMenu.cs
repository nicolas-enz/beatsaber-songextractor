using System;
using System.IO;
using System.IO.Compression;
using System.Windows.Forms;
using BS_Extractor;

namespace BeatSaber_SongExtractor
{
    public partial class MainMenu : UserControl
    {
        public Extractor t_parent;
        private bool IsSelectedAll = false;
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        { 
            LoadZipList();
        }

        private void LoadZipList()
        {
            DirectoryInfo di = new DirectoryInfo(t_parent.Paths[1]);
            FileInfo[] fi = di.GetFiles("*.zip");

            foreach(FileInfo f in fi)
            {
                zipList.Items.Add(Path.GetFileNameWithoutExtension(f.Name));
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DirectoryInfo di = new DirectoryInfo(t_parent.Paths[1]);
            FileInfo[] fi = di.GetFiles("*.zip");

            zipList.Items.Clear();

            foreach (FileInfo f in fi)
            {
                zipList.Items.Add(f.Name);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                for(int i = 0; i < zipList.Items.Count; i++)
                {
                    // Check if file exists with its full path    
                    if (zipList.GetItemChecked(i) && File.Exists(Path.Combine(t_parent.Paths[1], zipList.Items[i].ToString() + ".zip")))
                    {
                        // If file found, delete it    
                        File.Delete(Path.Combine(t_parent.Paths[1], zipList.Items[i].ToString() + ".zip"));
                        Console.WriteLine("File deleted.");
                    }
                    else Console.WriteLine("File not found");
                }
            }
            catch (IOException ioExp)
            {
                Console.WriteLine(ioExp.Message);
            }

            btnRefresh_Click(sender, e);
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            if (!IsSelectedAll)
            {
                for (int i = 0; i < zipList.Items.Count; i++)
                {
                    zipList.SetItemChecked(i, true);
                }
                btnSelectAll.Text = "Deselect All";
                IsSelectedAll = true;
            }
            else
            {
                for (int i = 0; i < zipList.Items.Count; i++)
                {
                    zipList.SetItemChecked(i, false);
                }
                btnSelectAll.Text = "Select All";
                IsSelectedAll = false;
            }
        }

        private void btnExtract_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < zipList.Items.Count; i++)
            {
                if (zipList.GetItemChecked(i))
                {
                    ZipFile.ExtractToDirectory(
                        Path.Combine(t_parent.Paths[1], zipList.Items[i].ToString() + ".zip"),
                        Path.Combine(t_parent.Paths[0], zipList.Items[i].ToString()), true);
                }
            }

            if(DeleteFiles.Checked)
            {
                for (int i = 0; i < zipList.Items.Count; i++)
                {
                    if (zipList.GetItemChecked(i) && File.Exists(Path.Combine(t_parent.Paths[1], zipList.Items[i].ToString() + ".zip")))
                    {
                        File.Delete(Path.Combine(t_parent.Paths[1], zipList.Items[i].ToString() + ".zip"));
                    }
                }
                btnRefresh_Click(sender, e);
            }

            NoErrors.Visible = true;
        }

    }
}

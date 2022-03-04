using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace BS_Extractor
{
    public partial class Extractor : Form
    {
        
        public string[] Paths = { "", "" };
        public Extractor()
        {
            InitializeComponent();
            CenterToScreen();

            AddDirectories.t_parent = this;
            MainMenu.t_parent = this;

            LoadPathFile();

            bool IsEmpty = false;

            foreach(string path in Paths)
            {
                if (path == "")
                    IsEmpty = true;
            }

            if (IsEmpty)
            {
                LoadAddDirectories();
            }
            else
            {
                LoadMainMenu();
            }
            
        }

        private void LoadPathFile()
        {
            if (File.Exists("Paths.txt"))
            {
                Paths = File.ReadAllLines("Paths.txt"); ;
            }
        }
        
        public void LoadAddDirectories()
        {
            Size = new Size(520, 270);
            AddDirectories.Visible = true;
            MainMenu.Visible = false;
        }

        public void LoadMainMenu()
        {
            LoadPathFile();
            Size = new Size(420, 420);
            AddDirectories.Visible = false;
            MainMenu.Visible = true;
        }
    }
}

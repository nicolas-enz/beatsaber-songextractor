
namespace BS_Extractor
{
    partial class Extractor
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddDirectories = new BeatSaber_SongExtractor.AddDirectories();
            this.MainMenu = new BeatSaber_SongExtractor.MainMenu();
            this.SuspendLayout();
            // 
            // AddDirectories
            // 
            this.AddDirectories.Location = new System.Drawing.Point(0, 27);
            this.AddDirectories.Name = "AddDirectories";
            this.AddDirectories.Size = new System.Drawing.Size(500, 200);
            this.AddDirectories.TabIndex = 0;
            this.AddDirectories.Visible = false;
            // 
            // MainMenu
            // 
            this.MainMenu.Location = new System.Drawing.Point(0, 27);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(421, 396);
            this.MainMenu.TabIndex = 1;
            this.MainMenu.Visible = false;
            // 
            // Extractor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 530);
            this.Controls.Add(this.MainMenu);
            this.Controls.Add(this.AddDirectories);
            this.Name = "Extractor";
            this.Text = "Beat Saber - Song Extractor";
            this.ResumeLayout(false);

        }

        #endregion

        private BeatSaber_SongExtractor.AddDirectories AddDirectories;
        private BeatSaber_SongExtractor.MainMenu MainMenu;
    }
}


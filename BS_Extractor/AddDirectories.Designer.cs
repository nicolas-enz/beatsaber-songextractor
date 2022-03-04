
namespace BeatSaber_SongExtractor
{
    partial class AddDirectories
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.bsfolderlabel = new System.Windows.Forms.Label();
            this.BSFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.BSPath = new System.Windows.Forms.TextBox();
            this.SelectBSFolder = new System.Windows.Forms.Button();
            this.bssongsfolder = new System.Windows.Forms.Label();
            this.STEPath = new System.Windows.Forms.TextBox();
            this.SelectSTE = new System.Windows.Forms.Button();
            this.STEFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.Done = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.lblLoadedCorrectly = new System.Windows.Forms.Label();
            this.Next = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bsfolderlabel
            // 
            this.bsfolderlabel.AutoSize = true;
            this.bsfolderlabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bsfolderlabel.Location = new System.Drawing.Point(13, 38);
            this.bsfolderlabel.Name = "bsfolderlabel";
            this.bsfolderlabel.Size = new System.Drawing.Size(112, 17);
            this.bsfolderlabel.TabIndex = 0;
            this.bsfolderlabel.Text = "Beat Saber Folder";
            // 
            // BSPath
            // 
            this.BSPath.Location = new System.Drawing.Point(171, 37);
            this.BSPath.Name = "BSPath";
            this.BSPath.Size = new System.Drawing.Size(239, 23);
            this.BSPath.TabIndex = 1;
            // 
            // SelectBSFolder
            // 
            this.SelectBSFolder.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SelectBSFolder.Location = new System.Drawing.Point(427, 37);
            this.SelectBSFolder.Name = "SelectBSFolder";
            this.SelectBSFolder.Size = new System.Drawing.Size(23, 23);
            this.SelectBSFolder.TabIndex = 2;
            this.SelectBSFolder.Text = "📁";
            this.SelectBSFolder.UseVisualStyleBackColor = true;
            this.SelectBSFolder.Click += new System.EventHandler(this.SelectBSFolder_Click);
            // 
            // bssongsfolder
            // 
            this.bssongsfolder.AutoSize = true;
            this.bssongsfolder.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bssongsfolder.Location = new System.Drawing.Point(13, 116);
            this.bssongsfolder.Name = "bssongsfolder";
            this.bssongsfolder.Size = new System.Drawing.Size(144, 17);
            this.bssongsfolder.TabIndex = 3;
            this.bssongsfolder.Text = "Songs to Extract Folder";
            // 
            // STEPath
            // 
            this.STEPath.Location = new System.Drawing.Point(171, 115);
            this.STEPath.Name = "STEPath";
            this.STEPath.Size = new System.Drawing.Size(239, 23);
            this.STEPath.TabIndex = 4;
            // 
            // SelectSTE
            // 
            this.SelectSTE.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SelectSTE.Location = new System.Drawing.Point(427, 115);
            this.SelectSTE.Name = "SelectSTE";
            this.SelectSTE.Size = new System.Drawing.Size(23, 23);
            this.SelectSTE.TabIndex = 5;
            this.SelectSTE.Text = "📁";
            this.SelectSTE.UseVisualStyleBackColor = true;
            this.SelectSTE.Click += new System.EventHandler(this.SelectSTE_Click);
            // 
            // Done
            // 
            this.Done.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Done.Location = new System.Drawing.Point(316, 156);
            this.Done.Name = "Done";
            this.Done.Size = new System.Drawing.Size(75, 30);
            this.Done.TabIndex = 6;
            this.Done.Text = "Done";
            this.Done.UseVisualStyleBackColor = true;
            this.Done.Click += new System.EventHandler(this.Done_Click);
            // 
            // Close
            // 
            this.Close.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Close.Location = new System.Drawing.Point(406, 156);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(75, 30);
            this.Close.TabIndex = 7;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.BackColor = System.Drawing.SystemColors.Control;
            this.ErrorLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel.Location = new System.Drawing.Point(44, 156);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(150, 17);
            this.ErrorLabel.TabIndex = 8;
            this.ErrorLabel.Text = "Both paths are required.";
            this.ErrorLabel.Visible = false;
            // 
            // lblLoadedCorrectly
            // 
            this.lblLoadedCorrectly.AutoSize = true;
            this.lblLoadedCorrectly.BackColor = System.Drawing.SystemColors.Control;
            this.lblLoadedCorrectly.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLoadedCorrectly.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblLoadedCorrectly.Location = new System.Drawing.Point(44, 156);
            this.lblLoadedCorrectly.Name = "lblLoadedCorrectly";
            this.lblLoadedCorrectly.Size = new System.Drawing.Size(119, 17);
            this.lblLoadedCorrectly.TabIndex = 9;
            this.lblLoadedCorrectly.Text = "Directories loaded.";
            this.lblLoadedCorrectly.Visible = false;
            // 
            // Next
            // 
            this.Next.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Next.Location = new System.Drawing.Point(360, 156);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(75, 30);
            this.Next.TabIndex = 10;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Visible = false;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // AddDirectories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Next);
            this.Controls.Add(this.lblLoadedCorrectly);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.Done);
            this.Controls.Add(this.SelectSTE);
            this.Controls.Add(this.STEPath);
            this.Controls.Add(this.bssongsfolder);
            this.Controls.Add(this.SelectBSFolder);
            this.Controls.Add(this.BSPath);
            this.Controls.Add(this.bsfolderlabel);
            this.Name = "AddDirectories";
            this.Size = new System.Drawing.Size(500, 200);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bsfolderlabel;
        private System.Windows.Forms.FolderBrowserDialog BSFolder;
        private System.Windows.Forms.TextBox BSPath;
        private System.Windows.Forms.Button SelectBSFolder;
        private System.Windows.Forms.Label bssongsfolder;
        private System.Windows.Forms.TextBox STEPath;
        private System.Windows.Forms.Button SelectSTE;
        private System.Windows.Forms.FolderBrowserDialog STEFolder;
        private System.Windows.Forms.Button Done;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.Label lblLoadedCorrectly;
        private System.Windows.Forms.Button Next;
    }
}

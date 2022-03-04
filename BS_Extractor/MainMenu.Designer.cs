
namespace BeatSaber_SongExtractor
{
    partial class MainMenu
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
            this.zipList = new System.Windows.Forms.CheckedListBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnExtract = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.lblZipList = new System.Windows.Forms.Label();
            this.DeleteFiles = new System.Windows.Forms.CheckBox();
            this.NoErrors = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // zipList
            // 
            this.zipList.FormattingEnabled = true;
            this.zipList.Location = new System.Drawing.Point(83, 49);
            this.zipList.Name = "zipList";
            this.zipList.Size = new System.Drawing.Size(170, 202);
            this.zipList.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(269, 49);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnExtract
            // 
            this.btnExtract.Location = new System.Drawing.Point(178, 264);
            this.btnExtract.Name = "btnExtract";
            this.btnExtract.Size = new System.Drawing.Size(75, 23);
            this.btnExtract.TabIndex = 2;
            this.btnExtract.Text = "Extract";
            this.btnExtract.UseVisualStyleBackColor = true;
            this.btnExtract.Click += new System.EventHandler(this.btnExtract_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(269, 85);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Location = new System.Drawing.Point(83, 264);
            this.btnSelectAll.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(89, 23);
            this.btnSelectAll.TabIndex = 5;
            this.btnSelectAll.Text = "Select All";
            this.btnSelectAll.UseVisualStyleBackColor = true;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // lblZipList
            // 
            this.lblZipList.AutoSize = true;
            this.lblZipList.Location = new System.Drawing.Point(83, 28);
            this.lblZipList.Name = "lblZipList";
            this.lblZipList.Size = new System.Drawing.Size(81, 15);
            this.lblZipList.TabIndex = 6;
            this.lblZipList.Text = "Songs .zip List";
            // 
            // DeleteFiles
            // 
            this.DeleteFiles.AutoSize = true;
            this.DeleteFiles.Location = new System.Drawing.Point(83, 293);
            this.DeleteFiles.Name = "DeleteFiles";
            this.DeleteFiles.Size = new System.Drawing.Size(171, 19);
            this.DeleteFiles.TabIndex = 7;
            this.DeleteFiles.Text = "Delete files after extraction?";
            this.DeleteFiles.UseVisualStyleBackColor = true;
            // 
            // NoErrors
            // 
            this.NoErrors.AutoSize = true;
            this.NoErrors.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NoErrors.ForeColor = System.Drawing.Color.Green;
            this.NoErrors.Location = new System.Drawing.Point(83, 319);
            this.NoErrors.Name = "NoErrors";
            this.NoErrors.Size = new System.Drawing.Size(145, 17);
            this.NoErrors.TabIndex = 8;
            this.NoErrors.Text = "Files extracted correctly";
            this.NoErrors.Visible = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.NoErrors);
            this.Controls.Add(this.DeleteFiles);
            this.Controls.Add(this.lblZipList);
            this.Controls.Add(this.btnSelectAll);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnExtract);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.zipList);
            this.Name = "MainMenu";
            this.Size = new System.Drawing.Size(400, 350);
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox zipList;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnExtract;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.Label lblZipList;
        private System.Windows.Forms.CheckBox DeleteFiles;
        private System.Windows.Forms.Label NoErrors;
    }
}

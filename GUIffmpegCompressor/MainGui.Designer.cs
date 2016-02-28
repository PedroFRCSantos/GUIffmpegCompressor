namespace GUIffmpeg
{
    partial class MainGui
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxFolderIn = new System.Windows.Forms.TextBox();
            this.textBoxFolderOut = new System.Windows.Forms.TextBox();
            this.buttonOpenFolderIn = new System.Windows.Forms.Button();
            this.buttonFolderOut = new System.Windows.Forms.Button();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewFilms = new System.Windows.Forms.DataGridView();
            this.convertVideo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.joinBefore = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.fileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finalName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonRun = new System.Windows.Forms.Button();
            this.labelFolderIn = new System.Windows.Forms.Label();
            this.labelOutputDir = new System.Windows.Forms.Label();
            this.folderBrowserDialogIn = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialogOut = new System.Windows.Forms.FolderBrowserDialog();
            this.progressBarWork = new System.Windows.Forms.ProgressBar();
            this.backgroundWorkerConverter = new System.ComponentModel.BackgroundWorker();
            this.menuStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFilms)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxFolderIn
            // 
            this.textBoxFolderIn.Location = new System.Drawing.Point(12, 52);
            this.textBoxFolderIn.Name = "textBoxFolderIn";
            this.textBoxFolderIn.Size = new System.Drawing.Size(591, 20);
            this.textBoxFolderIn.TabIndex = 0;
            this.textBoxFolderIn.TextChanged += new System.EventHandler(this.textBoxFolderInTextChanged);
            // 
            // textBoxFolderOut
            // 
            this.textBoxFolderOut.Location = new System.Drawing.Point(12, 107);
            this.textBoxFolderOut.Name = "textBoxFolderOut";
            this.textBoxFolderOut.Size = new System.Drawing.Size(591, 20);
            this.textBoxFolderOut.TabIndex = 1;
            this.textBoxFolderOut.TextChanged += new System.EventHandler(this.textBoxFolderOutTextChanged);
            // 
            // buttonOpenFolderIn
            // 
            this.buttonOpenFolderIn.Location = new System.Drawing.Point(609, 50);
            this.buttonOpenFolderIn.Name = "buttonOpenFolderIn";
            this.buttonOpenFolderIn.Size = new System.Drawing.Size(75, 23);
            this.buttonOpenFolderIn.TabIndex = 2;
            this.buttonOpenFolderIn.Text = "Browse";
            this.buttonOpenFolderIn.UseVisualStyleBackColor = true;
            this.buttonOpenFolderIn.Click += new System.EventHandler(this.buttonOpenFolderInClick);
            // 
            // buttonFolderOut
            // 
            this.buttonFolderOut.Location = new System.Drawing.Point(609, 104);
            this.buttonFolderOut.Name = "buttonFolderOut";
            this.buttonFolderOut.Size = new System.Drawing.Size(75, 23);
            this.buttonFolderOut.TabIndex = 3;
            this.buttonFolderOut.Text = "Browse";
            this.buttonFolderOut.UseVisualStyleBackColor = true;
            this.buttonFolderOut.Click += new System.EventHandler(this.buttonFolderOutClick);
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(696, 24);
            this.menuStripMain.TabIndex = 5;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openInToolStripMenuItem,
            this.openOutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openInToolStripMenuItem
            // 
            this.openInToolStripMenuItem.Name = "openInToolStripMenuItem";
            this.openInToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openInToolStripMenuItem.Text = "Open In";
            this.openInToolStripMenuItem.Click += new System.EventHandler(this.openInToolStripMenuItemClick);
            // 
            // openOutToolStripMenuItem
            // 
            this.openOutToolStripMenuItem.Name = "openOutToolStripMenuItem";
            this.openOutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openOutToolStripMenuItem.Text = "Open Out";
            this.openOutToolStripMenuItem.Click += new System.EventHandler(this.openOutToolStripMenuItemClick);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItemClick);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItemClick);
            // 
            // dataGridViewFilms
            // 
            this.dataGridViewFilms.AllowUserToAddRows = false;
            this.dataGridViewFilms.AllowUserToDeleteRows = false;
            this.dataGridViewFilms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewFilms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFilms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.convertVideo,
            this.joinBefore,
            this.fileName,
            this.finalName});
            this.dataGridViewFilms.Location = new System.Drawing.Point(12, 158);
            this.dataGridViewFilms.Name = "dataGridViewFilms";
            this.dataGridViewFilms.Size = new System.Drawing.Size(672, 168);
            this.dataGridViewFilms.TabIndex = 6;
            // 
            // convertVideo
            // 
            this.convertVideo.FillWeight = 70F;
            this.convertVideo.HeaderText = "Convert Video:";
            this.convertVideo.Name = "convertVideo";
            // 
            // joinBefore
            // 
            this.joinBefore.HeaderText = "Join to Video Before:";
            this.joinBefore.Name = "joinBefore";
            // 
            // fileName
            // 
            this.fileName.HeaderText = "Name:";
            this.fileName.Name = "fileName";
            this.fileName.ReadOnly = true;
            // 
            // finalName
            // 
            this.finalName.HeaderText = "Final Name:";
            this.finalName.Name = "finalName";
            this.finalName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.finalName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // buttonRun
            // 
            this.buttonRun.Location = new System.Drawing.Point(293, 382);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(102, 38);
            this.buttonRun.TabIndex = 7;
            this.buttonRun.Text = "Convert";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.button1Run);
            // 
            // labelFolderIn
            // 
            this.labelFolderIn.AutoSize = true;
            this.labelFolderIn.Location = new System.Drawing.Point(9, 36);
            this.labelFolderIn.Name = "labelFolderIn";
            this.labelFolderIn.Size = new System.Drawing.Size(63, 13);
            this.labelFolderIn.TabIndex = 8;
            this.labelFolderIn.Text = "Input folder:";
            // 
            // labelOutputDir
            // 
            this.labelOutputDir.AutoSize = true;
            this.labelOutputDir.Location = new System.Drawing.Point(12, 91);
            this.labelOutputDir.Name = "labelOutputDir";
            this.labelOutputDir.Size = new System.Drawing.Size(71, 13);
            this.labelOutputDir.TabIndex = 9;
            this.labelOutputDir.Text = "Output folder:";
            // 
            // progressBarWork
            // 
            this.progressBarWork.Location = new System.Drawing.Point(12, 346);
            this.progressBarWork.Name = "progressBarWork";
            this.progressBarWork.Size = new System.Drawing.Size(672, 23);
            this.progressBarWork.TabIndex = 10;
            // 
            // backgroundWorkerConverter
            // 
            this.backgroundWorkerConverter.WorkerReportsProgress = true;
            this.backgroundWorkerConverter.WorkerSupportsCancellation = true;
            this.backgroundWorkerConverter.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerConverterDoWork);
            this.backgroundWorkerConverter.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerConverterRunWorkerCompleted);
            // 
            // MainGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 432);
            this.Controls.Add(this.progressBarWork);
            this.Controls.Add(this.labelOutputDir);
            this.Controls.Add(this.labelFolderIn);
            this.Controls.Add(this.buttonRun);
            this.Controls.Add(this.dataGridViewFilms);
            this.Controls.Add(this.buttonFolderOut);
            this.Controls.Add(this.buttonOpenFolderIn);
            this.Controls.Add(this.textBoxFolderOut);
            this.Controls.Add(this.textBoxFolderIn);
            this.Controls.Add(this.menuStripMain);
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "MainGui";
            this.Text = "MainGui";
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFilms)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFolderIn;
        private System.Windows.Forms.TextBox textBoxFolderOut;
        private System.Windows.Forms.Button buttonOpenFolderIn;
        private System.Windows.Forms.Button buttonFolderOut;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridViewFilms;
        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label labelFolderIn;
        private System.Windows.Forms.Label labelOutputDir;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogIn;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogOut;
        private System.Windows.Forms.DataGridViewCheckBoxColumn convertVideo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn joinBefore;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn finalName;
        private System.Windows.Forms.ProgressBar progressBarWork;
        private System.ComponentModel.BackgroundWorker backgroundWorkerConverter;
    }
}
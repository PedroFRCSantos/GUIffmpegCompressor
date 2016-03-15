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
            this.openInToolStripOpenIn = new System.Windows.Forms.ToolStripMenuItem();
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
            this.labelDateFormat = new System.Windows.Forms.Label();
            this.labelBaseName = new System.Windows.Forms.Label();
            this.labelFirst = new System.Windows.Forms.Label();
            this.checkBoxName1 = new System.Windows.Forms.CheckBox();
            this.buttonUp1 = new System.Windows.Forms.Button();
            this.textBoxBaseName = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonDown1 = new System.Windows.Forms.Button();
            this.labelSecond = new System.Windows.Forms.Label();
            this.checkBoxName2 = new System.Windows.Forms.CheckBox();
            this.buttonDown2 = new System.Windows.Forms.Button();
            this.buttonUp2 = new System.Windows.Forms.Button();
            this.buttonDown3 = new System.Windows.Forms.Button();
            this.buttonUp3 = new System.Windows.Forms.Button();
            this.checkBoxName3 = new System.Windows.Forms.CheckBox();
            this.labelThird = new System.Windows.Forms.Label();
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
            this.openInToolStripOpenIn,
            this.openOutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openInToolStripOpenIn
            // 
            this.openInToolStripOpenIn.Name = "openInToolStripOpenIn";
            this.openInToolStripOpenIn.Size = new System.Drawing.Size(126, 22);
            this.openInToolStripOpenIn.Text = "Open In";
            this.openInToolStripOpenIn.Click += new System.EventHandler(this.openInToolStripMenuItemClick);
            // 
            // openOutToolStripMenuItem
            // 
            this.openOutToolStripMenuItem.Name = "openOutToolStripMenuItem";
            this.openOutToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.openOutToolStripMenuItem.Text = "Open Out";
            this.openOutToolStripMenuItem.Click += new System.EventHandler(this.openOutToolStripMenuItemClick);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
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
            this.buttonRun.Location = new System.Drawing.Point(289, 469);
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
            // labelDateFormat
            // 
            this.labelDateFormat.AutoSize = true;
            this.labelDateFormat.Location = new System.Drawing.Point(28, 376);
            this.labelDateFormat.Name = "labelDateFormat";
            this.labelDateFormat.Size = new System.Drawing.Size(68, 13);
            this.labelDateFormat.TabIndex = 11;
            this.labelDateFormat.Text = "Date Format:";
            // 
            // labelBaseName
            // 
            this.labelBaseName.AutoSize = true;
            this.labelBaseName.Location = new System.Drawing.Point(28, 405);
            this.labelBaseName.Name = "labelBaseName";
            this.labelBaseName.Size = new System.Drawing.Size(65, 13);
            this.labelBaseName.TabIndex = 12;
            this.labelBaseName.Text = "Base Name:";
            // 
            // labelFirst
            // 
            this.labelFirst.AutoSize = true;
            this.labelFirst.Location = new System.Drawing.Point(286, 376);
            this.labelFirst.Name = "labelFirst";
            this.labelFirst.Size = new System.Drawing.Size(13, 13);
            this.labelFirst.TabIndex = 13;
            this.labelFirst.Text = "1";
            // 
            // checkBoxName1
            // 
            this.checkBoxName1.AutoSize = true;
            this.checkBoxName1.Location = new System.Drawing.Point(308, 376);
            this.checkBoxName1.Name = "checkBoxName1";
            this.checkBoxName1.Size = new System.Drawing.Size(60, 17);
            this.checkBoxName1.TabIndex = 14;
            this.checkBoxName1.Text = "Name1";
            this.checkBoxName1.UseVisualStyleBackColor = true;
            this.checkBoxName1.CheckedChanged += new System.EventHandler(this.checkBoxName1CheckedChanged);
            // 
            // buttonUp1
            // 
            this.buttonUp1.Location = new System.Drawing.Point(418, 376);
            this.buttonUp1.Name = "buttonUp1";
            this.buttonUp1.Size = new System.Drawing.Size(48, 23);
            this.buttonUp1.TabIndex = 15;
            this.buttonUp1.Text = "up";
            this.buttonUp1.UseVisualStyleBackColor = true;
            this.buttonUp1.Click += new System.EventHandler(this.buttonUp1Click);
            // 
            // textBoxBaseName
            // 
            this.textBoxBaseName.Location = new System.Drawing.Point(99, 402);
            this.textBoxBaseName.Name = "textBoxBaseName";
            this.textBoxBaseName.Size = new System.Drawing.Size(136, 20);
            this.textBoxBaseName.TabIndex = 16;
            this.textBoxBaseName.TextChanged += new System.EventHandler(this.textBoxBaseNameTextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(99, 372);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 17;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1SelectedIndexChanged);
            // 
            // buttonDown1
            // 
            this.buttonDown1.Location = new System.Drawing.Point(473, 375);
            this.buttonDown1.Name = "buttonDown1";
            this.buttonDown1.Size = new System.Drawing.Size(46, 23);
            this.buttonDown1.TabIndex = 18;
            this.buttonDown1.Text = "Down";
            this.buttonDown1.UseVisualStyleBackColor = true;
            this.buttonDown1.Click += new System.EventHandler(this.buttonDown1Click);
            // 
            // labelSecond
            // 
            this.labelSecond.AutoSize = true;
            this.labelSecond.Location = new System.Drawing.Point(286, 408);
            this.labelSecond.Name = "labelSecond";
            this.labelSecond.Size = new System.Drawing.Size(13, 13);
            this.labelSecond.TabIndex = 19;
            this.labelSecond.Text = "2";
            // 
            // checkBoxName2
            // 
            this.checkBoxName2.AutoSize = true;
            this.checkBoxName2.Location = new System.Drawing.Point(308, 408);
            this.checkBoxName2.Name = "checkBoxName2";
            this.checkBoxName2.Size = new System.Drawing.Size(60, 17);
            this.checkBoxName2.TabIndex = 20;
            this.checkBoxName2.Text = "Name2";
            this.checkBoxName2.UseVisualStyleBackColor = true;
            this.checkBoxName2.CheckedChanged += new System.EventHandler(this.checkBoxName2CheckedChanged);
            // 
            // buttonDown2
            // 
            this.buttonDown2.Location = new System.Drawing.Point(473, 404);
            this.buttonDown2.Name = "buttonDown2";
            this.buttonDown2.Size = new System.Drawing.Size(46, 23);
            this.buttonDown2.TabIndex = 22;
            this.buttonDown2.Text = "Down";
            this.buttonDown2.UseVisualStyleBackColor = true;
            this.buttonDown2.Click += new System.EventHandler(this.buttonDown2Click);
            // 
            // buttonUp2
            // 
            this.buttonUp2.Location = new System.Drawing.Point(418, 405);
            this.buttonUp2.Name = "buttonUp2";
            this.buttonUp2.Size = new System.Drawing.Size(48, 23);
            this.buttonUp2.TabIndex = 21;
            this.buttonUp2.Text = "up";
            this.buttonUp2.UseVisualStyleBackColor = true;
            this.buttonUp2.Click += new System.EventHandler(this.buttonUp2Click);
            // 
            // buttonDown3
            // 
            this.buttonDown3.Location = new System.Drawing.Point(473, 433);
            this.buttonDown3.Name = "buttonDown3";
            this.buttonDown3.Size = new System.Drawing.Size(46, 23);
            this.buttonDown3.TabIndex = 26;
            this.buttonDown3.Text = "Down";
            this.buttonDown3.UseVisualStyleBackColor = true;
            this.buttonDown3.Click += new System.EventHandler(this.buttonDown3Click);
            // 
            // buttonUp3
            // 
            this.buttonUp3.Location = new System.Drawing.Point(418, 434);
            this.buttonUp3.Name = "buttonUp3";
            this.buttonUp3.Size = new System.Drawing.Size(48, 23);
            this.buttonUp3.TabIndex = 25;
            this.buttonUp3.Text = "up";
            this.buttonUp3.UseVisualStyleBackColor = true;
            this.buttonUp3.Click += new System.EventHandler(this.buttonUp3Click);
            // 
            // checkBoxName3
            // 
            this.checkBoxName3.AutoSize = true;
            this.checkBoxName3.Location = new System.Drawing.Point(308, 437);
            this.checkBoxName3.Name = "checkBoxName3";
            this.checkBoxName3.Size = new System.Drawing.Size(60, 17);
            this.checkBoxName3.TabIndex = 24;
            this.checkBoxName3.Text = "Name2";
            this.checkBoxName3.UseVisualStyleBackColor = true;
            this.checkBoxName3.CheckedChanged += new System.EventHandler(this.checkBoxName3CheckedChanged);
            // 
            // labelThird
            // 
            this.labelThird.AutoSize = true;
            this.labelThird.Location = new System.Drawing.Point(286, 437);
            this.labelThird.Name = "labelThird";
            this.labelThird.Size = new System.Drawing.Size(13, 13);
            this.labelThird.TabIndex = 23;
            this.labelThird.Text = "2";
            // 
            // MainGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 519);
            this.Controls.Add(this.buttonDown3);
            this.Controls.Add(this.buttonUp3);
            this.Controls.Add(this.checkBoxName3);
            this.Controls.Add(this.labelThird);
            this.Controls.Add(this.buttonDown2);
            this.Controls.Add(this.buttonUp2);
            this.Controls.Add(this.checkBoxName2);
            this.Controls.Add(this.labelSecond);
            this.Controls.Add(this.buttonDown1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBoxBaseName);
            this.Controls.Add(this.buttonUp1);
            this.Controls.Add(this.checkBoxName1);
            this.Controls.Add(this.labelFirst);
            this.Controls.Add(this.labelBaseName);
            this.Controls.Add(this.labelDateFormat);
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
        private System.Windows.Forms.ToolStripMenuItem openInToolStripOpenIn;
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
        private System.Windows.Forms.Label labelDateFormat;
        private System.Windows.Forms.Label labelBaseName;
        private System.Windows.Forms.Label labelFirst;
        private System.Windows.Forms.CheckBox checkBoxName1;
        private System.Windows.Forms.Button buttonUp1;
        private System.Windows.Forms.TextBox textBoxBaseName;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonDown1;
        private System.Windows.Forms.Label labelSecond;
        private System.Windows.Forms.CheckBox checkBoxName2;
        private System.Windows.Forms.Button buttonDown2;
        private System.Windows.Forms.Button buttonUp2;
        private System.Windows.Forms.Button buttonDown3;
        private System.Windows.Forms.Button buttonUp3;
        private System.Windows.Forms.CheckBox checkBoxName3;
        private System.Windows.Forms.Label labelThird;
    }
}
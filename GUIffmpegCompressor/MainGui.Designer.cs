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
            this.tableLayoutPanelListOfVideos = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxFolderIn
            // 
            this.textBoxFolderIn.Location = new System.Drawing.Point(12, 27);
            this.textBoxFolderIn.Name = "textBoxFolderIn";
            this.textBoxFolderIn.Size = new System.Drawing.Size(591, 20);
            this.textBoxFolderIn.TabIndex = 0;
            // 
            // textBoxFolderOut
            // 
            this.textBoxFolderOut.Location = new System.Drawing.Point(12, 81);
            this.textBoxFolderOut.Name = "textBoxFolderOut";
            this.textBoxFolderOut.Size = new System.Drawing.Size(591, 20);
            this.textBoxFolderOut.TabIndex = 1;
            // 
            // buttonOpenFolderIn
            // 
            this.buttonOpenFolderIn.Location = new System.Drawing.Point(609, 25);
            this.buttonOpenFolderIn.Name = "buttonOpenFolderIn";
            this.buttonOpenFolderIn.Size = new System.Drawing.Size(75, 23);
            this.buttonOpenFolderIn.TabIndex = 2;
            this.buttonOpenFolderIn.Text = "button1";
            this.buttonOpenFolderIn.UseVisualStyleBackColor = true;
            // 
            // buttonFolderOut
            // 
            this.buttonFolderOut.Location = new System.Drawing.Point(609, 78);
            this.buttonFolderOut.Name = "buttonFolderOut";
            this.buttonFolderOut.Size = new System.Drawing.Size(75, 23);
            this.buttonFolderOut.TabIndex = 3;
            this.buttonFolderOut.Text = "button1";
            this.buttonFolderOut.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelListOfVideos
            // 
            this.tableLayoutPanelListOfVideos.ColumnCount = 2;
            this.tableLayoutPanelListOfVideos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelListOfVideos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelListOfVideos.Location = new System.Drawing.Point(12, 118);
            this.tableLayoutPanelListOfVideos.Name = "tableLayoutPanelListOfVideos";
            this.tableLayoutPanelListOfVideos.RowCount = 2;
            this.tableLayoutPanelListOfVideos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelListOfVideos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelListOfVideos.Size = new System.Drawing.Size(672, 82);
            this.tableLayoutPanelListOfVideos.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(696, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openInToolStripMenuItem,
            this.openOutToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openInToolStripMenuItem
            // 
            this.openInToolStripMenuItem.Name = "openInToolStripMenuItem";
            this.openInToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openInToolStripMenuItem.Text = "Open In";
            // 
            // openOutToolStripMenuItem
            // 
            this.openOutToolStripMenuItem.Name = "openOutToolStripMenuItem";
            this.openOutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openOutToolStripMenuItem.Text = "Open Out";
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
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // MainGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 382);
            this.Controls.Add(this.tableLayoutPanelListOfVideos);
            this.Controls.Add(this.buttonFolderOut);
            this.Controls.Add(this.buttonOpenFolderIn);
            this.Controls.Add(this.textBoxFolderOut);
            this.Controls.Add(this.textBoxFolderIn);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainGui";
            this.Text = "MainGui";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFolderIn;
        private System.Windows.Forms.TextBox textBoxFolderOut;
        private System.Windows.Forms.Button buttonOpenFolderIn;
        private System.Windows.Forms.Button buttonFolderOut;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelListOfVideos;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}
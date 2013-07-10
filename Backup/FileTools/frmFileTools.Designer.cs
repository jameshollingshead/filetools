namespace FileTools
{
    partial class FileTools
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileTools));
            this.fileTree = new System.Windows.Forms.TreeView();
            this.treeImages = new System.Windows.Forms.ImageList(this.components);
            this.prependBtn = new System.Windows.Forms.Button();
            this.prependTxt = new System.Windows.Forms.TextBox();
            this.prependLbl = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renameBox = new System.Windows.Forms.GroupBox();
            this.renamerBtn = new System.Windows.Forms.Button();
            this.replaceLbl = new System.Windows.Forms.Label();
            this.findLbl = new System.Windows.Forms.Label();
            this.replaceTxt = new System.Windows.Forms.TextBox();
            this.findTxt = new System.Windows.Forms.TextBox();
            this.sorterBox = new System.Windows.Forms.GroupBox();
            this.sortBtn = new System.Windows.Forms.Button();
            this.sortLbl = new System.Windows.Forms.Label();
            this.prependBox = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.renameBox.SuspendLayout();
            this.sorterBox.SuspendLayout();
            this.prependBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileTree
            // 
            this.fileTree.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.fileTree.HideSelection = false;
            this.fileTree.ImageIndex = 0;
            this.fileTree.ImageList = this.treeImages;
            this.fileTree.Location = new System.Drawing.Point(12, 27);
            this.fileTree.Name = "fileTree";
            this.fileTree.SelectedImageIndex = 0;
            this.fileTree.Size = new System.Drawing.Size(245, 442);
            this.fileTree.TabIndex = 0;
            this.fileTree.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.fileTree_BeforeExpand);
            // 
            // treeImages
            // 
            this.treeImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("treeImages.ImageStream")));
            this.treeImages.TransparentColor = System.Drawing.Color.Transparent;
            this.treeImages.Images.SetKeyName(0, "drive.png");
            this.treeImages.Images.SetKeyName(1, "drive_cd.png");
            this.treeImages.Images.SetKeyName(2, "drive_floppy.png");
            this.treeImages.Images.SetKeyName(3, "folder.png");
            this.treeImages.Images.SetKeyName(4, "drive_network.png");
            this.treeImages.Images.SetKeyName(5, "drive_error.png");
            this.treeImages.Images.SetKeyName(6, "computer.png");
            this.treeImages.Images.SetKeyName(7, "folder_open.png");
            // 
            // prependBtn
            // 
            this.prependBtn.Location = new System.Drawing.Point(437, 64);
            this.prependBtn.Name = "prependBtn";
            this.prependBtn.Size = new System.Drawing.Size(75, 23);
            this.prependBtn.TabIndex = 2;
            this.prependBtn.Text = "OK";
            this.prependBtn.UseVisualStyleBackColor = true;
            this.prependBtn.Click += new System.EventHandler(this.prependBtn_Click);
            // 
            // prependTxt
            // 
            this.prependTxt.Location = new System.Drawing.Point(166, 24);
            this.prependTxt.Name = "prependTxt";
            this.prependTxt.Size = new System.Drawing.Size(344, 20);
            this.prependTxt.TabIndex = 1;
            // 
            // prependLbl
            // 
            this.prependLbl.AutoSize = true;
            this.prependLbl.Location = new System.Drawing.Point(6, 31);
            this.prependLbl.Name = "prependLbl";
            this.prependLbl.Size = new System.Drawing.Size(141, 13);
            this.prependLbl.TabIndex = 0;
            this.prependLbl.Text = "Prepend This To File Names";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(873, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // renameBox
            // 
            this.renameBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.renameBox.Controls.Add(this.renamerBtn);
            this.renameBox.Controls.Add(this.replaceLbl);
            this.renameBox.Controls.Add(this.findLbl);
            this.renameBox.Controls.Add(this.replaceTxt);
            this.renameBox.Controls.Add(this.findTxt);
            this.renameBox.Location = new System.Drawing.Point(275, 41);
            this.renameBox.Name = "renameBox";
            this.renameBox.Size = new System.Drawing.Size(593, 146);
            this.renameBox.TabIndex = 5;
            this.renameBox.TabStop = false;
            this.renameBox.Text = "Renamer";
            // 
            // renamerBtn
            // 
            this.renamerBtn.Location = new System.Drawing.Point(437, 110);
            this.renamerBtn.Name = "renamerBtn";
            this.renamerBtn.Size = new System.Drawing.Size(75, 23);
            this.renamerBtn.TabIndex = 4;
            this.renamerBtn.Text = "OK";
            this.renamerBtn.UseVisualStyleBackColor = true;
            this.renamerBtn.Click += new System.EventHandler(this.renamerBtn_Click);
            // 
            // replaceLbl
            // 
            this.replaceLbl.AutoSize = true;
            this.replaceLbl.Location = new System.Drawing.Point(8, 76);
            this.replaceLbl.Name = "replaceLbl";
            this.replaceLbl.Size = new System.Drawing.Size(119, 13);
            this.replaceLbl.TabIndex = 3;
            this.replaceLbl.Text = "Replace With This Text";
            // 
            // findLbl
            // 
            this.findLbl.AutoSize = true;
            this.findLbl.Location = new System.Drawing.Point(8, 41);
            this.findLbl.Name = "findLbl";
            this.findLbl.Size = new System.Drawing.Size(74, 13);
            this.findLbl.TabIndex = 2;
            this.findLbl.Text = "Find This Text";
            // 
            // replaceTxt
            // 
            this.replaceTxt.Location = new System.Drawing.Point(150, 73);
            this.replaceTxt.Name = "replaceTxt";
            this.replaceTxt.Size = new System.Drawing.Size(362, 20);
            this.replaceTxt.TabIndex = 1;
            // 
            // findTxt
            // 
            this.findTxt.Location = new System.Drawing.Point(150, 38);
            this.findTxt.Name = "findTxt";
            this.findTxt.Size = new System.Drawing.Size(362, 20);
            this.findTxt.TabIndex = 0;
            // 
            // sorterBox
            // 
            this.sorterBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.sorterBox.Controls.Add(this.sortBtn);
            this.sorterBox.Controls.Add(this.sortLbl);
            this.sorterBox.Location = new System.Drawing.Point(275, 213);
            this.sorterBox.Name = "sorterBox";
            this.sorterBox.Size = new System.Drawing.Size(594, 91);
            this.sorterBox.TabIndex = 6;
            this.sorterBox.TabStop = false;
            this.sorterBox.Text = "Sorter";
            // 
            // sortBtn
            // 
            this.sortBtn.Location = new System.Drawing.Point(437, 43);
            this.sortBtn.Name = "sortBtn";
            this.sortBtn.Size = new System.Drawing.Size(75, 23);
            this.sortBtn.TabIndex = 0;
            this.sortBtn.Text = "OK";
            this.sortBtn.UseVisualStyleBackColor = true;
            this.sortBtn.Click += new System.EventHandler(this.sortBtn_Click);
            // 
            // sortLbl
            // 
            this.sortLbl.AutoSize = true;
            this.sortLbl.Location = new System.Drawing.Point(6, 30);
            this.sortLbl.Name = "sortLbl";
            this.sortLbl.Size = new System.Drawing.Size(222, 13);
            this.sortLbl.TabIndex = 1;
            this.sortLbl.Text = "Sort Files Into Alphabetic Directories by Name";
            // 
            // prependBox
            // 
            this.prependBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.prependBox.Controls.Add(this.prependBtn);
            this.prependBox.Controls.Add(this.prependTxt);
            this.prependBox.Controls.Add(this.prependLbl);
            this.prependBox.Location = new System.Drawing.Point(275, 327);
            this.prependBox.Name = "prependBox";
            this.prependBox.Size = new System.Drawing.Size(593, 131);
            this.prependBox.TabIndex = 7;
            this.prependBox.TabStop = false;
            this.prependBox.Text = "Prepend";
            // 
            // FileTools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 495);
            this.Controls.Add(this.prependBox);
            this.Controls.Add(this.sorterBox);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.renameBox);
            this.Controls.Add(this.fileTree);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FileTools";
            this.Text = "File Tools";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.renameBox.ResumeLayout(false);
            this.renameBox.PerformLayout();
            this.sorterBox.ResumeLayout(false);
            this.sorterBox.PerformLayout();
            this.prependBox.ResumeLayout(false);
            this.prependBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView fileTree;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Button prependBtn;
        private System.Windows.Forms.TextBox prependTxt;
        private System.Windows.Forms.Label prependLbl;
        private System.Windows.Forms.GroupBox sorterBox;
        private System.Windows.Forms.Button sortBtn;
        private System.Windows.Forms.Label sortLbl;
        private System.Windows.Forms.GroupBox renameBox;
        private System.Windows.Forms.Button renamerBtn;
        private System.Windows.Forms.Label replaceLbl;
        private System.Windows.Forms.Label findLbl;
        private System.Windows.Forms.TextBox replaceTxt;
        private System.Windows.Forms.TextBox findTxt;
        private System.Windows.Forms.GroupBox prependBox;
        private System.Windows.Forms.ImageList treeImages;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Net;
using System.Management;


namespace FileTools
{
    public partial class FileTools : Form
    {
        enum folderTypes {FixedDrive, CDRom, Removeable, FolderClosed, Network, Other, MyComputer, FolderOpen};

        public FileTools()
        {
            InitializeComponent();

            CreateRootNode();

            AddDrivesToTree();

            fileTree.Nodes[0].Expand();
        }

        private void AddDrivesToTree()
        {
            int driveType;

            //Add logical Drives to the tree
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo d in drives)
            {

                TreeNode n = new TreeNode();
                n.Name = d.Name.ToString();
                n.Text = d.Name.ToString();
                n.Tag = d.Name.ToString();

                //Determine type of all attached drives and assign the appropriate images to the tree nodes
                driveType = GetDriveType(d);
                n.ImageIndex = driveType;
                n.SelectedImageIndex = driveType;
                
                AddPlaceholderForSubFolders(d, n);

                fileTree.Nodes[0].Nodes.Add(n);

            }
        }

        private static void AddPlaceholderForSubFolders(DriveInfo d, TreeNode n)
        {
            DirectoryInfo folder = new DirectoryInfo(d.Name.ToString());

            if (folder.Exists)
            {
                //If the drive has sub folders, add a placeholder node so you can expand the folder
                //string[] subFolders = Directory.GetDirectories(drives[i]);
                string[] subFolders = Directory.GetDirectories(d.Name.ToString());
                if (subFolders.Length > 0)
                {
                    n.Nodes.Add("PLACEHOLDER");
                }
            }
        }

        private void CreateRootNode()
        {
            //Create root node (MyComputer) for file tree and add it to the file tree
            TreeNode rootNode = new TreeNode();
            rootNode.Name = "rootNode";
            rootNode.Text = "My Computer";
            rootNode.ImageIndex = (int)folderTypes.MyComputer;
            rootNode.SelectedImageIndex = (int)folderTypes.MyComputer;
            this.fileTree.Nodes.Add(rootNode);
        }

        private static int GetDriveType(DriveInfo d)
        {

            int driveType;
            
            //Determine drive type and add appropriate icon to tree node
            if (d.DriveType == DriveType.Fixed)
            {
                driveType = (int)folderTypes.FixedDrive;                
            }
            else if (d.DriveType == DriveType.CDRom)
            {
                driveType = (int)folderTypes.CDRom;
            }
            else if (d.DriveType == DriveType.Removable)
            {
                driveType = (int)folderTypes.Removeable;
            }
            else if (d.DriveType == DriveType.Network)
            {
                driveType = (int)folderTypes.Network;
            }
            else
            {
                driveType = (int)folderTypes.Other;
            }

            return driveType;
        }

        
        private void fileTree_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            string pathInfo;
            
            //clear out the placeholder node if expanding node is not the tree's root
            if (e.Node.Text.ToString() != fileTree.Nodes[0].Text.ToString())
            {
                pathInfo = e.Node.Tag.ToString();
                e.Node.Nodes.Clear();
            }
            else
            {
                pathInfo = null;
            }

            if (pathInfo != null)
            {

                string[] newSubs = Directory.GetDirectories(pathInfo);

                if (newSubs.Length > 0)
                {
                    for (int k = 0; k < newSubs.Length; k++)
                    {
                        //Only get the non-hidden folders and non-system folders
                        //TODO: Find out why C:\PerfLogs denies access in Win7 or at least some flag 
                        //that it uses so I don't have to have the string hard-coded into the program
                        bool isHidden = ((File.GetAttributes(newSubs[k]) & FileAttributes.Hidden) == 
                            FileAttributes.Hidden);
                        bool isSystem = ((File.GetAttributes(newSubs[k]) & FileAttributes.System) ==
                            FileAttributes.System);
                        if(!isHidden && !newSubs[k].Contains("PerfLogs") && !isSystem)
                        {

                            TreeNode subNode = new TreeNode();
                            subNode.Name = newSubs[k];
                            string[] tokenPath = newSubs[k].Split(Path.DirectorySeparatorChar);
                            subNode.Text = tokenPath[tokenPath.Length-1];
                            subNode.Tag = newSubs[k];
                            subNode.ImageIndex = (int)folderTypes.FolderClosed;
                            subNode.SelectedImageIndex = (int)folderTypes.FolderOpen;

                            DirectoryInfo folder = new DirectoryInfo(newSubs[k]);
                            if (folder.Exists)
                            {
                                try
                                {
                                    string[] subFolders = Directory.GetDirectories(newSubs[k]);
                                    if (subFolders.Length > 0)
                                    {
                                        subNode.Nodes.Add("PLACEHOLDER");
                                    }
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Error: " + ex.Message);
                                }
                            }

                            
                            e.Node.Nodes.Add(subNode);
                        }

                    }
                }

            }
        }

        private void sortBtn_Click(object sender, EventArgs e)
        {
            string pathInfo = fileTree.SelectedNode.Tag.ToString();

            if (HelperFuncs.ConfirmMove(pathInfo))
            {

                //Create the directories to sort the files into
                CreateLetterAndNumberDirectories(pathInfo);
             
                //Add a placeholder node to the tree so it can be expanded
                fileTree.SelectedNode.Nodes.Add("PLACEHOLDER");

                //Move the files into the appropriate directory
                SortFilesIntoDirectoriesByFirstCharacter(pathInfo);
            }
        }

        private static void SortFilesIntoDirectoriesByFirstCharacter(string pathInfo)
        {
            try
            {
                //get the files
                string[] fileList = Directory.GetFiles(pathInfo);

                //Toss the files into directories
                for (int i = 0; i < fileList.Length; i++)
                {
                    string[] fileName = fileList[i].Split(Path.DirectorySeparatorChar);
                    string moveDir = pathInfo + Path.DirectorySeparatorChar + fileName[fileName.Length - 1].Substring(0, 1).ToUpper();
                    HelperFuncs.MoveFiles(fileList[i], moveDir, fileName[fileName.Length - 1]);
                }
            }
            catch (Exception ex2)
            {
                MessageBox.Show("Error: " + ex2.Message);
            }
        }

        private static void CreateLetterAndNumberDirectories(string pathInfo)
        {
            try
            {
                string dir = pathInfo + Path.DirectorySeparatorChar + "0-9";
                DirectoryInfo dirInfo = new DirectoryInfo(dir);
                if (!dirInfo.Exists)
                {
                    Directory.CreateDirectory(dir);
                }
                for (char letter = 'A'; letter <= 'Z'; letter++)
                {
                    dir = pathInfo + Path.DirectorySeparatorChar + letter.ToString();
                    dirInfo = new DirectoryInfo(dir);
                    if (!dirInfo.Exists)
                    {
                        Directory.CreateDirectory(dir);
                    }
                    Directory.CreateDirectory(dir);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void renamerBtn_Click(object sender, EventArgs e)
        {
            string pathInfo = fileTree.SelectedNode.Tag.ToString();

            try
            {
                string[] fileList = Directory.GetFiles(pathInfo);

                if (HelperFuncs.ConfirmMove(pathInfo))
                {
                    for (int i = 0; i < fileList.Length; i++)
                    {
                        string destFile;
                        string[] srcChkFile = fileList[i].Split(Path.DirectorySeparatorChar);
                        if (srcChkFile[srcChkFile.Length - 1].Contains(findTxt.Text.ToString()))
                        {
                            destFile = srcChkFile[srcChkFile.Length - 1].Replace(findTxt.Text.ToString(), replaceTxt.Text.ToString());
                            HelperFuncs.MoveFiles(fileList[i], pathInfo, destFile);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void prependBtn_Click(object sender, EventArgs e)
        {
            string pathInfo = fileTree.SelectedNode.Tag.ToString();

            try
            {

                string[] fileList = Directory.GetFiles(pathInfo);

                if (HelperFuncs.ConfirmMove(pathInfo))
                {
                    for (int i = 0; i < fileList.Length; i++)
                    {

                        string destFile;
                        string[] fileToRename = fileList[i].Split(Path.DirectorySeparatorChar);

                        destFile = prependTxt.Text.ToString() + fileToRename[fileToRename.Length - 1].ToString();

                        HelperFuncs.MoveFiles(fileList[i], pathInfo, destFile);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout about = new frmAbout();
            about.Show();
        }

        

    }
}

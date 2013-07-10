using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace FileTools
{
    

    public static class HelperFuncs
    {
        //Used to move/rename the files so the code is not repeated in event items
        public static void MoveFiles(string srcFile, string destPath, string destFile)
        {
            try
            {
                File.Move(srcFile, destPath + Path.DirectorySeparatorChar + destFile);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        //confirm that the user wants to move/rename the files
        //this should cut down on instances of bad commands being issued
        public static bool ConfirmMove(string dir)
        {
            try
            {
                string[] fileList = Directory.GetFiles(dir);
                DialogResult answer = MessageBox.Show(dir + " contains " + fileList.Length + " files. Continue?", "Warning", MessageBoxButtons.OKCancel);
                if(answer == DialogResult.OK)
                    return(true);
                else
                    return(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return (false);
            }
        }

        //This just grabs all of the directory flags and outputs them to a messagebox
        //It is here for diagnostic purposes
        public static void GetDirFlags(string dir)
        {
            if (dir != null)
            {
                bool isArchive = ((File.GetAttributes(dir) & FileAttributes.Archive) ==
                    FileAttributes.Archive);
                bool isCompressed = ((File.GetAttributes(dir) & FileAttributes.Compressed) ==
                    FileAttributes.Compressed);
                bool isDevice = ((File.GetAttributes(dir) & FileAttributes.Device) ==
                    FileAttributes.Device);
                bool isDirectory = ((File.GetAttributes(dir) & FileAttributes.Directory) ==
                    FileAttributes.Directory);
                bool isEncrypted = ((File.GetAttributes(dir) & FileAttributes.Encrypted) ==
                    FileAttributes.Encrypted);
                bool isHidden = ((File.GetAttributes(dir) & FileAttributes.Hidden) ==
                    FileAttributes.Hidden);
                bool isNormal = ((File.GetAttributes(dir) & FileAttributes.Normal) ==
                    FileAttributes.Normal);
                bool isNotContentIndexed = ((File.GetAttributes(dir) & FileAttributes.NotContentIndexed) ==
                    FileAttributes.NotContentIndexed);
                bool isOffline = ((File.GetAttributes(dir) & FileAttributes.Offline) ==
                    FileAttributes.Offline);
                bool isReadOnly = ((File.GetAttributes(dir) & FileAttributes.ReadOnly) ==
                    FileAttributes.ReadOnly);
                bool isReparsePoint = ((File.GetAttributes(dir) & FileAttributes.ReparsePoint) ==
                    FileAttributes.ReparsePoint);
                bool isSparseFile = ((File.GetAttributes(dir) & FileAttributes.SparseFile) ==
                    FileAttributes.SparseFile);
                bool isSystem = ((File.GetAttributes(dir) & FileAttributes.System) ==
                    FileAttributes.System);
                bool isTemporary = ((File.GetAttributes(dir) & FileAttributes.Temporary) ==
                    FileAttributes.Temporary);

                MessageBox.Show("List of flags and values:\r\n" +
                    "Archive - " + isArchive + "\r\n" +
                    "Compressed - " + isCompressed + "\r\n" +
                    "Device - " + isDevice + "\r\n" +
                    "Directory - " + isDirectory + "\r\n" +
                    "Encrypted - " + isEncrypted + "\r\n" +
                    "Hidden - " + isHidden + "\r\n" +
                    "Normal - " + isNormal + "\r\n" +
                    "Not Content Indexed - " + isNotContentIndexed + "\r\n" +
                    "Offline - " + isOffline + "\r\n" +
                    "Read Only - " + isReadOnly + "\r\n" +
                    "Reparse Point - " + isReparsePoint + "\r\n" +
                    "Sparse File - " + isSparseFile + "\r\n" +
                    "System - " + isSystem + "\r\n" +
                    "Temporary - " + isTemporary);

            }
        }

    }
}

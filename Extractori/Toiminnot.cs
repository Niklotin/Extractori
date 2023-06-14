using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Windows.Forms;

namespace Extractori.toiminnot
{
    public class Toiminnot
    {
        private static String defaultPath = "C:\\";
        public static String outputPath = "C:\\";
        public static List<String> files = new List<String>();

        /**
         * Opens the file dialog and sets the options for the dialog
         **/
        public static void OpenFileDialog()
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.InitialDirectory = defaultPath;
            openFile.Filter = "Zip and RAR files | *.zip;*.rar";
            openFile.FilterIndex = 1;
            openFile.RestoreDirectory = true;
            openFile.Multiselect = true;

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                defaultPath = openFile.FileName.Replace(openFile.SafeFileName, "");
                foreach (String path in openFile.FileNames)
                {
                    if (files.Contains(path))
                    {
                        continue;
                    }

                    files.Add(path);
                }
            }
        }

        /**
         * Opens up the output dialog and sets the options for the dialog
         * */

        public static void OpenOutputDialog()
        {
            OpenFileDialog openOutput = new OpenFileDialog();
            openOutput.ValidateNames = false;
            openOutput.CheckFileExists = false;
            openOutput.FileName = "Folder Selection";

            if (openOutput.ShowDialog() == DialogResult.OK)
            {
                outputPath = Path.GetDirectoryName(openOutput.FileName);
            }

        }

        /**
         * Extracts the files added into the system
         * */

        public static void ExtractFiles()
        {

            foreach (String path in files)
            {
                using (ZipArchive directory = ZipFile.OpenRead(path))
                {
                    ZipFile.ExtractToDirectory(path, outputPath, true);

                }

            }

        }
    }
}

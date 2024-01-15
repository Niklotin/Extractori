using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Text;
using System.Windows.Forms;


namespace Extractori.toiminnot
{
    public class Toiminnot
    {
        private static String defaultPath = " ";
        private static String outputPath = " ";
        private static String[] defaultPaths = { "", "" };
        private static String dataFile = "paths.dat";
        public static List<String> files = new List<String>();

        public static void InitalizeFilePaths()
        {
            if (!File.Exists(dataFile))
            {

                using (File.Create(dataFile)) { }
                
            }if (File.ReadAllLines(dataFile).Length != 2)
            {
                File.WriteAllLines(dataFile, defaultPaths);
            }
            else
            {
                defaultPaths = File.ReadAllLines(dataFile);
                defaultPath = defaultPaths[0];
                outputPath = defaultPaths[1];
            }
        }

        public static string getOutputPath()
        {
            return outputPath;
        }

        /**
         * Opens the file dialog and sets the options for the dialog
         **/
        public static void OpenFileDialog()
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.InitialDirectory = defaultPaths[0];
            openFile.Filter = "Zip and RAR files | *.zip;*.rar";
            openFile.FilterIndex = 1;
            openFile.RestoreDirectory = true;
            openFile.Multiselect = true;

            if (openFile.ShowDialog() == DialogResult.OK)
            {
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
            openOutput.InitialDirectory = $@"{defaultPaths[1]}";
            openOutput.RestoreDirectory = false;
            openOutput.ValidateNames = false;
            openOutput.CheckFileExists = false;
            openOutput.FileName = "Folder Selection";

            if (openOutput.ShowDialog() == DialogResult.OK)
            {
                outputPath = Path.GetDirectoryName(openOutput.FileName);
            }

        }
        /**
         * Sets the default outputpath, its kind of a hack because winforms default folder selection is straight ass, all these use a file selection instead, may lead to
         * frustration if you don't know how to use it, but i gag everytime i see the default folder selection so w/e
         **/
        public static void setOutputPath()
        {
            OpenFileDialog newOutput = new OpenFileDialog();
            newOutput.ValidateNames = false;
            newOutput.CheckFileExists= false;
            newOutput.FileName = "Folder Selcetion";

            if (newOutput.ShowDialog() == DialogResult.OK)
            {
                defaultPaths[1] = Path.GetDirectoryName (newOutput.FileName);
                File.WriteAllLines(dataFile, defaultPaths);
                InitalizeFilePaths();
            }
        }

        /**
         * Sets the default input path
         **/
        public static void setInputPath()
        {
            OpenFileDialog newOutput = new OpenFileDialog();
            newOutput.ValidateNames = false;
            newOutput.CheckFileExists = false;
            newOutput.FileName = "Folder Selection";

            if (newOutput.ShowDialog() == DialogResult.OK)
            {
                defaultPaths[0] = Path.GetDirectoryName(newOutput.FileName);
                File.WriteAllLines(dataFile, defaultPaths);
                InitalizeFilePaths();
            }

        }


        /**
         * Delegate and event for updating the progressbar
         **/
        public delegate void UpdateProgressBarDelegate(int value, int maxValue);
        public static event UpdateProgressBarDelegate OnUpdateProgressBar;

        /**
         * Extracts the files added into the system
         * Counts the progressbar values and updates them
         **/
        public static void ExtractFiles()
        {

            int totalFiles = files.Count;
            int extractedFiles = 0;

            foreach (String path in files)
            {
                using (ZipArchive directory = ZipFile.OpenRead(path))
                {
                    ZipFile.ExtractToDirectory(path, outputPath, true);
                }
                extractedFiles++;
                int progressValue = (int)((float)extractedFiles / totalFiles * 100);
                OnUpdateProgressBar?.Invoke(progressValue, 100);

            }

        }
    }
}

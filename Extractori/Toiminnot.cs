using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Windows.Forms;

namespace Extractori.toiminnot
{
    class Toiminnot
    {
        private static String defaultPath = "C:\\";
        public static String outputPath = "C:\\";
        public static List<String> fileet = new List<String>();
        public static void AvaaFileDialog()
        {
            OpenFileDialog avaaTiedosto = new OpenFileDialog();
            avaaTiedosto.InitialDirectory = defaultPath;
            avaaTiedosto.Filter = "Zip ja RAR tiedostoja | *.zip;*.rar";
            avaaTiedosto.FilterIndex = 1;
            avaaTiedosto.RestoreDirectory = true;
            avaaTiedosto.Multiselect = true;

            if (avaaTiedosto.ShowDialog() == DialogResult.OK)
            {
                String selectedFileName = avaaTiedosto.FileNames[0];
                defaultPath = avaaTiedosto.FileName.Replace(avaaTiedosto.SafeFileName, "");
                foreach (String path in avaaTiedosto.FileNames)
                {
                    if (fileet.Contains(path))
                    {
                        continue;
                    }

                    fileet.Add(path);
                }
            }
        }

        public static void AvaaOutputDialog()
        {
            OpenFileDialog avaaOutput = new OpenFileDialog();
            avaaOutput.ValidateNames = false;
            avaaOutput.CheckFileExists = false;
            avaaOutput.FileName = "Folder Selection";
            
            if(avaaOutput.ShowDialog() == DialogResult.OK)
            {
                outputPath = Path.GetDirectoryName(avaaOutput.FileName);
            }

        }

        public static void PuraTiedostot()
        {
         
            foreach(String path in fileet)
            {

                using (ZipArchive hakemisto = ZipFile.OpenRead(path))
                {
                    foreach (var entry in hakemisto.Entries)
                    {
                        int prog = hakemisto.Entries.Count;
                        
                        
                        String kansio = $@"{outputPath}\{entry}";
                        if(Directory.Exists(kansio))
                        {
                            Directory.Delete(kansio, true);
                        }
                    }

                    ZipFile.ExtractToDirectory(path, outputPath);
                }

            }
            
        }

    }
}

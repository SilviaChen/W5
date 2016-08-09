using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;
using System.IO;

namespace W5
{

    class Program
    {


        static void Main(string[] args)
        {

            //15-57 lines copy file 
            /*
            string sourcePath = @"C:\TestFolder";
            string targetPath = @"C:\TestFolder\subDir";
            string fileName = "test.txt";

            //Use path class to mainpulate file and directory paths.
            string sourceFile = System.IO.Path.Combine(sourcePath, fileName);
            string destFile = System.IO.Path.Combine(targetPath, fileName);

            //To copy a folder's contents to a new location:
            //Create a new target folder, if necessary.
            if (!System.IO.Directory.Exists(targetPath))
            {
                System.IO.Directory.CreateDirectory(targetPath);
            }

            //To copy a file to another location and 
            //overwrite the destination file if it already exists.
            System.IO.File.Copy(sourceFile, destFile, true);


            if (System.IO.Directory.Exists(sourcePath))
            {
                string[] files = System.IO.Directory.GetFiles(sourcePath);

                //This folder is too small so that we won't have time to see the progress dialog box.
                //FileSystem.CopyDirectory(sourcePath, targetPath, UIOption.AllDialogs);

                //Copy the files and overwrite destination files if they already exist.
                foreach (string s in files)
                {
                    //Use static Path methods to extract only the file name from the path. 
                    fileName = System.IO.Path.GetFileName(s);
                    destFile = System.IO.Path.Combine(targetPath, fileName);
                    System.IO.File.Copy(s, destFile, true);
                }

            }
            else
            {
                Console.WriteLine("Source path does not exists.");
            }
           */
            DirectoryInfo dir = new DirectoryInfo(System.AppDomain.CurrentDomain.BaseDirectory);

            if (!File.Exists(dir.Parent.FullName + @"..\..\..\TestFolder\test.txt"))
            {
                File.Create(dir.Parent.FullName + @"..\..\..\TestFolder\test.txt");
            }
      
            //StreamReader sr = new StreamReader(@"C:\TestFolder\subDir\test.txt");
            //StreamWriter sw = new StreamWriter(@"C:\TestFolder\testOriginal.txt");
            string text = System.IO.File.ReadAllText(dir.Parent.FullName + @"..\..\..\TestFolder\testOriginal.txt");
            //System.Console.WriteLine("{0}",text);

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(dir.Parent.FullName + @"..\..\..\TestFolder\test.txt"))
            {
                file.Write(text);
            }


            //sr.Close();
            //sw.Write(Console.ReadLine());
            //sw.Close();

               
            Console.ReadKey();
        }
    }
}

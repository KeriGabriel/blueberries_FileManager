using System;
using System.IO;


namespace blueberries_FileManager
{
   
    public class FileManager
    {
       private string _FilePath = string.Empty;
        private long _Size = 0;
        private bool _ReadOnly;
       private DateTime _DateChanged;

        // returns true or false
        public bool FileExist(string filepath)
        {
            return File.Exists(filepath);   
        }
        //if file exist get file name without extention
       public string FileName(string filepath)
        {
            if (File.Exists(filepath))
            {

                string fileName = Path.GetFileNameWithoutExtension(filepath);
                return fileName;

            }
            else
            {
                return "File Not Found";
            }         
        }
        //***** NEEDS WORK***
        //Directory info memory expensive
        public string DirectoryName(string filepath)
        {
            if (File.Exists(filepath))
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(filepath);
                string directoryName = string.Empty;
                if (directoryInfo.Parent == null)
                {
                    directoryName = filepath;
                }
                else 
                {
                    directoryName = Path.GetDirectoryName(filepath);
                }
                return directoryName;
            }
            else
            {
                return "Directory Not Found";
            }
        }
        //****NEEDS WORK*** Directory.EnumerateFiles array ~less memory
        public string LarestFileINCurrentDirectory(string filepath)
        {
            if (File.Exists(filepath))
            {
               //find largest file
                
            }
            else
            {
                return " File not found";
            }
            //if a tie is found, first one alpha sorted
            return filepath ;
        }
        //****NEEDS WORK***
        string VowelWeight(string filepath)
        {
            //Format: 12 Es, 1 A, 4 Is, 6 Os, 2 Us, 0Ys
            //return all zeros if file supplied has no txt extension
            return filepath ;
        }
        //returns path extention // //if file contains double extention this will only remove the end extention
        public string FileExtension(string filepath)
        {
            return Path.GetExtension(filepath);
        }
        //make byte array 
        public byte[] GetByteArray(string filepath)
        {
            byte[] byteArray = new byte[filepath.Length];
            return byteArray;
        }
        //****NEEDS WORK*****
        public string ToString()
        {
            // returns a string concatenation of:
            string FilePath;
            long Size;
            bool ReadOnly;
            DateTime DateChanged;
            //string newString = FilePath + Size + DateChanged;
            return base.ToString();
        }
    }
}

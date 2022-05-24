
using System;


namespace blueberries_FileManager
{
	public class Blueberry
	{
		public string DirectoryName { get; set; }
		public string LargestFileInCurrentDirectory { get; set; }
		public string VowelWeight { get; set; }
		public string FileName { get; set; }
		public string FileExtention { get; set; }
		public DateTime DateChanged { get; set; }

		public long Size;
		public bool ReadOnly;


		public bool FileExists(string _filepath)
		{
			return File.Exists(_filepath);
			//return true;
		}

		//***** NEEDS WORK***
		//Directory info memory expensive
		public string GetDirectory(string _filepath)
		{
			if (File.Exists(_filepath))
			{
				DirectoryInfo directoryInfo = new DirectoryInfo(_filepath);
				string directoryName = string.Empty;
				if (directoryInfo.Parent == null)
				{
					directoryName = _filepath;
				}
				else
				{
					directoryName = Path.GetDirectoryName(_filepath);
				}
				return directoryName;
			}
			else
			{
				return "Directory Not Found";
			}
		}

		//****NEEDS WORK*** Directory.EnumerateFiles array ~less memory
		public string GetLargestFile(string _filepath)
		{
			if (File.Exists(_filepath))
			{
				//find largest file
			}
			else
			{
				return " File not found";
			}
			//if a tie is found, first one alpha sorted
			return _filepath;
		}

		//****NEEDS WORK***
		public string GetVowels(string _filepath)
		{
			//     //Format: 12 Es, 1 A, 4 Is, 6 Os, 2 Us, 0Ys
			//     //return all zeros if file supplied has no txt extension

			return "in progress";
		}

		public string GetFileName(string _filepath)
		{
			if (File.Exists(_filepath))
			{

				string fileName = Path.GetFileNameWithoutExtension(_filepath);
				return fileName;

			}
			else
			{
				return "File Not Found";
			}
		}

		//returns path extention 
		//if file contains double extention this will only remove the end extention
		public string getFileExtention(string _filepath)
		{
			return Path.GetExtension(_filepath);
		}

		//****NEEDS WORK*****
		public string ToString(string _filepath)
		{
			return _filepath + Size + ReadOnly + DateChanged;
		}
	}
}






       // public string filepath;
       // public string DirectoryName(string filepath)
       // {
       //     return filepath;
       // }
       // public string LarestFileINCurrentDirectory(string filepath)
       // {
       //     //if a tie is found, first one alpha sorted
       //     return filepath ;
       // }
       // string VowelWeight(string filepath)
       // {
       //     //Format: 12 Es, 1 A, 4 Is, 6 Os, 2 Us, 0Ys
       //     //return all zeros if file supplied has no txt extension
       //     return filepath ;
       // }
       // string FileName;
       // string FileExtension(string filepath)
       // {
       //     return Path.GetExtension(filepath);
       // }
       // byte[] GetByteArray(string filepath)
       // {
       //     byte[] bytes = new byte[0];
       //     return bytes;
       // }
       //public Blueberry()
       // {
           
       //     // returns a string concatenation of:
       //     string FilePath;
       //     long Size;
       //     bool ReadOnly;
       //     DateTime DateChanged;
       //     //string newString = FilePath + Size + DateChanged;
       //     return ;

       // }

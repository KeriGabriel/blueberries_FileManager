
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

		//byte[] ourByte[] = new();
		public long Size;
		public bool ReadOnly;


		public bool FileExists(string _filepath)
		{
			// Add Code Check
			return true;
		}

		public string GetDirectory(string _filepath)
		{
			return "get code";
		}

		public string GetLargestFile(string _filepath)
		{
			return "do code";
		}

		public string GetVowels(string _filepath)
		{
			//     //Format: 12 Es, 1 A, 4 Is, 6 Os, 2 Us, 0Ys
			//     //return all zeros if file supplied has no txt extension

			return "set code";
		}

		public string GetFileName(string _filepath)
		{
			return "do code";
		}

		public string getFileExtention(string _filepath)
		{
			return "do code";
		}


		public string ToString(string _filepath)
		{
			// returns a string concatention of:
			// FilePath; Size; ReadOnly; DateChanged

			return _filepath + Size + ReadOnly + DateChanged;


			//return base.ToString(string _filepath);
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

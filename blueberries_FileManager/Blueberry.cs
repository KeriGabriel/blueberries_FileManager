
using System;


namespace blueberries_FileManager
{

	public class Blueberry
	{
		public string DirectoryName { get; set; }
		public string LargestFileInCurrentDirectory	{ get; set; }
		public string VowelWeight { get; set; }
		public string FileName { get; set; }
		public string FileExtention { get; set; }

		byte[] GetByteArray { get; set; }

		public override string ToString()
		{
			// returns a string concatention of:
			// FilePath; Size; ReadOnly; DateChanged

			return base.ToString();
		}


		public bool FileExists(string _filepath)
		{
			// Add Code Check
			return true;
		}

		public

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


    }




    }
}
using System;
using System.Text;

namespace blueberries_FileManager
{
	public class Blueberry
	{
		public bool FileExists(string _filepath)
		{
			return File.Exists(_filepath);
		}

		public string DirectoryName(string _filepath)
		{
			if (FileExists(_filepath))
			{
				return Path.GetDirectoryName(_filepath);
			}
			else
			{
				return "Directory Not Found";
			}
		}

		public string LargestFileInCurrentDirectory(string _filepath)
		{
			if (FileExists(_filepath))
			{
				//find largest file in the directory of filepath
				//if a tie is found, first one alpha sorted

				string directory = DirectoryName(_filepath);
				DirectoryInfo directoryInfo = new DirectoryInfo(directory);
				IEnumerable<FileInfo> fileList = directoryInfo.GetFiles("*.*", SearchOption.AllDirectories);
				FileInfo largestFile =
				(from file in fileList
				 let length = GetFileLength(file)
				 where length > 0
				 orderby length descending
				 select file).First();
				return largestFile.ToString();
				//return largestFile.Name;
			}
			else
			{
				return " File not found";
			}
		}

		public string VowelWeight(string _filepath)
		{
			//     //Format: 12 Es, 1 A, 4 Is, 6 Os, 2 Us, 0Ys
			//     //return all zeros if file supplied has no txt extension
			int[] c = new int[6];
			char[] l = new char[6] { 'E', 'A', 'I', 'O', 'U', 'Y' };
			//char[] l = new char[6] { 'A', 'E', 'I', 'O', 'U', 'Y' };
			string f = Path.GetFileNameWithoutExtension(_filepath).ToUpper();
			for (int v = 0; v < l.Length; v++)
				if (Path.GetExtension(_filepath) == ".txt") c[v] = f.Count(n => n == l[v]);
				else c[v] = 0;
			string output = "";
			for (int i = 0; i < l.Length; i++)
				if (c[i] == 1) output = $"{output}{c[i]} {l[i]}, ";
				else output = $"{output}{c[i]} {l[i]}s, ";
			return output.Substring(0, output.Length - 2);
		}

		public string FileName(string _filepath)
		{
			/* trim backwards to first backslash (doesn't really matter if it exists or not,
			we are just returning the file name portion of the path string */
			if (FileExists(_filepath))
			{
				return Path.GetFileNameWithoutExtension(_filepath);
			}
			else
			{
				return "File Not Found";
			}
		}

		public string FileExtention(string _filepath)
		{
			if (FileExists(_filepath))
			{
				return Path.GetExtension(_filepath);
			}
			else { return "File not found"; }
		}

		public byte[] GetByteArray(string _filepath)
		{
			return Encoding.ASCII.GetBytes(_filepath);

		}

		public string ToString(string _filepath)
		{
			FileInfo fileInfo = new FileInfo(_filepath);
			string returnString = string.Empty;
			returnString += _filepath;
			returnString += fileInfo.Length;
			returnString += fileInfo.IsReadOnly;
			returnString += File.GetLastWriteTime(_filepath);

			return returnString;
		}

		//provides length of file
		public long GetFileLength(FileInfo fileInfo)
		{
			long length = 0;
			try
			{
				length = fileInfo.Length;
			}
			catch (FileNotFoundException)
			{
				//If no file add zero bytes to the total
				length = 0;
			}
			return length;



			//	if (FileExists(_filepath))
			//	{
			//		FileInfo fileInfo = new FileInfo(_filepath);
			//		GetReadOnly(_filepath);
			//		getDateChanged(_filepath);
			//		Size = GetFileLength(fileInfo);

			//		//GetFileLength(_filepath);
			//		return " \n The filepath: " + _filepath + "\n" +
			//		" The Size of the file: " + Size + "\n" +
			//		" Read only: " + ReadOnly + "\n" +
			//		" Date Changed: " + DateChanged;
			//	}
			//	else { return "File not found"; }
			//}


			//public DateTime DateChanged { get; set; }
			//public long Size;
			//public bool ReadOnly;

			//// Utility Functions (can we combine this with one call?)
			//public DateTime getDateChanged(string _filepath)
			//      {
			//	DateChanged= File.GetLastWriteTime(_filepath);
			//	return DateChanged;
			//}	

			//public string GetReadOnly(string _filepath)
			//      {
			//          try 
			//          {
			//		FileInfo fileInfo = new FileInfo(_filepath);
			//              if (fileInfo.IsReadOnly)
			//              {
			//			ReadOnly = true;
			//		}
			//		return ReadOnly.ToString();
			//	}
			//          catch (FileNotFoundException)
			//          {
			//		return "File Not Found";
			//          }
			//      }


		}
	}
}

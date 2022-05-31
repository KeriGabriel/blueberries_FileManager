using System;
using System.Text;

namespace blueberries_FileManager
{
	public class Blueberry
	{
		//bool FileExists(filepath)
		public bool FileExists(string _filepath)
		{
			
			return File.Exists(_filepath);
		}
		//string DirectoryName(filepath)
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
		//string LargestFileInCurrentDirectory(filepath)
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
		//This needs to read txt file not filepath name
		//string VowelWeight(filepath)
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

			//*** this produces just the filename without extension or path 
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
			long Size= fileInfo.Length;
			bool ReadOnly = fileInfo.IsReadOnly;
			DateTime DateChanged = File.GetLastWriteTime(_filepath);

			return String.Format
				("\n File Path:{0}, \n Size:{1},\n ReadOnly:{2} \n Date Changed last:{3}", _filepath, Size, ReadOnly, DateChanged);

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
		}
	}
}

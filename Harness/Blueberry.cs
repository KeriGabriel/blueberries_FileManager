
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
		
		/// <summary>
		/// How / Where do we need to collect the data changed? 
		/// </summary>
		public DateTime DateChanged { get; set; }

		public long Size;
		public bool ReadOnly;


		public bool FileExists(string _filepath)
		{
			return File.Exists(_filepath);
			//return true;
		}
		//Needs Work
		public string GetDirectory(string _filepath)
		/*Directory info memory expensive
		 * 
		 * AP - Can we get this when doing the "if exists" method?
		 * If the file exists, the directory must be valid?
		 * 
		 */
		{
			if (FileExists(_filepath))
			{
				return Path.GetDirectoryName(_filepath);
			}
			else
			{
				return "File Not Found";
			}
			//if (File.Exists(_filepath))
			//{
			//	DirectoryInfo directoryInfo = new DirectoryInfo(_filepath);
			//	string directoryName = string.Empty;
			//	if (directoryInfo.Parent == null)
			//	{
			//		directoryName = _filepath;
			//	}
			//	else
			//	{
			//		directoryName = Path.GetDirectoryName(_filepath);
			//	}
			//	return directoryName;
			//}
			//else
			//{
			//	return "Directory Not Found";
			//}
		}
		//****NEEDS WORK*** Directory.EnumerateFiles array ~less memory
		public string GetLargestFile(string _filepath)
		{
			if (FileExists(_filepath))
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
			int[] c = new int[6];
			char[] l = new char[6] { 'A', 'E', 'I', 'O', 'U', 'Y' };
			string f = Path.GetFileNameWithoutExtension(_filepath).ToUpper();
			for (int v = 0; v < l.Length; v++)
				if (Path.GetExtension(_filepath) == ".txt") c[v] = f.Count(n => n == l[v]);
				else c[v] = 0;
			string output = "";
			for (int i = 0; i < l.Length; i++)
				if (c[i] == 1) output = $"{output}{c[i]} {l[i]}, ";
				else output = $"{output}{c[i]} {l[i]}s, ";
			return output.Substring(0, output.Length-2);
		}

		public string GetFileName(string _filepath)
		{
			if (FileExists(_filepath))
			{
				FileName = Path.GetFileNameWithoutExtension(_filepath);
				return FileName;
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
			if (FileExists(_filepath))
            {
				return Path.GetExtension(_filepath);
			}
			else { return "File not found"; }
		}

		//****NEEDS WORK*****
		public string ToString(string _filepath)
		{
			if (FileExists(_filepath))
			{
				return _filepath + Size + ReadOnly + DateChanged;
			}
			else { return "File not found"; }	
		}
	}
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using blueberries_FileManager;
using System;
using System.IO;
using System.Text;

namespace UnitTestFileManager
{
	[TestClass]
	public class FileManagerTest
	{

		// Updated to use relative path
		//private static string bigFile;
		//private static string goodPath;
		//private static string goodFile;
		//private static string goodFileNoExt;

		//// Updated to use relative path
		private static string bigFile = "BigFile.pdf";
		private static string goodPath = "./Testing/GoodFile.txt";
		private static string goodFile = "GoodFile.txt";
		private static string goodFileNoExt = "GoodFile";


		public TestContext context;

		[ClassInitialize]
		public static void ClassInit(TestContext context)
		{
			
			//string localPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
			//string localPath = Environment.CurrentDirectory;

			//bigFile = Path.Combine(root, bigFile);

			//bigFile = context.Properties["bigFile"].ToString();
			//bigFile = Path.Combine(localPath, bigFile);


			//goodPath = context.Properties["goodPath"].ToString();
			//goodFile = context.Properties["goodPath"].ToString();
			//goodFileNoExt = context.Properties["goodFileNoExt"].ToString();


			//goodFile = context.Properties["goodFile"].ToString();
			//goodFile = Path.Combine(localPath, goodFile);

			Console.WriteLine("Test are initializing...");
		}

		Blueberry testBerry = new();

		#region Test DirectoryName(filepath)
		[TestMethod]
		public void DirectoryNameSucess()
		{
			Assert.AreEqual(".\\Testing", testBerry.DirectoryName(goodPath));
		}

		[TestMethod]
		public void DirectoryNameFail()
		{
			Assert.AreNotEqual("/foo", testBerry.DirectoryName(goodPath));
		}
		#endregion

		#region Test LargestFileInCurrentDirectory(filepath)
		[TestMethod]
		public void LargestFileSucess()
		{
			Assert.AreEqual(bigFile, testBerry.LargestFileInCurrentDirectory(goodPath));
		}

		[TestMethod]
		public void LargestFileFail()
		{
			Assert.AreNotEqual(goodFile, testBerry.LargestFileInCurrentDirectory(goodPath));
		}
		#endregion

		#region Test VowelWeight(filepath)
		[TestMethod]
		public void VowelWeightSucess()
		{
			// Format: 12 Es, 1 A, 4 Is, 6 Os, 2 Us, 0Ys
			//	./Testing/GoodFile.txt
			Assert.AreEqual("2 Es, 0 A, 2 Is, 2 Os, 0 Us, 0Ys", testBerry.VowelWeight(goodPath));
		}

		[TestMethod]
		public void VowelWeightCalcFail()
		{
			// Format: 12 Es, 1 A, 4 Is, 6 Os, 2 Us, 0Ys
			Assert.AreNotEqual("12 As, 1 E, 1 I, 2 Os, 0 Us, 0 Ys", testBerry.VowelWeight(goodPath));
		}

		[TestMethod]
		public void VowelWeightExtentionFail()
		{
			// Format: 12 Es, 1 A, 4 Is, 6 Os, 2 Us, 0Ys
			Assert.AreNotEqual("2 Es, 0 A, 2 Is, 2 Os, 0 Us, 0Ys", testBerry.VowelWeight(bigFile));
		}

		#endregion

		#region Test FileName(filepath)
		[TestMethod]
		public void FileNameSucess()
		{
			Assert.AreEqual(goodFileNoExt, testBerry.FileName(goodPath));
		}

		[TestMethod]
		public void FileNameFail()
		{
			Assert.AreNotEqual("foo", testBerry.FileName(goodPath));
		}
		#endregion

		#region Test FileExtention(filepath)
		[TestMethod]
		public void FileExtention()
		{
			Assert.AreEqual(".txt", testBerry.FileExtention(goodPath));
		}

		[TestMethod]
		public void FileExtentionFail()
		{
			Assert.AreNotEqual(".jpg", testBerry.FileName(goodPath));
		}
		#endregion

		#region Test GetByteArray(filepath)
		[TestMethod]
		public void ByteArraySucess()
		{
			Assert.AreEqual(goodPath,
				Encoding.ASCII.GetString(testBerry.GetByteArray(goodPath)));
		}

		[TestMethod]
		public void ByteArrayFail()
		{
			Assert.AreNotEqual("foo", testBerry.GetByteArray(goodPath).ToString());
		}
		#endregion

		#region Test ToString(filepath)
		[TestMethod]
		public void ToStringSucess()
		{
			Assert.AreEqual("./Testing/GoodFile.txt1305False5/24/2022 11:01:26 AM", testBerry.ToString(goodPath));
		}

		[TestMethod]
		public void ToStringFail()
		{

			Assert.AreNotEqual("boo", testBerry.ToString(goodPath));

		}

		#endregion
	}
}
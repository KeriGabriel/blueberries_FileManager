using Microsoft.VisualStudio.TestTools.UnitTesting;
using blueberries_FileManager;
using System;
using System.IO;

namespace UnitTestFileManager
{
	[TestClass]
	public class FileManagerTest
	{

		// Updated to use relative path
		private static string bigFile = "BigFile.pdf";
		private static string goodPath = "./Testing/GoodFile.txt";
		private static string goodFile = "GoodFile.txt";
		private static string goodFileNoExt = "GoodFile";

		//public TestContext TestContext { get; set; }
		[ClassInitialize]
		public static void ClassInit(TestContext context)
		{
			// what do you want to set up as the test suite
			// is about to be run
			// string localPath= Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
			//string localPath = Environment.CurrentDirectory;

			//bigFile = Path.Combine(root, bigFile);
			//// goodPath = context.Properties["goodPath"].ToString();
			//        // goodPath = Path.Combine(localPath, goodPath);

			//bigFile =  context.Properties["bigFile"].ToString();
			//        bigFile=Path.Combine(localPath, bigFile);

			//goodFile = context.Properties["goodFile"].ToString();
			//        goodFile=Path.Combine(localPath, goodFile);


			Console.WriteLine("Test are initializing...");
		}

		Blueberry testBerry = new();

		#region File Exisits? Test
		[TestMethod]
		public void FileExistsSuccess()
		{
			Assert.IsTrue(testBerry.FileExists(goodPath));
		}

		[TestMethod]
		public void FileExistsFail()
		{
			Assert.IsFalse(testBerry.FileExists("ImaginaryFile"));
		}
		#endregion

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

		// To do: Check requirements for return value
		[TestMethod]
		public void LargeFileFail()
		{
			Assert.AreNotEqual(goodFile, testBerry.LargestFileInCurrentDirectory(goodPath));
		}
		#endregion

		#region Test VowelWeight(filepath)
		[TestMethod]
		public void VowelWeightSucess()
		{
			Assert.IsFalse(1 == 1);
		}

		[TestMethod]
		public void VowelWeightFail()
		{
			Assert.IsFalse(1 == 1);
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
			Assert.AreEqual(1, 2);
		}

		[TestMethod]
		public void ByteArrayFail()
		{
			Assert.AreEqual(1, 2);
		}
		#endregion

		#region Test ToString(filepath)
		public void ToStringSucess()
		{

		}

		public void ToStringFail()
		{

		}

		#endregion

	}
}
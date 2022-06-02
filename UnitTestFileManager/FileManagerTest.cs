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
		private static string bigFile = null;
		private static string goodFile = null;
		private static string finalLocalPath = String.Empty;
		private static string vowel = null;
		public TestContext TestContext;

		[ClassInitialize]
		public static void ClassInit(TestContext context)
		{
			string localPath = Environment.CurrentDirectory;
			localPath = Directory.GetParent(localPath).FullName;
			localPath = Directory.GetParent(localPath).FullName;
			localPath = Directory.GetParent(localPath).FullName;
			finalLocalPath = Directory.GetParent(localPath).FullName;

			bigFile = context.Properties["bigFile"].ToString();
			goodFile = context.Properties["goodFile"].ToString();
			vowel = context.Properties["vowel"].ToString();
			bigFile = Path.Combine(finalLocalPath, bigFile);
			goodFile = Path.Combine(finalLocalPath, goodFile);
			vowel = Path.Combine(finalLocalPath, vowel);

			Console.WriteLine("Test are initializing...");
		}
		Blueberry testBerry = new();
	
		#region Test DirectoryName(filepath)
		[TestMethod]
		public void DirectoryNameSucess()
		{
			Assert.AreEqual(finalLocalPath+@"\Testing", testBerry.DirectoryName(goodFile));
		}

		[TestMethod]
		public void DirectoryNameFail()
		{
			Assert.AreNotEqual("/foo", testBerry.DirectoryName(goodFile));
		}
		#endregion

		#region Test LargestFileInCurrentDirectory(filepath)
		[TestMethod]
		public void LargestFileSucess()
		{
			Assert.AreEqual(bigFile, testBerry.LargestFileInCurrentDirectory(bigFile));
		}

		[TestMethod]
		public void LargestFileFail()
		{
			Assert.AreNotEqual(goodFile, testBerry.LargestFileInCurrentDirectory(goodFile));
		}
		#endregion

		#region Test VowelWeight(filepath)
		[TestMethod]
		public void VowelWeightSucess()
		{
			// Format: 12 Es, 1 A, 4 Is, 6 Os, 2 Us, 0Ys
			//	./Testing/GoodFile.txt
			Assert.AreEqual("7 Es, 3 As, 4 Is, 10 Os, 1 U, 1Y", testBerry.VowelWeight(vowel));
		}

		[TestMethod]
		public void VowelWeightCalcFail()
		{
			// Format: 12 Es, 1 A, 4 Is, 6 Os, 2 Us, 0Ys
			Assert.AreNotEqual("12 As, 1 E, 1 I, 2 Os, 0 Us, 0Ys", testBerry.VowelWeight(goodFile));
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
			Assert.AreEqual("GoodFile", testBerry.FileName(goodFile));
		}

		[TestMethod]
		public void FileNameFail()
		{
			Assert.AreNotEqual("foo", testBerry.FileName(goodFile));
		}
		#endregion

		#region Test FileExtention(filepath)
		[TestMethod]
		public void FileExtention()
		{
			Assert.AreEqual(".txt", testBerry.FileExtention(goodFile));
		}

		[TestMethod]
		public void FileExtentionFail()
		{
			Assert.AreNotEqual(".jpg", testBerry.FileName(goodFile));
		}
		#endregion

		#region Test GetByteArray(filepath)
		[TestMethod]
		public void ByteArraySucess()
		{
			Assert.AreEqual(goodFile,
				Encoding.ASCII.GetString(testBerry.GetByteArray(goodFile)));
		}

		[TestMethod]
		public void ByteArrayFail()
		{
			Assert.AreNotEqual("foo", testBerry.GetByteArray(goodFile).ToString());
		}
		#endregion

		#region Test ToString(filepath)
		[TestMethod]
		public void ToStringSucess()
		{
			string DateChanged = File.GetLastWriteTime(goodFile).ToString();
            //This will fail if GoodFile dateChange is changed
            Assert.AreEqual(finalLocalPath + @"\Testing\GoodFile.txt1305False"+DateChanged, testBerry.ToString(goodFile,true));
		}
		[TestMethod]
		public void ToStringFail()
		{
			Assert.AreNotEqual("boo", testBerry.ToString(goodFile));
		}

		#endregion
	}
}
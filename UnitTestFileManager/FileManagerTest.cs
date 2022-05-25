using Microsoft.VisualStudio.TestTools.UnitTesting;
using blueberries_FileManager;
using System;

namespace UnitTestFileManager
{
    [TestClass]
    public class FileManagerTest
    {
		//To do: move to runsettings as path to testing directory within solution
		Blueberry testBerry = new();
		string bigFile = "c:\temp\bigfile.txt";

		string goodPath = "c:\temp";
		string goodFile = "c:\temp\test.txt";

		string badPath = "c:\temp\foo";
		string badFile = "c:\temp\foo.bar";


		//string goodPath = "./Testing/ToDo.txt";
		//string goodDirectory = "./Testing/";

		//string badPath = "./foo.bar";
		//string badDirectory = "./foo/";


		#region Test sucess / failure of Blueberry.FileExists()
		[TestMethod]
		public void FileExists()
		{
			Assert.AreEqual(true, testBerry.FileExists(goodPath));
		}

		[TestMethod]
		public void FileNotExists()
		{
			Assert.AreNotEqual(true, testBerry.FileExists(badPath));
		}
		#endregion

		#region Test success / failure of Blueberry.GetDirectory()
		[TestMethod]
		public void TestDirectoryFound()
		{
			Assert.AreEqual(goodPath, testBerry.GetDirectory(goodPath));
		}

		[TestMethod]
		public void TestDirectoryMissing()
		{
			Assert.IsFalse(badPath == testBerry.GetDirectory(goodPath));
		}
		#endregion

		#region Test success / failure of Blueberry.GetLargestFile()
		[TestMethod]
		public void LargestFileSucess()
		{
			Assert.AreEqual(bigFile, testBerry.GetLargestFile(goodPath));
		}

		// To do: Check requirements for return value
		[TestMethod]
		public void LargeFileFail()
		{
			Assert.AreEqual("-1", testBerry.GetLargestFile(goodPath));
		}
		#endregion

		#region Test success / failure of Blueberry.GetFileName() 
		[TestMethod]
		public void FileNameSucess()
		{
			Assert.AreEqual(goodFile, testBerry.GetFileName(goodPath));
		}

		[TestMethod]
		public void FileNameFail()
		{
			// To do:  This isn't right
			Assert.IsTrue(false);
			//Assert.AreNotEqual(goodFile, testBerry.GetFileName(goodPath));
		}
		#endregion

		#region Test sucess / failure of Blueberry.GetVowels()
		// To do:  Fix this
		[TestMethod]
		public void VowelsCorrect()
		{
			Assert.IsTrue("what is correct value" == testBerry.GetVowels(goodPath));
		}
		[TestMethod]
		public void VowelsWrong()
		{
			Assert.IsTrue("what is correct value" == testBerry.GetVowels(goodPath));
		}
		#endregion

		#region Test success / failure of Blueberry.Get
		[TestMethod]
		public void ExtentionSucess()
		{
			Assert.IsTrue("txt" == testBerry.getFileExtention(goodPath));
		}

		[TestMethod]
		public void ExtentionFail()
		{
			Assert.IsFalse("pdf" == testBerry.getFileExtention(goodPath));
		}
		#endregion

		#region Test Sucess / Failure of Blueberry.ToString()
		// To do:  Not Done
		[TestMethod]
		public void ToStringSucess()
		{
			Assert.IsFalse(true);
		}

		[TestMethod]
		public void ToStringFail()
		{
			Assert.IsFalse(true);
		}

		#endregion

	}
}
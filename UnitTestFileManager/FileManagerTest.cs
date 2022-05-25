using Microsoft.VisualStudio.TestTools.UnitTesting;
using blueberries_FileManager;
using System;

namespace UnitTestFileManager
{
    [TestClass]
    public class FileManagerTest
    {
		// move to runsettings
		Blueberry testBerry = new();
		string goodPath = "/Testing/ToDo.txt";
		string badPath = "./foo";


		[TestMethod]
		public void FileExists()
		{
			//Assert.AreEqual(true, testBerry.FileExists(goodPath));
			//Assert.AreNotEqual(false, testBerry.FileExists(badPath));
		}

		[TestMethod]
		public void TestDirectoryName()
		{
			Assert.AreEqual(goodPath, testBerry.GetDirectory(goodPath));

		}

		[TestMethod]
		public void LargestFile()
		{
		}


		[TestMethod]
		public void TestFileName()
		{
		}


		[TestMethod]
		public void TestVowels()
		{
		}


		[TestMethod]
		public void TestFileExtention()
		{
		}

		[TestMethod]
		public void TestToString()
		{
		}

	}
}
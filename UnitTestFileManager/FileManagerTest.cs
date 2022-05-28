using Microsoft.VisualStudio.TestTools.UnitTesting;
using blueberries_FileManager;
using System;
using System.IO;

namespace UnitTestFileManager
{
	[TestClass]
	public class FileManagerTest
    {

		private static string? bigFile = null;
		private static string? goodPath = null;
		private static string? goodFile = null;
		private static string? badPath = null;
		public TestContext TestContext { get; set; }
		[ClassInitialize]
		public static void ClassInit(TestContext context)
		{
            // what do you want to set up as the test suite
            // is about to be run
            // string localPath= Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string localPath = Environment.CurrentDirectory;
            goodPath = context.Properties["goodPath"].ToString();
            goodPath = Path.Combine(localPath, goodPath);
            bigFile =  context.Properties["bigFile"].ToString();
            bigFile=Path.Combine(localPath, bigFile);
            goodFile = context.Properties["goodFile"].ToString();
            goodFile=Path.Combine(localPath, goodFile);
            badPath = context.Properties["badPath"].ToString();

			Console.WriteLine("Test are initializing...");
		}


		//public TestContext TestContext { get; set; }
		////To do: move to runsettings as path to testing directory within solution
		//string bigFile = "c:\\temp\\bigfile.txt";
		//string goodFile = "\\Testing\\goodFile.txt";
		//string goodPath = "c:\\temp";
		//string badPath = "c:\\temp\\foo";

		Blueberry testBerry = new();

        //#region Test sucess / failure of Blueberry.FileExists()
        [TestMethod]
        public void FileExists()
        {
            Assert.AreEqual(true, testBerry.FileExists(goodFile));
        }

        //[TestMethod]
        //public void FileNotExists()
        //{
        //    Assert.AreNotEqual(true, testBerry.FileExists(badPath));
        //}
        //#endregion

        //#region Test success / failure of Blueberry.GetDirectory()
        //[TestMethod]
        //public void TestDirectoryFound()
        //{
        //    Assert.AreEqual(goodPath, testBerry.GetDirectory(goodPath));
        //}

        //[TestMethod]
        //public void TestDirectoryMissing()
        //{
        //    Assert.IsFalse(badPath == testBerry.GetDirectory(goodPath));
        //}
        //#endregion

        //#region Test success / failure of Blueberry.GetLargestFile()
        //[TestMethod]
        //public void LargestFileSucess()
        //{
        //    Assert.AreEqual(bigFile, testBerry.GetLargestFile(goodPath));
        //}

        //// To do: Check requirements for return value
        //[TestMethod]
        //public void LargeFileFail()
        //{
        //    Assert.AreEqual("-1", testBerry.GetLargestFile(goodPath));
        //}
        //#endregion

        //#region Test success / failure of Blueberry.GetFileName() 
        //[TestMethod]
        //public void FileNameSucess()
        //{
        //    Assert.AreEqual(goodFile, testBerry.GetFileName(goodPath));
        //}

        //[TestMethod]
        //public void FileNameFail()
        //{
        //    // To do:  This isn't right
        //    Assert.IsTrue(false);
        //    //Assert.AreNotEqual(goodFile, testBerry.GetFileName(goodPath));
        //}
        //#endregion

        //#region Test sucess / failure of Blueberry.GetVowels()
        //// To do:  Fix this
        //[TestMethod]
        //public void VowelsCorrect()
        //{
        //    Assert.IsTrue("what is correct value" == testBerry.GetVowels(goodPath));
        //}
        //[TestMethod]
        //public void VowelsWrong()
        //{
        //    Assert.IsTrue("what is correct value" == testBerry.GetVowels(goodPath));
        //}
        //#endregion

        //#region Test success / failure of Blueberry.Get
        //[TestMethod]
        //public void ExtentionSucess()
        //{
        //    Assert.IsTrue("txt" == testBerry.getFileExtention(goodPath));
        //}

        //[TestMethod]
        //public void ExtentionFail()
        //{
        //    Assert.IsFalse("pdf" == testBerry.getFileExtention(goodPath));
        //}
        //#endregion

        //#region Test Sucess / Failure of Blueberry.ToString()
        //// To do:  Not Done
        //[TestMethod]
        //public void ToStringSucess()
        //{
        //    Assert.IsFalse(true);
        //}

        //[TestMethod]
        //public void ToStringFail()
        //{
        //    Assert.IsFalse(true);
        //}

        //#endregion

    }
}
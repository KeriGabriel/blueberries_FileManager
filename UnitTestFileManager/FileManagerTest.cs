using Microsoft.VisualStudio.TestTools.UnitTesting;
using blueberries_FileManager;
using System.Text;

namespace UnitTestFileManager
{
	[TestClass]
	public class FileManagerTest
	{
		private static string bigFile = null;
		private static string goodPath = null;
		private static string goodFile = null;
		private static string goodFileNoExt = null;

		[ClassInitialize]
		public static void ClassInit(TestContext context)
		{
			bigFile = context.Properties["bigFile"].ToString();
			goodPath = context.Properties["goodPath"].ToString();
			goodFile = context.Properties["goodFile"].ToString();
			goodFileNoExt = context.Properties["goodFileNoExt"].ToString();
		}

		Blueberry testBerry = new();

		#region Test DirectoryName(filepath)
		[TestMethod]
		public void DirectoryNameSucess()
		{
			Assert.IsTrue(1 == 2);
			//Assert.AreEqual(finalLocalPath+@"\Testing", testBerry.DirectoryName(goodPath));
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
			Assert.AreEqual("1 E, 0 As, 1 I, 2 Os, 0 Us, 0 Ys", testBerry.VowelWeight(goodPath));
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
			Assert.IsTrue(1==2);
		}

		[TestMethod]
		public void ToStringFail()
		{
			Assert.AreNotEqual("boo", testBerry.ToString(goodPath));
		}

		#endregion
	}
}
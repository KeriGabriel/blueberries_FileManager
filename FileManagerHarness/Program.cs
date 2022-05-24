// See https://aka.ms/new-console-template for more information
using blueberries_FileManager;


FileManager FM = new FileManager();
String TestFilePath = "C:\\Users\\Keri Gabriel\\Downloads\\Blank diagram.pdf";
string TestFileD = "C:\\Users\\Keri Gabriel\\Desktop\\Cricut Design Space.lnk";
Console.WriteLine(FM.FileName(TestFilePath));
Console.WriteLine(FM.DirectoryName(TestFileD)); 
    Console.WriteLine(FM.FileExtension(TestFilePath));
Console.WriteLine(FM.GetByteArray(TestFilePath));
//Console.WriteLine(FM.LarestFileINCurrentDirectory(TestFilePath));
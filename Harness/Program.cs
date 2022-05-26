using blueberries_FileManager;
using System;

string filepath;
Console.WriteLine("Enter the filepath");
filepath = @"" + Console.ReadLine();

// To do:  fix this back to a prompt / dialog
//filepath = "c:\temp";

Blueberry ourBerry = new();
if (ourBerry.FileExists(filepath))
{
    Console.WriteLine("Does File Exist? " + ourBerry.FileExists(filepath) + "\n");

    Console.WriteLine("Directory Name is: " + ourBerry.GetDirectory(filepath) + "\n");

    Console.WriteLine(ourBerry.GetLargestFile(filepath,true) + "\n");

    //Console.WriteLine("The Largest File in the directory is: " + ourBerry.GetLargestFile(filepath) + "\n");

    Console.WriteLine("The vowel weight is: " + ourBerry.GetVowels(filepath) + "\n");

    Console.WriteLine("The Filename is: " + ourBerry.GetFileName(filepath) + "\n");

    Console.WriteLine("The file extension is: " + ourBerry.getFileExtention(filepath) + "\n");

    Console.WriteLine("String Override = " + ourBerry.ToString(filepath) + "\n");

}
else
{
    Console.WriteLine("\n Please try again with a valid file path");
}

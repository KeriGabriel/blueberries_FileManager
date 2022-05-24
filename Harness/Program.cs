using blueberries_FileManager;
using System;

string filepath;
Console.WriteLine("Enter the filepath");
filepath = Console.ReadLine();

Blueberry ourBerry = new();

Console.WriteLine("Does File Exist? " + ourBerry.FileExists(filepath) + "\n");

Console.WriteLine("Directory Name is: " + ourBerry.GetDirectory(filepath) + "\n");

Console.WriteLine("The Largest File in the directory is: " + ourBerry.GetVowels(filepath) + "\n");

Console.WriteLine("The vowel weight is: " + ourBerry.GetVowels(filepath) + "\n");

Console.WriteLine("The Filename is - do we know? " + ourBerry.GetFileName(filepath) + "\n");

Console.WriteLine("The file extension is: " + ourBerry.getFileExtention(filepath) + "\n");

Console.WriteLine("String Override = " + ourBerry.ToString(filepath) + "\n");






Console.Write("Path to File: ");
string path = Console.ReadLine();
Console.Write("New File Path: ");
string newFilePath = Console.ReadLine();
Console.Write("Your Specific Word: ");
string specificWord = Console.ReadLine();

StreamReader srFile = new StreamReader(path);
StreamWriter newFile = new StreamWriter(newFilePath);

string copiedLines = null;

string textLine = srFile.ReadLine();

while (textLine != null)
{
    if(textLine.Contains(specificWord))
    {
        newFile.WriteLine(textLine);
    }
    textLine = srFile.ReadLine();
}
newFile.Flush();
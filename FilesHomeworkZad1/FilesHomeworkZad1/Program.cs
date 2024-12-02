Console.Write("Path to File: ");
string path = Console.ReadLine();
int wordsCount = 0;
int sentenceCount = 0;
int numOfCopiedLines = 3;
int copiedLinesCounter = 0;

if (File.Exists(path))
{
    StreamReader srFile = new StreamReader(path);

    string copiedLines = null;

    char[] wordSeperators = { ' ' };
    char[] sentenceSeperators = { '.', '!', '?' };

    string textLine = srFile.ReadLine();

    while (textLine != null)
    {
        sentenceCount += textLine.Split(sentenceSeperators).Length - 1;
        wordsCount += textLine.Split(wordSeperators).Length;
        if (numOfCopiedLines != copiedLinesCounter)
        {
            copiedLines += textLine + " ";
            copiedLinesCounter++;
        }
        textLine = srFile.ReadLine();
    }

    Console.WriteLine("Number of sentences: " + sentenceCount);
    Console.WriteLine("Number of words: " + wordsCount);
    Console.WriteLine($"The first {numOfCopiedLines} lines of the text file: {copiedLines}");
}
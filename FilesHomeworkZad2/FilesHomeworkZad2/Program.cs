Console.Write("Input file location: ");
string inputPath = Console.ReadLine();
Console.Write("Output file location: ");
string outputPath = Console.ReadLine();

if (File.Exists(inputPath))
{
    File.Copy(inputPath, outputPath, true);
}
else
{
    Console.WriteLine("Error: File location doesnt exist!");
    return;
}
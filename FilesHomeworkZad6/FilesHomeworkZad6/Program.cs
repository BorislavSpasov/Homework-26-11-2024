Console.Write("Log File location: ");
string path = Console.ReadLine();
StreamWriter sw = new StreamWriter(path);

if (File.Exists(path))
{
    Console.Write("Calculate factorial: ");
    int input = int.Parse(Console.ReadLine());
    int result = 1;
    var watch = System.Diagnostics.Stopwatch.StartNew();
    double elapsedMs = 0;
    for (int i = input; i > 0; i--)
    {
        result *= i;
    }
    elapsedMs = watch.ElapsedTicks;
    watch.Stop();
    DateTime now = DateTime.Now;
    sw.WriteLine($"Ticks for execution: {elapsedMs}; Current Date and Time: {now}; Result: {result}");
    sw.Flush();
}

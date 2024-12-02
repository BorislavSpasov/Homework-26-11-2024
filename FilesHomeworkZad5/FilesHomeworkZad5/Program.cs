using System.Globalization;
Console.Write("CSV file location: ");
string path = Console.ReadLine();
Console.Write("New file location: ");
string newFileLoc = Console.ReadLine();

string csvLine = null;

int productLoc = 0;
int quantityLoc = 1;
int priceLoc = 2;

string mostSoldProduct = null;
int mostSoldProductValue = 0;

double totalPrice = 0;
double test = 1.2;

StreamReader srCSV = new StreamReader(path);
StreamWriter swNewFile = new StreamWriter(newFileLoc);
while (!srCSV.EndOfStream)
{
    csvLine = srCSV.ReadLine();
    string[] currentLine = csvLine.Split(',');
    if (int.Parse(currentLine[quantityLoc]) > mostSoldProductValue)
    {
        mostSoldProductValue = int.Parse(currentLine[quantityLoc]);
        mostSoldProduct = currentLine[productLoc];
    }
    totalPrice += double.Parse(currentLine[quantityLoc]) * double.Parse(currentLine[priceLoc], CultureInfo.InvariantCulture);
}

swNewFile.WriteLine("Total Price Of Products: " + totalPrice);
swNewFile.WriteLine("The Most Sold Product: " + mostSoldProduct);
swNewFile.Flush();
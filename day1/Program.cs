// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string[] lines = File.ReadAllLines("input.txt");
List<int> allDigits = new List<int>();

foreach (string line in lines)
{
    Nullable<int> first = null;
    Nullable<int> last = null;
    List<int> digits = new List<int>();

    foreach (char c in line) {
        if(Char.IsDigit(c)) {
            digits.Add(int.Parse(c.ToString()));
        }
    }
    foreach (int d in digits) {
        Console.WriteLine(d);
    }
}


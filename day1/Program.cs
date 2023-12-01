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
    first = digits.First();
    last = digits.Last();
    string digit = $"{first}{last}";
    allDigits.Add(int.Parse(digit));

    foreach (int d in allDigits) {
        Console.WriteLine(d);
    }

    int total = allDigits.Sum(x => Convert.ToInt32(x));
    Console.WriteLine(total);
}

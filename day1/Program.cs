// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string[] lines = File.ReadAllLines("input.txt");
int total = 0;

foreach (string line in lines)
{
    Nullable<int> first = null;
    Nullable<int> last = null;
    List<char> digits = new List<char>();

    foreach (char c in line) {
        if(Char.IsDigit(c)) {
Console.WriteLine("char {0}", c);
            digits.Add(c);
        }
    }
    foreach (char d in digits) {
Console.WriteLine("char {0}", d);
    }
    first = digits.First();
Console.WriteLine("first {0}", first);
    last = digits.Last();
Console.WriteLine("last {0}", last);
    int lineNumber = int.Parse(string.Format("{0}{1}", first, last));
    total += lineNumber;
    break;

}
Console.WriteLine(total);

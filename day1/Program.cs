// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string[] lines = File.ReadAllLines("input.txt");
int[] allDigits;

foreach (string line in lines)
{
    Nullable<int> first = null;
    Nullable<int> last = null;
    int[] digits = [];

    foreach (char c in line) {
	      if(Char.IsDigit(c)) {
            digits.Append(c);
        }
    }
    Console.WriteLine("[{0}]", string.Join(", ", digits));
}


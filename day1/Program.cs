// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string[] lines = File.ReadAllLines("input.txt");
int[] allDigits;

foreach (string line in lines)
{
    int first;
    int last;
    int[] digits;

    foreach (char c in line) {
	if(Char.IsDigit(c)) {
            digits.Append(c);
        }
    }
}

Console.WriteLine(line);

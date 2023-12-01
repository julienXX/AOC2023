// See https://aka.ms/new-console-template for more information

string[] lines = File.ReadAllLines("input.txt");
int total = 0;

foreach (string line in lines)
{
    char? first = FirstDigit(line);
    char? last = FirstDigit(Reverse(line));
    int lineNumber = int.Parse(string.Format("{0}{1}", first, last));
    total += lineNumber;
}

Console.WriteLine(total);

char? FirstDigit(string s)
{
    foreach (char c in s)
    {
        if (Char.IsDigit(c))
        {
            return c;
        }
    }
    return null;
}

string Reverse(string s)
{
    char[] charArray = s.ToCharArray();
    Array.Reverse(charArray);
    return new string(charArray);
}


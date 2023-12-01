namespace Learning.CSharp
{
    public class Calibration
    {
        private static int total = 0;

        public static void Main()
        {
            foreach (string encryptedCalibrationValue in ReadEncryptedCalibrationValues())
            {
                int calibrationValue = DecryptCalibrationValue(encryptedCalibrationValue);
                total += calibrationValue;
            }
            Console.WriteLine(total);
        }

        static string[] ReadEncryptedCalibrationValues()
        {
            return File.ReadAllLines("input.txt");
        }

        static int DecryptCalibrationValue(string line)
        {
            char? first = FirstDigit(line);
            char? last = FirstDigit(Reverse(line));
            return MakeCalibrationValue(first, last);
        }

        static int MakeCalibrationValue(char? first, char? last)
        {
            return int.Parse(string.Format("{0}{1}", first, last));
        }

        static char? FirstDigit(string s)
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

        static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}

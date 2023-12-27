using System;

class param49
{
    static int HexToDec(string hex)
    {
        int result = 0;
        for (int i = 0; i < hex.Length; i++)
        {
            char c = hex[i];
            int digit = 0;
            if (char.IsDigit(c))
            {
                digit = c - '0';
            }
            else if (char.IsUpper(c))
            {
                digit = c - 'A' + 10;
            }
            else if (char.IsLower(c))
            {
                digit = c - 'a' + 10;
            }
            result = result * 16 + digit;
        }
        return result;
    }

    public static void Run()
    {
        string[] hexNumbers = { "1A", "FF", "2E", "9", "5B" };

        foreach (string hex in hexNumbers)
        {
            int dec = HexToDec(hex);
            Console.WriteLine($"16-ричное: {hex} -> Десятичное: {dec}");
        }
    }
}
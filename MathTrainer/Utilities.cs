namespace MathTrainer;

public static class Utilities
{
    public static int NumberOfDigits(int number)
    {
        if (number == 0) return 1;  // Special case for 0, as it has 1 digit
        return (int)Math.Floor(Math.Log10(Math.Abs(number)) + 1);
    }
}
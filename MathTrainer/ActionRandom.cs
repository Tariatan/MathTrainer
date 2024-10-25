namespace MathTrainer;

public static class ActionRandom
{
    private static readonly Random Randomizer = new();

    public static QuestionAction RandomFromSet(QuestionAction[] allowedValues)
    {
        var randomIndex = Randomizer.Next(0, allowedValues.Length);
        return allowedValues[randomIndex];
    }

    public static int RandomFromSet(int[] allowedValues)
    {
        var randomIndex = Randomizer.Next(0, allowedValues.Length);
        return allowedValues[randomIndex];
    }
}
using System.Reflection;

namespace MathTrainer;

public static class Extensions
{
    public static string ActionToString(this QuestionAction action)
    {
        return action switch
        {
            QuestionAction.Addition => "+",
            QuestionAction.Subtraction => "-",
            QuestionAction.Multiplication => "x",
            QuestionAction.Division => "\u00f7",
            QuestionAction.DivisionWithRemainder => "\u00f7",
            _ => throw new ArgumentOutOfRangeException()
        };
    }
}
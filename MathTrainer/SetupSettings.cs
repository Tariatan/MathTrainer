namespace MathTrainer;

public class SetupSettings
{
    public bool Addition { set; get; }
    public bool Subtraction { set; get; }
    public bool Multiplication { set; get; }
    public bool Division { set; get; }
    public bool DivisionWithRemainder { set; get; }

    public int NumbersFrom { set; get; }
    public int NumbersTo { set; get; }

    public int AdditionLimit { set; get; }

    public required Range MultiplicationAllowedValues { set; get; }

    public int ExerciseDuration { set; get; }
    public int QuestionDuration { set; get; }
}
using System.Media;
using MathTrainer.Properties;
using Timer = System.Windows.Forms.Timer;

namespace MathTrainer;

public partial class Trainer : Form
{
    private readonly Form m_SetupForm;
    private readonly SetupSettings m_Settings;
    private readonly Timer m_ExerciseProgressTimer = new();
    private readonly Timer m_QuestionTimer = new();
    private readonly Timer m_AnswerTimer = new();

    private readonly Random m_Rand = new();

    private int m_NumberOne;
    private int m_NumberTwo;

    private QuestionAction m_Action;
    private readonly List<QuestionAction> m_AllowedActions = [];

    private int m_AnswersCount;
    private int m_CorrectAnswersCount;

    private readonly SoundPlayer m_SoundPlayer = new();

    private readonly CircularProgressBar.CircularProgressBar m_QuestionCountdown = new();
    private readonly CircularProgressBar.CircularProgressBar m_ExerciseCountdown = new();

    public Trainer(Form setupForm, SetupSettings settings)
    {
        m_SetupForm = setupForm;
        m_Settings = settings;

        InitializeComponent();

        ResetAllData();

        InitializeAllowedAction();

        InitializeExerciseProgress();
        InitializeQuestionCountdown();
        InitializeAnswerTimer();

        NextQuestion();
        m_ExerciseProgressTimer.Start();
    }

    private void InitializeExerciseProgress()
    {
        m_ExerciseProgressTimer.Interval = 500;
        m_ExerciseProgressTimer.Tick += ExerciseProgressTimerOnTick;

        m_ExerciseCountdown.Step = 1;
        m_ExerciseCountdown.Minimum = 0;
        m_ExerciseCountdown.Maximum = m_Settings.QuestionDuration * 120;
        m_ExerciseCountdown.Location = ctrl_StatisticsBox.Location with { X = 30 };
        m_ExerciseCountdown.Size = new Size(135, 135);
        m_ExerciseCountdown.ProgressColor = Color.Gold;

        m_ExerciseCountdown.InnerWidth = 0;
        m_ExerciseCountdown.StartAngle = -90;
        m_ExerciseCountdown.Value = 0;

        Controls.Add(m_ExerciseCountdown);
    }

    private void InitializeQuestionCountdown()
    {
        m_QuestionTimer.Interval = 500;
        m_QuestionTimer.Tick += QuestionTimerOnTick;

        m_QuestionCountdown.Step = 100;
        m_QuestionCountdown.Minimum = 0;
        m_QuestionCountdown.Maximum = m_Settings.QuestionDuration * 200;
        m_QuestionCountdown.Size = new Size(55, 55);
        m_QuestionCountdown.Location = new Point(ctrl_Equation_Frame.Location.X - 2 * m_QuestionCountdown.Size.Width, ctrl_Equation_Frame.Location.Y + 15);
        m_QuestionCountdown.ProgressColor = Color.Gold;

        m_QuestionCountdown.InnerWidth = 0;
        m_QuestionCountdown.StartAngle = -90;
        m_QuestionCountdown.Value = 0;

        Controls.Add(m_QuestionCountdown);
    }

    private void ExerciseProgressTimerOnTick(object? sender, EventArgs e)
    {
        if (m_ExerciseCountdown.Value < m_ExerciseCountdown.Maximum)
        {
            m_ExerciseCountdown.PerformStep();
            return;
        }

        m_ExerciseProgressTimer.Stop();
        m_QuestionTimer.Stop();

        Chime(MathTrainer.Chime.Complete);
    }

    private void QuestionTimerOnTick(object? sender, EventArgs e)
    {
        if (m_QuestionCountdown.Value < m_QuestionCountdown.Maximum)
        {
            m_QuestionCountdown.PerformStep();
            return;
        }

        EvaluateAnswerAndProceed();
    }

    private void InitializeAnswerTimer()
    {
        m_AnswerTimer.Interval = 100;
        m_AnswerTimer.Tick += AnswerTimerOnTick;
    }

    private void AnswerTimerOnTick(object? sender, EventArgs e)
    {
        m_AnswerTimer.Stop();
        EvaluateAnswerAndProceed();
    }

    private void NextQuestion()
    {
        m_Action = ActionRandom.RandomFromSet(m_AllowedActions.ToArray());
        ctrl_R_Frame.Visible = m_Action is QuestionAction.DivisionWithRemainder;
        m_NumberOne = m_Rand.Next(m_Settings.NumbersFrom, m_Settings.NumbersTo + 1);
        m_NumberTwo = m_Rand.Next(m_Settings.NumbersFrom, m_Settings.NumbersTo + 1);

        if (m_Action is QuestionAction.Subtraction)
        {
            do
            {
                m_NumberTwo = m_Rand.Next(m_Settings.NumbersFrom, m_Settings.NumbersTo);
            }
            while (m_NumberTwo > m_NumberOne);
        }

        if (m_Action is QuestionAction.Addition)
        {
            do
            {
                m_NumberOne = m_Rand.Next(m_Settings.NumbersFrom, m_Settings.NumbersTo + 1);
                m_NumberTwo = m_Rand.Next(m_Settings.NumbersFrom, m_Settings.NumbersTo + 1);
            }
            while (m_NumberOne + m_NumberTwo > m_Settings.AdditionLimit);
        }

        if (m_Action is QuestionAction.Multiplication)
        {
            m_NumberOne = ActionRandom.RandomFromSet(m_Settings.MultiplicationAllowedValues.Columns);
            m_NumberTwo = ActionRandom.RandomFromSet(m_Settings.MultiplicationAllowedValues.Rows);

            // Swap numbers occasionally
            if (m_Rand.Next(2) == 0)
            {
                (m_NumberOne, m_NumberTwo) = (m_NumberTwo, m_NumberOne);
            }
        }

        if (m_Action is QuestionAction.Division)
        {
            var left = ActionRandom.RandomFromSet(m_Settings.MultiplicationAllowedValues.Columns);
            var right = ActionRandom.RandomFromSet(m_Settings.MultiplicationAllowedValues.Rows);

            // Swap numbers occasionally
            if (m_Rand.Next(2) == 0)
            {
                (left, right) = (right, left);
            }

            m_NumberOne = left * right;
            m_NumberTwo = left;
        }

        if (m_Action is QuestionAction.DivisionWithRemainder)
        {
            m_NumberOne = m_Rand.Next(m_Settings.NumbersFrom, m_Settings.NumbersTo + 1);

            do
            {
                m_NumberTwo = m_Rand.Next(2, 10);
            }
            while (m_NumberTwo > m_NumberOne || m_NumberOne == m_NumberOne / m_NumberTwo * m_NumberTwo);

        }

        ctrl_NumberOne.Text = m_NumberOne.ToString();
        ctrl_NumberTwo.Text = m_NumberTwo.ToString();
        ctrl_Action.Text = m_Action.ActionToString();
        ctrl_Answer.Text = string.Empty;
        ctrl_R.Text = string.Empty;

        m_QuestionTimer.Start();
    }

    private void OnKeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode is Keys.Delete or Keys.Return or Keys.Back)
        {
            ctrl_Answer.Text = string.Empty;
            ctrl_R.Text = string.Empty;
        }
    }

    private void OnKeyPress(object sender, KeyPressEventArgs e)
    {
        if (!m_ExerciseProgressTimer.Enabled)
        {
            return;
        }

        if (m_AnswerTimer.Enabled)
        {
            return;
        }

        if (!char.IsDigit(e.KeyChar))
        {
            return;
        }

        if (e.KeyChar == '0' && m_Action is not QuestionAction.Subtraction && ctrl_Answer.Text.Length == 0)
        {
            return;
        }

        var correctAnswer = GetCorrectAnswer();
        if (m_Action is QuestionAction.DivisionWithRemainder)
        {
            if (ctrl_Answer.Text.Length < Utilities.NumberOfDigits(correctAnswer))
            {
                ctrl_Answer.Text += e.KeyChar;
                return;
            }

            ctrl_R.Text += e.KeyChar;

            if (ctrl_R.Text.Length < Utilities.NumberOfDigits(GetCorrectRemainder()))
            {
                return;
            }

            m_QuestionTimer.Stop();
            m_AnswerTimer.Start();

            return;
        }

        ctrl_Answer.Text += e.KeyChar;

        if (ctrl_Answer.Text.Length < Utilities.NumberOfDigits(correctAnswer))
        {
            return;
        }

        m_QuestionTimer.Stop();
        m_AnswerTimer.Start();
    }

    private int GetCorrectAnswer()
    {
        return m_Action switch
        {
            QuestionAction.Addition => m_NumberOne + m_NumberTwo,
            QuestionAction.Subtraction => m_NumberOne - m_NumberTwo,
            QuestionAction.Multiplication => m_NumberOne * m_NumberTwo,
            QuestionAction.Division => m_NumberOne / m_NumberTwo,
            QuestionAction.DivisionWithRemainder => m_NumberOne / m_NumberTwo,
            _ => throw new ArgumentOutOfRangeException()
        };
    }

    private int GetCorrectRemainder()
    {
        return m_NumberOne - m_NumberOne / m_NumberTwo * m_NumberTwo;
    }

    private void EvaluateAnswerAndProceed()
    {
        m_QuestionTimer.Stop();
        m_QuestionCountdown.Value = 0;
        m_QuestionCountdown.Update();
        Thread.Sleep(100);

        var answer = ctrl_Answer.Text.Length > 0 ? ctrl_Answer.Text : "0";
        var remainder = ctrl_R.Text.Length > 0 ? ctrl_R.Text : "0";

        StoreAnswer(int.Parse(answer), int.Parse(remainder));

        UpdateStatistics();

        NextQuestion();
    }

    private void StoreAnswer(int answer, int remainder)
    {
        var correctAnswer = GetCorrectAnswer();
        var isCorrect = answer == correctAnswer;

        var correctRemainder = -1;

        if (m_Action is QuestionAction.DivisionWithRemainder)
        {
            correctRemainder = GetCorrectRemainder();
            var isCorrectRemainder = remainder == correctRemainder;

            isCorrect = isCorrect && isCorrectRemainder;
        }

        ++m_AnswersCount;
        if (isCorrect)
        {
            ++m_CorrectAnswersCount;
        }

        var question = ctrl_NumberOne.Text + " " + ctrl_Action.Text + " " + ctrl_NumberTwo.Text + " =";

        ctrl_Question5.Text = ctrl_Question4.Text;
        ctrl_Question5.ForeColor = ctrl_Question4.ForeColor;
        ctrl_Result5.Text = ctrl_Result4.Text;
        ctrl_Result5.ForeColor = ctrl_Result4.ForeColor;
        ctrl_Answer5.Text = ctrl_Answer4.Text;
        ctrl_Question4.Text = ctrl_Question3.Text;
        ctrl_Question4.ForeColor = ctrl_Question3.ForeColor;
        ctrl_Result4.Text = ctrl_Result3.Text;
        ctrl_Result4.ForeColor = ctrl_Result3.ForeColor;
        ctrl_Answer4.Text = ctrl_Answer3.Text;
        ctrl_Question3.Text = ctrl_Question2.Text;
        ctrl_Question3.ForeColor = ctrl_Question2.ForeColor;
        ctrl_Result3.Text = ctrl_Result2.Text;
        ctrl_Result3.ForeColor = ctrl_Result2.ForeColor;
        ctrl_Answer3.Text = ctrl_Answer2.Text;
        ctrl_Question2.Text = ctrl_Question1.Text;
        ctrl_Question2.ForeColor = ctrl_Question1.ForeColor;
        ctrl_Result2.Text = ctrl_Result1.Text;
        ctrl_Result2.ForeColor = ctrl_Result1.ForeColor;
        ctrl_Answer2.Text = ctrl_Answer1.Text;
        ctrl_Answer2.ForeColor = ctrl_Answer1.ForeColor;

        if (m_Action is QuestionAction.DivisionWithRemainder)
        {
            ctrl_ResultR5.Text = ctrl_ResultR4.Text;
            ctrl_ResultR5.ForeColor = ctrl_ResultR4.ForeColor;
            ctrl_AnswerR5.ForeColor = ctrl_AnswerR4.ForeColor;
            ctrl_AnswerR5.Text = ctrl_AnswerR4.Text;
            ctrl_ResultR4.Text = ctrl_ResultR3.Text;
            ctrl_ResultR4.ForeColor = ctrl_ResultR3.ForeColor;
            ctrl_AnswerR4.ForeColor = ctrl_AnswerR3.ForeColor;
            ctrl_AnswerR4.Text = ctrl_AnswerR3.Text;
            ctrl_ResultR3.Text = ctrl_ResultR2.Text;
            ctrl_ResultR3.ForeColor = ctrl_ResultR2.ForeColor;
            ctrl_AnswerR3.ForeColor = ctrl_AnswerR2.ForeColor;
            ctrl_AnswerR3.Text = ctrl_AnswerR2.Text;
            ctrl_ResultR2.Text = ctrl_ResultR1.Text;
            ctrl_ResultR2.ForeColor = ctrl_ResultR1.ForeColor;
            ctrl_AnswerR2.ForeColor = ctrl_AnswerR1.ForeColor;
            ctrl_AnswerR2.Text = ctrl_AnswerR1.Text;
        }

        ctrl_Question1.Text = question;
        ctrl_Question1.ForeColor = isCorrect ? Color.Blue : Color.OrangeRed;
        ctrl_Result1.Text = correctAnswer.ToString();
        ctrl_Result1.ForeColor = isCorrect ? Color.Blue : Color.Green;
        ctrl_Answer1.Text = isCorrect ? string.Empty : answer.ToString();

        if (m_Action is QuestionAction.DivisionWithRemainder)
        {
            ctrl_ResultR1.Text = correctRemainder.ToString();
            ctrl_ResultR1.ForeColor = isCorrect ? Color.Blue : Color.Green;
            ctrl_AnswerR1.Text = isCorrect ? string.Empty : remainder.ToString();
        }

        Chime(isCorrect ? MathTrainer.Chime.Success : MathTrainer.Chime.Failure);
    }

    private void Chime(Chime chime)
    {
        var sound = chime switch
        {
            MathTrainer.Chime.Success => Resources.success,
            MathTrainer.Chime.Failure => Resources.failure,
            MathTrainer.Chime.Complete => Resources.complete,
            _ => throw new ArgumentOutOfRangeException(nameof(chime), chime, null)
        };
        using Stream soundStream = sound;
        m_SoundPlayer.Stream = soundStream;
        m_SoundPlayer.Play();
    }

    private void UpdateStatistics()
    {
        ctrl_AnswersTotal.Text = m_AnswersCount.ToString();
        ctrl_AnswersCorrect.Text = m_CorrectAnswersCount.ToString();
        ctrl_AnswersRatio.Text = m_AnswersCount == 0 ? string.Empty : (m_CorrectAnswersCount * 100 / m_AnswersCount) + "%";
    }

    private void InitializeAllowedAction()
    {
        if (m_Settings.Addition)
        {
            m_AllowedActions.Add(QuestionAction.Addition);
        }
        if (m_Settings.Subtraction)
        {
            m_AllowedActions.Add(QuestionAction.Subtraction);
        }
        if (m_Settings.Multiplication)
        {
            m_AllowedActions.Add(QuestionAction.Multiplication);
        }
        if (m_Settings.Division)
        {
            m_AllowedActions.Add(QuestionAction.Division);
        }
        if (m_Settings.DivisionWithRemainder)
        {
            m_AllowedActions.Add(QuestionAction.DivisionWithRemainder);
        }
    }

    private void ResetAllData()
    {
        m_AnswersCount = 0;
        m_CorrectAnswersCount = 0;

        #region Timers
        m_ExerciseProgressTimer.Stop();
        m_QuestionTimer.Stop();
        #endregion

        #region Question
        ctrl_NumberOne.Text = string.Empty;
        ctrl_NumberTwo.Text = string.Empty;
        ctrl_Action.Text = string.Empty;
        ctrl_Answer.Text = string.Empty;
        ctrl_R.Text = string.Empty;
        ctrl_R_Frame.Visible = false;
        #endregion

        #region History
        ctrl_Question1.Text = string.Empty;
        ctrl_Result1.Text = string.Empty;
        ctrl_ResultR1.Text = string.Empty;
        ctrl_Answer1.Text = string.Empty;
        ctrl_AnswerR1.Text = string.Empty;
        ctrl_Question2.Text = string.Empty;
        ctrl_Result2.Text = string.Empty;
        ctrl_ResultR2.Text = string.Empty;
        ctrl_Answer2.Text = string.Empty;
        ctrl_AnswerR2.Text = string.Empty;
        ctrl_Question3.Text = string.Empty;
        ctrl_Result3.Text = string.Empty;
        ctrl_ResultR3.Text = string.Empty;
        ctrl_Answer3.Text = string.Empty;
        ctrl_AnswerR3.Text = string.Empty;
        ctrl_Question4.Text = string.Empty;
        ctrl_Result4.Text = string.Empty;
        ctrl_ResultR4.Text = string.Empty;
        ctrl_Answer4.Text = string.Empty;
        ctrl_AnswerR4.Text = string.Empty;
        ctrl_Question5.Text = string.Empty;
        ctrl_Result5.Text = string.Empty;
        ctrl_ResultR5.Text = string.Empty;
        ctrl_Answer5.Text = string.Empty;
        ctrl_AnswerR5.Text = string.Empty;
        #endregion

        #region Stats
        ctrl_AnswersTotal.Text = string.Empty;
        ctrl_AnswersCorrect.Text = string.Empty;
        ctrl_AnswersRatio.Text = string.Empty;
        #endregion

        m_SoundPlayer.Stop();
    }

    private void menu_Restart_Click(object sender, EventArgs e)
    {
        ResetAllData();
        Hide();
        m_SetupForm.Show();
    }

    private void OnClose(object sender, FormClosedEventArgs e)
    {
        m_SetupForm.Close();
    }

    private void OnResultR1Changed(object sender, EventArgs e) => ctrl_ResultR1_Frame.Visible = ctrl_ResultR1.Text.Length > 0;
    private void OnResultR2Changed(object sender, EventArgs e) => ctrl_ResultR2_Frame.Visible = ctrl_ResultR2.Text.Length > 0;
    private void OnResultR3Changed(object sender, EventArgs e) => ctrl_ResultR3_Frame.Visible = ctrl_ResultR3.Text.Length > 0;
    private void OnResultR4Changed(object sender, EventArgs e) => ctrl_ResultR4_Frame.Visible = ctrl_ResultR4.Text.Length > 0;
    private void OnResultR5Changed(object sender, EventArgs e) => ctrl_ResultR5_Frame.Visible = ctrl_ResultR5.Text.Length > 0;
    private void OnAnswerR1Changed(object sender, EventArgs e) => ctrl_AnswerR1_Frame.Visible = ctrl_AnswerR1.Text.Length > 0;
    private void OnAnswerR2Changed(object sender, EventArgs e) => ctrl_AnswerR2_Frame.Visible = ctrl_AnswerR2.Text.Length > 0;
    private void OnAnswerR3Changed(object sender, EventArgs e) => ctrl_AnswerR3_Frame.Visible = ctrl_AnswerR3.Text.Length > 0;
    private void OnAnswerR4Changed(object sender, EventArgs e) => ctrl_AnswerR4_Frame.Visible = ctrl_AnswerR4.Text.Length > 0;
    private void OnAnswerR5Changed(object sender, EventArgs e) => ctrl_AnswerR5_Frame.Visible = ctrl_AnswerR5.Text.Length > 0;
    private void OnAnswer1Changed(object sender, EventArgs e) => ctrl_Answer1.Visible = ctrl_Answer1.Text.Length > 0;
    private void OnAnswer2Changed(object sender, EventArgs e) => ctrl_Answer2.Visible = ctrl_Answer2.Text.Length > 0;
    private void OnAnswer3Changed(object sender, EventArgs e) => ctrl_Answer3.Visible = ctrl_Answer3.Text.Length > 0;
    private void OnAnswer4Changed(object sender, EventArgs e) => ctrl_Answer4.Visible = ctrl_Answer4.Text.Length > 0;
    private void OnAnswer5Changed(object sender, EventArgs e) => ctrl_Answer5.Visible = ctrl_Answer5.Text.Length > 0;

    private void OnQuestion1Changed(object sender, EventArgs e) => ctrl_Question1.Visible = ctrl_Question1.Text.Length > 0;
    private void OnQuestion2Changed(object sender, EventArgs e) => ctrl_Question2.Visible = ctrl_Question2.Text.Length > 0;
    private void OnQuestion3Changed(object sender, EventArgs e) => ctrl_Question3.Visible = ctrl_Question3.Text.Length > 0;
    private void OnQuestion4Changed(object sender, EventArgs e) => ctrl_Question4.Visible = ctrl_Question4.Text.Length > 0;
    private void OnQuestion5Changed(object sender, EventArgs e) => ctrl_Question5.Visible = ctrl_Question5.Text.Length > 0;
    private void OnResult1Changed(object sender, EventArgs e) => ctrl_Result1.Visible = ctrl_Result1.Text.Length > 0;
    private void OnResult2Changed(object sender, EventArgs e) => ctrl_Result2.Visible = ctrl_Result2.Text.Length > 0;
    private void OnResult3Changed(object sender, EventArgs e) => ctrl_Result3.Visible = ctrl_Result3.Text.Length > 0;
    private void OnResult4Changed(object sender, EventArgs e) => ctrl_Result4.Visible = ctrl_Result4.Text.Length > 0;
    private void OnResult5Changed(object sender, EventArgs e) => ctrl_Result5.Visible = ctrl_Result5.Text.Length > 0;
}
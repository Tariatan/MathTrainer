namespace MathTrainer;

public partial class Setup : Form
{
    public Setup()
    {
        InitializeComponent();

        GenerateMultiplicationTable();

        ctrl_Start.Enabled = false;
    }

    private void GenerateMultiplicationTable()
    {
        var table = new int[8, 8];

        // Populate the multiplication table
        for (var i = 2; i <= 9; i++)
        {
            for (var j = 2; j <= 9; j++)
            {
                table[i - 2, j - 2] = i * j; // Fill the array
            }
        }

        // Bind to DataGridView
        ctrl_MultiplicationTable.ColumnCount = 8;
        ctrl_MultiplicationTable.RowCount = 8;

        // Set headers
        for (var i = 0; i < 8; i++)
        {
            ctrl_MultiplicationTable.Columns[i].HeaderText = (i + 2).ToString();
        }

        // Fill DataGridView with the multiplication table
        for (var i = 0; i < 8; i++)
        {
            ctrl_MultiplicationTable.Rows[i].HeaderCell.Value = (i + 2).ToString();
            for (var j = 0; j < 8; j++)
            {
                ctrl_MultiplicationTable.Rows[i].Cells[j].Value = table[i, j];
            }
        }
    }

    private void OnStartClick(object sender, EventArgs e)
    {
        var settings = new SetupSettings()
        {
            Addition = ctrl_Addition.Checked,
            Division = ctrl_Division.Checked,
            DivisionWithRemainder = ctrl_DivisionWithRemainder.Checked,
            Multiplication = ctrl_Multiplication.Checked,
            Subtraction = ctrl_Subtraction.Checked,
            NumbersFrom = (int)ctrl_NumbersFrom.Value,
            NumbersTo = (int)ctrl_NumbersTo.Value,
            AdditionLimit = (int)ctrl_AdditionExtraLimit.Value,
            MultiplicationAllowedValues = GetAllowedMultiplicationValues(),
            ExerciseDuration = (int)ctrl_ExerciseDuration.Value,
            QuestionDuration = (int)ctrl_QuestionDuration.Value,
        };

        var trainer = new Trainer(this, settings);
        Hide();
        trainer.Show();
    }

    private void OnChanged(object sender, EventArgs e)
    {
        var controls = new List<CheckBox>(){ ctrl_Addition, ctrl_Subtraction, ctrl_Multiplication, ctrl_Division, ctrl_DivisionWithRemainder };
        ctrl_Start.Enabled = controls.Any(c => c.Checked);

        ctrl_AdditionExtraBox.Enabled = ctrl_Addition.Checked;
        ctrl_MultiplicationTable.Enabled = ctrl_Multiplication.Checked || ctrl_Division.Checked;

    }

    private void OnMinValueChanged(object sender, EventArgs e)
    {
        ctrl_NumbersTo.Minimum = ctrl_NumbersFrom.Value;
    }

    private void OnMultiplicationTableSelectionChanged(object sender, EventArgs e)
    {
        ColorizeMultiplicationTableHeaders();
    }

    private void OnMultiplicationTableEnabledChanged(object sender, EventArgs e)
    {
        ColorizeMultiplicationTableHeaders();
    }

    private void ColorizeMultiplicationTableHeaders()
    {
        var color = ctrl_MultiplicationTable.Enabled ? Color.Cornsilk : Color.Gray;

        for (var i = 0; i < ctrl_MultiplicationTable.ColumnCount; i++)
        {
            ctrl_MultiplicationTable.Columns[i].HeaderCell.Style.ForeColor = color;
            ctrl_MultiplicationTable.Rows[i].HeaderCell.Style.ForeColor = color;
        }

        if (ctrl_MultiplicationTable.Enabled is false)
        {
            return;
        }

        var cells = ctrl_MultiplicationTable.SelectedCells;
        for (var i = 0; i < cells.Count; i++)
        {
            ctrl_MultiplicationTable.Columns[cells[i].ColumnIndex].HeaderCell.Style.ForeColor = Color.DarkOrange;
            ctrl_MultiplicationTable.Rows[cells[i].RowIndex].HeaderCell.Style.ForeColor = Color.DarkOrange;
        }
    }

    private Range GetAllowedMultiplicationValues()
    {
        var columns = new List<int>();
        var rows = new List<int>();

        var cells = ctrl_MultiplicationTable.SelectedCells;

        for (var i = 0; i < cells.Count; i++)
        {
            var col = ctrl_MultiplicationTable.Columns[cells[i].ColumnIndex].HeaderText;
            var row = ctrl_MultiplicationTable.Rows[cells[i].RowIndex].HeaderCell.Value.ToString()!;

            columns.Add(int.Parse(col));
            rows.Add(int.Parse(row));
        }

        return new Range(columns.ToArray(), rows.ToArray());
    }
}
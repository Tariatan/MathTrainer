namespace MathTrainer;

public sealed class ReverseProgressBar : ProgressBar
{
    public ReverseProgressBar()
    {
        RightToLeft = RightToLeft.Yes;
        RightToLeftLayout = true;
    }

    public new int Value
    {
        get => base.Value;
        set => base.Value = Maximum - value;
    }

    public Color ProgressColor { get; set; } = Color.Blue; // Default color

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        if (this.Value > 0)
        {
            using (var brush = new SolidBrush(ProgressColor))
            {
                // Draw the filled area of the ProgressBar
                e.Graphics.FillRectangle(brush, 0, 0, (int)(this.Width * ((float)this.Value / this.Maximum)), this.Height);
            }
        }
    }

}
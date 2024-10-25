using System.ComponentModel;
using Timer = System.Windows.Forms.Timer;

namespace MathTrainer;

public sealed class CountdownControl : UserControl
{
    private readonly Timer m_Timer = new();
    private int m_CountdownTime = 10;  // Total countdown time in seconds
    private int m_ElapsedTime = 0;     // Time that has passed

    public EventHandler TimeOut;

    [Category("Countdown Settings"), Description("Total countdown time in seconds.")]
    public int CountdownTime
    {
        get => m_CountdownTime;
        set { m_CountdownTime = value; Invalidate(); }
    }

    public CountdownControl()
    {
        // Initialize the Timer
        m_Timer.Interval = 1000; // 1 second intervals
        m_Timer.Tick += Timer_Tick;

        // Optional: Double-buffering for smoother rendering
        this.DoubleBuffered = true;

        // Set default size
        this.Size = new Size(55, 55);
    }

    // Start the countdown
    public void StartCountdown()
    {
        m_ElapsedTime = 0;
        m_Timer.Start();
    }

    // Start the countdown
    public void StopCountdown()
    {
        m_ElapsedTime = 0;
        m_Timer.Stop();
    }

    // Start the countdown
    public void RestartCountdown()
    {
        m_ElapsedTime = 0;
        m_Timer.Stop();
        m_Timer.Start();
    }

    // Timer tick event handler
    private void Timer_Tick(object? sender, EventArgs e)
    {
        m_ElapsedTime++;
        if (m_ElapsedTime >= m_CountdownTime)
        {
            m_Timer.Stop(); // Stop when countdown finishes
            TimeOut.Invoke(this, EventArgs.Empty);
        }

        this.Invalidate(); // Force the control to repaint (call OnPaint)
    }

    // Override OnPaint to draw the countdown circle
    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        // Get graphics object
        var g = e.Graphics;

        // Calculate percentage completed
        var percentage = (float)m_ElapsedTime / m_CountdownTime;

        // Circle parameters
        var circleRadius = Math.Min(this.ClientSize.Width, this.ClientSize.Height) / 2;
        var circleX = (this.ClientSize.Width - circleRadius * 2) / 2;
        var circleY = (this.ClientSize.Height - circleRadius * 2) / 2;

        // Draw the background circle (gray)
        g.FillEllipse(Brushes.Yellow, circleX, circleY, circleRadius * 2, circleRadius * 2);

        // Draw the countdown arc (green)
        using var pen = new Pen(Color.Green, 15);
        // Calculate the sweep angle (based on percentage completed)
        var sweepAngle = 360 * (1 - percentage);

        // Draw the arc
        g.DrawArc(pen, circleX, circleY, circleRadius * 2, circleRadius * 2, -90, sweepAngle);

        // Draw the time remaining in the center of the circle
        var timeLeftText = (m_CountdownTime - m_ElapsedTime).ToString();
        var font = new Font("Arial", 24, FontStyle.Bold);
        var textSize = g.MeasureString(timeLeftText, font);
        var textPosition = new PointF(
            (this.ClientSize.Width - textSize.Width) / 2,
            (this.ClientSize.Height - textSize.Height) / 2);

        //g.DrawString(timeLeftText, font, Brushes.Black, textPosition);
    }
}
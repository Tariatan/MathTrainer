namespace MathTrainer
{
    partial class Setup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Setup));
            ctrl_Addition = new CheckBox();
            ctrl_Subtraction = new CheckBox();
            ctrl_Multiplication = new CheckBox();
            ctrl_Division = new CheckBox();
            ctrl_ExerciseDuration = new NumericUpDown();
            ctrl_QuestionDuration = new NumericUpDown();
            label3 = new Label();
            label4 = new Label();
            ctrl_Start = new Button();
            ctrl_NumbersFrom = new NumericUpDown();
            ctrl_NumbersTo = new NumericUpDown();
            groupBox1 = new GroupBox();
            ctrl_AdditionExtraBox = new GroupBox();
            ctrl_AdditionExtraLimit = new NumericUpDown();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            pictureBox1 = new PictureBox();
            ctrl_MultiplicationTable = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            groupBox4 = new GroupBox();
            ctrl_DivisionWithRemainder = new CheckBox();
            groupBox5 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)ctrl_ExerciseDuration).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ctrl_QuestionDuration).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ctrl_NumbersFrom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ctrl_NumbersTo).BeginInit();
            groupBox1.SuspendLayout();
            ctrl_AdditionExtraBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ctrl_AdditionExtraLimit).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ctrl_MultiplicationTable).BeginInit();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // ctrl_Addition
            // 
            ctrl_Addition.AutoSize = true;
            ctrl_Addition.BackColor = Color.Transparent;
            ctrl_Addition.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ctrl_Addition.ForeColor = SystemColors.ControlLightLight;
            ctrl_Addition.Location = new Point(21, 22);
            ctrl_Addition.Name = "ctrl_Addition";
            ctrl_Addition.Size = new Size(137, 34);
            ctrl_Addition.TabIndex = 0;
            ctrl_Addition.Text = "Сложение";
            ctrl_Addition.UseVisualStyleBackColor = false;
            ctrl_Addition.CheckedChanged += OnChanged;
            // 
            // ctrl_Subtraction
            // 
            ctrl_Subtraction.AutoSize = true;
            ctrl_Subtraction.BackColor = Color.Transparent;
            ctrl_Subtraction.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ctrl_Subtraction.ForeColor = Color.Gainsboro;
            ctrl_Subtraction.Location = new Point(21, 114);
            ctrl_Subtraction.Name = "ctrl_Subtraction";
            ctrl_Subtraction.Size = new Size(146, 34);
            ctrl_Subtraction.TabIndex = 1;
            ctrl_Subtraction.Text = "Вычитание";
            ctrl_Subtraction.UseVisualStyleBackColor = false;
            ctrl_Subtraction.CheckedChanged += OnChanged;
            // 
            // ctrl_Multiplication
            // 
            ctrl_Multiplication.AutoSize = true;
            ctrl_Multiplication.BackColor = Color.Transparent;
            ctrl_Multiplication.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ctrl_Multiplication.ForeColor = Color.Cornsilk;
            ctrl_Multiplication.Location = new Point(21, 39);
            ctrl_Multiplication.Name = "ctrl_Multiplication";
            ctrl_Multiplication.Size = new Size(152, 34);
            ctrl_Multiplication.TabIndex = 2;
            ctrl_Multiplication.Text = "Умножение";
            ctrl_Multiplication.UseVisualStyleBackColor = false;
            ctrl_Multiplication.CheckedChanged += OnChanged;
            // 
            // ctrl_Division
            // 
            ctrl_Division.AutoSize = true;
            ctrl_Division.BackColor = Color.Transparent;
            ctrl_Division.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ctrl_Division.ForeColor = Color.DarkOrange;
            ctrl_Division.Location = new Point(21, 101);
            ctrl_Division.Name = "ctrl_Division";
            ctrl_Division.Size = new Size(120, 34);
            ctrl_Division.TabIndex = 3;
            ctrl_Division.Text = "Деление";
            ctrl_Division.UseVisualStyleBackColor = false;
            ctrl_Division.CheckedChanged += OnChanged;
            // 
            // ctrl_ExerciseDuration
            // 
            ctrl_ExerciseDuration.BackColor = SystemColors.ControlDarkDark;
            ctrl_ExerciseDuration.Font = new Font("Segoe UI", 15.75F);
            ctrl_ExerciseDuration.ForeColor = Color.Cornsilk;
            ctrl_ExerciseDuration.Location = new Point(21, 35);
            ctrl_ExerciseDuration.Maximum = new decimal(new int[] { 15, 0, 0, 0 });
            ctrl_ExerciseDuration.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            ctrl_ExerciseDuration.Name = "ctrl_ExerciseDuration";
            ctrl_ExerciseDuration.Size = new Size(120, 35);
            ctrl_ExerciseDuration.TabIndex = 7;
            ctrl_ExerciseDuration.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // ctrl_QuestionDuration
            // 
            ctrl_QuestionDuration.BackColor = SystemColors.ControlDarkDark;
            ctrl_QuestionDuration.Font = new Font("Segoe UI", 15.75F);
            ctrl_QuestionDuration.ForeColor = Color.Cornsilk;
            ctrl_QuestionDuration.Location = new Point(17, 35);
            ctrl_QuestionDuration.Maximum = new decimal(new int[] { 15, 0, 0, 0 });
            ctrl_QuestionDuration.Minimum = new decimal(new int[] { 3, 0, 0, 0 });
            ctrl_QuestionDuration.Name = "ctrl_QuestionDuration";
            ctrl_QuestionDuration.Size = new Size(120, 35);
            ctrl_QuestionDuration.TabIndex = 8;
            ctrl_QuestionDuration.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.ForeColor = Color.Cornsilk;
            label3.Location = new Point(8, 73);
            label3.Name = "label3";
            label3.Size = new Size(36, 30);
            label3.TabIndex = 9;
            label3.Text = "от";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.ForeColor = Color.Cornsilk;
            label4.Location = new Point(130, 73);
            label4.Name = "label4";
            label4.Size = new Size(39, 30);
            label4.TabIndex = 11;
            label4.Text = "до";
            // 
            // ctrl_Start
            // 
            ctrl_Start.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ctrl_Start.Location = new Point(192, 600);
            ctrl_Start.Name = "ctrl_Start";
            ctrl_Start.Size = new Size(170, 67);
            ctrl_Start.TabIndex = 9;
            ctrl_Start.Text = "Старт";
            ctrl_Start.UseVisualStyleBackColor = true;
            ctrl_Start.Click += OnStartClick;
            // 
            // ctrl_NumbersFrom
            // 
            ctrl_NumbersFrom.BackColor = SystemColors.ControlDarkDark;
            ctrl_NumbersFrom.Font = new Font("Segoe UI", 15.75F);
            ctrl_NumbersFrom.ForeColor = Color.Cornsilk;
            ctrl_NumbersFrom.Location = new Point(50, 71);
            ctrl_NumbersFrom.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            ctrl_NumbersFrom.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            ctrl_NumbersFrom.Name = "ctrl_NumbersFrom";
            ctrl_NumbersFrom.Size = new Size(74, 35);
            ctrl_NumbersFrom.TabIndex = 4;
            ctrl_NumbersFrom.Value = new decimal(new int[] { 4, 0, 0, 0 });
            ctrl_NumbersFrom.ValueChanged += OnMinValueChanged;
            // 
            // ctrl_NumbersTo
            // 
            ctrl_NumbersTo.BackColor = SystemColors.ControlDarkDark;
            ctrl_NumbersTo.Font = new Font("Segoe UI", 15.75F);
            ctrl_NumbersTo.ForeColor = Color.Cornsilk;
            ctrl_NumbersTo.Location = new Point(167, 71);
            ctrl_NumbersTo.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            ctrl_NumbersTo.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            ctrl_NumbersTo.Name = "ctrl_NumbersTo";
            ctrl_NumbersTo.Size = new Size(77, 35);
            ctrl_NumbersTo.TabIndex = 5;
            ctrl_NumbersTo.Value = new decimal(new int[] { 9, 0, 0, 0 });
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(ctrl_NumbersTo);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(ctrl_NumbersFrom);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBox1.ForeColor = Color.Cornsilk;
            groupBox1.Location = new Point(333, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(258, 180);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Числа";
            // 
            // ctrl_AdditionExtraBox
            // 
            ctrl_AdditionExtraBox.BackColor = Color.Transparent;
            ctrl_AdditionExtraBox.Controls.Add(ctrl_AdditionExtraLimit);
            ctrl_AdditionExtraBox.Enabled = false;
            ctrl_AdditionExtraBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ctrl_AdditionExtraBox.ForeColor = Color.Cornsilk;
            ctrl_AdditionExtraBox.Location = new Point(164, 22);
            ctrl_AdditionExtraBox.Name = "ctrl_AdditionExtraBox";
            ctrl_AdditionExtraBox.Size = new Size(154, 72);
            ctrl_AdditionExtraBox.TabIndex = 16;
            ctrl_AdditionExtraBox.TabStop = false;
            ctrl_AdditionExtraBox.Text = "Сумма не более";
            // 
            // ctrl_AdditionExtraLimit
            // 
            ctrl_AdditionExtraLimit.BackColor = SystemColors.ControlDarkDark;
            ctrl_AdditionExtraLimit.Font = new Font("Segoe UI", 15.75F);
            ctrl_AdditionExtraLimit.ForeColor = Color.Cornsilk;
            ctrl_AdditionExtraLimit.Location = new Point(22, 28);
            ctrl_AdditionExtraLimit.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            ctrl_AdditionExtraLimit.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            ctrl_AdditionExtraLimit.Name = "ctrl_AdditionExtraLimit";
            ctrl_AdditionExtraLimit.Size = new Size(71, 35);
            ctrl_AdditionExtraLimit.TabIndex = 6;
            ctrl_AdditionExtraLimit.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(ctrl_ExerciseDuration);
            groupBox2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBox2.ForeColor = Color.Cornsilk;
            groupBox2.Location = new Point(34, 460);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(263, 82);
            groupBox2.TabIndex = 17;
            groupBox2.TabStop = false;
            groupBox2.Text = "Продолжительность тренировки";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.Transparent;
            groupBox3.Controls.Add(ctrl_QuestionDuration);
            groupBox3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBox3.ForeColor = Color.Cornsilk;
            groupBox3.Location = new Point(303, 460);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(213, 82);
            groupBox3.TabIndex = 18;
            groupBox3.TabStop = false;
            groupBox3.Text = "Время на каждый вопрос";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Enabled = false;
            pictureBox1.Image = Properties.Resources.ahtung;
            pictureBox1.Location = new Point(522, 460);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(110, 225);
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // ctrl_MultiplicationTable
            // 
            ctrl_MultiplicationTable.AllowUserToAddRows = false;
            ctrl_MultiplicationTable.AllowUserToDeleteRows = false;
            ctrl_MultiplicationTable.AllowUserToResizeColumns = false;
            ctrl_MultiplicationTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle1.ForeColor = Color.Cornsilk;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            ctrl_MultiplicationTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            ctrl_MultiplicationTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ctrl_MultiplicationTable.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 7F);
            dataGridViewCellStyle2.ForeColor = Color.CornflowerBlue;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            ctrl_MultiplicationTable.DefaultCellStyle = dataGridViewCellStyle2;
            ctrl_MultiplicationTable.Enabled = false;
            ctrl_MultiplicationTable.EnableHeadersVisualStyles = false;
            ctrl_MultiplicationTable.Location = new Point(333, 19);
            ctrl_MultiplicationTable.Margin = new Padding(0);
            ctrl_MultiplicationTable.Name = "ctrl_MultiplicationTable";
            ctrl_MultiplicationTable.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle3.ForeColor = Color.Cornsilk;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            ctrl_MultiplicationTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            ctrl_MultiplicationTable.RowHeadersWidth = 20;
            ctrl_MultiplicationTable.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = Color.DarkGray;
            dataGridViewCellStyle4.ForeColor = Color.Cornsilk;
            ctrl_MultiplicationTable.RowsDefaultCellStyle = dataGridViewCellStyle4;
            ctrl_MultiplicationTable.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ctrl_MultiplicationTable.RowTemplate.DefaultCellStyle.SelectionBackColor = SystemColors.ActiveCaption;
            ctrl_MultiplicationTable.RowTemplate.DefaultCellStyle.SelectionForeColor = SystemColors.ButtonFace;
            ctrl_MultiplicationTable.RowTemplate.Height = 18;
            ctrl_MultiplicationTable.RowTemplate.Resizable = DataGridViewTriState.False;
            ctrl_MultiplicationTable.ScrollBars = ScrollBars.None;
            ctrl_MultiplicationTable.SelectionMode = DataGridViewSelectionMode.CellSelect;
            ctrl_MultiplicationTable.ShowCellErrors = false;
            ctrl_MultiplicationTable.ShowCellToolTips = false;
            ctrl_MultiplicationTable.ShowEditingIcon = false;
            ctrl_MultiplicationTable.ShowRowErrors = false;
            ctrl_MultiplicationTable.Size = new Size(180, 162);
            ctrl_MultiplicationTable.TabIndex = 20;
            ctrl_MultiplicationTable.SelectionChanged += OnMultiplicationTableSelectionChanged;
            ctrl_MultiplicationTable.EnabledChanged += OnMultiplicationTableEnabledChanged;
            // 
            // Column1
            // 
            Column1.HeaderText = "2";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Resizable = DataGridViewTriState.False;
            Column1.SortMode = DataGridViewColumnSortMode.NotSortable;
            Column1.Width = 20;
            // 
            // Column2
            // 
            Column2.HeaderText = "3";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Resizable = DataGridViewTriState.False;
            Column2.SortMode = DataGridViewColumnSortMode.NotSortable;
            Column2.Width = 20;
            // 
            // Column3
            // 
            Column3.HeaderText = "4";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Resizable = DataGridViewTriState.False;
            Column3.SortMode = DataGridViewColumnSortMode.NotSortable;
            Column3.Width = 20;
            // 
            // Column4
            // 
            Column4.HeaderText = "5";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Resizable = DataGridViewTriState.False;
            Column4.SortMode = DataGridViewColumnSortMode.NotSortable;
            Column4.Width = 20;
            // 
            // Column5
            // 
            Column5.HeaderText = "6";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Resizable = DataGridViewTriState.False;
            Column5.SortMode = DataGridViewColumnSortMode.NotSortable;
            Column5.Width = 20;
            // 
            // Column6
            // 
            Column6.HeaderText = "7";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Resizable = DataGridViewTriState.False;
            Column6.SortMode = DataGridViewColumnSortMode.NotSortable;
            Column6.Width = 20;
            // 
            // Column7
            // 
            Column7.HeaderText = "8";
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            Column7.Resizable = DataGridViewTriState.False;
            Column7.SortMode = DataGridViewColumnSortMode.NotSortable;
            Column7.Width = 20;
            // 
            // Column8
            // 
            Column8.HeaderText = "9";
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            Column8.Resizable = DataGridViewTriState.False;
            Column8.SortMode = DataGridViewColumnSortMode.NotSortable;
            Column8.Width = 20;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.Transparent;
            groupBox4.Controls.Add(ctrl_DivisionWithRemainder);
            groupBox4.Controls.Add(ctrl_Addition);
            groupBox4.Controls.Add(groupBox1);
            groupBox4.Controls.Add(ctrl_Subtraction);
            groupBox4.Controls.Add(ctrl_AdditionExtraBox);
            groupBox4.Location = new Point(34, 18);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(598, 216);
            groupBox4.TabIndex = 21;
            groupBox4.TabStop = false;
            // 
            // ctrl_DivisionWithRemainder
            // 
            ctrl_DivisionWithRemainder.AutoSize = true;
            ctrl_DivisionWithRemainder.BackColor = Color.Transparent;
            ctrl_DivisionWithRemainder.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ctrl_DivisionWithRemainder.ForeColor = Color.DarkOrange;
            ctrl_DivisionWithRemainder.Location = new Point(21, 168);
            ctrl_DivisionWithRemainder.Name = "ctrl_DivisionWithRemainder";
            ctrl_DivisionWithRemainder.Size = new Size(237, 34);
            ctrl_DivisionWithRemainder.TabIndex = 21;
            ctrl_DivisionWithRemainder.Text = "Деление с остатком";
            ctrl_DivisionWithRemainder.UseVisualStyleBackColor = false;
            ctrl_DivisionWithRemainder.CheckedChanged += OnChanged;
            // 
            // groupBox5
            // 
            groupBox5.BackColor = Color.Transparent;
            groupBox5.Controls.Add(ctrl_Multiplication);
            groupBox5.Controls.Add(ctrl_Division);
            groupBox5.Controls.Add(ctrl_MultiplicationTable);
            groupBox5.Location = new Point(34, 240);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(598, 203);
            groupBox5.TabIndex = 22;
            groupBox5.TabStop = false;
            // 
            // Setup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FloralWhite;
            BackgroundImage = Properties.Resources.background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(669, 709);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(ctrl_Start);
            DoubleBuffered = true;
            ForeColor = Color.CornflowerBlue;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Setup";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Настройки";
            TopMost = true;
            ((System.ComponentModel.ISupportInitialize)ctrl_ExerciseDuration).EndInit();
            ((System.ComponentModel.ISupportInitialize)ctrl_QuestionDuration).EndInit();
            ((System.ComponentModel.ISupportInitialize)ctrl_NumbersFrom).EndInit();
            ((System.ComponentModel.ISupportInitialize)ctrl_NumbersTo).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ctrl_AdditionExtraBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ctrl_AdditionExtraLimit).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ctrl_MultiplicationTable).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private CheckBox ctrl_Addition;
        private CheckBox ctrl_Subtraction;
        private CheckBox ctrl_Multiplication;
        private CheckBox ctrl_Division;
        private NumericUpDown ctrl_ExerciseDuration;
        private NumericUpDown ctrl_QuestionDuration;
        private Label label3;
        private Label label4;
        private Button ctrl_Start;
        private NumericUpDown ctrl_NumbersFrom;
        private NumericUpDown ctrl_NumbersTo;
        private GroupBox groupBox1;
        private GroupBox ctrl_AdditionExtraBox;
        private NumericUpDown ctrl_AdditionExtraLimit;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private PictureBox pictureBox1;
        private DataGridView ctrl_MultiplicationTable;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private CheckBox ctrl_DivisionWithRemainder;
    }
}
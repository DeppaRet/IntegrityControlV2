namespace IntegrityV2
{
  partial class MainWindow
  {
    /// <summary>
    /// Обязательная переменная конструктора.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Освободить все используемые ресурсы.
    /// </summary>
    /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Код, автоматически созданный конструктором форм Windows

    /// <summary>
    /// Требуемый метод для поддержки конструктора — не изменяйте 
    /// содержимое этого метода с помощью редактора кода.
    /// </summary>
    private void InitializeComponent()
    {
      this.Start = new System.Windows.Forms.Button();
      this.Action = new System.Windows.Forms.ComboBox();
      this.label3 = new System.Windows.Forms.Label();
      this.Method = new System.Windows.Forms.ComboBox();
      this.label4 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.Output = new System.Windows.Forms.RichTextBox();
      this.Input = new System.Windows.Forms.RichTextBox();
      this.Polinom = new System.Windows.Forms.TextBox();
      this.PolinomText = new System.Windows.Forms.Label();
      this.ControlSumText = new System.Windows.Forms.Label();
      this.ControlSum = new System.Windows.Forms.TextBox();
      this.VerticalControlSumText = new System.Windows.Forms.Label();
      this.VerticalControlSum = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // Start
      // 
      this.Start.Location = new System.Drawing.Point(608, 104);
      this.Start.Name = "Start";
      this.Start.Size = new System.Drawing.Size(75, 23);
      this.Start.TabIndex = 25;
      this.Start.Text = "Выполнить";
      this.Start.UseVisualStyleBackColor = true;
      this.Start.Click += new System.EventHandler(this.Start_Click);
      // 
      // Action
      // 
      this.Action.FormattingEnabled = true;
      this.Action.Items.AddRange(new object[] {
            "Отправить сообщение",
            "Проверить полученное сообщение"});
      this.Action.Location = new System.Drawing.Point(494, 77);
      this.Action.Name = "Action";
      this.Action.Size = new System.Drawing.Size(202, 21);
      this.Action.TabIndex = 24;
      this.Action.SelectedIndexChanged += new System.EventHandler(this.Action_SelectedIndexChanged);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label3.Location = new System.Drawing.Point(491, 58);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(177, 16);
      this.label3.TabIndex = 23;
      this.label3.Text = "Что необходимо сделать?";
      // 
      // Method
      // 
      this.Method.FormattingEnabled = true;
      this.Method.Items.AddRange(new object[] {
            "Контроль по паритету",
            "Вертикальный и горизонтальный контроль",
            "Цикличесйкий избыточный контроль"});
      this.Method.Location = new System.Drawing.Point(494, 28);
      this.Method.Name = "Method";
      this.Method.Size = new System.Drawing.Size(202, 21);
      this.Method.TabIndex = 22;
      this.Method.SelectedIndexChanged += new System.EventHandler(this.Method_SelectedIndexChanged);
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label4.Location = new System.Drawing.Point(491, 9);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(119, 16);
      this.label4.TabIndex = 21;
      this.label4.Text = "Выберите метод:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(248, 12);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(110, 13);
      this.label2.TabIndex = 20;
      this.label2.Text = "Полученные данные";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(8, 12);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(123, 13);
      this.label1.TabIndex = 19;
      this.label1.Text = "Отправленные данные";
      // 
      // Output
      // 
      this.Output.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.Output.Location = new System.Drawing.Point(251, 28);
      this.Output.Name = "Output";
      this.Output.Size = new System.Drawing.Size(237, 259);
      this.Output.TabIndex = 18;
      this.Output.Text = "";
      // 
      // Input
      // 
      this.Input.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.Input.Location = new System.Drawing.Point(8, 28);
      this.Input.Name = "Input";
      this.Input.Size = new System.Drawing.Size(237, 259);
      this.Input.TabIndex = 17;
      this.Input.Text = "";
      // 
      // Polinom
      // 
      this.Polinom.Enabled = false;
      this.Polinom.Location = new System.Drawing.Point(494, 267);
      this.Polinom.Name = "Polinom";
      this.Polinom.Size = new System.Drawing.Size(202, 20);
      this.Polinom.TabIndex = 26;
      this.Polinom.Visible = false;
      // 
      // PolinomText
      // 
      this.PolinomText.AutoSize = true;
      this.PolinomText.Location = new System.Drawing.Point(491, 251);
      this.PolinomText.Name = "PolinomText";
      this.PolinomText.Size = new System.Drawing.Size(192, 13);
      this.PolinomText.TabIndex = 27;
      this.PolinomText.Text = "Введите полином в двоичной форме";
      this.PolinomText.Visible = false;
      // 
      // ControlSumText
      // 
      this.ControlSumText.AutoSize = true;
      this.ControlSumText.Location = new System.Drawing.Point(491, 134);
      this.ControlSumText.Name = "ControlSumText";
      this.ControlSumText.Size = new System.Drawing.Size(109, 13);
      this.ControlSumText.TabIndex = 29;
      this.ControlSumText.Text = "Контрольная сумма";
      this.ControlSumText.Visible = false;
      // 
      // ControlSum
      // 
      this.ControlSum.Location = new System.Drawing.Point(494, 150);
      this.ControlSum.Name = "ControlSum";
      this.ControlSum.Size = new System.Drawing.Size(202, 20);
      this.ControlSum.TabIndex = 28;
      this.ControlSum.Visible = false;
      // 
      // VerticalControlSumText
      // 
      this.VerticalControlSumText.AutoSize = true;
      this.VerticalControlSumText.Location = new System.Drawing.Point(491, 177);
      this.VerticalControlSumText.Name = "VerticalControlSumText";
      this.VerticalControlSumText.Size = new System.Drawing.Size(183, 13);
      this.VerticalControlSumText.TabIndex = 31;
      this.VerticalControlSumText.Text = "Вертикальная контрольная сумма";
      this.VerticalControlSumText.Visible = false;
      // 
      // VerticalControlSum
      // 
      this.VerticalControlSum.Location = new System.Drawing.Point(494, 193);
      this.VerticalControlSum.Name = "VerticalControlSum";
      this.VerticalControlSum.Size = new System.Drawing.Size(202, 20);
      this.VerticalControlSum.TabIndex = 30;
      this.VerticalControlSum.Visible = false;
      // 
      // MainWindow
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(704, 299);
      this.Controls.Add(this.VerticalControlSumText);
      this.Controls.Add(this.VerticalControlSum);
      this.Controls.Add(this.ControlSumText);
      this.Controls.Add(this.ControlSum);
      this.Controls.Add(this.PolinomText);
      this.Controls.Add(this.Polinom);
      this.Controls.Add(this.Start);
      this.Controls.Add(this.Action);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.Method);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.Output);
      this.Controls.Add(this.Input);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "MainWindow";
      this.Text = "MainWindow";
      this.Load += new System.EventHandler(this.MainWindow_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Button Start;
    private System.Windows.Forms.ComboBox Action;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.ComboBox Method;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.RichTextBox Output;
    private System.Windows.Forms.RichTextBox Input;
    private System.Windows.Forms.TextBox Polinom;
    private System.Windows.Forms.Label PolinomText;
    private System.Windows.Forms.Label ControlSumText;
    private System.Windows.Forms.TextBox ControlSum;
    private System.Windows.Forms.Label VerticalControlSumText;
    private System.Windows.Forms.TextBox VerticalControlSum;
  }
}


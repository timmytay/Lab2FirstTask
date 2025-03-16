namespace Lab2FirstTask
{
  partial class Form1
  {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      label1 = new Label();
      KopeckAmount = new NumericUpDown();
      button1 = new Button();
      checkTheme = new CheckBox();
      ((System.ComponentModel.ISupportInitialize)KopeckAmount).BeginInit();
      SuspendLayout();
      // 
      // label1
      // 
      label1.AutoSize = true;
      label1.Location = new Point(12, 15);
      label1.Name = "label1";
      label1.Size = new Size(167, 15);
      label1.TabIndex = 2;
      label1.Text = "Укажите количество копеек: ";
      // 
      // KopeckAmount
      // 
      KopeckAmount.Location = new Point(185, 12);
      KopeckAmount.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
      KopeckAmount.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
      KopeckAmount.Name = "KopeckAmount";
      KopeckAmount.RightToLeft = RightToLeft.No;
      KopeckAmount.Size = new Size(88, 23);
      KopeckAmount.TabIndex = 3;
      KopeckAmount.Value = new decimal(new int[] { 1, 0, 0, 0 });
      // 
      // button1
      // 
      button1.BackColor = SystemColors.Window;
      button1.ForeColor = SystemColors.ControlText;
      button1.Location = new Point(12, 41);
      button1.Name = "button1";
      button1.Size = new Size(194, 23);
      button1.TabIndex = 4;
      button1.Text = "Вывести число рублей и копеек";
      button1.UseVisualStyleBackColor = false;
      button1.Click += button1_Click;
      // 
      // checkTheme
      // 
      checkTheme.AutoSize = true;
      checkTheme.Location = new Point(12, 70);
      checkTheme.Name = "checkTheme";
      checkTheme.Size = new Size(95, 19);
      checkTheme.TabIndex = 5;
      checkTheme.Text = "Тёмная тема";
      checkTheme.UseVisualStyleBackColor = true;
      checkTheme.CheckedChanged += checkBox1_CheckedChanged;
      // 
      // Form1
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      BackColor = SystemColors.Window;
      ClientSize = new Size(284, 111);
      Controls.Add(checkTheme);
      Controls.Add(button1);
      Controls.Add(KopeckAmount);
      Controls.Add(label1);
      Name = "Form1";
      StartPosition = FormStartPosition.CenterScreen;
      Text = "Конвертер копеек";
      ((System.ComponentModel.ISupportInitialize)KopeckAmount).EndInit();
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion
    private Label label1;
    private NumericUpDown KopeckAmount;
    private Button button1;
    private CheckBox checkTheme;
  }
}

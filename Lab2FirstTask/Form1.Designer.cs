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
      button1 = new Button();
      label2 = new Label();
      KopeckAmount = new TextBox();
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
      // button1
      // 
      button1.BackColor = SystemColors.Window;
      button1.ForeColor = SystemColors.ControlText;
      button1.Location = new Point(238, 41);
      button1.Name = "button1";
      button1.Size = new Size(63, 25);
      button1.TabIndex = 4;
      button1.Text = "Расчёт";
      button1.UseVisualStyleBackColor = false;
      button1.Click += button1_Click;
      // 
      // label2
      // 
      label2.AutoSize = true;
      label2.Location = new Point(12, 46);
      label2.Name = "label2";
      label2.Size = new Size(220, 15);
      label2.TabIndex = 6;
      label2.Text = "Вывести количество рублей и копеек: ";
      // 
      // KopeckAmount
      // 
      KopeckAmount.Location = new Point(185, 12);
      KopeckAmount.Name = "KopeckAmount";
      KopeckAmount.Size = new Size(116, 23);
      KopeckAmount.TabIndex = 7;
      KopeckAmount.KeyPress += textBox1_KeyPress;
      // 
      // Form1
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      BackColor = SystemColors.Window;
      ClientSize = new Size(311, 75);
      Controls.Add(KopeckAmount);
      Controls.Add(label2);
      Controls.Add(button1);
      Controls.Add(label1);
      Name = "Form1";
      StartPosition = FormStartPosition.CenterScreen;
      Text = "Конвертер копеек";
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion
    private Label label1;
    private Button button1;
    private Label label2;
    private TextBox KopeckAmount;
  }
}

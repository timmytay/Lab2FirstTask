using System.Windows.Forms.VisualStyles;

namespace Lab2FirstTask
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
      KopeckAmount.Text = Properties.Settings.Default.numerKopecks.ToString();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      try
      {
        int val = int.Parse(KopeckAmount.Text);

        if (val < 1 || val > 9999)
          throw new ArgumentOutOfRangeException();

        string message = ProcessInput(val);
        MessageBox.Show(message, "Вывод ответа", MessageBoxButtons.OK, MessageBoxIcon.Information);
        Properties.Settings.Default.numerKopecks = val;
        Properties.Settings.Default.Save();
      }
      catch (FormatException)
      {
        MessageBox.Show("Вы можете вводить лишь числа.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
      catch (ArgumentOutOfRangeException)
      {
        MessageBox.Show("Необходимо ввести целое число от 1 до 9999.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    public string ProcessInput(int input)
    {
      int costInKopecks = input;
      int rubles = costInKopecks / 100;
      int kopecks = costInKopecks % 100;

      string result = $"{rubles} {GetRublesEnding(rubles)} ";
      result += $"{kopecks} {GetKopecksEnding(kopecks)}";

      return result;
    }

    private static string GetRublesEnding(int rubles)
    {
      if (rubles >= 11 && rubles <= 14)
        return "рублей";
      else
        return rubles % 10 == 1 ? "рубль" :
               rubles % 10 >= 2 && rubles % 10 <= 4 ? "рубля" :
               "рублей";
    }

    private static string GetKopecksEnding(int kopecks)
    {
      if (kopecks >= 11 && kopecks <= 14)
        return "копеек";
      else
        return kopecks % 10 == 1 ? "копейка" :
               kopecks % 10 >= 2 && kopecks % 10 <= 4 ? "копейки" :
               "копеек";
    }

    private void KopeckAmount_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (e.KeyChar == (char)Keys.Enter)
      {
        button1.PerformClick();
        e.Handled = true;
      }
    }

    private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (e.KeyChar == (char)Keys.Enter)
      {
        button1.PerformClick();
        e.Handled = true;
      }
    }

    // Обработчик события закрытия формы для сохранения настроек
    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
      Properties.Settings.Default.Save(); // Здесь мы сохраняем настройки автоматически
    }
  }
}
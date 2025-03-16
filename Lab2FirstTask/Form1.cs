namespace Lab2FirstTask
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
    }

    private void button1_Click(object sender, EventArgs e)
    {
      // Получаем значение из NumericUpDown
      decimal value = KopeckAmount.Value;

      // Формируем сообщение для отображения
      string message = ProcessInput(value); // Получаем результат из ProcessInput

      // Показываем сообщение с измененным заголовком и иконкой
      MessageBox.Show(message, "Вывод ответа", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void checkBox1_CheckedChanged(object sender, EventArgs e)
    {
      if (checkTheme.Checked) // Если CheckBox отмечен
      {
        // Устанавливаем темные цвета для формы
        checkTheme.BackColor = Color.DimGray; // Темный фон
        checkTheme.ForeColor = Color.White; // Белый текст

        // Устанавливаем цвета для элементов управления
        button1.BackColor = Color.DimGray;
        button1.ForeColor = Color.White;

        KopeckAmount.BackColor = Color.DimGray;
        KopeckAmount.ForeColor = Color.White;

        this.BackColor = Color.DimGray;
        this.ForeColor = Color.White;
      }
      else // Если CheckBox не отмечен
      {
        // Возвращаем все в светлое состояние
        checkTheme.BackColor = Color.White; // Светлый фон
        checkTheme.ForeColor = Color.Black; // Черный текст

        // Устанавливаем цвета для элементов управления
        button1.BackColor = Color.White; // Светлый фон для кнопки
        button1.ForeColor = Color.Black; // Черный текст для кнопки

        KopeckAmount.BackColor = Color.White; // Светлый фон для другого элемента
        KopeckAmount.ForeColor = Color.Black; // Черный текст для другого элемента

        this.BackColor = Color.White; // Светлый фон для формы
        this.ForeColor = Color.Black; // Черный текст для формы
      }
    }

    public string ProcessInput(decimal input)
    {
      int costInKopecks = (int)input; // Преобразуем decimal в int
      int rubles = costInKopecks / 100;
      int kopecks = costInKopecks % 100;

      // Формируем строку результата
      string result = $"{rubles} {GetRublesEnding(rubles)} ";
      result += $"{kopecks} {GetKopecksEnding(kopecks)}";

      return result; // Возвращаем результат
    }

    private static string GetRublesEnding(int rubles)
    {
      if (rubles >= 11 && rubles <= 14)
      {
        return "рублей";
      }
      else
      {
        return rubles % 10 == 1 ? "рубль" :
               rubles % 10 >= 2 && rubles % 10 <= 4 ? "рубля" :
               "рублей";
      }
    }

    private static string GetKopecksEnding(int kopecks)
    {
      if (kopecks >= 11 && kopecks <= 14)
      {
        return "копеек";
      }
      else
      {
        return kopecks % 10 == 1 ? "копейка" :
               kopecks % 10 >= 2 && kopecks % 10 <= 4 ? "копейки" :
               "копеек";
      }
    }
  }
}

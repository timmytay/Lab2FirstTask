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
      string message = $"Вы ввели {value} копеек.";

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
  }
}
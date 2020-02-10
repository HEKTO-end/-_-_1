using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace калькулятор
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Class1 pipio = new Class1();//ОБьявление класса
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_a_TextChanged(object sender, TextCompositionEventArgs e)
        {

        }
        /// <summary>
        /// выводит ответы или ошибку
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
                                    
            if (TextBox_a.Text != string.Empty && TextBox_b.Text != string.Empty && TextBox_c.Text != string.Empty)
            {
                if (!Char.IsDigit(TextBox_a.Text, 0) || !Char.IsDigit(TextBox_b.Text, 0) || !Char.IsDigit(TextBox_c.Text, 0)) //Провека что чувак ввёл числа а не буквы
                {
                    MessageBox.Show("были введены некоретные данные");
                    TextBox_a.Clear();
                    TextBox_b.Clear(); //Очищает textBox
                    TextBox_c.Clear();
                    TextBlock_a.Text = null;
                    TextBlock_b.Text = null;
                    TextBlock_c.Text = null;
                }
                else
                {
                    var a = Convert.ToInt32(TextBox_a.Text); //Передаёт значение с  textBox в перменную
                    var b = Convert.ToInt32(TextBox_b.Text); //Передаёт значение с  textBox в перменную
                    var c = Convert.ToInt32(TextBox_c.Text); //Передаёт значение с  textBox в перменную
                    if (pipio.Check(a, b, c) != 0)
                    {
                        this.Otvet.Text = ($"P = {pipio.Check(a, b, c)}" +
                        $"\nS = { Math.Round(pipio.Area(a, b, c), 3) }" +
                        $"\nR вписанной окружности = { Math.Round(pipio.Area_of_inner_circle(a, b, c), 3)}");                    
                        TextBlock_a.Text = TextBox_a.Text;
                        TextBlock_b.Text = TextBox_b.Text;
                        TextBlock_c.Text = TextBox_c.Text;
                    }
                    else
                    {
                        MessageBox.Show("были введены некоретные данные");
                        TextBlock_a.Text = null;
                        TextBlock_b.Text = null;
                        TextBlock_c.Text = null;
                    }
                }
            }
            else
            {
                MessageBox.Show("Ячейки не могут быть пустыми");
                TextBox_a.Clear();
                TextBox_b.Clear();
                TextBox_c.Clear();
                TextBlock_a.Text = null;
                TextBlock_b.Text = null;
                TextBlock_c.Text = null;
            }
        }
        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.Key == Key.D1 || e.Key == Key.D2 || e.Key == Key.D3 || e.Key == Key.D4 || e.Key == Key.D5 || e.Key == Key.D6 || e.Key == Key.D7 || e.Key == Key.D8 || e.Key == Key.D9 || e.Key == Key.D0)
            {
                    TextBlock_a.Text = TextBox_a.Text; //если нажата цифра то передаёт данные с textBox в textBlock
            }

        } // метод для отслеживания нажатий. НЕ РЕАЛИЗОВАННА ДО КОНЦА
        private void TextBox_a_TextChanged(object sender, TextChangedEventArgs e)
        {

        } 
        private void TextBox_KeyDown1(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.D1 || e.Key == Key.D2 || e.Key == Key.D3 || e.Key == Key.D4 || e.Key == Key.D5 || e.Key == Key.D6 || e.Key == Key.D7 || e.Key == Key.D8 || e.Key == Key.D9 || e.Key == Key.D0)
            {
                TextBlock_b.Text = TextBox_b.Text;
            }
        } // метод для отслеживания нажатий. НЕ РЕАЛИЗОВАННА ДО КОНЦА
        private void TextBox_b_TextChanged(object sender, TextChangedEventArgs e)
        {

        } 
        private void TextBox_KeyDown2(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.D1 || e.Key == Key.D2 || e.Key == Key.D3 || e.Key == Key.D4 || e.Key == Key.D5 || e.Key == Key.D6 || e.Key == Key.D7 || e.Key == Key.D8 || e.Key == Key.D9 || e.Key == Key.D0)
            {
                TextBlock_c.Text = TextBox_c.Text;
            }
        } // метод для отслеживания нажатий. НЕ РЕАЛИЗОВАННА ДО КОНЦА
        private void TextBox_c_TextChanged(object sender, TextChangedEventArgs e)
        {

        } 
    }
}

using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace lab3mdk
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Result.Text = "";

            Cursor cursor = new Cursor();
            cursor = cursor + (int.Parse(korX.Text), int.Parse(korY.Text));
            Result.Text += ($"Координаты курсора: X = {cursor.X}, Y = {cursor.Y}");
            korX.Text = "";
            korY.Text = "";

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Result.Text = "";

            Cursor cursor = new Cursor();

            if (int.TryParse(SizeKurs.Text, out int number))
            {
                if (number <= 15)
                {
                    cursor.Size = int.Parse(SizeKurs.Text);
                    Result.Text += ($"размер курсора:{cursor.Size}");
                    SizeKurs.Text = "";
                }
                else
                {
                    SizeKurs.Text = "";

                    MessageBox.Show("Веденные данные должы быть не больше 15");
                }
            }
            else
            {
                SizeKurs.Text = "";
                MessageBox.Show("Веденные данные должны быть числами");

            }


        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Result.Text = "";
            Cursor cursor = new Cursor();
            
           if (Visibility.Text == "виден")
            {
                cursor.ShowCursor();
                Result.Text += ($"Видиомсть курсора:{cursor.Visible}");
            }
           else if (Visibility.Text == "не виден")
            {cursor.HideCursor();
                Result.Text += ($"Видиомсть курсора:{cursor.Visible}");
            }

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Result.Text = "";
            Cursor cursor = new Cursor();
            if (ViewKurs.Text != "горизонтальный" && ViewKurs.Text != "вертикальный")
            {
                MessageBox.Show("Вы можете выбирать одну из видов курсора: горизонтальный или вертикальный");
               ViewKurs.Text = "";
            }
            else {
                cursor.Orientation = ViewKurs.Text;
                Result.Text += ($"Вид курсора: {cursor.Orientation}");
                ViewKurs.Text = "";
            }
            ViewKurs.Text = "";
        }
    }
}
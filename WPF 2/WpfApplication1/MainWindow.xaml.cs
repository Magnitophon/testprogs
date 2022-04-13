using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

namespace WpfApplication1
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

        private void bttn1_Click(object sender, RoutedEventArgs e)
        {
            double a, b, c;   
            if(rdbttn1.IsChecked==true)
               {
                Treugol T =new Treugol();
                a=T.get_A();
                b=T.get_B();
                c = T.get_C(); 
                double p=(a+b+c)/2;
                double S = Math.Sqrt(p*(p - a)*(p - b)*(p - c));
                double P = a + b + c;
                ans.Content = "Ответ: Р = " + P + "; S = " + S;
               }
            if (rdbttn2.IsChecked == true)
            {
                if (txtbxCoord.Text == "" || txtbxCoord1.Text == "" || txtbxCoord2.Text == "" || txtbxCoord3.Text == "" || txtbxCoord4.Text == "" || txtbxCoord5.Text == "")
                    ans.Content = "Заполните все поля!";
                else{
                int x1 = Convert.ToInt16(txtbxCoord.Text);
                int y1 = Convert.ToInt16(txtbxCoord1.Text);
                int x2 = Convert.ToInt16(txtbxCoord2.Text);
                int y2 = Convert.ToInt16(txtbxCoord3.Text);
                int x3 = Convert.ToInt16(txtbxCoord4.Text);
                int y3 = Convert.ToInt16(txtbxCoord5.Text);
                if ((x1 == x2 && y1 == y2) || (x1 == x3 && y1 == y3) || (x2 == x3 && y2 == y3))
                    ans.Content = "Треугольник не существует!";
                else
                {
                    Treugol T = new Treugol(x1, y1, x2, y2, x3, y3);
                    a = T.get_A();
                    b = T.get_B();
                    c = T.get_C();
                    if (a + b > c && a + c > b && c + b > a)
                    {
                        double p = (a + b + c) / 2;
                        double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                        double P = a + b + c;
                        ans.Content = "Ответ: Р = " + P + "; S = " + S;
                    }
                    else
                        ans.Content = "Треугольник не существует!";
                }
                }
            }
            if (rdbttn2_Copy.IsChecked == true)
            {
                if (txtbx1.Text == "" || txtbx2.Text == "" || txtbx3.Text == "")
                    ans.Content = "Заполните все поля!";
                else
                {
                    Treugol T = new Treugol();
                    a = Convert.ToInt16(txtbx1.Text);
                    b = Convert.ToInt16(txtbx2.Text);
                    c = Convert.ToInt16(txtbx3.Text);
                    if (a + b > c && a + c > b && c + b > a)
                    {
                        double p = (a + b + c) / 2;
                        double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                        double P = a + b + c;
                        ans.Content = "Ответ: Р = " + P + "; S = " + S;
                    }
                    else
                        ans.Content = "Треугольник не существует!";
                }
            }
        }

        private void close_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }


        private void auth_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Автор: Козлов Дмитрий" + "\n\nГруппа: 121791");
        }

        private void rdbttn2_Copy_Checked(object sender, RoutedEventArgs e)
        {
            txtbx1.Clear();
            txtbx2.Clear();
            txtbx3.Clear();
            txtbxCoord.Clear();
            txtbxCoord1.Clear();
            txtbxCoord2.Clear();
            txtbxCoord3.Clear();
            txtbxCoord4.Clear();
            txtbxCoord5.Clear();
            txtbx1.IsEnabled = true;
            txtbx2.IsEnabled = true;
            txtbx3.IsEnabled = true;
            txtbxCoord.IsEnabled = false;
            txtbxCoord1.IsEnabled = false;
            txtbxCoord2.IsEnabled = false;
            txtbxCoord3.IsEnabled = false;
            txtbxCoord4.IsEnabled = false;
            txtbxCoord5.IsEnabled = false;
        }

        private void rdbttn1_Checked(object sender, RoutedEventArgs e)
        {
            txtbx1.Clear();
            txtbx2.Clear();
            txtbx3.Clear();
            txtbxCoord.Clear();
            txtbxCoord1.Clear();
            txtbxCoord2.Clear();
            txtbxCoord3.Clear();
            txtbxCoord4.Clear();
            txtbxCoord5.Clear();
            Treugol T = new Treugol();
            txtbx1.Text = Convert.ToString(T.get_A());
            txtbx2.Text = Convert.ToString(T.get_B());
            txtbx3.Text = Convert.ToString(T.get_C());
            txtbx1.IsEnabled = false;
            txtbx2.IsEnabled = false;
            txtbx3.IsEnabled = false;
            txtbxCoord.IsEnabled = false;
            txtbxCoord1.IsEnabled = false;
            txtbxCoord2.IsEnabled = false;
            txtbxCoord3.IsEnabled = false;
            txtbxCoord4.IsEnabled = false;
            txtbxCoord5.IsEnabled = false;
        }

        private void rdbttn2_Checked(object sender, RoutedEventArgs e)
        {
            txtbx1.Clear();
            txtbx2.Clear();
            txtbx3.Clear();
            txtbxCoord.Clear();
            txtbxCoord1.Clear();
            txtbxCoord2.Clear();
            txtbxCoord3.Clear();
            txtbxCoord4.Clear();
            txtbxCoord5.Clear();
            txtbx1.IsEnabled = false;
            txtbx2.IsEnabled = false;
            txtbx3.IsEnabled = false;
            txtbxCoord.IsEnabled = true;
            txtbxCoord1.IsEnabled = true;
            txtbxCoord2.IsEnabled = true;
            txtbxCoord3.IsEnabled = true;
            txtbxCoord4.IsEnabled = true;
            txtbxCoord5.IsEnabled = true;
        }

        private void task1_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void task2_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}

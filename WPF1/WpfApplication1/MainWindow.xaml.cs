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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void del_all_Click(object sender, RoutedEventArgs e)
        {
            text1.Text = "";
            lstbox1.Items.Clear();
            lstbox2.Items.Clear();
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void cmbbox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void write_Click(object sender, RoutedEventArgs e)
        {
            int n = cmbbox1.SelectedIndex;
            switch(n)
            {
                case 0:
                    int l = lstbox1.Items.Count;
                    lstbox1.Items.Add(lstbox1.Items + "");
                    for(int i=l-1;i>=0;i--)
                    {
                        lstbox1.Items[i + 1] = lstbox1.Items[i];
                    }
                    lstbox1.Items[0] = text1.Text;
                    break;
                case 1:
                    lstbox1.Items.Add(text1.Text);break;
                case 2:
                    int ind1 = -1;
                    int ll = lstbox1.Items.Count;
                        ind1 = lstbox1.SelectedIndex;
                    if (ind1 <= -1)
                        MessageBox.Show("Элемент не выбран!");
                    else
                    {
                        lstbox1.Items.Add(lstbox1.Items + "");
                        for (int i = ll - 1; i >= ind1; i--)
                        {
                            lstbox1.Items[i + 1] = lstbox1.Items[i];
                        }
                        lstbox1.Items[ind1] = text1.Text;
                    }
                    break;

                case 3:
                    int ind2 = -1;
                        int l2 = lstbox1.Items.Count;
                        ind2 = lstbox1.SelectedIndex;
                        if (ind2 <= -1)
                             MessageBox.Show("Элемент не выбран!");
                        else{
                        lstbox1.Items.Add(lstbox1.Items + "");
                        for (int i = l2 - 1; i > ind2; i--)
                        {
                            lstbox1.Items[i + 1] = lstbox1.Items[i];
                        }
                        lstbox1.Items[ind2 + 1] = text1.Text;
                    }
                    break;
            }
        }

        private void right1_Click(object sender, RoutedEventArgs e)
        {
            int n = -1;
            n = lstbox1.SelectedIndex;
            int count = lstbox1.Items.Count;
            if (n <= -1)
                MessageBox.Show("Элемент не выбран!");
            else
            {
                lstbox2.Items.Add(lstbox1.Items[n]);
                lstbox1.Items.RemoveAt(n);
            }
        }

        private void right2_Click(object sender, RoutedEventArgs e)
        {
            foreach (var obj in lstbox1.Items)
                lstbox2.Items.Add(obj);
            lstbox1.Items.Clear();
        }

        private void left1_Click(object sender, RoutedEventArgs e)
        {
            int n = -1;
            n = lstbox2.SelectedIndex;
            int count = lstbox2.Items.Count;
            if (n <= -1)
                MessageBox.Show("Элемент не выбран!");
            else
            {
                lstbox1.Items.Add(lstbox2.Items[n]);
                lstbox2.Items.RemoveAt(n);
            }
        }

        private void left2_Click(object sender, RoutedEventArgs e)
        {
            foreach (var obj in lstbox2.Items)
                lstbox1.Items.Add(obj);
            lstbox2.Items.Clear();
        }

        private void mnuNew1_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void mnuNew2_Click(object sender, RoutedEventArgs e)
        {
            text1.Text = "";
            lstbox1.Items.Clear();
            lstbox2.Items.Clear(); 
        }

        private void mnuNew3_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Автор: Зеленев Илья");
        }

        private void Text1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}

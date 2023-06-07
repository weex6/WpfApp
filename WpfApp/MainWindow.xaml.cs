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

namespace WpfApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Random r = new Random();
            int rnd = r.Next(1, 3);
            if (rnd == 2)
            {
                if (!string.IsNullOrEmpty(txtElem.Text))
                {
                    if (!lstElem.Items.Contains(txtElem.Text))
                    {
                        if (MessageBox.Show("Вы действительно хотите добавить новый элемент?", "Добавление в список",
                        MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                        {
                            lstElem.Items.Add(txtElem.Text);
                            txtElem.Clear();
                        }
                    }
                    else MessageBox.Show("Данный элемент уже есть в списке", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Asterisk);
                }
                else MessageBox.Show("Надо что-нибудь ввести!", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else MessageBox.Show("А не буду добавлять", "А, ой", MessageBoxButton.OK, MessageBoxImage.Warning);
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            lstElem.Items.Clear();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}

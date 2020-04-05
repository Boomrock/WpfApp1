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
using System.ComponentModel;
using WpfApp1.data;

namespace WpfApp1
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
        private BindingList<Date> Date1;

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Date1 = new BindingList<Date>()
            {
                new Date() { Text = "1234", Check = true, Text1 = "awdawd" }
       
            };
            dg.ItemsSource = Date1;
           // Date1.ListChanged += 
        }

    }
}
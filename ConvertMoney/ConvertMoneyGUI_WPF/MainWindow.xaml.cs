using ConvertMoneyGUI_WPF.ViewModels;
using System;
using System.Windows;
using GetData.Model;


namespace ConvertMoneyGUI_WPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //Close.Click += (s, a) => { Environment.Exit(1); };
            //gdLoading.Visibility = Visibility.Visible;
            LeftChangeValute.MouseDown += (s, a) => { gdMain.Visibility = Visibility.Collapsed; gdSelValute.Visibility = Visibility.Visible; };

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

    }
}

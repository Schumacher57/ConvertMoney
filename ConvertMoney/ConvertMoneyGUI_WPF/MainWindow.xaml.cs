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
            this.DataContext = new MainWindowViewModel();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

    }
}

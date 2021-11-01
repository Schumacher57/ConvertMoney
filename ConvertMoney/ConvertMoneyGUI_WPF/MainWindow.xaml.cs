using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;
using ConvertMoneyGUI_WPF.Service;



namespace ConvertMoneyGUI_WPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ValuteConvert valute;
        private string activeChange;

        public MainWindow()
        {
            InitializeComponent();

            valute = new ValuteConvert();
            
            // Заполняем ListBox с валютой, значениями
            lbListValute.ItemsSource = valute.ListValutes;
            

            // Привязываем значение валюты к соответствующим полям
            tbActiveValuteOne.SetBinding(TextBox.TextProperty, new Binding("Value") { Source = valute.ActiveValuteOne, Mode = BindingMode.OneWay });
            // Привязываем значение валюты к соответствующим полям
            tbActiveValuteTwo.SetBinding(TextBox.TextProperty, new Binding("Value") { Source = valute.ActiveValuteTwo, Mode = BindingMode.OneWay });

            // Действие при изменение текста валюты справа
            tbActiveValuteOne.TextChanged += TbActiveValuteOne_TextChanged; // Конвертируем одно из другого
            
            // Действие при изменение текста валюты слева
            tbActiveValuteTwo.TextChanged += TbActiveValuteTwo_TextChanged; // Конвертируем дргое из одного

            // Привязываем имя валюты слева
            LeftValuteName.SetBinding(TextBlock.TextProperty, new Binding("ShortNameOne") { Source = valute, Mode = BindingMode.OneWay });

            // Привязываем имя валюты справа
            RightValuteName.SetBinding(TextBlock.TextProperty, new Binding("ShortNameTwo") { Source = valute, Mode = BindingMode.OneWay });

            // Выбор валюты слева.
            LeftChangeValute.MouseDown += ChangeValute_MouseDown;
            // Выбор валюты справа.
            RightChangeValute.MouseDown += ChangeValute_MouseDown;
            // Действие привыборе валюты
            lbListValute.SelectionChanged += lbListValute_SelectionChanged;

        }

        /// <summary>
        /// Действие при выборе валюты
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbListValute_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Действие в зависимости от того изменение валюты слева или изменение валюты справа
            if (activeChange == "LeftChangeValute")
            {
                valute.ActiveValuteOne = valute.SetValuteByShortName(lbListValute.SelectedItem.ToString());
            }
            else
            {
                valute.ActiveValuteTwo = valute.SetValuteByShortName(lbListValute.SelectedItem.ToString());
            }
            gdMain.Visibility = Visibility.Visible; // Возвращаем видимость главного меню
            gdSelValute.Visibility = Visibility.Collapsed;  // Скрываем видимость выбора валюты
        }
        /// <summary>
        /// Действие при изменении валюты
        /// </summary>
        /// <param name="sender">Объект вызвавший это изменение</param>
        /// <param name="e"></param>
        private void ChangeValute_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            activeChange = (sender as TextBlock).Name;
            gdMain.Visibility = Visibility.Collapsed;
            gdSelValute.Visibility = Visibility.Visible;
        }

        private void TbActiveValuteOne_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tbActiveValuteTwo.IsSelectionActive == false)
            {
                tbActiveValuteTwo.Text = valute.ConvertVlaute(valute.ActiveValuteOne, valute.ActiveValuteTwo, tbActiveValuteOne.Text);
            }
        }
        private void TbActiveValuteTwo_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tbActiveValuteOne.IsSelectionActive == false)
            {
                tbActiveValuteOne.Text = valute.ConvertVlaute(valute.ActiveValuteTwo, valute.ActiveValuteOne, tbActiveValuteTwo.Text);
            }
        }

    }
}

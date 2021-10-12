using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertMoneyGUI_WPF.ViewModels
{
    class MainWindowViewModel : BaseViewModel
    {
        private string _synchronizedText;

        public string SynchronizedText
        {
            get => _synchronizedText;
            set
            {
                _synchronizedText = value;
                OnPropertyChanged(nameof(SynchronizedText));
            }
        }

    }
}

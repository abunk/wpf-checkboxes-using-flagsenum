using Microsoft.Practices.Prism.Mvvm;

using WpfCheckboxesUsingFlagsEnum.Common;

namespace WpfCheckboxesUsingFlagsEnum.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private int _optionValue;

        public MainWindowViewModel()
        {
            OptionValue = (int)Option.All;
        }

        public int OptionValue
        {
            get { return _optionValue; }
            set { SetProperty(ref _optionValue, value); }
        }
    }
}
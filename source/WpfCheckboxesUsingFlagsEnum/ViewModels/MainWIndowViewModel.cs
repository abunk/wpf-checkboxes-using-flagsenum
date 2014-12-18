using Microsoft.Practices.Prism.Mvvm;

using WpfCheckboxesUsingFlagsEnum.Common;

namespace WpfCheckboxesUsingFlagsEnum.ViewModels
{
    public class MainWIndowViewModel : BindableBase
    {
        private int _optionValue;

        public MainWIndowViewModel()
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
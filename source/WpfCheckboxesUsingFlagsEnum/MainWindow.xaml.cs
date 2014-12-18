using WpfCheckboxesUsingFlagsEnum.ViewModels;

namespace WpfCheckboxesUsingFlagsEnum
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();

            DataContext = new MainWindowViewModel();
        }
    }
}

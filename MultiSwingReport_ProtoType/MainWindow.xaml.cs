using MaterialDesignThemes.Wpf;
using System.Windows;
using System.Windows.Input;

namespace MultiSwingReport_ProtoType
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

        private void ChangeTheme_ToggleChecked(object sender, RoutedEventArgs e)
        {
            ChangeTheme(true);
        }

        private void ChangeTheme(bool isDark)
        {
            if (isDark)
            {
                new PaletteHelper().SetLightDark(true);
            }
            else
            {
                new PaletteHelper().SetLightDark(false);
            }
         }

        private void ChangeTheme_ToggleButtonUnchecked(object sender, RoutedEventArgs e)
        {
            ChangeTheme(false);
        }
    }
}

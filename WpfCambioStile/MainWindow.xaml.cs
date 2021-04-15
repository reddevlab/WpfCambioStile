using System.Windows;

namespace WpfCambioStile
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var app = (App)Application.Current;

            string newTema = CbThemeName.Text;
            if (!string.IsNullOrEmpty(newTema))
            {
                app.ApplicaTema(CbThemeName.Text);
            }
        }
    }
}

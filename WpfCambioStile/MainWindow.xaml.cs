using System.Windows;
using System.Windows.Controls;

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


            // Altro medoto più elegante, ma non funziona
            //string str = ((ComboBoxItem)(CbThemeName.SelectedItem)).Content.ToString();
            //if (!string.IsNullOrEmpty(str))
            //{
            //    Style style;
            //    switch (str)
            //    {
            //        case "Default":
            //            style = (Style)Application.Current.TryFindResource("Styles/DefaultStyle");
            //            break;
            //        case "Dark":
            //            style = (Style)Application.Current.TryFindResource("Styles/DarkStyle");
            //            break;
            //        case "Flat":
            //            style = (Style)Application.Current.TryFindResource("FlatStyle");
            //            break;
            //        case "Modern":
            //            style = (Style)Application.Current.TryFindResource("ModernStyle");
            //            break;
            //        default:
            //            style = Style;
            //            break;
            //    }
            //    Style = style;
            //}


        }
    }
}

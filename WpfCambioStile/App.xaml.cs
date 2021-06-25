using System;
using System.Windows;

namespace WpfCambioStile
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private ResourceDictionary ThemeDictionary => Resources.MergedDictionaries[0];

        public string CurrentTheme { get; set; } = "Dark";

        public App()
        {
            InitializeComponent();

            ApplicaTema(CurrentTheme);
        }

        public void ApplicaTema(string tema)
        {
            tema = tema.ToLower();
            switch (tema)
            {
                case "dark":
                    ChangeTheme(new Uri("/styles/DarkStyle.xaml", UriKind.RelativeOrAbsolute));
                    CurrentTheme = "dark";
                    // Salvare su settings
                    break;
                case "flat":
                    ChangeTheme(new Uri("/styles/flatStyle.xaml", UriKind.RelativeOrAbsolute));
                    CurrentTheme = "flat";
                    // Salvare su settings
                    break;
                case "modern":
                    ChangeTheme(new Uri("/styles/ModernStyle.xaml", UriKind.RelativeOrAbsolute));
                    CurrentTheme = "modern";
                    // Salvare su settings
                    break;
                default:
                    ChangeTheme(new Uri("/styles/DefaultStyle.xaml", UriKind.RelativeOrAbsolute));
                    CurrentTheme = "default";
                    // Salvare su settings
                    break;

            }
        }

        void ChangeTheme(Uri uri)
        {
            ThemeDictionary.MergedDictionaries.Clear();
            ThemeDictionary.MergedDictionaries.Add(new ResourceDictionary()
            {
                Source = uri
            });
        }
    }
}

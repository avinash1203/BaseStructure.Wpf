using System;
using System.Windows;

namespace Structure
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        private string currentTheme;

        public string CurrentTheme
        {
            get { return currentTheme; }
            set { currentTheme = value; }
        }

        public App()
        {
            CurrentTheme = "Orange";
            CurrentLanguage = "English";
        }
        public ResourceDictionary ThemeDictionary
        {

            get
            {
                return Resources.MergedDictionaries[0];
            }
        }

        public void ChangeTheme()
        {
            ThemeDictionary.MergedDictionaries.Clear();
            if (CurrentTheme == "Orange")
            {
                CurrentTheme = "Black";
                ThemeDictionary.MergedDictionaries.Add( new ResourceDictionary() { Source = new System.Uri("Themes/Black/BlackTheme.xaml", UriKind.RelativeOrAbsolute) });
            }
            else
            {
                CurrentTheme = "Orange";
                ThemeDictionary.MergedDictionaries.Add( new ResourceDictionary() { Source = new System.Uri("Themes/Orange/OrangeTheme.xaml", UriKind.RelativeOrAbsolute) });
            }

        }

        private string currentLanguage;

        public string CurrentLanguage
        {
            get { return currentLanguage; }
            set { currentLanguage = value; }
        }


        public ResourceDictionary LanguageDictionary
        {

            get
            {
                return Resources.MergedDictionaries[1];
            }
        }

        public void ChangeLanguage()
        {
            LanguageDictionary.MergedDictionaries.Clear();
            if (CurrentLanguage == "English")
            {
                CurrentLanguage = "German";
                LanguageDictionary.MergedDictionaries.Add( new ResourceDictionary() { Source = new System.Uri("Languages/German/German.xaml", UriKind.RelativeOrAbsolute) });
            }
            else
            {
                CurrentLanguage = "English";
                LanguageDictionary.MergedDictionaries.Add( new ResourceDictionary() { Source = new System.Uri("Languages/English/English.xaml", UriKind.RelativeOrAbsolute) });
            }

        }

    }
}

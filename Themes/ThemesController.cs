using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace formProj.Themes
{
    public static class ThemesController
    {
        public enum ThemeType
        {
            LightTheme,
            DarkTheme
        }

        public static ThemeType CurrentTheme { get; set; }


        public static ResourceDictionary ThemeDictionary
        {
            get { return Application.Current.Resources.MergedDictionaries[0]; }
            set { Application.Current.Resources.MergedDictionaries[0] = value; }

        }
        public static void changeTheme(Uri newThemeUri){
            ThemeDictionary = new ResourceDictionary() { Source = newThemeUri };

        }
        public static void SetTheme(ThemeType theme){
            string themeVal = null;
            CurrentTheme = theme;

            switch (theme)
            {
                case ThemeType.LightTheme: themeVal = "LightTheme"; break;
                case ThemeType.DarkTheme:themeVal = "darktheme"; break;
                default:
                    break;
            }
            try
            {
                if (!string.IsNullOrEmpty(themeVal))
                {
                    changeTheme(new Uri($"C:\\Users\\AJ\\Desktop\\INTERNSHIP\\formProj\\formProj\\Themes\\{themeVal}.xaml"));
                }
            }
            catch {}

        }
    }
}

using formProj.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.ComponentModel;
using Haley.Abstractions;
using Haley.Services;
using Haley.Models;

namespace formProj.ViewModels
{
    public class MainViewModel : BaseViewModel , INotifyPropertyChanged
    {
        private BaseViewModel _selectedVM = new SignUpViewModel();
        private string buttonContent = "Submit";
        public ICommand UpdateView { get; set; }
        public ICommand toggleTheme { get; set; }
        public bool isLight = true;

        public IThemeService ts;
        public string ButtonContent { get => buttonContent; set {  
                buttonContent = value;
                OnPropertyChanged(nameof(buttonContent));
            } 
        }

        public BaseViewModel SelectedViewModel
        {
            get { return _selectedVM; }
            set { _selectedVM = value;
                this.ButtonContent = "Login" ;
                OnPropertyChanged(nameof(SelectedViewModel));
                
               
            }
        }

        public MainViewModel()
        {
            UpdateView = new UpdateView(this);
            toggleTheme = new DarkThemeToggle(this);
            ts = ThemeService.Singleton;
            Register();
        }

        void Register()
        {
            var _asmB = new AssemblyThemeBuilder();
            _asmB.Add("Dark", new Uri("pack://application:,,,/formProj;component/Themes/DarkTheme.xaml"))
                .Add("Light", new Uri("pack://application:,,,/formProj;component/Themes/LightTheme.xaml"));
            ts.RegisterGroup(_asmB);
            ts.SetStartupTheme("Light");
        }


    }
}

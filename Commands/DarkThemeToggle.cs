using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using formProj.ViewModels;
using Haley.Abstractions;
using Haley.Services;

namespace formProj.Commands
{
    public class DarkThemeToggle : ICommand
    {
        MainViewModel mv;

        public event EventHandler? CanExecuteChanged;


        public DarkThemeToggle(MainViewModel mv)
        {
            this.mv = mv;
        }
        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            if (mv.isLight)
            {
                mv.ts.ChangeTheme("Dark");
            }
            else
            {
                mv.ts.ChangeTheme("Light");

            }
            mv.isLight = !mv.isLight;

        }
    }
}

using formProj.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace formProj.Commands
{
    public class UpdateView : ICommand
    {
        private MainViewModel viewModel;
        public UpdateView(MainViewModel viewModel){
            this.viewModel = viewModel;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            
            if ( parameter.ToString() == "login")
            {
                viewModel.SelectedViewModel = new LoginViewModel();
            }
        }
    }
}

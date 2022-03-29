using formProj.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.ComponentModel;
namespace formProj.ViewModels
{
    public class MainViewModel : BaseViewModel , INotifyPropertyChanged
    {
        private BaseViewModel _selectedVM = new SignUpViewModel();
        private string buttonContent = "Submit";
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

        public ICommand UpdateView { get; set; }

        public MainViewModel()
        {
            UpdateView = new UpdateView(this);
        }

    }
}

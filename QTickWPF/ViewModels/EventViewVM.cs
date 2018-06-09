using QTickWPF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QTickWPF.ViewModels
{
    public class EventViewVM : BaseVM
    {
        private Event _event;
        public Event Event
        {
            get => _event;
            set
            {
                _event = value;
                NotifyPropertyChanged(nameof(Event));
            }
        }


        private MainWindowVM _mainWindowVM;
        public EventViewVM(MainWindowVM mainWindowVM)
        {
            _mainWindowVM = mainWindowVM;

        }
    }
   
}

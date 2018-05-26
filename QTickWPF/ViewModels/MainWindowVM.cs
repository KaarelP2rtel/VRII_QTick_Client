using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QTickWPF.Models;
using QTickWPF.Services;

namespace QTickWPF.ViewModels
{
        public class MainWindowVM : INotifyPropertyChanged
        {
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(string propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        //private readonly EventsService _eventsService;
        private readonly LoginService _loginService;
        
        
        private List<Event> _events;
        private string _token;

        public List<Event> Events
        {
            get
            {
                return _events;
            }
            private set 
            {   
                _events = value;
                NotifyPropertyChanged("Events");
            }
        }
        public string Token
        {
            get
            {
                return _token;
            }
            set
            {
                _token = value;
                NotifyPropertyChanged("Token");
            }
        }

        public MainWindowVM()
        {
            _events = new List<Event>();

            //_eventsService = new EventsService();
            _loginService = new LoginService();

        }
    

        // vaate Data laadimine
        public async void LoadData()
        {
            //Events = await _eventsService.GetEventsAsync();
            
            _events.Add(new Event() { EventName = "Kontsert 1" });
        }

    }
}

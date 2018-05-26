using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using QTickWPF.Models;
using QTickWPF.Services;
using QTickWPF.Views;

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


        private List<Models.Event> _events;
        private string _token;

        private string _loginUserInput;
        private string _loginPasswordInput;
        private Page _userFrameContent;
        public List<Models.Event> Events
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
            private set
            {
                _token = value;
                NotifyPropertyChanged("Token");
            }
        }

        public string LoginUserInput
        {
            get => _loginUserInput;
            private set
            {
                _loginUserInput = value;
                NotifyPropertyChanged("LoginUserInput");
            }
        }

        public string LoginPasswordInput
        {
            get => _loginPasswordInput;
            private set
            {
                _loginPasswordInput = value;
                NotifyPropertyChanged("LoginPasswordInput");
            }
        }

        public Page UserFrameContent
        {
            get => _userFrameContent;
            private set
            {
                _userFrameContent = value;
                NotifyPropertyChanged("UserFrameContent");
            }
        }

        public MainWindowVM()
        {
            _events = new List<Models.Event>();
            
            UserFrameContent = new LoginForm(this);
            
            //_eventsService = new EventsService();
            _loginService = new LoginService();

        }

        public async void TryLogin()
        {
            Token = await _loginService.GetTokenAsync(LoginUserInput, LoginPasswordInput);   
            UserFrameContent = new LoggedIn(this,null,null);
        }

        // vaate Data laadimine
        public async void LoadData()
        {
            //Events = await _eventsService.GetEventsAsync();

            _events.Add(new Models.Event() { EventName = "Kontsert 1" });
        }

    }
}

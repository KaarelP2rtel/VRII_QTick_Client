﻿using System;
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

        private string _loginUserInput;
        private string _loginPasswordInput;

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

        public MainWindowVM()
        {
            _events = new List<Event>();

            //_eventsService = new EventsService();
            _loginService = new LoginService();

        }

        public async void TryLogin()
        {
            Token = await _loginService.GetToken(LoginUserInput, LoginPasswordInput);           
        }

        // vaate Data laadimine
        public async void LoadData()
        {
            //Events = await _eventsService.GetEventsAsync();

            _events.Add(new Event() { EventName = "Kontsert 1" });
        }

    }
}

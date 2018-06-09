using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using QTickWPF.Models;
using QTickWPF.Models.DTO;
using QTickWPF.Services;
using QTickWPF.Views;

namespace QTickWPF.ViewModels
{
    public class MainWindowVM : BaseVM
    {

        #region DataBinding
        private List<Event> _events;

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

        private Page _userFrameContent;
        public Page UserFrameContent
        {
            get => _userFrameContent;
            private set
            {
                _userFrameContent = value;
                NotifyPropertyChanged(nameof(UserFrameContent));
            }
        }

        private Page _eventsListFrameContent;

        public Page EventsListFrameContent
        {
            get => _eventsListFrameContent;
            private set
            {
                _eventsListFrameContent = value;
                NotifyPropertyChanged(nameof(EventsListFrameContent));
            }
        }



        private string _token;
        public string Token
        {
            get
            {
                return _token;
            }
            private set
            {
                _token = value;
                NotifyPropertyChanged(nameof(Token));
            }
        }


        #endregion

        private LoginFormVM _loginFormVM;
        private EventsFrameVM _eventsFrameVM;
        private EventViewVM _eventViewVM;
        private readonly EventsService _eventsService;


        public MainWindowVM()
        {
            _eventsService = new EventsService();

            _loginFormVM = new LoginFormVM(this);
            _eventsFrameVM = new EventsFrameVM(this);

            UserFrameContent = new LoginForm(_loginFormVM);
            EventsListFrameContent = new EventsFrame(_eventsFrameVM);

            LoadData();

        }

        public void EventSelected(Event selectedEvent)
        {
            _eventViewVM = new EventViewVM(this);
            EventsListFrameContent = new EventView(_eventViewVM);
            _eventViewVM.Event = selectedEvent;
        }

        public async void LoadData()
        {

            Events = await _eventsService.GetEventsAsync();
        }

        internal void UserLoggedIn(string token)
        {
            Token = token;
            UserFrameContent = null;
            _loginFormVM = null;
        }
    }
}

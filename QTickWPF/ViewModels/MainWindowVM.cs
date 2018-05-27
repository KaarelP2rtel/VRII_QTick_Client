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

        private readonly EventsService _eventsService;


        public MainWindowVM()
        {
            _eventsService = new EventsService();

            _loginFormVM = new LoginFormVM(this);

            UserFrameContent = new LoginForm(_loginFormVM);

            LoadData();

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

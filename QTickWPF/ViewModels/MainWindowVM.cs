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

        private readonly EventsService _eventsService;
        private readonly LoginService _loginService;
        private readonly RegisterService _registerService;

        #region DataBinding Fields
        private List<Event> _events;
        private string _token;
        private string _loginUserInput;
        private string _loginPasswordInput;
        private Page _userFrameContent;

        #endregion

        #region DataBinding Props
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
            set
            {
                _loginUserInput = value;
                NotifyPropertyChanged("LoginUserInput");
            }
        }
        public string LoginPasswordInput
        {
            get => _loginPasswordInput;
            set
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
        #endregion

        public MainWindowVM()
        {
            _events = new List<Models.Event>();
            _eventsService = new EventsService();
            _loginService = new LoginService();
            _registerService = new RegisterService();

            UserFrameContent = new LoginForm(this);
            LoadData();

        }

        public async void TryLogin()
        {
            Token = await _loginService.GetTokenAsync(LoginUserInput, LoginPasswordInput);
            UserFrameContent = new LoggedIn(this);
        }


        public async void LoadData()
        {


            Events = await _eventsService.GetEventsAsync();
        }

        internal void TryRegister()
        {
            _registerService.RegisterAsync(new RegisterDTO
            {
                Name="UusIsik",
                UserName=LoginUserInput,
                Password=LoginPasswordInput,
                PasswordAgain=LoginPasswordInput
            });
        }

    }
}

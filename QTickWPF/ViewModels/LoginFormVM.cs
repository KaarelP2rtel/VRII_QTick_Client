using QTickWPF.Models.DTO;
using QTickWPF.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace QTickWPF.ViewModels
{
    public class LoginFormVM : BaseVM
    {

        #region DataBinding
        private string _loginUserInput;
        public string LoginUserInput
        {
            get => _loginUserInput;
            set
            {
                _loginUserInput = value;
                NotifyPropertyChanged(nameof(LoginUserInput));
            }
        }

        private string _loginPasswordInput;
        public string LoginPasswordInput
        {
            get => _loginPasswordInput;
            set
            {
                _loginPasswordInput = value;
                NotifyPropertyChanged(LoginPasswordInput);
            }
        }

        private string _loginPasswordAgainInput;
        public string LoginPasswordAgainInput
        {
            get => _loginPasswordInput;
            set
            {
                _loginPasswordInput = value;
                NotifyPropertyChanged(LoginPasswordAgainInput);
            }
        }

        private string _registerNameInput;
        public string RegisterNameInput
        {
            get => _registerNameInput;
            set
            {
                _registerNameInput = value;
                NotifyPropertyChanged(nameof(RegisterNameInput));
            }
        }

        #endregion



        private readonly LoginService _loginService;
        private readonly MainWindowVM _mainWindowVM; 

        public LoginFormVM(MainWindowVM mainWindowVM)
        {
            _mainWindowVM = mainWindowVM;

            _loginService = new LoginService();
            
        }
        public async void TryLogin()
        {
            var token = await _loginService.GetTokenAsync(LoginUserInput, LoginPasswordInput);
            _mainWindowVM.UserLoggedIn(token);

        }
        public void TryRegister()
        {
            var newUser = _loginService.RegisterAsync(new RegisterDTO
            {
                Name = RegisterNameInput,
                UserName = LoginUserInput,
                Password = LoginPasswordInput,
                PasswordAgain = LoginPasswordAgainInput
            });
            if (newUser != null)
            {
                TryLogin();
            }

        }
    }
}

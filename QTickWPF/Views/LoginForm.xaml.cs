using QTickWPF.Services;
using QTickWPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace QTickWPF.Views
{
    /// <summary>
    /// Interaction logic for LoginForm.xaml
    /// </summary>
    public partial class LoginForm : Page
    {
        //Variables to use
        private MainWindowVM _vm;
        private Frame _userFrame;
        private Frame _overFrame;

        private LoginService _loginService;

        //Constructor for LoginForm
        public LoginForm(MainWindowVM mainVM, Frame userFrame, Frame overFrame)
        {
            InitializeComponent();
            _vm = mainVM;
            _userFrame = userFrame;
            _overFrame = overFrame;
            _loginService = new LoginService();
        }

        //When register button is pressed, it tries to register user
        private void RegisterBtn_Click(object sender, RoutedEventArgs e)
        {
            //var username = RegisterUser.Text;
            //var password = RegisterPassword.Password;

            try
            {
               // _vm.User = UserService.Register(username, password);

                _userFrame.Content = new LoggedIn(_vm, _userFrame, _overFrame);

            }
            catch (InvalidOperationException er)
            {
                RegisterError.Text = er.Message;
            }
        }

        //When login button is pressed, it tries to login user
        private async void LoginBtn_Click(object sender, RoutedEventArgs e)
        {
            var username = LoginUser.Text;
            var password = LoginPassword.Password;
            string token = await _loginService.GetToken(username, password);
            _vm.Token = token;

            try
            {
              //  _vm.User = UserService.LogIn(username, password);
                _userFrame.Content = new LoggedIn(_vm, _userFrame, _overFrame);
            }
            catch (InvalidOperationException er)
            {
                LoginError.Text = er.Message;
            }
        }

        //Triggers login button when pressed enter in login fields
        private void checkLoginEnter_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                LoginBtn_Click(sender, e);
            }
        }

        //Triggers register button when pressed enter in registering fields
        private void checkRegisterEnter_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                RegisterBtn_Click(sender, e);
            }
        }
    }
}

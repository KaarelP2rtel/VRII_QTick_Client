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


        MainWindowVM _vm;
        //Constructor for LoginForm
        public LoginForm(MainWindowVM vm)
        {
            InitializeComponent();
            _vm = vm;
            DataContext = vm;
            
   
        }

        //When register button is pressed, it tries to register user
        private void RegisterBtn_Click(object sender, RoutedEventArgs e)
        {
            _vm.TryRegister();
        }

        //When login button is pressed, it tries to login user
        private void LoginBtn_Click(object sender, RoutedEventArgs e)
        {
            _vm.TryLogin(); 
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

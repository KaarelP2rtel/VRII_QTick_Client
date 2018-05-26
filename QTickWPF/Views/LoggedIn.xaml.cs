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
    /// Interaction logic for LoggedIn.xaml
    /// </summary>
    public partial class LoggedIn : Page
    {
        //Variables to use
        private MainWindowVM _vm;
        private Frame _userFrame;
        private Frame _overFrame;

        //Constructor for LoggedIn
        public LoggedIn(MainWindowVM mainVM, Frame userFrame, Frame overFrame)
        {
            InitializeComponent();

            _vm = mainVM;
            _userFrame = userFrame;
            _overFrame = overFrame;
            // TODO user has to be here
            //userName.Text = _vm.User.Username;
        }

        //Logs the user out, closing event and displaying LoginForm
        private void LogoutBtn_Click(object sender, RoutedEventArgs e)
        {
           // _vm.User = null;

            _overFrame.Content = null;
            _overFrame.Visibility = Visibility.Hidden;

            
        }

        //Opens the settings page 
        private void SettingsBtn_Click(object sender, RoutedEventArgs e)
        {
            _overFrame.Content = new Settings(_vm, _overFrame);
            _overFrame.Visibility = Visibility.Visible;
        }

        //Opens the new event page 
        private void NewEventBtn_Click(object sender, RoutedEventArgs e)
        {
            //_overFrame.Content = new EventEdit(_vm, _overFrame);
            _overFrame.Visibility = Visibility.Visible;
        }
    }
}

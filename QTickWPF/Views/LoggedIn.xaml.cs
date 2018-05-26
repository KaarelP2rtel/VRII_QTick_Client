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


        //Constructor for LoggedIn
        public LoggedIn(MainWindowVM vm)
        {
            InitializeComponent();

            _vm = vm;

        }

        //Logs the user out, closing event and displaying LoginForm
        private void LogoutBtn_Click(object sender, RoutedEventArgs e)
        {
        
        }

        //Opens the settings page 
        private void SettingsBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        //Opens the new event page 
        private void NewEventBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

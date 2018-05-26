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
    /// Interaction logic for Settings.xaml
    /// </summary>
    public partial class Settings : Page
    {
        //Variables to use
        private MainWindowVM _vm;
        private Frame _overFrame;

        //Constructor for settings page
        public Settings(MainWindowVM mainVM, Frame overFrame)
        {
            InitializeComponent();

            _vm = mainVM;
            _overFrame = overFrame;
        }

        //Closes the page when back button is clicked
        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            _overFrame.Content = null;
            _overFrame.Visibility = Visibility.Hidden;
        }
    }
}

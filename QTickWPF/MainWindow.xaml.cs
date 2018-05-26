using QTickWPF.ViewModels;
using QTickWPF.Views;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace QTickWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Variables to use
        private MainWindowVM _vm;

        //Main function that starts the MainWindowVM and loginform into its place
        public MainWindow()
        {
            InitializeComponent();
            this._vm = new MainWindowVM();
            this.DataContext = _vm;

            userFrame.Content = _vm.UserFrameContent;
           
          
        }
    }
}

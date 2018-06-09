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
    /// Interaction logic for EventsFrame.xaml
    /// </summary>
    public partial class EventsFrame : Page
    {
        private EventsFrameVM _vm;
        public EventsFrame(EventsFrameVM vm)
        {
            _vm = vm;
            DataContext = _vm;
            InitializeComponent();

            
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            _vm.ItemSelected();
        }
    }
}

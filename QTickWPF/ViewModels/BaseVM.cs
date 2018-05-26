using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QTickWPF.ViewModels
{
    public class BaseVM : INotifyPropertyChanged //see tähendab, et saaks teavitada VIEWsid andmete muutmisest
    { // ütleb Viewle et uuenda
        // omavad ja kontrollivad neid andmeid, mida View saab kasutada
        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyPropertyChanged(string propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}

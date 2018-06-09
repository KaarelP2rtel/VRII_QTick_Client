using QTickWPF.Models;
using QTickWPF.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QTickWPF.ViewModels
{
    public class EventsFrameVM : BaseVM
    {
        
        private readonly MainWindowVM _mainWindowVM;
        private readonly EventsService _eventsService;
        private List<Event> _events;
        public List<Event> Events
        {
            get => _events;

            private set
            {
                _events = value;
                NotifyPropertyChanged(nameof(Events));
            }
        }

        private Event _selectedEvent;
        public Event SelectedEvent
        {
            get => _selectedEvent; set
            {
                _selectedEvent = value;
                NotifyPropertyChanged(nameof(SelectedEvent));
            }
        }


        public EventsFrameVM(MainWindowVM mainWindowVM)
        {
            _eventsService = new EventsService();
            _mainWindowVM = mainWindowVM;
            LoadEvents();

        }
        public async Task LoadEvents()
        {
            Events = await _eventsService.GetEventsAsync();
        }

        internal void ItemSelected()
        {
            _mainWindowVM.EventSelected(SelectedEvent);
        }
    }
}

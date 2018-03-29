using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Menopaws.Models;
using System.Collections.ObjectModel;
using Syncfusion.SfSchedule.XForms;
using Menopaws.Data;

namespace Menopaws
{
	public partial class SchedulePage : ContentPage
    {
        ScheduleAppointmentCollection scheduleAppointmentCollection;
        IMenopausalDataStore _dataStore;
        private string _defaultEventName;

        public SchedulePage()
		{
            InitializeComponent();
            InitialiseSchedule();
		}

        public SchedulePage(string callingPageName, IMenopausalDataStore dataStore)
		{
			InitializeComponent();
            _dataStore = dataStore;
            InitialiseSchedule();
            _defaultEventName = callingPageName;
		}

        private void InitialiseSchedule() 
        {
            schedule.CellDoubleTapped += OnCellTapped;
            scheduleAppointmentCollection = new ScheduleAppointmentCollection();
        }

		async void OnDoneButtonClicked(object sender, EventArgs e)
		{
			await Navigation.PopAsync();
		}

		async void OnInputTextClicked(object sender, EventArgs args)
		{
			await Navigation.PushAsync(new InputTextPage());
        }

        void OnCellTapped(object sender, CellTappedEventArgs e)
        {
            var newAppointment = new ScheduleAppointment()
            {
                StartTime = DateTime.Now,
                EndTime = DateTime.Now.AddHours(2),
                Subject = _defaultEventName
            };
            scheduleAppointmentCollection.Add(newAppointment);
            schedule.DataSource = scheduleAppointmentCollection;
        }
	}
}

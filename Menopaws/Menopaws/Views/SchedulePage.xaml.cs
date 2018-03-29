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
        IMenopausalDataStore _dataStore;
        private string _defaultEventName;

        public SchedulePage()
		{
            InitializeComponent();
            InitialiseSchedule();
		}

        public SchedulePage(IMenopausalDataStore dataStore)
		{
			InitializeComponent();

            _dataStore = dataStore;
            _defaultEventName = "Hot flush";

            InitialiseSchedule();
		}

        public void SetDefaultEvent(string defaultEventName)
        {
            _defaultEventName = defaultEventName;
        }

        private void InitialiseSchedule() 
        {
            schedule.CellDoubleTapped += OnCellTapped;
        }

		async void OnDoneButtonClicked(object sender, EventArgs e)
		{
			await Navigation.PopAsync();
		}

		async void OnInputTextClicked(object sender, EventArgs args)
		{
			await Navigation.PushAsync(new InputTextPage());
        }

        private ScheduleAppointmentCollection CreateAndPopulateNewAppointmentCollection()
        {
            var newCollection = new ScheduleAppointmentCollection();
            if (schedule.DataSource != null)
            {
                foreach (var appt in schedule.DataSource)
                {
                    newCollection.Add(appt as ScheduleAppointment);
                }
            }
            return newCollection;
        }

        void OnCellTapped(object sender, CellTappedEventArgs e)
        {
            var scheduleAppointmentCollection = CreateAndPopulateNewAppointmentCollection();
            var newAppointment = new ScheduleAppointment()
            {
                StartTime = DateTime.Now,
                EndTime = DateTime.Now.AddHours(2),
                Subject = _defaultEventName,
                Location = "Here!"
            };
            scheduleAppointmentCollection.Add(newAppointment);
            schedule.DataSource = scheduleAppointmentCollection;
        }
	}
}

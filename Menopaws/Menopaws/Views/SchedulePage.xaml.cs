using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Menopaws.Models;
using System.Collections.ObjectModel;
using Syncfusion.SfSchedule.XForms;

namespace Menopaws
{
	public partial class SchedulePage : ContentPage
	{
		ScheduleAppointmentCollection scheduleAppointmentCollection;
		public SchedulePage()
		{
			InitializeComponent();


		}

		public SchedulePage(string callingPageName)
		{
			InitializeComponent();

			scheduleAppointmentCollection = new ScheduleAppointmentCollection();

			schedule.CellDoubleTapped += (object sender, CellTappedEventArgs e) =>
			{
				scheduleAppointmentCollection.Add((new ScheduleAppointment()
				{
					StartTime = new DateTime(2017, 10, 31, 11, 0, 0),
					EndTime = new DateTime(2017, 05, 08, 12, 0, 0),
					Subject = callingPageName,
					Location = "Hutchison road",
				}));
				schedule.DataSource = scheduleAppointmentCollection;
				DisplayAlert("Tapped!", callingPageName, "OK");
			};

		}

		async void OnDoneButtonClicked(object sender, EventArgs e)
		{
			await Navigation.PopAsync();
		}

		async void OnInputTextClicked(object sender, EventArgs args)
		{
			await Navigation.PushAsync(new InputTextPage());
		}
	}
}

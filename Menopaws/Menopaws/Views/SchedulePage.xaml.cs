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

			scheduleAppointmentCollection = new ScheduleAppointmentCollection();
		}

		public SchedulePage(string callingPageName)
		{
			InitializeComponent();

			schedule.CellDoubleTapped += (object sender, CellTappedEventArgs e) =>
			{
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

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
			DisplayAlert("Tapped!", sender.ToString(), "OK");
		}
	}
}

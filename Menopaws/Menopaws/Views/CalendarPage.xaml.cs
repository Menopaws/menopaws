using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Telerik.XamarinForms.Input;
using Menopaws.Models;
using System.Collections.ObjectModel;

namespace Menopaws
{
	public partial class CalendarPage : ContentPage
	{
		private ObservableCollection<Appointment> appointments;

		public CalendarPage()
		{
			InitializeComponent();
			calendar.SelectedDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
			calendar.SelectionChanged += (sender, e) =>
			{
				String date = ((Telerik.XamarinForms.Input.RadCalendar)sender).SelectedDate.ToString();
				date = date.Substring(0, 10);

				AddNewRecord(date, "New Entry for Tracking");
			};
			appointments = new ObservableCollection<Appointment>();
		}

		async void OnDoneButtonClicked(object sender, EventArgs e)
		{
			await Navigation.PopAsync();
		}

		async void OnInputTextClicked(object sender, EventArgs args)
		{
			await Navigation.PushAsync(new InputTextPage());
		}

		void AddNewRecord(string datetime, string recordTitle)
		{
			appointments.Add(new Appointment(datetime.Substring(0, 10), "", recordTitle));
			this.calendar.AppointmentsSource = appointments;

		}


	}
}

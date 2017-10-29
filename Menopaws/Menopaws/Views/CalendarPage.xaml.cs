using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Menopaws
{
	public partial class CalendarPage : ContentPage
	{
		public CalendarPage()
		{
			InitializeComponent();
			calendar.SelectedDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
			calendar.SelectionChanged += (sender, e) =>
			{
				String date = ((Telerik.XamarinForms.Input.RadCalendar)sender).SelectedDate.ToString();
				date.Substring(0, 10);
				DisplayAlert("Alert!", date, "OK");
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

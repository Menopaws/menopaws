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

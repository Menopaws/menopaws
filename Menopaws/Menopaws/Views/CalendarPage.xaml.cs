using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Menopaws.Models;
using System.Collections.ObjectModel;

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

		void AddNewRecord(string datetime, string recordTitle)
		{
			throw new NotImplementedException();

		}
	}
}

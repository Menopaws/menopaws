﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Menopaws.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DateEntryPage : ContentPage
	{
		public DateEntryPage()
		{
			InitializeComponent();
			BindingContext = new TimeEntryPageViewModel();
		}

		async void OnDoneButtonClicked(object sender, EventArgs e)
		{
			await Navigation.PopAsync();
		}

		async void OnDateSelected(object sender, EventArgs e)
		{
			var dateSelected = datePicker.Date;
			(BindingContext as TimeEntryPageViewModel).Status = "Date selected.";
			//Status = DataAccess.AdoExample.DoSomeDataAccess();
		}

		async void OnInputTextClicked(object sender, EventArgs args)
		{
			await Navigation.PushAsync(new InputTextPage());
		}
	}
}
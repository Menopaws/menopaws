﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Menopaws.Views;
using Menopaws.Data;

namespace Menopaws
{
	public partial class MainPage : ContentPage
	{
        private IMenopausalDataStore dataStore;

		public MainPage()
		{
			InitializeComponent();
            dataStore = new MenopausalDataStub();
            //BindingContext = new MainPageViewModel(Navigation);
        }

		async void OnHotFlushButtonClicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new CalendarPage());
			listView.ItemsSource = dataStore.GetAllMenopausalEvents();
		}

		async void OnMoodButtonClicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new CalendarPage());
		}

		async void OnAddTimeButtonClicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new TimeEntryPage());
		}

		async void OnAddDateButtonClicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new DateEntryPage());
		}

		async void OnInputTextClicked(object sender, EventArgs args)
		{
			await Navigation.PushAsync(new InputTextPage());
		}

		void OnListItemSelected(object sender, SelectedItemChangedEventArgs e)
		{

		}
	}
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Menopaws
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
			//BindingContext = new MainPageViewModel(Navigation);
		}

		async void OnHotFlushButtonClicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new CalendarPage());
			//listView.ItemsSource = await App.Database.GetItemsAsync();
		}

		async void OnListItemSelected(object sender, SelectedItemChangedEventArgs e)
		{
			//((App)App.Current).ResumeAtTodoId = (e.SelectedItem as TodoItem).ID;
			//Debug.WriteLine("setting ResumeAtTodoId = " + (e.SelectedItem as TodoItem).ID);
			if (e.SelectedItem != null)
			{
				//await Navigation.PushAsync(new TodoItemPage
				//{
				//    BindingContext = e.SelectedItem as TodoItem
				//});
			}
		}
	}
}

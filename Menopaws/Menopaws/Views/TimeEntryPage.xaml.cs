using System;


using Xamarin.Forms;


namespace Menopaws.Views
{

	public partial class TimeEntryPage : ContentPage
	{
		public TimeEntryPage()
		{
			InitializeComponent();
			BindingContext = new TimeEntryPageViewModel();
			timePicker.PropertyChanged += (sender, e) =>
			{
				if (e.PropertyName == TimePicker.TimeProperty.PropertyName)
				{
					OnTimeSelected(sender, e);
				}
			};
		}

		async void OnDoneButtonClicked(object sender, EventArgs e)
		{
			await Navigation.PopAsync();
		}

		async void OnTimeSelected(object sender, EventArgs e)
		{
			var timeSelected = timePicker.Time;
			(BindingContext as TimeEntryPageViewModel).Status = "Time selected.";
			//Status = Menopaws.DataAccess.AdoExample.DoSomeDataAccess();
		}

		async void OnInputTextClicked(object sender, EventArgs args)
		{
			await Navigation.PushAsync(new InputTextPage());
		}
	}
}
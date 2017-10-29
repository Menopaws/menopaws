using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Menopaws.Texting;

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
            DependencyService.Get<ITexting>().SendText("07777111222");
            (BindingContext as TimeEntryPageViewModel).Status = "Time selected.";
			//Status = Menopaws.DataAccess.AdoExample.DoSomeDataAccess();
		}

		async void OnInputTextClicked(object sender, EventArgs args)
		{
			await Navigation.PushAsync(new InputTextPage());
		}
	}
}
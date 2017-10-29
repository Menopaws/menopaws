using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Menopaws
{
	public partial class DataEntryPage : ContentPage
	{
		public DataEntryPage()
		{
			InitializeComponent();
		}

        async void OnDoneButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        async void OnDateSelected(object sender, EventArgs e)
        {
            var dateSelected = datePicker.Date;
        }
    }
}

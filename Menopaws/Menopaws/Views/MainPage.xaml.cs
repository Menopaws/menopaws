using System;
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
			BindingContext = new MainPageViewModel(Navigation);
		}

        async void OnHotFlushButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CalendarPage());
        }
    }
}

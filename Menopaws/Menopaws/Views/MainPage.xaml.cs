using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Menopaws.Views;
using Menopaws.Data;
using Syncfusion.SfSchedule.XForms;

namespace Menopaws
{
	public partial class MainPage : ContentPage
	{
        private readonly IMenopausalDataStore dataStore;

        public MainPage()
		{
			InitializeComponent();
			dataStore = new MenopausalDataStub();
			BindingContext = new MainPageViewModel(Navigation, dataStore);
        }
	}
}

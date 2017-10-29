using System;
using System.Windows.Input;
using System.ComponentModel;
using Xamarin.Forms;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Menopaws.Texting;

namespace Menopaws
{
	public class MainPageViewModel : INotifyPropertyChanged
	{
		public ICommand AddFlushClicked { get; private set; }
		public ICommand InputTextClicked { get; private set; }
		public INavigation Navigation { get; set; }
		private ITexting textingService { get; set; }


		public MainPageViewModel(INavigation navigation)
		{
			this.Navigation = navigation;
			textingService = new StubbedTexting();
			AddFlushClicked = new Command(async () => await GoToCalendarPage());
			InputTextClicked = new Command(async () => await GoToTextInputPage());
		}

		public async Task GoToCalendarPage() => await Navigation.PushAsync(new CalendarPage());

		public async Task GoToTextInputPage() => await Navigation.PushAsync(new CalendarPage());


		public event PropertyChangedEventHandler PropertyChanged;

		private void OnPropertyChanged([CallerMemberName] string name = null) =>
		PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

	}
}

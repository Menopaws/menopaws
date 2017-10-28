using System;
using System.Windows.Input;
using System.ComponentModel;
using Xamarin.Forms;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Menopaws
{
	public class MainPageViewModel : INotifyPropertyChanged
	{
		public ICommand AddFlushClicked { get; private set; }
		public INavigation Navigation { get; set; }


		public MainPageViewModel(INavigation navigation)
		{
			this.Navigation = navigation;
			AddFlushClicked = new Command(async () => await GoToCalendarPage());
		}

		public async Task GoToCalendarPage() => await Navigation.PushAsync(new CalendarPage());



		public event PropertyChangedEventHandler PropertyChanged;

		private void OnPropertyChanged([CallerMemberName] string name = null) =>
		PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

	}
}

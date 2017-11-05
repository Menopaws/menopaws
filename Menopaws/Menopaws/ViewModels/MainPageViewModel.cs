using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;


namespace Menopaws
{
	public class MainPageViewModel : INotifyPropertyChanged
	{
		public INavigation Navigation { get; set; }

		public ICommand CrisisButtonCommand { get; private set; }

		public MainPageViewModel(INavigation navigation)
		{
			this.Navigation = navigation;
			CrisisButtonCommand = new Command(NavigateSendTextPage);
		}

		void NavigateSendTextPage() => Navigation.PushAsync(new InputTextPage());

		public event PropertyChangedEventHandler PropertyChanged;

		private void OnPropertyChanged([CallerMemberName] string name = null) =>
		PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
	}
}

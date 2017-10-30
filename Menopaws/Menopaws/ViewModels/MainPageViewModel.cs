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
		public INavigation Navigation { get; set; }

		public MainPageViewModel(INavigation navigation)
		{
			this.Navigation = navigation;
		}

		public event PropertyChangedEventHandler PropertyChanged;

		private void OnPropertyChanged([CallerMemberName] string name = null) =>
		PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
	}
}

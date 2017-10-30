using System;
using System.Windows.Input;
using System.ComponentModel;
using Xamarin.Forms;
using System.Runtime.CompilerServices;

namespace Menopaws
{
	public class MainPageViewModel : INotifyPropertyChanged
	{
		public ICommand AddFlushClicked { get; private set; }
		private string status = "Welcome to Menopaws!";


		public MainPageViewModel()
		{
			AddFlushClicked = new Command(AddFlush);
		}

		private void AddFlush()
		{
			Status = "Hot Flush Added!";
		}

		public string Status
		{
			get => status;

			set
			{
				status = value;
				OnPropertyChanged();
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		private void OnPropertyChanged([CallerMemberName] string name = null) =>
		PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

	}
}

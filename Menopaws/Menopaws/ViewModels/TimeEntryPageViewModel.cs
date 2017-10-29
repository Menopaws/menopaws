using System;
using System.Windows.Input;
using System.ComponentModel;
using Xamarin.Forms;
using System.Runtime.CompilerServices;

namespace Menopaws
{
	public class TimeEntryPageViewModel : INotifyPropertyChanged
	{
		private string status = "Nothing entered yet.";
		private TimeSpan time = DateTime.Now.TimeOfDay;

		public TimeEntryPageViewModel()
		{
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

		public TimeSpan Time
		{
			get => time;

			set
			{
				time = value;
				OnPropertyChanged();
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		private void OnPropertyChanged([CallerMemberName] string name = null) =>
		PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
	}
}

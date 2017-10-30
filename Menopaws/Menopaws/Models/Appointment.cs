using System;
using Telerik.XamarinForms.Input;
using Xamarin.Forms;
using System.Collections.ObjectModel;

namespace Menopaws
{
	public class Appointment : IAppointment
	{

		public ObservableCollection<Appointment> Appointments;


		public Appointment(String start, String end, String title)
		{

		}

		public DateTime EndDate
		{
			get;
			set;
		}

		public DateTime StartDate
		{
			get;
			set;
		}

		public string Title
		{
			get;
			set;
		}

		public Color Color
		{
			get;
			set;
		}

		public bool IsAllDay
		{
			get;
			set;
		}

		public string Detail
		{
			get;
			set;
		}
	}
}

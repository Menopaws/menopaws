using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Azure.Mobile;
using Microsoft.Azure.Mobile.Analytics;
using Microsoft.Azure.Mobile.Crashes;
using Xamarin.Forms;
using Menopaws.Data;

namespace Menopaws
{
	public partial class App : Application
	{
		static TodoItemDatabase database;

		public App()
		{
			InitializeComponent();

			MobileCenter.Start("android=33593bd5-0d32-45af-8142-dada9967c93d;",
				   typeof(Analytics), typeof(Crashes));

			MainPage = new NavigationPage(new Menopaws.MainPage());
		}

		public static TodoItemDatabase Database
		{
			get
			{
				if (database == null)
				{
					database = new TodoItemDatabase(DependencyService.Get<IFileHelper>().GetLocalFilePath("TodoSQLite.db3"));
				}
				return database;
			}
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}

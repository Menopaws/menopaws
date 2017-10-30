using System;

using Xamarin.Forms;

namespace Menopaws
{
	public class MasterDetailPage : ContentPage
	{
		public MasterDetailPage()
		{
			Content = new StackLayout
			{
				Children = {
					new Label { Text = "Hello ContentPage" }
				}
			};
		}
	}
}


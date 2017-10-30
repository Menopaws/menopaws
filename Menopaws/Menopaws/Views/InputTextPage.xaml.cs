using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Menopaws.Texting;
using Plugin.Messaging;

namespace Menopaws
{
	public partial class InputTextPage : ContentPage
	{
		private ITexting textingService { get; set; }
		public InputTextPage()
		{
			InitializeComponent();

		}

		void OnSendClicked(object sender, EventArgs args)
		{
			if (phoneNumber.Text != null)
			{
				try
				{
					var smsMessenger = CrossMessaging.Current.SmsMessenger;
					if (smsMessenger.CanSendSms)
					{
						smsMessenger.SendSmsInBackground(phoneNumber.Text, message.Text);
						Navigation.PopAsync(true);
					}
					else
					{
						DisplayAlert("Alert!", "Device does not support SMS", "OK");
					}

				}
				catch (Exception e)
				{
					DisplayAlert("Error!", e.Message, "OK");
				}

			}
			else
			{
				DisplayAlert("Alert", "Please enter a phone number", "OK");
			}

		}
	}
}

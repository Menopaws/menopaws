using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clockwork;
using System.Net;

namespace Menopaws.Texting
{
	public class ClockworkTexting : ITexting
	{
		public String SendText(String phoneNumber, String message)
		{
			String resultString = "Not done a bloody thing!";

			try
			{
				Clockwork.API api = new API("86a49466376c82f249d918a48ea7f67dcbcb07bb");
				SMSResult result = api.Send(
					new SMS
					{
						To = phoneNumber,
						Message = message
					});

				if (result.Success)
				{
					resultString = String.Format(
						"Success! SMS Sent to {0}, Clockwork ID: {1}",
						result.SMS.To,
						result.ID);
				}
				else
				{
					resultString = String.Format(
						"SMS to {0} failed, Clockwork Error: {1} {2}",
						result.SMS.To,
						result.ErrorCode,
						result.ErrorMessage);
				}
			}
			catch (APIException ex)
			{
				// You’ll get an API exception for errors
				// such as wrong username or password
				resultString = "API Exception: " + ex.Message;
			}
			catch (WebException ex)
			{
				// Web exceptions mean you couldn’t reach the Clockwork server
				resultString = "Web Exception: " + ex.Message;
			}
			catch (ArgumentException ex)
			{
				// Argument exceptions are thrown for missing parameters,
				// such as forgetting to set the username
				resultString = "Argument Exception: " + ex.Message;
			}
			catch (Exception ex)
			{
				// Something else went wrong, the error message should help
				resultString = "Unknown Exception: " + ex.Message;
			}

			return resultString;
		}
	}
}

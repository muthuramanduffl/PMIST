using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Web;

/// <summary>
/// Summary description for MailFunction
/// </summary>
public class MailFunction
{
	public void SendMails(string Subject,string body)
	{
		try
		{
			using (System.Net.Mail.MailMessage mm = new System.Net.Mail.MailMessage("PMU Application<applications@pmu.edu>", "Muthuraman@duffldigital.com"))
			{

				mm.Subject = Subject;
				mm.Body = body;
				//MailAddress Bcopy = new MailAddress("admission@pmu.edu");
				//mm.Bcc.Add(Bcopy);
				mm.IsBodyHtml = true;
				SmtpClient smtp = new SmtpClient();
				smtp.Host = " relay-hosting.secureserver.net";
				NetworkCredential NetworkCred = new NetworkCredential("applications@pmu.edu", "periyar2020");
				smtp.Credentials = NetworkCred;
				smtp.Port = 25;
				smtp.UseDefaultCredentials = true;
				smtp.EnableSsl = false;
				smtp.Send(mm);

			}
		}
		catch (Exception ex)
		{

		}

	}
}
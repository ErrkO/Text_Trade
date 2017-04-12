﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Eric TODO

using System;
using System.Net;
using System.Net.Mail;


public class Email
{

    public MailAddress e_Mail;

    private string client;
    private string username;
    private string password;
    private int port;
    private bool TSL_SSL;
    private bool defaultsettings;
    private bool IsOutlook;
    private bool IsGmail;

    public MailAddress E_Mail
    {
        
        get { return this.E_Mail; }

        set { this.e_Mail = value; }
        
    }

    public string email
	{

		get { return this.email; }

		set { this.email = value; }

	}

    public string UserName
    {

        get { return this.username; }

        set { this.username = value; }

    }

    public string Password
    {

        private get { return this.password; }

        set { this.password = value; }

    }

    // Constructor
    public Email(string email)
    {

        this.email = email;

        this.e_Mail = new MailAddress(email);

    }

    public Email(string email, bool outlook = false)
    {

        this.email = email;

        this.e_Mail = new MailAddress(email);

        if (outlook == true)
        {

            this.IsOutlook = true;

            client = "smtp-mail.outlook.com";
            port = 587;
            TSL_SSL = true;
            defaultsettings = false;

        }

        else
        {

            this.IsGmail = true;

            client = "smtp.gmail.com";
            port = 587;
            TSL_SSL = true;
            defaultsettings = false;

        }

    }

    public void SendMessage(string to, string subject, string body)
    {

        MailMessage mail = new MailMessage();
        mail.From = E_Mail;

        SmtpClient smtp = new SmtpClient();
        smtp.Port = 587;
        smtp.EnableSsl = true;
        smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
        smtp.UseDefaultCredentials = false;
        smtp.Credentials = new NetworkCredential(mail.From.Address, Password);
        smtp.Host = "smtp.gmail.com";

        mail.To.Add(new MailAddress(to));

        mail.IsBodyHtml = true;
        string st = "Test";

        mail.Body = st;
        smtp.Send(mail);

    }

    public void OpenMessage()
	{
		throw new System.NotImplementedException();
	}

	public virtual void SendMail(Email email)
	{
		throw new System.NotImplementedException();
	}

}


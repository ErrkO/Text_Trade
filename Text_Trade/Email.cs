﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;


public class Email
{
	public string email
	{

		get { return this.email; }
		set { this.email = value; }

	}

    public Email(string email)
    {

        this.email = email;

    }

	public virtual void OpenMessage()
	{
		throw new System.NotImplementedException();
	}

	public virtual void SendMail(Email email)
	{
		throw new System.NotImplementedException();
	}

}


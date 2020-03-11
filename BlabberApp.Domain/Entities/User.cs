using System;
using System.Net.Mail;
using BlabberApp.Domain.Entities;
namespace BlabberApp.Domain.Entities
{
    // public class User : BaseEntity
    // {
    //     private System.DateTime _regDTTM;
    //     public System.DateTime RegDTTM
    //     {
    //        get{ return this._regDTTM;}
    //         set {this._regDTTM = value;}
    //     }

    //     private System.DateTime _lastLoginDTTM;
    //     public System.DateTime LastLoginDTTM
    //     {
    //        get{ return this._lastLoginDTTM;}
    //         set {this._lastLoginDTTM = value;}
    //     }

    //     private string _userID;
    //     public string UserID
    //     {
    //         get{ return this._userID;}
    //         set
    //         {
    //             try
    //             {
    //                 MailAddress m = new MailAddress(value);
    //                 this._userID = value;
    //             }
    //             catch (FormatException)
    //             {
    //                 throw new FormatException("DUH, not an email");//fe.Message);
    //             }
    //         }
    //     }
    // } 

    public class User : BaseEntity
    {
        public System.DateTime RegisterDTTM{get;set;}
        public System.DateTime LastLoginDTTM{get;set;}
        public string Email{get; private set;}

        public void ChangeEmail(string email)
        {
            if(string.IsNullOrWhiteSpace(email) || email.Length > 50)
            {
                throw new FormatException("Email is invalid");
            }

            try
            {
                MailAddress m = new MailAddress(email);
            }catch(FormatException)
            {
                throw new FormatException("Email is invalid");
            }

            Email = email;
        }
    }  
}
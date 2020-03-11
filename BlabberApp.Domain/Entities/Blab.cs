using BlabberApp.Domain.Interfaces;
using System;

namespace BlabberApp.Domain.Entities
{
    public class Blab : BaseEntity
    {
    //    private System.DateTime _dttm;
    //     public System.DateTime DTTM
    //     {
    //         get { return this._dttm; }
    //         set { this._dttm = value; }
    //     }
    //     private string _message;
    //     public string Message
    //     {
    //         get { return this._message; }
    //         set { this._message = value; }
    //     }
    //     private string _userId;
    //     public string UserID
    //     {
    //         get { return this._userId; }
    //         set { this._userId = value; }
    //     }

        public DateTime DTTM {get; set;}
        public string Message {get; set;}
        public string UserID{get;set;}

        public Blab()
        {
            DTTM = DateTime.Now;
        }
    }
}
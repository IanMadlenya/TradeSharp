//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TradeSharp.Linq
{
    using System;
    using System.Collections.Generic;
    
    public partial class ACCOUNT
    {
        public ACCOUNT()
        {
            this.BALANCE_CHANGE = new HashSet<BALANCE_CHANGE>();
            this.BROKER_ORDER = new HashSet<BROKER_ORDER>();
            this.PENDING_ORDER = new HashSet<PENDING_ORDER>();
            this.PENDING_ORDER_CLOSED = new HashSet<PENDING_ORDER_CLOSED>();
            this.PLATFORM_USER_ACCOUNT = new HashSet<PLATFORM_USER_ACCOUNT>();
            this.POSITION_CLOSED = new HashSet<POSITION_CLOSED>();
            this.POSITION = new HashSet<POSITION>();
            this.ACCOUNT_SHARE = new HashSet<ACCOUNT_SHARE>();
            this.SERVICE = new HashSet<SERVICE>();
            this.SUBSCRIPTION_SIGNAL = new HashSet<SUBSCRIPTION_SIGNAL>();
            this.TOP_PORTFOLIO = new HashSet<TOP_PORTFOLIO>();
            this.USER_EVENT = new HashSet<USER_EVENT>();
            this.USER_TOP_PORTFOLIO = new HashSet<USER_TOP_PORTFOLIO>();
            this.ACCOUNT_SHARE_HISTORY = new HashSet<ACCOUNT_SHARE_HISTORY>();
        }
    
        public int ID { get; set; }
        public string Currency { get; set; }
        public decimal Balance { get; set; }
        public decimal UsedMargin { get; set; }
        public string AccountGroup { get; set; }
        public string Description { get; set; }
        public decimal MaxLeverage { get; set; }
        public int Status { get; set; }
        public System.DateTime TimeCreated { get; set; }
        public Nullable<System.DateTime> TimeBlocked { get; set; }
        public string ReadonlyPassword { get; set; }
    
        public virtual ACCOUNT_GROUP ACCOUNT_GROUP { get; set; }
        public virtual COMMODITY COMMODITY { get; set; }
        public virtual ICollection<BALANCE_CHANGE> BALANCE_CHANGE { get; set; }
        public virtual ICollection<BROKER_ORDER> BROKER_ORDER { get; set; }
        public virtual ICollection<PENDING_ORDER> PENDING_ORDER { get; set; }
        public virtual ICollection<PENDING_ORDER_CLOSED> PENDING_ORDER_CLOSED { get; set; }
        public virtual ICollection<PLATFORM_USER_ACCOUNT> PLATFORM_USER_ACCOUNT { get; set; }
        public virtual ICollection<POSITION_CLOSED> POSITION_CLOSED { get; set; }
        public virtual ICollection<POSITION> POSITION { get; set; }
        public virtual ICollection<ACCOUNT_SHARE> ACCOUNT_SHARE { get; set; }
        public virtual ICollection<SERVICE> SERVICE { get; set; }
        public virtual ICollection<SUBSCRIPTION_SIGNAL> SUBSCRIPTION_SIGNAL { get; set; }
        public virtual ICollection<TOP_PORTFOLIO> TOP_PORTFOLIO { get; set; }
        public virtual ICollection<USER_EVENT> USER_EVENT { get; set; }
        public virtual ICollection<USER_TOP_PORTFOLIO> USER_TOP_PORTFOLIO { get; set; }
        public virtual ICollection<ACCOUNT_SHARE_HISTORY> ACCOUNT_SHARE_HISTORY { get; set; }
    }
}
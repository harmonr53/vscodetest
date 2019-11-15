using System;
using CsvHelper;
using CsvHelper.Configuration;

namespace vsctest.Models
{
    public class Transaction
    {
        public string Origination {get;set;}
        public string Description {get;set;}
        public string Category {get;set;}
        public DateTime TransDate {get;set;}
        public DateTime PostDate {get;set;}
        public float Amount{get;set;}

        public string CreditOrDebit {get;set;}

        public Transaction(DateTime posted, float amount, string desc)
        {
            PostDate = posted;
            TransDate = posted;
            Amount = amount;
            Description = desc;
            Origination = "Wells Fargo";
            if(amount < 0)
                CreditOrDebit = "Debit";
            else
                CreditOrDebit = "Credit";
        }

        public Transaction(DateTime transacted, DateTime posted, int card, string desc, string category, float debit, float credit)
        {
            TransDate = transacted;
            PostDate = posted;
            if(!String.IsNullOrEmpty(string.Format("{0:N2}", debit)))
            {
                Amount = debit;
                CreditOrDebit = "Debit";
            }
            if(!String.IsNullOrEmpty(string.Format("{0:N2}", credit)))
            {
                Amount = credit;
                CreditOrDebit = "Credit";
            }
            Description = desc;
            Origination = "Capital One Card: " + card.ToString();
            Category = category;
        }
        public Transaction(string card, DateTime posted, DateTime transacted, string type, string category,string merchant,string desc, float amount)
        {
            Origination = "Target " + card;
            Description = desc;
            Category = category;
            TransDate = transacted;
            PostDate = posted;
            if(type == "Credit")
            {
                
            }
        }
    }
}
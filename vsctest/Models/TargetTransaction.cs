using System;
using CsvHelper;
using CsvHelper.Configuration;

namespace vsctest.Models
{
    public class TargetTransaction
    {
        public string Card {get;set;}
        public DateTime PostingDate {get;set;}
        public DateTime TransactionDate {get;set;}
        public string Type{get;set;}
        public string Category{get;set;}
        public string MerchantName{get;set;}
        public string MerchantCity{get;set;}
        public string MerchantState{get;set;}
        public string Description{get;set;}
        public string TransactionType{get;set;}
        public string Amount{get;set;}
        public string ReferenceNumber{get;set;}
    }

    public class TargetMap : ClassMap<TargetTransaction>
    {
        public TargetMap()
        {
            Map(m => m.Card).Index(0);
            Map(m => m.PostingDate).Index(1);
            Map(m => m.TransactionDate).Index(2);
            Map(m =>m.Type).Index(3);
            Map(m =>m.Category).Index(4);
            Map(m =>m.MerchantName).Index(5);
            Map(m =>m.MerchantCity).Index(6);
            Map(m =>m.MerchantState).Index(7);
            Map(m =>m.Description).Index(8);
            Map(m =>m.TransactionType).Index(9);
            Map(m =>m.Amount).Index(10);
            Map(m =>m.ReferenceNumber).Index(11);
        }
    }
}
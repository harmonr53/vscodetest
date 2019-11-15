using System;
using CsvHelper;
using CsvHelper.Configuration;

namespace vsctest.Models
{
    public class CapOneTransaction
    {
        public DateTime TransactionDate {get;set;}
        public DateTime PostedDate {get;set;}
        public int Card {get;set;}
        public string Description {get;set;}
        public string Category{get;set;}
        public float Debit {get;set;}
        public float Credit{get;set;}
    }

    public class CapOneMap : ClassMap<CapOneTransaction>
    {
        public CapOneMap()
        {
            Map(m => m.TransactionDate).Index(0);
            Map(m => m.PostedDate).Index(1);
            Map(m => m.Card).Index(2);
            Map(m => m.Description).Index(3);
            Map(m => m.Category).Index(4);
            Map(m => m.Debit).Index(5);
            Map(m => m.Credit).Index(6);
        }
    }
}
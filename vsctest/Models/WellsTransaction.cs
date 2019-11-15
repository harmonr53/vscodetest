using System;
using CsvHelper;
using CsvHelper.Configuration;

namespace vsctest.Models
{
    public class WellsTransaction
    {
        public DateTime PostedDate {get;set;}
        public float Amount{get;set;}
        public string Description{get;set;}
    }

    public class WellsMap : ClassMap<WellsTransaction>
    {
        public WellsMap()
        {
            Map(m => m.PostedDate).Index(0);
            Map(m => m.Amount).Index(1);
            Map(m => m.Description).Index(4);
        }
    }
}
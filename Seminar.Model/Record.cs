using System;
using System.Collections.Generic;
using System.Text;

namespace Seminar.Model
{
    public class Record
    {
        public string Feeling { get; set; }
        public string Description { get; set; }
        public string Date { get; set; }

        public Record(string feeling, string description, string date)
        {
            Feeling = feeling;
            Description = description;
            Date = date;
        }
    }
}

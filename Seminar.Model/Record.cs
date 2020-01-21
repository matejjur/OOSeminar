using System;
using System.Collections.Generic;
using System.Text;

namespace Seminar.Model
{
    public class Record
    {
        public string Feeling { get; set; }
        public string Description { get; set; }

        public Record(string description)
        {
            //Feeling = feeling;
            Description = description;
        }
    }
}

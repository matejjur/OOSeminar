using System;
using System.Collections.Generic;
using System.Text;

namespace Seminar.Model
{
    public class Record
    {
        public string Feeling { get; set; }

        public Record(string feeling)
        {
            Feeling = feeling;
        }
    }
}

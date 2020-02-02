namespace Seminar.Model
{
    public class Record
    {
        public string Feeling { get; set; }
        public string Description { get; set; }
        public string Date { get; set; }
        public string Diet { get; set; }
        public string Keywords { get; set; }

        public Record(string feeling, string description, string date, string diet, string keywords)
        {
            Feeling = feeling;
            Description = description;
            Date = date;
            Diet = diet;
            Keywords = keywords;
        }
    }
}

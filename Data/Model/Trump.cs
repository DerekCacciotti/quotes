using System;
using System.Collections.Generic;
using System.Linq;
namespace quotes.Data.Model
{
    public class Trump
    {
          public DateTime appeared_at { get; set; }
        public DateTime created_at { get; set; }
        public string quote_id { get; set; }
        public List<string> tags { get; set; }
        public DateTime updated_at { get; set; }
        public string value { get; set; }
        public Embedded _embedded { get; set; }
        public Links _links { get; set; }
    }
    public class Self
    {
        public string href { get; set; }
    }

    public class Links
    {
        public Self self { get; set; }
    }

    public class Author
    {
        public string author_id { get; set; }
        public object bio { get; set; }
        public DateTime created_at { get; set; }
        public string name { get; set; }
        public string slug { get; set; }
        public DateTime updated_at { get; set; }
        public Links _links { get; set; }
    }

    public class Source
    {
        public DateTime created_at { get; set; }
        public object filename { get; set; }
        public string quote_source_id { get; set; }
        public object remarks { get; set; }
        public DateTime updated_at { get; set; }
        public string url { get; set; }
        public Links _links { get; set; }
    }

    public class Embedded
    {
        public List<Author> author { get; set; }
        public List<Source> source { get; set; }
    }


}
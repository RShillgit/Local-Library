using System;
using System.Collections.Generic;
namespace Local_Library.Data.Models
{
    public class Book : Entity
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string CoverImage { get; set; }
        public string Publisher { get; set; }
        public DateTime PublicationDate { get; set; }
        public Category Category { get; set; }
        public Guid ISBN { get; set; }
        public int PageCount { get; set; }
    }
}

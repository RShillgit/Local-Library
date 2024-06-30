using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Local_Library.Data.Models
{
    public class Book
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

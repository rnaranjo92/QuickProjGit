using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuickProj.Models
{
    public class BookModels
    {
        public int Id { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public string Name { get; set; }
        public int NumberOfPages { get; set; }
        public DateTime rentLength = DateTime.Now.AddDays(7);
        public DateTime PublicationDate { get; set; }
        public bool isAddedToCart { get; set; }
    }
}
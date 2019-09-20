using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuickProj.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public BookModels Book { get; set; }
        public string UserId { get; set; }
        public bool IsCheckedout { get; set; }
    }
}
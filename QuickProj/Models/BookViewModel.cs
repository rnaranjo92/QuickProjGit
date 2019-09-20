using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuickProj.Models
{
    public class BookViewModel
    {
        public BookModels Books { get; set; }
        public ApplicationUser User { get; set; }
    }
}
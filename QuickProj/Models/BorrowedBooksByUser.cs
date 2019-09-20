using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuickProj.Models
{
    public class BorrowedBooksByUser
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
        public int BookId { get; set; }
        public BookModels Book { get; set; }
        public DateTime ReturnDate { get; set; }
    }
}
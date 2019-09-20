using QuickProj.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuickProj.Controllers
{
    public class BookController : Controller
    {
        public ApplicationDbContext _context;
        // GET: Book
        public BookController()
        {
            _context = new ApplicationDbContext();
        }
        public ActionResult Index(string keyword)
        {
            return View(_context.Books.Where(k=>k.Name.Contains(keyword)||k.ISBN.Contains(keyword)||k.Author.Contains(keyword)||keyword==null).ToList());
        }

    }
}
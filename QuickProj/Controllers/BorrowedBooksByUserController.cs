using Microsoft.AspNet.Identity;
using QuickProj.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using System.Web.Mvc;

namespace QuickProj.Controllers
{
    public class BorrowedBooksByUserController : Controller
    {
        public ApplicationDbContext _context;
        // GET: Book
        public BorrowedBooksByUserController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: BorrowedBooksByUser
        public ActionResult Index()
        {
            var userId = User.Identity.GetUserId();
            var borrowedBook = _context.BorrowedBooksByUsers.Include(c=>c.Book).Where(c => c.UserId == userId).ToList();

            return View(borrowedBook);
        }
        public ActionResult Checkout()
        {
            var userId = User.Identity.GetUserId();
            var books = _context.Carts.Where(c => c.UserId == userId).Select(c=>c.Book).ToList();
            var cartItems = _context.Carts.Where(c => c.UserId == userId).ToList();
            foreach(var book in books)
            {
                var bookOut = new BorrowedBooksByUser()
                {
                    Book = book,
                    UserId = userId,
                    ReturnDate = DateTime.Now.AddDays(7)
                };
                book.isAddedToCart = false;
                _context.BorrowedBooksByUsers.Add(bookOut);
            }
            foreach(var item in cartItems)
            {
                _context.Carts.Remove(item);
            }
            _context.SaveChanges();
            return RedirectToAction("Index", "Book");

        }
            
    }
}
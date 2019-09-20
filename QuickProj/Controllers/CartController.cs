using QuickProj.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Microsoft.AspNet.Identity;

namespace QuickProj.Controllers
{
    public class CartController : Controller
    {
        public ApplicationDbContext _context;
        // GET: Book
        public CartController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Cart
        public ActionResult Index()
        {
            return View(_context.Carts.Include(c=>c.Book).ToList());
        }
        public ActionResult AddToCart(int Id)
        {
            var userId = User.Identity.GetUserId();
            var user = _context.Users.SingleOrDefault(c => c.Id == userId);

            if(user.libraryCardNumber == null)
            {
                return View("NoLibraryCardError");
            }

            var cart = new Cart
            {
                BookId = Id,
                UserId = userId,
                IsCheckedout = false
            };
            var book = _context.Books.SingleOrDefault(c => c.Id == Id);
            book.isAddedToCart = true;
            _context.Carts.Add(cart);
            _context.SaveChanges();

            return RedirectToAction("Index", "Book");
        }
    }
}
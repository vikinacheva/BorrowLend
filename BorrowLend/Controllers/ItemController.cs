using BorrowLend.Data;
using BorrowLend.Models;
using Microsoft.AspNetCore.Mvc;

namespace BorrowLend.Controllers
{
    public class ItemController : Controller
    {
        private readonly ApplicationDbContext _db;
        public IActionResult Index()
        {
            IEnumerable<Item>
                obj = _db.Items;
            return View(obj);
        }
        public ItemController(ApplicationDbContext db)
        {
            _db = db;
        }
    }
}

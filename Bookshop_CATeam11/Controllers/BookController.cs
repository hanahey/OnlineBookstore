using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bookshop_CATeam11.Controllers
{
    public class BookController : Controller
    {
        // GET: Book
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult CartItems()
        {
            return View();
        }

        #region helper
        public void AddItem() { }
        #endregion
    }
}
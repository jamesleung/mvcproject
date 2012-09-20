using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication1.ViewModels;

namespace MvcApplication1.Controllers
{
    public class StoreController : Controller
    {
        //
        // GET: /Store/

        public ActionResult Index()
        {
            var genres = new List<string> { "Rock", "Jazz", "Country", "Pop", "Disco" };

            var viewModel = new StoreIndexViewModel
            {
                NumberOfGenres = genres.Count(),
                Genres = genres
            };

            return View(viewModel);
        }

        public string Browse(string genre)
        {
            string message = HttpUtility.HtmlEncode("Store.Browse, Genre = " + genre);
            return message;
        }

        public string Details(string Id, string name)
        {
            string message = "Store.Details, ID = " + Id + ", Name = " + name;
            return message;
        }

    }
}

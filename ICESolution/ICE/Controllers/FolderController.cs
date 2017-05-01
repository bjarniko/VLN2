using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ICE.Models;

namespace ICE.Controllers
{
    public class FolderController : Controller
    {
        // GET: Folder
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CreateNewFolderView()
        {
            return View();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ICE.Models;

namespace ICE.Controllers
{
    public class FileController : Controller
    {
        // GET: File
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult FileEditorView()
        {
            return View();
        }

        public ActionResult CreateNewFileView()
        {
            return View();
        }
    }
}
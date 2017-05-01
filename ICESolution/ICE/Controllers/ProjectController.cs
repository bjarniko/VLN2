using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ICE.Models;

namespace ICE.Controllers
{
    public class ProjectController : Controller
    {
        // GET: Project
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CreateNewProjectView()
        {
            return View();
        }

        public ActionResult ListOfProjectsView()
        {
            return View();
        }

        public ActionResult ProjectView()
        {
            return View();
        }

        public ActionResult ListOfFilesAndFoldersView()
        {
            return View();
        }

        public ActionResult ShareProjectView()
        {
            return View();
        }


    }
}
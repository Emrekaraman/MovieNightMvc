﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieNightMvc.Areas.Admin.Controllers
{
    public class DashBoardController : AdminBaseController
    {
        // GET: Admin/DashBoard
        public ActionResult Index()
        {
            return View();
        }
    }
}
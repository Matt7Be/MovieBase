﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCMovie.Entities;

namespace MVCMovie.Controllers
{
    public class MoviesController : Controller
    {

        private MovieContext db;

 

        public IActionResult Index()
        {
            return View();
        }
    }
}
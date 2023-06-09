﻿using Microsoft.AspNetCore.Mvc;
using MovieList.Db;
using Microsoft.EntityFrameworkCore;

namespace MovieList.Controllers
{
    public class HomeController : Controller
    {
        private MovieContext Context { get; set; }
        public HomeController(MovieContext ctx) => Context = ctx;
        public IActionResult Index()
        {
            var movies = Context.Movies.Include(m => m.Genre).OrderBy(m => m.Name).ToList();
            return View(movies);
        }
    }
}
﻿using jukebox.Data;
using jukebox.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace jukebox.Controllers
{
    public class GenreController : Controller
    {

        private readonly ApplicationDbContext _db;

        public GenreController(ApplicationDbContext db )
        {
            _db = db;
        }
        public IActionResult Index()
        {

            IEnumerable<Genres> objGeneres = _db.Genres;
            return View(objGeneres);
        }

        public IActionResult Privacy()
        {
            return View();
        }

       
    }
}
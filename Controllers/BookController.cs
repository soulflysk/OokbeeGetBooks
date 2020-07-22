using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using SampleMVCApps.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
namespace SampleMVCApps.Controllers
{
    public class BookController : Controller
    {
        private readonly OokbeeEntities _context;

    public BookController(OokbeeEntities context)
    {
        _context = context;
    }
        public IActionResult Index()
        {
            ViewData["Message"] = "Hello, This is my view";
            return View();
        }
        public IActionResult GetBooks()
        {

            var books = _context.Books;
            return View(books);

        }
    }
}
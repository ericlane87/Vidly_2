﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {

        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };
            var customers = new List<Customer>()
            {
                new Customer { Name = "customer 1" },
                new Customer { Name = "customer 1" }
            };

            var ViewModel = new RandomViewModel
            {

                Movies = movie,
                Customers = customers
            };
            return View(ViewModel);
        




        //[Route("Movies/released/{year}/{month:range:regex(\\d{2})}:range(1,12")]


        //ViewData["Movie"] = movie;
        //  ViewBag.Movie = movie;

        //return View(movie);

        // return new ViewResult();
        // return Content("Hello World!");
        // return HttpNotFound();
        // return new EmptyResult();
        //return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name" });
    

}
            //public ActionResult Edit(int id)
            //{
            //    return Content("id="+ id);
            //}
        
        public ActionResult Index(int? pageIndex,string sortBy)
        {
            if (!pageIndex.HasValue)
            {
                pageIndex = 1; 
            }


            if (string.IsNullOrWhiteSpace(sortBy))
            {
                sortBy = "Name";
            }

            return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        }


        
             public ActionResult ByReleaseDate(int year,int month)
        {
            return Content(year + "/" + month);

        }            

    }
    
}
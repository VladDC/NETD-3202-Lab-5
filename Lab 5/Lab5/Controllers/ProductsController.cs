﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Lab5.Contants;

namespace Lab5.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Authorize(Permissions.Products.Create)]
        public IActionResult Create()
        {
            return View();
        }

        [Authorize(Permissions.Products.View)]
        public IActionResult Read()
        {
            return View();
        }

        [Authorize(Permissions.Products.Edit)]
        public IActionResult Edit()
        {
            return View();
        }

        [Authorize(Permissions.Products.Delete)]
        public IActionResult Delete()
        {
            return View();
        }
    }
}
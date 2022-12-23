﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SiteMVC.Models;

namespace SiteMVC.Controllers;

public class HomeController : Controller
{
   
    public IActionResult Index()
    {
        TempData["Nome"] = "RB";
        return View();
    }
    public IActionResult Demo()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

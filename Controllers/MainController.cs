﻿using Microsoft.AspNetCore.Mvc;
using SessionStateManagementForHighScalability.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace SessionStateManagementForHighScalability.Controllers
{
    public class MainController : Controller
    {
        UMSContext ORM = null;
        public MainController(UMSContext _ORM) { 
        
        ORM= _ORM;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult RegisterNewUser()
        {
            return View();
        }
        [HttpPost]
        public IActionResult RegisterNewUser(SystemUser U)
        {
            try
            {
                U.Role = "Staff";
                U.Status = "Active";
                ORM.SystemUsers.Add(U);
                ORM.SaveChanges();
                ViewBag.Message = "User "+U.Username+" Registered Succesfully !";
            }
            catch
            {
                ViewBag.Message = "Unable to Register the User,Please Try again";
            }
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {

            if (Request.Cookies["LastLoggedInTime"] != null)
            {
                ViewBag.LTLD = Request.Cookies["LastLoggedInTime"].ToString();
                
            }
            return View();
            
        }
        [HttpPost]
        public IActionResult Login(SystemUser U)
        {
            SystemUser LoggedInUser= ORM.SystemUsers.Where(x=>x.Username==U.Username&& x.Password==U.Password).FirstOrDefault();
            if (LoggedInUser == null)
            {
                ViewBag.Message = "Please check the credentials";
                return View();
            }

            //Save the user info into the session
            HttpContext.Session.SetString("Username",LoggedInUser.Username);
            HttpContext.Session.SetString("Role", LoggedInUser.Role);

            Response.Cookies.Append("LastLoggedInTime", DateTime.Now.ToString());



            return RedirectToAction("Dashboard");
        }

        public IActionResult Dashboard()
        {
            if(string.IsNullOrEmpty(HttpContext.Session.GetString("Username")))
            {
                return RedirectToAction("Login");
            }
            ViewBag.Username = HttpContext.Session.GetString("Username");       
            ViewBag.Role=HttpContext.Session.GetString("Role");
            return View();
         }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }
    }
}
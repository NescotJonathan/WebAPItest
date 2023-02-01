﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPItest.Controllers
{
    public class DemoController : ApiController //Controller
    {
        public string Get()
        {
            return "Welcome To Web API";  //Our Controller name is “Demo”, so we will run the following -> URL.“http://localhost:53027/api/Demo”.
        } //run http://localhost:53027/api/Demo, it will call “Get ()” -> Your localhost will NOT be 53027 -> You may have a different number
        public List<string> Get(int Id)
        {
            return new List<string>
            {
                "Data1",
                "Data2"
            }; //Call: http://localhost:53027/api/Demo/1 for this result -> Again you may have a different localhost number
        }

        /* // GET: Demo
        public ActionResult Index()
        {
            return View();
        }
        */
    }
}
using Skeeetch.Data;
using Skeeetch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace Skeeetch.Controllers
{
    public class YelpController : Controller
    {

        public ActionResult Business()
        {
            //var id = yelpId;
            

            ViewBag.Title = "Business Info";
            var client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", "Bearer **API KEY GOES HERE**");
            var result = client.GetAsync($"https://api.yelp.com/v3/businesses/qa70o0JbMVMQJf4fvWiZaw").Result;
            var business = result.Content.ReadAsAsync<Business>().Result;
            
            return View(business);

        }

    


            // GET: Yelp
            public ActionResult Index()
        {
            return View();
        }

        // GET: Yelp/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Yelp/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Yelp/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Yelp/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Yelp/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Yelp/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Yelp/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}

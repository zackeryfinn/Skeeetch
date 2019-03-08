using Skeeetch.Data;
using Skeeetch.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;



namespace Skeeetch.Controllers
{
    public class SearchController : Controller
    {
        public async Task<ActionResult> BusinessSearch( /*INSERT SEARCH TERMS HERE*/)

        {
            // var search = new GetBusinesses();

            ViewBag.Title = "Search Results";
            var client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", "Bearer raaudZPJ5cBD-o2GeXygnClQg5NBxz2BPcGVsWtiHEHFFjcTxw1ORVFzTASsLQaiEpAwiiwlfiwElgRZ3J_lhiFTyVwr4zH4eFCr1rUTd0go9OFFXZXTQrlSxrB6XHYx");

            var result = await client.GetAsync($"https://api.yelp.com/v3/businesses/search?term=taco&location=detroit&price=1");
            var businessResponses = result.Content.ReadAsAsync<BusinessRoot>();
            ObjectCache cache = 
            
            //List<string> topThreeYelpIds = new List<string>();
            //topThreeYelpIds.Add(businessResponses.Result.businesses.ElementAt(0).YelpId);
            //topThreeYelpIds.Add(businessResponses.Result.businesses.ElementAt(1).YelpId);
            //topThreeYelpIds.Add(businessResponses.Result.businesses.ElementAt(2).YelpId);





            return RedirectToAction("Reviews", new { topThreeYelpIds = topThreeYelpIds });

        }


        public async Task<ActionResult> Reviews(List<string> topThreeYelpIds)
        {

           
                for (int i = 0; i < topThreeYelpIds.Count; i++)
                {


                    ViewBag.Title = "Reviews";
                    var client = new HttpClient();
                    client.DefaultRequestHeaders.Add("Authorization", "Bearer raaudZPJ5cBD-o2GeXygnClQg5NBxz2BPcGVsWtiHEHFFjcTxw1ORVFzTASsLQaiEpAwiiwlfiwElgRZ3J_lhiFTyVwr4zH4eFCr1rUTd0go9OFFXZXTQrlSxrB6XHYx");
                    var result = await client.GetAsync($"https://api.yelp.com/v3/businesses/{topThreeYelpIds[i]}/reviews");
                    var businessReviews = result.Content.ReadAsAsync<ReviewRoot>();
                }
           
            return View();

        }



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

        public async Task<ActionResult> Keyword()
        {
            var client = new HttpClient();
            var queryString = HttpUtility.ParseQueryString(string.Empty);

            // Request headers
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", "*API Key*");

            var uri = "https://eastus.api.cognitive.microsoft.com/text/analytics/v2.0/keyPhrases?" + queryString;

            HttpResponseMessage response;

            // Request body
            byte[] byteData = Encoding.UTF8.GetBytes("{'documents': [{'language': 'en','id': '1','text': 'Hello world. This is some input text that I love.'},{'language': 'fr','id': '2','text': 'Bonjour tout le monde'}]");

            using (var content = new ByteArrayContent(byteData))
            {
                content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                response = await client.PostAsync(uri, content);
                
            }
            var keywords = await response.Content.ReadAsAsync<DocumentRoot>();
            var info = keywords.Documents.FirstOrDefault<Document>();
            return View(info);
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

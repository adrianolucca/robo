using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Modelo.Domain.Entities;
using Newtonsoft.Json;

namespace Becomex.Controllers
{
    public class RoboController : Controller
    {

        private string URLAPI = "http://localhost:58096/Robo/api/";
       
        // GET: Robo
        public ActionResult Index()
        {
            return View();
        }

      

        [HttpPost]
        public async Task<ActionResult> NextMove(Robo robo)
        {
                     

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(URLAPI);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

          
            string json = JsonConvert.SerializeObject(robo);

            // Espera o resultado
            using (HttpResponseMessage response = await client.PostAsync("NextMove", new StringContent(json, Encoding.UTF8, "application/json")))
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                var roboRetorno = JsonConvert.DeserializeObject<Robo>(responseContent);


                return Ok(roboRetorno);
            }
        }

        // POST: Robo/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Robo/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Robo/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Robo/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Robo/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
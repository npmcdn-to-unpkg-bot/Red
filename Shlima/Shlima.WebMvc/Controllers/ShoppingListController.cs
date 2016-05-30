using System;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System.Web.Mvc;
using Newtonsoft.Json;
using System.Text;
using Shlima.WebMvc.Models.ShoppingList;

namespace Shlima.WebMvc.Controllers
{
    public class ShoppingListController : Controller
    {
        public async Task<ActionResult> Index()
        {
            using (var httpClient = new HttpClient())
            {
                using (var httpResponseMessage = await httpClient.GetAsync("http://localhost/Shlima.WebApi/shoppinglist"))
                {
                    if (httpResponseMessage.StatusCode == HttpStatusCode.OK)
                    {
                        using (var httpContent = httpResponseMessage.Content)
                        {
                            var contentAsString = await httpContent.ReadAsStringAsync();
                            var model = JsonConvert.DeserializeObject<Index>(contentAsString);
                            return View(model);
                        }
                    }
                    throw new NotImplementedException();
                }
            }
        }

        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            using (var httpClient = new HttpClient())
            {
                using (var httpResponseMessage = await httpClient.GetAsync($"http://localhost/Shlima.WebApi/shoppinglist/{id.Value}"))
                {
                    if (httpResponseMessage.StatusCode == HttpStatusCode.OK)
                    {
                        using (var httpContent = httpResponseMessage.Content)
                        {
                            var contentAsString = await httpContent.ReadAsStringAsync();
                            var model = JsonConvert.DeserializeObject<Details>(contentAsString);
                            return View(model);
                        }
                    }
                    if (httpResponseMessage.StatusCode == HttpStatusCode.NotFound)
                    {
                        return HttpNotFound();
                    }
                    throw new NotImplementedException();
                }
            }
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        //public async Task<ActionResult> Create([Bind(Include = "Name")] WebApiModel.ShoppingList.Post shoppingList)
        public async Task<ActionResult> Create(Create model)
        {
            if (ModelState.IsValid)
            {
                using (var httpClient = new HttpClient())
                {
                    var serializedModel = JsonConvert.SerializeObject(model);
                    var content = new StringContent(serializedModel, Encoding.Default, "application/json");
                    using (var httpResponseMessage = await httpClient.PostAsync("http://localhost/Shlima.WebApi/shoppinglist", content))
                    {
                        if (httpResponseMessage.StatusCode == HttpStatusCode.OK)
                        {
                            return RedirectToAction("Index");
                        }
                        throw new NotImplementedException();
                    }
                }
            }
            return View(model);
        }

        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            using (var httpClient = new HttpClient())
            {
                using (var httpResponseMessage = await httpClient.GetAsync($"http://localhost/Shlima.WebApi/shoppinglist/{id.Value}"))
                {
                    if (httpResponseMessage.StatusCode == HttpStatusCode.OK)
                    {
                        using (var httpContent = httpResponseMessage.Content)
                        {
                            var contentAsString = await httpContent.ReadAsStringAsync();
                            var model = JsonConvert.DeserializeObject<Edit>(contentAsString);
                            return View(model);
                        }
                    }
                    if (httpResponseMessage.StatusCode == HttpStatusCode.NotFound)
                    {
                        return HttpNotFound();
                    }
                    throw new NotImplementedException();
                }
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        //public async Task<ActionResult> Edit([Bind(Include = "Id,Name,Timestamp")] ShoppingList shoppingList)
        public async Task<ActionResult> Edit(Edit model)
        {
            if (ModelState.IsValid)
            {
                using (var httpClient = new HttpClient())
                {
                    var serializedModel = JsonConvert.SerializeObject(model); 
                    var content = new StringContent(serializedModel, Encoding.Default, "application/json");
                    using (var httpResponseMessage = await httpClient.PutAsync($"http://localhost/Shlima.WebApi/shoppinglist/{model.ShoppingList.Id}", content))
                    {
                        if (httpResponseMessage.StatusCode == HttpStatusCode.OK)
                        {
                            return RedirectToAction("Index");
                        }
                        throw new NotImplementedException();
                    }
                }
            }
            return View(model);
        }

        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            using (var httpClient = new HttpClient())
            {
                using (var httpResponseMessage = await httpClient.GetAsync($"http://localhost/Shlima.WebApi/shoppinglist/{id.Value}"))
                {
                    if (httpResponseMessage.StatusCode == HttpStatusCode.OK)
                    {
                        using (var httpContent = httpResponseMessage.Content)
                        {
                            var contentAsString = await httpContent.ReadAsStringAsync();
                            var model = JsonConvert.DeserializeObject<Delete>(contentAsString);
                            return View(model);
                        }
                    }
                    if (httpResponseMessage.StatusCode == HttpStatusCode.NotFound)
                    {
                        return HttpNotFound();
                    }
                    throw new NotImplementedException();
                }
            }
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            using (var httpClient = new HttpClient())
            {
                using (var httpResponseMessage = await httpClient.DeleteAsync($"http://localhost/Shlima.WebApi/shoppinglist/{id}"))
                {
                    if (httpResponseMessage.StatusCode == HttpStatusCode.OK)
                    {
                        return RedirectToAction("Index");
                    }
                    throw new NotImplementedException();
                }
            }
        }
    }
}

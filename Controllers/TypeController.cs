using System.Collections.Generic;
using woww.Data;
using woww.Models;
using Microsoft.AspNetCore.Mvc;

namespace woww.Controllers
{
    public class TypeController : Controller
    {
        private readonly ApplicationDbContext _db;

        public TypeController(ApplicationDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public IActionResult Type()
        {
            IEnumerable<Item> itemList = _db.Items;
            return View(itemList);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Item item)
        {
            if(ModelState.IsValid)
            {
                _db.Items.Add(item);
                _db.SaveChanges();
                return RedirectToAction("Type");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var item = _db.Items.Find(id);
            if(item == null)
            {
                return NotFound();
            }
            return View(item);
        }

        [HttpPost]
        public IActionResult Edit(Item item)
        {
            if(ModelState.IsValid)
            {
                _db.Items.Update(item);
                _db.SaveChanges();
                return RedirectToAction("Type");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var item = _db.Items.Find(id);
            if(item == null)
            {
                return NotFound();
            }
            return View(item);
        }

        [HttpPost]
        [ActionName("Delete")]
        public IActionResult DeletePost(int id)
        {
            var item = _db.Items.Find(id);
            if(item == null)
            {
                return NotFound();
            }
            _db.Items.Remove(item);
            _db.SaveChanges();
            return RedirectToAction("Type");
        }
    }
}
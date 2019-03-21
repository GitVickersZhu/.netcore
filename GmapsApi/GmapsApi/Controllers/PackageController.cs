using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GmapsApi.Models;
// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GmapsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PackageController : ControllerBase
    {
        private readonly ItemContext _context;

        public PackageController(ItemContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<List<Item>> GetAll()
        {
            return _context.Items.ToList();
        }
        [HttpGet("{id}", Name = "GetItem")]
        public ActionResult<Item> GetById(long id)
        {
            var item = _context.Items.Find(id);
            if(item == null)
            {
                return NotFound();
            }
            return item;
        }
        [HttpPost]
        public IActionResult Create(Item item)
        {
            _context.Items.Add(item);
            _context.SaveChanges();
            return CreatedAtRoute("GetItem", new { id = item.Id}, item);
        }
        [HttpPut("{id}")]
        public IActionResult Update(long id, Item item)
        {
            var todo = _context.Items.Find(id);
            if(todo == null)
            {
                return NotFound();
            }
            todo.Name = item.Name;
            todo.Size = item.Size;
            todo.Address = item.Address;

            _context.Items.Update(todo);
            _context.SaveChanges();
            return NoContent();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            var todo = _context.Items.Find(id);
            if(todo == null)
            {
                return NotFound();
            }
            _context.Items.Remove(todo);
            _context.SaveChanges();
            return NoContent();
        }
    }
}

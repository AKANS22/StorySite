using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StoryBoard.Data;
using StoryBoard.Models;

namespace StoryBoard.Controllers
{
    public class StoryController : Controller
    {
        private readonly AppDbContext appDbContext;
        public StoryController(AppDbContext appDbContext) 
        { 
            this.appDbContext= appDbContext;
        }
        public IActionResult Index()
        {
            var stories = appDbContext.Stories.ToList();

            return View(stories);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Story story)
        {
            if (ModelState.IsValid)
            {
                appDbContext.Stories.Add(story);
                appDbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(story);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using MyWebApp.Models;


namespace MyWebApp.Controllers{
    public class HomeController : Controller{
       public IActionResult Index()
    {
        ViewBag.Title = "Home | Daniel's practice";
        return View();
    }


        public string Test(){
            return"good bye world";
        }

        public IActionResult Post(){
            Post Post = new Post();
            Post.Title = "My First Post";
            Post.PostedDate = DateTime.Now;
            Post.Author = "Daniel";
            Post.Body = "This is my first post.";
            return View(Post);
        }
    }
}
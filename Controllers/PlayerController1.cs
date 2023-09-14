using Microsoft.AspNetCore.Mvc;
using WebAppAssign04.Models;

namespace WebAppAssign04.Controllers
{
    public class PlayerController1 : Controller
    {
        static List<Player> players = new List<Player>
        {
            new Player(){UserId=1,UserName="Kohli",UserPwd="kohli@1256",UserEmail="kohli@yahoo.com"},
            new Player(){UserId=2,UserName="Dhoni",UserPwd="dhoni@123",UserEmail="dhoni@hotmail.com"},
            new Player(){UserId=3,UserName="dhawan",UserPwd="dhawan@1256",UserEmail="dhawan@mail.com"},
            new Player(){UserId=4,UserName="Sharma",UserPwd="sh@346",UserEmail="sh@yahoomail.com"},
            new Player(){UserId=5,UserName="Bravo",UserPwd="v@isha",UserEmail="b5@gmail.com"},
        };
        public IActionResult Index()
        {
            return View(players);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View(new Player());
        }
        [HttpPost]
        public IActionResult Create(Player model)
        {
            if (ModelState.IsValid)
            {
                players.Add(model);
                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }
        }
    }
}

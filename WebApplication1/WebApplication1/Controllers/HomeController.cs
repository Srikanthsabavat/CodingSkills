using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
       public int SumofPlayer, SumofDealer;
        public ActionResult Start()
        {
            return View();

        }


        public ActionResult Index()
        {

            

            var s = new Game();
    
           var dealer1 = s.Shuffle();
            var dealer2 = s.Shuffle();
            var player1 = s.Shuffle();
            var player2 = s.Shuffle();
            var player3 = s.Shuffle();



            ViewBag.Dealer = string.Format("{0}, {1} ", dealer1, dealer2);

           ViewBag.Player = string.Format("{0}, {1}", player1, player2);


            int intdealer1 = s.convertToInt(dealer1);
           int intdealer2 = s.convertToInt(dealer2);
           int intPlayer1 = s.convertToInt(player1);
            int intPlayer2 = s.convertToInt(player2);

             //int SumofPlayer, SumofDealer;

           SumofDealer = intdealer1 + intdealer2;
            ViewBag.SumDealer = string.Format("{0}", SumofDealer);
             SumofPlayer = intPlayer1 + intPlayer2;
            ViewBag.SumPlayer = string.Format("{0}", SumofPlayer);

         if(SumofPlayer>SumofDealer&&SumofPlayer<=21)
            {
                return RedirectToAction("ERRROR");
            }
         
           
            return View();

           
            
           
        }
        public ActionResult ERRROR()
        {
            
                ViewBag.Gameover = "Player win";
            
            return View();
        }
      




        [HttpGet]
        public ActionResult HitButton()
        {
            /* Game Hit = new Game();
            TempData["Hit"] = "Dialer";
            //TempData["Sum"] = "";*/
             return View();
            
        }

       [HttpPost]
      

        public ActionResult HitButton(Game sf)
        {
            /* TempData["Hit"] = TempData["Details"] + string.Format("{0}", sf.HitMethod());*/

                        
            return RedirectToAction("Index");
        }
       
        [HttpGet]
   
        public ActionResult StandButton()
        {
            Game stand = new Game();
            TempData["Stand"] = "Player";
            return View(stand);

        }
       [HttpPost]
        public ActionResult StandButton(Game sf)
        {
            Game ga = new Game();

            TempData["Stand"] = TempData["Details"] + string.Format("{0}", sf.StandMethod());
            return RedirectToAction("Index");

        }
        public ActionResult Playagain()
        {
            return RedirectToAction("Start");

        }



    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bakery.Models;

namespace Bakery.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public JsonResult BakeryResult(double NumberofPackages, string PackCode)
        {
            bool result = false;
            double FinalValue;
            if(PackCode.ToUpper() == "VS5")
            {
                FinalValue = getVegemiteScroll(NumberofPackages);
                result = true;
            }
            else if (PackCode.ToUpper() == "MB11")
            {
                FinalValue = getBlueberryMuffin(NumberofPackages);
                result = true;
            }
            else if (PackCode.ToUpper() == "CF")
            {
                FinalValue = getCroissant(NumberofPackages);
                result = true;
            }
            else
            {
                result = false;
                FinalValue = 0;
            }
            return Json(new
            {
                result = result,
                TotalAmount = FinalValue,
            });
        }
        public double getVegemiteScroll(double VS)
        {
            double TotalValueVegScr = 0;
            for (int i = 1; i <= VS; i++)
            {
                if (VS <= 3)
                {
                    TotalValueVegScr += 6.99;
                    i = Convert.ToInt32(VS) - 1;
                    VS -= VS;
                }
                else
                {
                    TotalValueVegScr += 8.99;
                    i = Convert.ToInt32(VS) - 1;
                    VS -= VS;
                }
            }

            return TotalValueVegScr;
        }
        public double getBlueberryMuffin(double BM)
        {
            double TotalValueBluemuff = 0;
            for (int i = 1; i <= BM; i++)
            {
                if (BM <= 2)
                {
                    TotalValueBluemuff += 9.95;
                    i = Convert.ToInt32(BM) - 1;
                    BM -= BM;
                }
                else if (BM <= 5)
                {
                    TotalValueBluemuff += 16.95;
                    i = Convert.ToInt32(BM) - 1;
                    BM -= BM;
                }
                else
                {
                    TotalValueBluemuff += 24.95;
                    i = Convert.ToInt32(BM) - 1;
                    BM -= BM;
                }
            }

            return TotalValueBluemuff;
        }

        public double getCroissant(double Cro)
        {
            double TotalValueCroissant = 0;
            for (int i = 1; i <= Cro; i++)
            {
                if (Cro <= 2)
                {
                    TotalValueCroissant += 5.95;
                    i = Convert.ToInt32(Cro) - 1;
                    Cro -= Cro;
                }
                else if (Cro <= 5)
                {
                    TotalValueCroissant += 9.95;
                    i = Convert.ToInt32(Cro) - 1;
                    Cro -= Cro;
                }
                else
                {
                    TotalValueCroissant += 16.99;
                    i = Convert.ToInt32(Cro) - 1;
                    Cro -= Cro;
                }
            }

            return TotalValueCroissant;
        }
    }
}
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
        /*Post method to get the required result*/
        public JsonResult BakeryResult(double NumberofPackages, string PackCode)
        {
            bool result = false;
            double FinalValue;
            if (PackCode.ToUpper() == "VS5")
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
        /*getVegemiteScroll() getting the value from input and calculating the total */
        public double getVegemiteScroll(double VS)
        {
            double TotalValueVegScr = 0;
            for (int i = 1; i <= VS; i++)
            {
                if (VS == 0)
                {
                    break;
                }
                if (VS >= 3 && VS % 2 == 1 && Session["VS5"] == null)
                {
                    TotalValueVegScr += 6.99;
                    VS -= 3;
                }
                else if (VS <= 3)
                {
                    TotalValueVegScr += 6.99;
                    VS -= 3;
                }
                else if (VS >= 5 && VS % 2 == 0)
                {
                    TotalValueVegScr += 8.99;
                    VS -= 5;
                    Session["VS5"] = true;
                }
                else if (VS == 5)
                {
                    TotalValueVegScr += 8.99;
                    VS -= 5;
                }
                else if (VS == 3)
                {
                    TotalValueVegScr += 6.99;
                    VS -= 3;
                }
            }

            return TotalValueVegScr;
        }

        /*getBlueberryMuffin() getting the value from input and calculating the total */
        public double getBlueberryMuffin(double BM)
        {
            double TotalValueBluemuff = 0;
            for (int i = 1; i <= BM; i++)
            {
                if (BM == 0)
                {
                    break;
                }
                if ((BM <= 2 || BM % 2 == 0) && BM <= 8)
                {
                    TotalValueBluemuff += 9.95;
                    BM -= 2;
                    i = 1;
                }
                else if ((BM >= 2 || BM % 2 == 0) && BM <= 8)
                {
                    TotalValueBluemuff += 9.95;
                    BM -= 2;
                }
                else if (BM <= 5 && BM % 2 != 0)
                {
                    TotalValueBluemuff += 16.95;
                    BM -= 5;
                }
                else
                {
                    TotalValueBluemuff += 24.95;
                    BM -= 8;
                }
            }

            return TotalValueBluemuff;
        }
        /*getCroissant() getting the value from input and calculating the total */
        public double getCroissant(double Cro)
        {
            double TotalValueCroissant = 0;
            for (int i = 1; i <= Cro; i++)
            {
                if (Cro == 0)
                {
                    break;
                }
                if ((Cro <= 3 || Cro % 2 == 0) && Cro <= 9)
                {
                    TotalValueCroissant += 5.95;
                    Cro -= 3;
                }
                else if ((Cro >= 5 || Cro % 2 == 0) && Cro >= 9)
                {
                    TotalValueCroissant += 9.95;
                    Cro -= 5;
                }
                else if (Cro == 5)
                {
                    TotalValueCroissant += 9.95;
                    Cro -= 5;
                }
                else if (Cro == 9)
                {
                    TotalValueCroissant += 16.99;
                    Cro -= 9;
                }
            }


            return TotalValueCroissant;
        }
    }
}
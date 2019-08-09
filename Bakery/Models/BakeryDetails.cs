using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bakery.Models
{
    public class BakeryDetails
    {
        /* Just in Information */
        /* packs for Vegemite Scroll */
        public static Dictionary<double, double> VegemiteScroll = new Dictionary<double, double>()
        {
            {3,6.99},
            {5,8.99},
        };
        public double[] VegemiteScroll_ar = new double[] {
            3,
            5
        };

        /* packs for Blueberry Muffin */
        public static Dictionary<double, double> BlueberryMuffin = new Dictionary<double, double>()
        {
            {2,9.95},
            {5,16.95},
            {8,24.95},
        };
        public double[] BlueberryMuffin_ar = new double[] {
            2,
            5,
            8
        };

        /* packs for Croissant */
        public static Dictionary<double, double> Croissant = new Dictionary<double, double>()
        {
            {3,5.95},
            {5,9.95},
            {9,16.99},
        };
        private double[] Croissant_ar = new double[] {
            3,
            5,
            9
        };

       
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bakery.Models
{
    public class BakeryDetails
    {
        /* packs for Vegemite Scroll */
        public static Dictionary<double, double> VegemiteScroll = new Dictionary<double, double>()
        {
            {3,6.99},
            {5,8.99},
        };
        private static double[] VegemiteScroll_ar = new double[] {
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
        private static double[] BlueberryMuffin_ar = new double[] {
            2,
            5,
            8
        };

        /* packs for Croissant */
        public static Dictionary<double, double> Croissant = new Dictionary<double, double>()
        {
            {2,5.95},
            {5,9.95},
            {8,16.99},
        };
        private static double[] Croissant_ar = new double[] {
            3,
            5,
            9
        };
    }
}
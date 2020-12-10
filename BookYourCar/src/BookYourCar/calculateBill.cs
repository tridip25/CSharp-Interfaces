using System;
using System.Collections.Generic;

namespace BookYourCar
{
    public class calculateBill
    {
        public static double kilometer;
        public static double pricePerKilometer;
        public double getTotalAmountStatus(double km , double pricePerKm )
        {
            kilometer = km;
            pricePerKilometer = pricePerKm;
            return kilometer * pricePerKilometer;
        }

        public void showPrintedBill(string car , double amount)
        {
            Console.WriteLine("_____________________________________________________________________________________________");
            Console.WriteLine("                 Hello Guest !!!     ---------        -----------------                      ");
            Console.WriteLine("                 ------     --------          -------Your Bill Details:                      ");
            Console.WriteLine($"                CAR BOOKED     : {car} ------------------------                             ");
            Console.WriteLine($"                PRICE/KM       : {pricePerKilometer} --------------------                   ");
            Console.WriteLine($"                TOTAL KM       : {kilometer} --------------------                           ");
            Console.WriteLine($"                AMOUNT         : {amount} --------------------                              ");
            Console.WriteLine("_____________________________________________________________________________________________");
        }
    }
}
using System;
using System.Collections.Generic;

namespace BookYourCar
{
    public class menu
    {
        public static void showMenu()
        {
            double km = 0.0;
            var bill = new calculateBill();
            try{
            while(true)
             {
                Console.WriteLine("-----------AVAILABLE CARS------------");
                Console.WriteLine("----------SELECT YOUR CAR------------");
                Console.WriteLine("-----------1/ Toyota (Rs 25/km)------");
                Console.WriteLine("-----------2/ Ford (Rs 20/km)--------");
                Console.WriteLine("-----------3/ Maruti (Rs 15/km)------");
                Console.WriteLine("-----------4/ Renault(Rs 18/km-------");
                Console.WriteLine("Enter your choice :");
                var input = Console.ReadLine();
            
                var choice = int.Parse(input);
                
             
                switch(choice)
                {
                    case 1: 
                        km = showSecondMenu();
                        
                        bill.showPrintedBill("Toyota", bill.getTotalAmountStatus(km, 25));
                    break;
                    
                    case 2:
                        km = showSecondMenu();
                        bill.showPrintedBill("Ford", bill.getTotalAmountStatus(km, 20));
                    break;
                    
                    case 3:
                        km = showSecondMenu();
                        bill.showPrintedBill("Maruti", bill.getTotalAmountStatus(km, 15));
                    break;
                    
                    case 4:
                        km = showSecondMenu();
                         bill.showPrintedBill("renault", bill.getTotalAmountStatus(km, 18));
                    break;
                    
                    default :
                        Console.WriteLine("Wrong Choice !!!"); 
                    break;



                }
             }
            }
               catch(Exception)
                {
                    Console.WriteLine("Invalid input");
                }
        }

        public static double showSecondMenu()
        {
            Console.WriteLine("Enter total KM :");
            var input = Console.ReadLine();
            var km = double.Parse(input);
            return km;
        }
    }
}
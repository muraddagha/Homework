using System;
using System.Collections.Generic;
using System.Text;

namespace Taxii
{
    class Bolt:Taxi
    {
        
        private static double _TotalOrder;
        public static double TotalOrder { get => _TotalOrder; }
        private static double _TotalAmount;
        public static double TotalAmount { get => _TotalAmount; }
        private static double Price;
        public Bolt()
        {
            kmPrice = 5;
        }

        public override void Drive(double roadKM)
        {
            _TotalOrder++;
            _TotalAmount += Price;
            Console.WriteLine(Price);
        }

        public override double Calc(double roadKm)
        {

            
            Price = this.kmPrice * roadKm;
            return Price;
        }
    }
}

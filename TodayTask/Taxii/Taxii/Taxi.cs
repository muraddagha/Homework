using System;
using System.Collections.Generic;
using System.Text;

namespace Taxii
{
    abstract class Taxi
    {

        protected double kmPrice;

        public abstract void Drive(double roadKM);

        public abstract double Calc(double roadKm);
        
        
          
        
        
    }
}

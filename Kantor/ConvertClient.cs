using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kantor
{
    class ConvertClient
    {
        private ICantorInterface convertInterface;  
  
       //Constructor: assigns strategy to interface  
        public ConvertClient(ICantorInterface strategy)  
        {  
            convertInterface = strategy;  
        }  
  
        //Executes the strategy  
       public double Calculate(double value)  
        {  
           return convertInterface.Calculate(value);  
        }  
    }
}

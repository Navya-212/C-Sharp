using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
  class Program
  {
    static void Main(string[] args)
    {
    	Int32 value=11;
        
        if(value<10) //if-else case
         {
          Console.WriteLine("Value is less than 10");
         }
         else
         {
          Console.WriteLine("Value is greater than 10");
         }
        //switch case
        switch(value) 
       {
         case 1: Console.WriteLine("Value is 1");	
         	break;
         case 2: Console.WriteLine("Value is 2");
         	break;
         default: Console.WriteLine("value is different");
         	break;
       }
    }
  }
}
//output:Value is greater than 10
// value is different
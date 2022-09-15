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
    	Int32 value=10,i=0;
        
        while(i<value){ //while loop
          Console.Write(i+" ");
          i=i+1;
         }	
         Console.Write("\n");
         //WriteLine : to print in next line
         for(Int32 j=value; j<15;j++){
         	Console.Write(j+" ");
         }
    }
  }
}
//output:0 1 2 3 4 5 6 7 8 9 
// 10 11 12 13 14 
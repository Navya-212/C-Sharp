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
    	Int32 num1=100,num2=11;
        double num3=10.01;
        bool status=true;
        String message="Value is ";
        Console.Write(num1+num2+"\n");
        Console.Write((num1 > num2) +"\n");
   		Console.Write(message+num3 +"\n");
        Console.Write(!status +"\n");
        num2--;
        Console.Write(num2);
    }
  }
}
//output:111
// True
// Value is10.01
// False
// 10
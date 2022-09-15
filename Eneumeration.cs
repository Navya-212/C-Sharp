//An enumeration is used in any programming language to define a constant set of values. For example, the days of the week can be defined as an enumeration and used anywhere in the program. In C#, the enumeration is defined with the help of the keyword ‘enum’.
//enum= to declare enumeration
//Days=name of enumeration
//week names= value of enumeration
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
  class Program
  {
  	enum Days{sun,mon,tue,wed,thur,fri,sat};
    static void Main(string[] args)
    {
    	Console.Write(Days.mon);
    }
  }
}
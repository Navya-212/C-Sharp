using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApplication
{
 class Program
 {
  static void Main(string[] args)
  {
   Stack st=new Stack();
   st.Push(10);
   st.Push(20);
   st.Push(30);
   foreach(Object x in st){
   	Console.WriteLine(x);
   }
   
   
   Console.WriteLine(st.Count);
   Console.WriteLine(st.Contains(20));
   st.Pop();
   Console.WriteLine(st.Count);
  }
 }
}
//output
// 30
// 20
// 10
// 3
// True
// 2
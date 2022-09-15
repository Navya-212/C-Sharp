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
   Queue q= new Queue();
   
   Int32 i=0,k=10;
   while(i<5){
     q.Enqueue(k);
     i++;
     k+=10;
   }
   foreach(Object x in q){
   	Console.WriteLine(x);
   }
   
   
   Console.WriteLine(q.Count);
   Console.WriteLine(q.Contains(20));
   q.Dequeue();
   Console.WriteLine(q.Count);
  }
 }
}
// output
// 10
// 20
// 30
// 40
// 50
// 5
// True
// 4
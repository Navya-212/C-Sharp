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
   Hashtable ht = new Hashtable();
   ht.Add("001",".Net");
   ht.Add("002","C#");
   ht.Add("003","ASP.Net");

   ICollection keys = ht.Keys;//This is done via the ICollection interface. This is a special data type which can be used to store the keys of a hashtable collections. We then assign the keys of the hashtable collection to the variable ‘keys’.

   foreach (String k in keys)
   {
    Console.WriteLine(ht[k]);
   }
    Console.WriteLine(ht.ContainsKey("001"));
   Console.WriteLine(ht.ContainsValue("C#"));
   }
 }
}
//output:
// C#
// ASP.Net
// .Net
// True
// True

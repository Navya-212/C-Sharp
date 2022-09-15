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
    	Int32[] arr=new Int32[5];
        Int32 i=0, k=10;
        
        while(i<5){ //while loop
          arr[i]=k;
          k+=10;
          i=i+1;
         }	
         Console.WriteLine("Length of array is "+arr.Length );
         
         for(Int32 j=0; j<arr.Length;j++){
         	Console.Write(arr[j]+" ");
         }
    }
  }
}
//output:Length of array is 5
// 10 20 30 40 50 
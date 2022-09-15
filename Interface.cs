//An Interface in C# is used along with a class to define a contract which is an agreement on what the class will provide to an application. The interface defines what operations a class can perform. An interface declares the properties and methods. It is up to the class to define exactly what the method will do.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DemoApplication
{
 interface Tutorial
 {
  void SetTutorial(int pID, string pName);
  String GetTutorial();
 }
 
  class NewTutorial:Tutorial
  {
   protected int TutorialID; 
   protected string TutorialName;
   
   public void SetTutorial(int pID,string pName) 
   {
    TutorialID=pID;
    TutorialName=pName;
   }
   
   public String GetTutorial()
   {
    return TutorialName;
   }
  
  static void Main(string[] args) 
  {
   NewTutorial pTutor=new NewTutorial();
   
   pTutor.SetTutorial(1,"DotNet");
    
   Console.WriteLine(pTutor.GetTutorial());
    
   Console.ReadKey(); 
  }
 }
}
//output: DotNet

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Abstract Class can never be instantiated and is marked by the keyword abstract. An abstract class contains zero or more abstract methods in it. Abstract class acts as a base class and is designed to be inherited by subclasses that either implement or either override its method.

namespace DemoApplication
{
 abstract class Tutorial //the use of the abstract keyword. This is used to denote that the class is an abstract class.
 {
  public virtual void Set() //defining our method which does nothing. The method must have the keyword called virtual. This means that the method cannot be changed by the child class. This is a basic requirement for any abstract class.
  {
      
  }
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
   
   pTutor.SetTutorial(1,".Net");
    
   Console.WriteLine(pTutor.GetTutorial());
    
   Console.ReadKey(); 
  }
 }
}
//output: .Net
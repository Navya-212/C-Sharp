using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//public access modifier
namespace HelloWorld
{
  class Tutorial
  {
  	int TutId;
    String TutName;
    public void setTutorial(int tid, String tname){
    TutId=tid;
    TutName=tname;
    }
    public String getTutorial(){
    	return TutName;
    }
    static void Main(string[] args)
    {
    	Tutorial obj=new Tutorial();
        obj.setTutorial(1,"dotnet");
      Console.WriteLine(obj.getTutorial());    
    }
  }
}

//private
namespace HelloWorld
{
  class Tutorial
  {
  	int TutId;
    String TutName;
    private void setTutorial(int tid, String tname){
    TutId=tid;
    TutName=tname;
    }
    
    static void Main(string[] args)
    {
    	Tutorial obj=new Tutorial();
        obj.setTutorial(1,"dotnet");//cannot be accesed
      Console.WriteLine(obj.getTutorial());    
    }
  }
}
//To access private method in C# programming of a class, we need to use reflection technique. In brief, reflection objects are used to get type information at run time.

//constructor
namespace DemoApplication
{
 class Tutorial
 {
  public int TutorialID; 
  public string TutorialName;
  
  public Tutorial()
  {
   TutorialID=0;
   TutorialName="Default";
  }
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
   Tutorial pTutor=new Tutorial();
    
   Console.WriteLine(pTutor.GetTutorial());
    
   Console.ReadKey(); 
  }
 }
}
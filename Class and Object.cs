using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


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
    	Tutorial obj=new Tutorial(); //creating object
        obj.setTutorial(1,"dotnet");
      Console.WriteLine(obj.getTutorial());    
    }
  }
}

//output: dotnet
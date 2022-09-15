//child class inherits properties of parent class
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
    public class NewTutorial:Tutorial{ //inheriting class Tutorial
    	public void RenameTut(String tNewName){
        	TutName=tNewName;
        }
    }
    static void Main(string[] args)
    {
    	Tutorial obj=new Tutorial(); //creating object
        obj.setTutorial(1,"dotnet");
      Console.WriteLine(obj.getTutorial());
      NewTutorial newobj=new NewTutorial();
      newobj.RenameTut(".net");
      Console.WriteLine(newobj.getTutorial());
    }
  }
}
//output: dotnet
//.net
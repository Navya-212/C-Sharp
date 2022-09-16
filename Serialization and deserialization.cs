using System;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
//The concept of Serialization and deserialization is used whenever data pertaining to objects have to be sent from one application to another. Serialization is used to export application data into a file. The destination application then uses deserialization to extract the data from the application for further use.

namespace DemoApplication
{
  [Serializable] //serializable attribute
  class Tutorial //class to serialize
  {
  public int ID;
  public String Name;
   static void Main(string[] args)
   {
    Tutorial obj = new Tutorial(); //initializing obj
    obj.ID = 1;
    obj.Name = ".Net";

    IFormatter formatter = new BinaryFormatter(); //creating file stream
    Stream stream = new FileStream(@"E:\ExampleNew.txt",FileMode.Create,FileAccess.Write);

    formatter.Serialize(stream, obj); //serialize obj
    stream.Close();

    stream = new FileStream(@"E:\ExampleNew.txt",FileMode.Open,FileAccess.Read); //creating stream
    Tutorial objnew = (Tutorial)formatter.Deserialize(stream); //deserialize obj

    Console.WriteLine(objnew.ID);
    Console.WriteLine(objnew.Name);

    Console.ReadKey();
  }
 }
}
//output:
// 1
// .Net
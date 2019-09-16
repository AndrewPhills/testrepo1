using System;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace test2
{

    [Serializable]  //Serializable attribute

    public class Tutorial  //class to serialize
    {
        public int ID;
        public String Name;


        static void Main(string[] args)
        {
            Tutorial obj = new Tutorial(); //Object (obj) datatype class tutorial instance
            obj.ID = 1;
            obj.Name = ".Net";  // INITIALIZE AN OBJECT

            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(@"E:\ExampleNew.txt", FileMode.Create, FileAccess.Write);////////////
            // CREATE THE FILE STREAM

            formatter.Serialize(stream, obj);
            stream.Close();  // SERIALIZE THE OJECT

            stream = new FileStream(@"E:\ExampleNew.txt", FileMode.Open, FileAccess.Read);
            //We create the object "stream" to open the file Example.txt in reading only mode.

            Tutorial objnew = (Tutorial)formatter.Deserialize(stream);
            // CREATE THE FILE STREAM
            //DESERIALIZE THE OBJECT

            Console.WriteLine(objnew.ID);
            Console.WriteLine(objnew.Name);
            // WRITE THE DATA TO THE CONSOLE

            Console.ReadKey();
        }
    }
} 
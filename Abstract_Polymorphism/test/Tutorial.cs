using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{  public abstract class Abstracta
    {
        public abstract void MyMetod() ;  // abstract methods in abstract classes cannot have a body


        public void MynewMethod() //void methods ( -no need to return- ) can have body and implement 
        {

        }

    }


    public class Abstract1 : Abstracta //abstract implements method here
    {
        public override void MyMetod()
        {
            base.MynewMethod();
        }
    }
    internal interface Guru99Interface  // Define the public interface
    { 
        //here we define the methods
        //no more acces modifiers in interface

        void SetTutorial(int pID, string pName);
        String GetTutorial();
        void MyMethod();

    }

    public class Guru99Tutorial : Guru99Interface // class extends the interface
    {
        protected int TutorialID;
        protected string TutorialName;

        public void SetTutorial(int pID, String pName)
        {
            TutorialID = pID;
            TutorialName = pName;
        }
        public String GetTutorial()
        {
            return TutorialName;
        }


        public virtual void MyMethod()
        {
            Console.WriteLine("New method");

        }

    

    

        static void Main(string[] args)
        {
            Guru99Interface pTutor = new Guru99Tutorial();

           
            pTutor.MyMethod(); 
         
            Guru99Interface item = new MyClass2();
            item.MyMethod();
            pTutor.MyMethod();
            item.MyMethod();

            Console.ReadKey();
        }
    } 

    public class MyClass2 : Guru99Tutorial
    {
        public override void MyMethod()
        {
            base.MyMethod();
            Console.WriteLine("Another one");
        } 
    }
}
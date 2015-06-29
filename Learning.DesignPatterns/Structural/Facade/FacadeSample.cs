using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.DesignPatterns.Structural.Facade
{
    public class FacadeSample
    {

        public static void Run()
        {
            FacadeClient client = new FacadeClient();
            client.DisplaySub1();
            client.DisplaySub2();
            //client.
        }


    }


    public class FacadeClient
    {

        private SubSystem1 _sub1;
        private SubSystem2 _sub2;
        public FacadeClient()
        {
            _sub1 = new SubSystem1();
            _sub2 = new SubSystem2();
        }

        public void DisplaySub1()
        {
            _sub1.DisplaySystem1();
        }

        public void DisplaySub2()
        {
            _sub2.DisplaySystem2();
            _sub2.DisplaySystem1();
        }
    }


    public class SubSystem1
    {
        public virtual void DisplaySystem1()
        {
            Console.WriteLine("Display System 1");
        }
    }

    public class SubSystem2 : SubSystem1
    {
        public override void DisplaySystem1() 
        {
            Console.WriteLine("Display System 2.1");
        }
        public void DisplaySystem2()
        {
            Console.WriteLine("Display System 2.2");
        }

    }
}

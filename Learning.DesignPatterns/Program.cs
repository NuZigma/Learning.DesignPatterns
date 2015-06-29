using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Learning.DesignPatterns.Builder;
using Learning.DesignPatterns.AbstractFactory;
using Learning.DesignPatterns.FactoryMethod;
using Learning.DesignPatterns.Singleton;
using Learning.DesignPatterns.Structural.Facade;

namespace Learning.DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {


            //BuilderSample.Run();

            //AbstractFactorySample.Run();

            //FactoryMethodSample.Run();

            //SingletonSample.Run();

            FacadeSample.Run();

            Console.ReadKey();
            
        }
    }
}

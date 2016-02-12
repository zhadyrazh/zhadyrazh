using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classmemberMethod
{
    abstract class Motorcycle
    {
        public void StartEngine()
        {

        }

        protected void AddGas(int gallons)
        {

        }

        public virtual int Drive(int miles, int speed)
        {
            return 1;
        }

        public abstract double GetTopSpeed();
     }
    
    class TestMotorcycle : Motorcycle
    {
        public override double GetTopSpeed()
        {
            return 108.4;
        }

        static void Main()
        {
            TestMotorcycle moto = new TestMotorcycle();

            moto.StartEngine();
            moto.AddGas(15);
            moto.Drive(5, 20);

            double speed = moto.GetTopSpeed();
         
            Console.WriteLine("My top speed is {0}", speed);
            Console.ReadKey();
        }


    } 
}
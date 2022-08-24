using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car();

            var truck = new Truck();

            var suv = new SUV();
            var vehicle = new List<IVehicle> { car, truck, suv};
            
            
            

            foreach(var veh in vehicle)
            {
                veh.Drive();
                veh.ChangeGears(true);
                veh.Reverse();
            }
        }
    }
}

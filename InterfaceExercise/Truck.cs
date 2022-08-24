using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        public Truck()
        {

        }

        public double EngineSize { get; set; } = 8.0;
        public string Model { get; set; } = "Ford";
        public string Make { get; set; } = "F-150";
        public int SeatCount { get; set; } = 4;
        public string CompanyName { get; set; } = "Ford";
        public string Motto { get; set; } = "Built Ford Tough";
        public bool HasChangedGears { get; set; }

        public bool HasFourWheelDrive { get; set; } = true;


        public void Drive()
        {
            if (HasFourWheelDrive == true)
            {
                Console.WriteLine($" 4 wheel drive {GetType().Name} now driving forward. . .");
            }
            else
            {
                Console.WriteLine($"{GetType().Name} now driving forward. . .");
            }
            
        }
        public void Reverse()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} now reversing. . .");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine("Cant reverse until we change gears");
            }

        }
        public void Park()
        {
            Console.WriteLine();
        }

        public void ChangeGears(bool isChanged)
        {
            HasChangedGears = isChanged;
        }

    }


}

using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class SUV : IVehicle, ICompany
    {
        public SUV()
        {

        }

        public double EngineSize { get; set; } = 6.0;
        public string Model { get; set; } = "Ford";
        public string Make { get; set; } = "Excusion";
        public int SeatCount { get; set; } = 7;
        public string CompanyName { get; set; } = "Ford";
        public string Motto { get; set; } = "Built Ford Tough";
        public bool HasChangedGears { get; set; }

        public bool HasAllWheelDrive { get; set; } = true;

        public void Drive()
        {
            if(HasAllWheelDrive == true)
            {
                Console.WriteLine($"All Wheel Drive {GetType().Name} now driving forward. . .");
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

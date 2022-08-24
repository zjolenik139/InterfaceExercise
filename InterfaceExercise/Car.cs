﻿using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise 
{
    public class Car : IVehicle, ICompany
    {
        public Car()
        {

        }

        public double EngineSize { get; set; } = 4.7;
        public string Model { get; set; } = "Ford";
        public string Make { get; set; } = "Mustang";
        public int SeatCount { get; set; } = 4;
        public string CompanyName { get; set; } = "Ford";
        public string Motto { get; set; } = "Built Ford Tough";
        public bool HasChangedGears { get; set; }

        public void Drive()
        {
            Console.WriteLine($"{GetType().Name} now driving forward. . .");
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

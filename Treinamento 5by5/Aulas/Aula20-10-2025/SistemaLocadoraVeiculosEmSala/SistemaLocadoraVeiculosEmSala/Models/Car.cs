using SistemaLocadoraVeiculosEmSala.Abstracts;
using SistemaLocadoraVeiculosEmSala.Enumerators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLocadoraVeiculosEmSala.Models
{
    public class Car : Vehicle
    {
        private bool ManualGearBox { get; set; }

        private int NumberOfPassengers { get; set; }


        public Car(
            string model,
            string brand,
            string licensePlate,
            Kind kind,
            string cor,
            int year,
            bool isAvailable,
            double dailyCost,
            bool gearBox,
            int numberOfPassengers
            )
            : base(
                  model,
                  brand,
                  licensePlate,
                  kind,
                  cor,
                  year,
                  isAvailable,
                  dailyCost
                  )
        {
            this.ManualGearBox = gearBox;
            this.NumberOfPassengers = numberOfPassengers;
        }
    }
}

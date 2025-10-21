using SistemaLocadoraVeiculosEmSala.Abstracts;
using SistemaLocadoraVeiculosEmSala.Enumerators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLocadoraVeiculosEmSala.Models
{
    public class Motorcycle : Vehicle
    {
        private int EngineCapacity { get; set; }
        public int NumberOfPassengers { get; set; }


        public Motorcycle(
            string model,
            string brand,
            string licensePlate,
            Kind kind,
            string cor,
            int year,
            bool isAvailable,
            double dailyCost,
            int engineCapacity,
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
            this.EngineCapacity = engineCapacity;
            this.NumberOfPassengers = numberOfPassengers;
        }
    }
}

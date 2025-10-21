using SistemaLocadoraVeiculosEmSala.Abstracts;
using SistemaLocadoraVeiculosEmSala.Enumerators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLocadoraVeiculosEmSala.Models
{
    public class Truck : Vehicle
    {
        private int LoadCapacity { get; set; }

        private int Axles { get; set; }

        public Truck(
            string model,
            string brand,
            string licensePlate,
            Kind kind,
            string cor,
            int year,
            bool isAvailable,
            double dailyCost,
            int load,
            int axle
            ) : base(
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
            this.LoadCapacity = load;
            this.Axles = axle;

        }

        

       
    }
}

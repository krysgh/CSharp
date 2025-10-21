using SistemaLocadoraVeiculosEmSala.Enumerators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLocadoraVeiculosEmSala.Abstracts
{
    public abstract class Vehicle
    {
        private Guid Id { get; set; } = new Guid();

        private string Model { get; set; }

        private string Brand { get; set; }

        private string LicensePlate { get; set; }

        private Kind Kind { get; set; }

        public string Cor { get; set; }

        private int Year { get; set; }

        private bool isAvailable { get; set; } = true;

        private double DailyCost { get; set; }

        public Vehicle(
            string model,
            string brand,
            string licensePlate,
            Kind kind,
            string cor,
            int year,
            bool isAvailable,
            double dailyCost
            )
        { 
            this.Model = model;
            this.Brand = brand;
            this.LicensePlate = licensePlate;
            this.Kind = kind;
            this.Cor = cor;
            this.Year = year;
            this.isAvailable = isAvailable;
            this.DailyCost = dailyCost;
        }

    }
}

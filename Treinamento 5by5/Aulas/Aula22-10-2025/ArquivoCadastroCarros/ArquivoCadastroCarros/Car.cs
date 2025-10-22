using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArquivoCadastroCarros
{
    public class Car
    {
        public int Id { get; private set; }

        public string Brand { get; private set; }

        public string Model { get; private set; }

        public int Year { get; private set; }

        public string Color { get; set; }

        public string LicensePlate { get; private set; }

        public Car(
            int id,
            string brand,
            string model,
            int year,
            string color,
            string licensePlate
            )
        {
            Id = id;
            Brand = brand;
            Model = model;
            Year = year;
            Color = color;
            LicensePlate = licensePlate;
        }


        public override string ToString()
        {
            return $"{this.Id}\n" +
                $"{this.Brand}\n" +
                $"{this.Model}\n" +
                $"{this.Year}\n" +
                $"{this.Color}\n" +
                $"{this.LicensePlate}";
        }

        public void SetColor( string color)
        {
            this.Color = color;
        }

        public string ToFile()
        {
            return $"{this.Id}, {this.Brand}, {this.Model}, {this.Year}, {this.Color}, {this.LicensePlate}";
        }

    }
}

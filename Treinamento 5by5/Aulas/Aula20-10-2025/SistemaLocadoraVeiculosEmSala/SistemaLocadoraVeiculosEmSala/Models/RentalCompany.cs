using SistemaLocadoraVeiculosEmSala.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLocadoraVeiculosEmSala.Models
{
    public class RentalCompany
    {
        public List<Rental> Rentals = new List<Rental>();

        public List<Person> Customers = new List<Person>();

        public List<Vehicle> Vehicles = new List<Vehicle>();

    }
}

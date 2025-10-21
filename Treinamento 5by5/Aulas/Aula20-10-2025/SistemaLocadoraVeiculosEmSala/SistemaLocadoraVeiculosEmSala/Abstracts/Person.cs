using SistemaLocadoraVeiculosEmSala.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLocadoraVeiculosEmSala.Abstracts
{
    public abstract class Person
    {
        private string Name { get; set; }

        private DateOnly BirthDate { get; set; }

        private Contact Contact { get; set; }

        private Address Address  { get; set; }

        public Person(string name, DateOnly birthDate, Contact contact, Address address)
        {
            this.Name = name;
            this.BirthDate = birthDate;
            this.Contact = contact;
            this.Address = address;
        }

        public string GetName()
        {
            return this.Name;
        }

        public void SetContactPhone(string phone)
        {
            this.Contact.setPhone(phone);
        }

        public override string ToString()
        {
            return $"Name: {this.Name}\n" +
                $"BirthDate: {this.BirthDate}\n" +
                $"Contact: {this.Contact}\n" +
                $"Address: {this.Address}";
        }



    }
}

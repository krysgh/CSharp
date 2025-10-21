using SistemaLocadoraVeiculosEmSala.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLocadoraVeiculosEmSala.Models
{
    public class CustomerPF : Person
    {
        private Guid Id { get; set; } = Guid.NewGuid();

        private string CNH { get; set; }

        private string CPF { get; set; }

        public CustomerPF(
            string name,
            DateOnly birthDate, 
            Contact contact,
            Address address,
            string cnh,
            string cpf
            ) 
            : base(
                  name,
                  birthDate,
                  contact,
                  address
                  )
        {
            this.CNH = cnh;
            this.CPF = cpf;
        }

        public override string ToString()
        {
            return $"{this.Id}\n" +
                $"{base.ToString()}\n" +
                $"CPF: {this.CPF}\n" +
                $"CNH: {this.CNH}";
        }
    }
}

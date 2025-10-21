using SistemaLocadoraVeiculosEmSala.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLocadoraVeiculosEmSala.Models
{
    public class CustomerPJ : Person
    {
        private Guid Id { get; set; } = new Guid();

        private string CNPJ { get; set; }

        public CustomerPJ(
            string name,
            DateOnly birthDate,
            Contact contact,
            Address address,
            string cnpj
            )
            : base(
                  name,
                  birthDate,
                  contact,
                  address
                  )
            {
            CNPJ = cnpj;
        }

        public override string ToString()
        {
            return $"{this.Id}\n" +
                $"{base.ToString()}\n" +
                $"cnpj: {this.CNPJ}\n";
        }
    }
}

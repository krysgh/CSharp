using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArquivoCadastroCarros
{
    public class Rental
    {
        public List<Car> Cars { get; }

        public Rental(List<Car> cars) {
            this.Cars = cars;
        }

        public void RegisterCar()
        {
            Console.Write("informe o ID: ");
            var id = Convert.ToInt32(Console.ReadLine());
            Console.Write("informe a marca: ");
            var brand = Console.ReadLine();
            Console.Write("informe o modelo: ");
            var model = Console.ReadLine();
            Console.Write("informe o ano: ");
            var year = Convert.ToInt32(Console.ReadLine());
            Console.Write("informe a cor: ");
            var color = Console.ReadLine();
            Console.Write("informea placa: ");
            var licensePlate = Console.ReadLine();

            this.Cars.Add(new Car(id,brand,model,year,color,licensePlate));
        }

        public void ListAllCars()
        {
            foreach(Car c in this.Cars)
                Console.WriteLine(c + "\n");
        }

        private Car SearchForCar(int id)
        {
            return this.Cars.Find(c => c.Id == id);
        }

        public void ChangeCarColor()
        {
            Console.WriteLine("Qual Id do carro: ");
            var id = Convert.ToInt32((Console.ReadLine()));
            var car = SearchForCar(id);

            if(car is null)
            {
                Console.WriteLine("Carro não encontrado!");
            }
            else
            {
                Console.WriteLine("Qual a nova cor do carro: ");
                var newColor = Console.ReadLine();
                car.SetColor(newColor);

                Console.WriteLine(car);
            }
        }

        public void RemoveCar()
        {
            Console.WriteLine("Informe o Id: ");
            var id = Convert.ToInt32((Console.ReadLine()));
            Car car = SearchForCar(id);

            if(car is null)
            {
                Console.WriteLine("Carro não cadastrado!");
            }
            else
            {
                this.Cars.Remove(car);
                Console.WriteLine("Carro removido com sucesso!");
            }
        }

    }
}

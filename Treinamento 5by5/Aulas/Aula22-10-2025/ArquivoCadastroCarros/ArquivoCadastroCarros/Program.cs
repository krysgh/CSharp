// See https://aka.ms/new-console-template for more information

using ArquivoCadastroCarros;

string LoadProgram()
{
    string directory = @"C:\Locadora\Dados\";
    string file = "carros";
    if (!Directory.Exists(directory))
    {
        Directory.CreateDirectory(directory);
    }
    if (!File.Exists(Path.Combine(directory,file)))
    {
        File.Create(Path.Combine(directory, file));
    }
    return Path.Combine(directory, file);
}

List<Car> ReadFile()
{
    var fullPath = LoadProgram();

    StreamReader sr = new StreamReader(fullPath);

    using (sr)
    {
        if (sr.ReadToEnd() is null)
        {
            return new List<Car>();
        }
        else
        {

            List<Car> cars = new List<Car>();

            while (sr.ReadLine() is not null)
            {
                string line = sr.ReadLine();
                var values = line.Split(',');
                Car car = new Car(Convert.ToInt32(values[0]), values[1], values[2], Convert.ToInt32(values[3]), values[4], values[5]);
                cars.Add(car);
            }
            sr.Close();
            return cars;

        }
    }

}

void WriteFile(List<Car> cars)
{
    var fullPath = LoadProgram();

    StreamWriter sw = new StreamWriter(fullPath);

    using (sw)
    {
        foreach(Car car in cars)
        {
            sw.WriteLine(car.ToFile());
        }

    sw.Close();
    }
}

var rentalCompany = new Rental(ReadFile());


rentalCompany.ListAllCars();

rentalCompany.RegisterCar();

rentalCompany.RegisterCar();

rentalCompany.RegisterCar();

rentalCompany.ListAllCars();

rentalCompany.ChangeCarColor();

rentalCompany.RemoveCar();

rentalCompany.ListAllCars();


WriteFile(rentalCompany.Cars);




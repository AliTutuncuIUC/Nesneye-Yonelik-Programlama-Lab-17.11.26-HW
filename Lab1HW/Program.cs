class Motor
{
    public string Model {get; private set;}
    public int HorsePower {get; private set;}

    public Motor(string m, int h)
    {
        Model = m;
        HorsePower = h;
    }

    public void Ignite()
    {
        Console.WriteLine("Engine On!");
    }
}

class Car
{
    public string Brand{get; private set;}
    private Motor _motor;           //Composition relationship

    public Car(string b, string m, int h)
    {
        Brand = b;
        _motor = new Motor(m, h);
    }

    public void Start()
    {
        Console.WriteLine("Car starts...");
        _motor.Ignite();
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Brand: {Brand}\nHorse Power: {_motor.HorsePower}");
    }

}

class Program
{
    static void Main()
    {
        Car car1 = new Car("CarBrand", "MotorModel", 60);
        car1.ShowInfo();
        car1.Start();
    }
}

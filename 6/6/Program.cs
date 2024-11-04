class Car
{
    public string Name { get; set; }
    public string Color { get; set; }
    public double Price { get; set; }
    public const string CompanyName = "CompanyName";

    public Car()
    {
        Name = "Unknown";
        Color = "Unknown";
        Price = 0.0;
    }

    public Car(string name, string color, double price)
    {
        Name = name;
        Color = color;
        Price = price;
    }

    public void Input()
    {
        Console.Write("Введіть назву автомобіля: ");
        Name = Console.ReadLine();

        Console.Write("Введіть колір автомобіля: ");
        Color = Console.ReadLine();

        Console.Write("Введіть ціну автомобіля: ");
        Price = Convert.ToDouble(Console.ReadLine());
    }

    public void Print()
    {
        Console.WriteLine($"Назва: {Name}, Колір: {Color}, Ціна: {Price}, Виробник: {CompanyName}");
    }

    public void ChangePrice(double percentage)
    {
        Price -= Price * (percentage / 100);
    }

    public void Repaint(string newColor)
    {
        if (Color.ToLower() == "white")
        {
            Color = newColor;
        }
    }

    public string PrintInfo()
    {
        return $"Назва: {Name}, Колір: {Color}, Ціна: {Price}, Виробник: {CompanyName}";
    }
}

class Program
{
    static void Main()
    {
        Car[] cars = new Car[3];
        for (int i = 0; i < cars.Length; i++)
        {
            cars[i] = new Car();
            Console.WriteLine($"Введення даних для авто {i + 1}:");
            cars[i].Input();
        }

        Console.WriteLine("\nАвто після зменшення ціни на 10%:");
        foreach (Car car in cars)
        {
            car.ChangePrice(10);
            car.Print();
        }

        Console.Write("\nВведіть новий колір для авто з білим кольором: ");
        string newColor = Console.ReadLine();
        foreach (Car car in cars)
        {
            car.Repaint(newColor);
        }

        Console.WriteLine("\nОновлені дані про авто:");
        foreach (Car car in cars)
        {
            Console.WriteLine(car.PrintInfo());
        }

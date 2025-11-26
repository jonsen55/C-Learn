abstract class ElectronicDevice
{
    private string brand;
    private double price;

    public string Brand
    {
        get { return brand; }
        set { brand = value; }
    }

    public double Price
    {
        get { return price; }
        set { price = value; }
    }

    public ElectronicDevice(string brand, double price)
    {
        Brand = brand;
        Price = price;
    }

    public abstract void ShowInfo();
}

class Laptop : ElectronicDevice
{
    public Laptop(string brand, double price) : base(brand, price)
    {
    }

    public void TurnOnBattery()
    {
        Console.WriteLine("Laptop battery is now ON.");
    }

    public override void ShowInfo()
    {
        Console.WriteLine($"Laptop Brand: {Brand}, Price: {Price}");
    }
}

class Smartphone : ElectronicDevice
{
    public Smartphone(string brand, double price) : base(brand, price)
    {
    }    

    public void EnableCamera()
    {
        Console.WriteLine("Smartphone camera is now ON.");
    }

    public override void ShowInfo()
    {
        Console.WriteLine($"Smartphone Brand: {Brand}, Price: {Price}");
    }
}

class ElectronicsStore
{
    private List<ElectronicDevice> devices = new List<ElectronicDevice>();

    public void AddDevice(ElectronicDevice device)
    {
        devices.Add(device);
    }

    public void RemoveDevice(ElectronicDevice device)
    {
        devices.Remove(device);
    }

    public void ShowAllDeviceDetails()
    {
        foreach (var device in devices)
        {
            device.ShowInfo();
            if (device is Laptop laptop)
            {
                laptop.TurnOnBattery();
            }
            else if (device is Smartphone smartphone)
            {
                smartphone.EnableCamera();
            }
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        ElectronicsStore store = new ElectronicsStore();

        Laptop laptop = new Laptop("Dell", 1200.00);
        Smartphone smartphone = new Smartphone("Samsung", 800.00);

        store.AddDevice(laptop);
        store.AddDevice(smartphone);

        store.ShowAllDeviceDetails();
    }
}

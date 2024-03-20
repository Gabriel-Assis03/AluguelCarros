using RentCars.Types;
namespace RentCars.Models;

//3 - Crie a classe `Vehicle`
public class Vehicle
{
    string _Brand = "" ;
    public string Brand
    {
        get { return _Brand; }
        set { _Brand = value; }
    }
    string _Model = "";
    public string Model
    {
        get { return _Model; }
        set { _Model = value; }
    }
    decimal _Price;
    public decimal Price
    {
        get { return _Price; }
        set { _Price = value; }
    }

    FuelType _Fuel;
    public FuelType Fuel
    {
        get { return _Fuel; }
        set { _Fuel = value; }
    }

    int _EngineCapacity;
    public int EngineCapacity
    {
        get { return _EngineCapacity; }
        set { _EngineCapacity = value; }
    }

    Color _MainColor;
    public Color MainColor
    {
        get { return _MainColor; }
        set { _MainColor = value; }
    }

    int _Year;
    public int Year
    {
        get { return _Year; }
        set { _Year = value; }
    }

    double _PricePerDay;
    public double PricePerDay
    {
        get { return _PricePerDay; }
        set { _PricePerDay = value; }
    }

    bool _IsRented = false;
    public bool IsRented
    {
        get { return _IsRented; }
        set { _IsRented = value; }
    }
}
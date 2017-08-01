using System.Collections.Generic;

namespace CarDealer.Models
{
  public class Car
  {
    private string _makeModel;
    private int _mileage;
    private float _price;



    private static List<Car> _carList = new List<Car> {};

    public Car (string makeModel = "", int mileage = 0, int price = 0)
    {
        _makeModel = makeModel;
        _mileage = mileage;
        _price = price;
    }

    public string GetMakeModel()
    {
        return _makeModel;
    }
    public void SetMakeModel(string newMakeModel)
    {
        _makeModel = newMakeModel;
    }
    public int GetMileage()
    {
        return _mileage;
    }
    public void SetMileage(int newMileage)
    {
        _mileage = newMileage;
    }
    public float GetPrice()
    {
        return _price;
    }
    public void SetPrice(float newPrice)
    {
        _price = newPrice;
    }
    public void Save()
    {
        _carList.Add(this);
    }
    public static List<Car> AllCars()
    {
        return _carList;
    }
  }
}

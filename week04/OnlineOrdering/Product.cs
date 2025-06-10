using System;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;

public class Product
{
    public string _productid;
    public string _name;
    public double _price;
    public int _quantity;

    public Product(string productid, string name, double price, int quantity)
    {
        _productid = productid;
        _name = name;
        _price = price;
        _quantity = quantity;
    }

    public double ComputeTotalCost()
    {
        return _price * _quantity;
    } 
}
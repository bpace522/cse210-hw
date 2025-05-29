using System;
using System.Numerics;

public class Product
{
    public string _productid;
    public string _name;
    public double _price;
    public int _quantity;

    public double ComputeTotalCost(double price, int quantity)
    {
        double total;

        total = price * quantity;

        return total;
    } 
}
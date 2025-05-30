using System;
using System.Net.Sockets;

public class Customer
{
    public string _name { get; }
    public Address _address { get; }

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool CustomerUSAorNot()
    {
        return _address.USAorNot();
    }
}
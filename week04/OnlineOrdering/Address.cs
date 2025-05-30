using System;

public class Address
{
    public string _streetAddress;
    public string _city;
    public string _stateorprovince;
    public string _country;

    public Address(string streetAddress, string city, string stateorprovince, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _stateorprovince = stateorprovince;
        _country = country;
    }

    public bool USAorNot()
    {
        if (_country == "USA")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public string GetDisplayText()
    {
        return $"- {_streetAddress} \n- {_city}, {_stateorprovince}, {_country}";
    }
}
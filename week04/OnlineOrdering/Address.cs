using System;

public class Address
{
    public string _streetAddress;
    public string _city;
    public string _stateorprovince;
    public string _country;

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
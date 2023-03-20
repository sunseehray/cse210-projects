using System;

public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool isFromUSA()
    {
        if (_address.isUSA() == true) {
            return true;
        } else {
            return false;
        }
    }
}
using System;

public class Order
{
    public List<Product> Products { get; set; } = new List<Product>();
    public Customer Customer { get; }

    public Order(Customer customer)
    {
        Customer = customer;
        Products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        Products.Add(product);
    }

    public double CalculateTotalCost()
    {
        double total = 0;
        foreach (var product in Products)
        {
            total += product.ComputeTotalCost();
        }
        if (Customer.CustomerUSAorNot())
        {
            return total + 5;
        }
        else
        {
            return total + 35;
        }
    }

    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (var product in Products)
        {
            label += $"- {product._name} (ID: {product._productid})\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return $"{Customer._name} {Customer._address.GetDisplayText()}";
    }
}
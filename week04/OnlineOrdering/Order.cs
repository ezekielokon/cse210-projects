using System.Collections.Generic;


public class Order
{
    private const decimal USAShippingCost = 5m;
    private const decimal InternationalShippingCost = 35m;
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public Customer GetCustomer() { return _customer;}
    public void SetCustomer(Customer customer) { _customer = customer; }  
    
    public decimal GetShippingCost()
    {
        return _customer.LivesInUSA() ? USAShippingCost : InternationalShippingCost;
    }
    
    public decimal GetTotalPrice()
    {
        decimal total = 0;
        foreach (Product product in _products)
        {
            total += product.GetTotalCost();
        }
        return total + GetShippingCost();
    }

    public string GetPackingLabel()
    {
        string label = "PACKING LABEL\n";
        foreach (Product product in _products)
        {
            label += $"{product.GetName()} (ID: {product.GetProductId})\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return $"SHIPPING LABEL\n{_customer.GetName()}\n{_customer.GetAddress().GetFullAddress()}\n";
    }
}


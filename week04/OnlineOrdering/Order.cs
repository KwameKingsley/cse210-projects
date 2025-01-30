using System;
using System.Collections.Generic;

public class Order
{
    private List<Product> products;
    private Customer customer;

    public Order(Customer customer)
    {
        this.customer = customer;
        this.products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public double GetTotalCost()
    {
        double totalCost = 0;

        foreach (Product product in products)
        {
            totalCost += product.GetTotalCost();
        }

        double shippingCost = customer.LivesInUSA() ? 5 : 35;
        return totalCost + shippingCost;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "Packing Label:\n";

        foreach (Product product in products)
        {
            packingLabel += "- " + product.GetPackingLabel() + "\n";
        }

        return packingLabel;
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{customer.GetName()}\n{customer.GetAddress()}";
    }
}
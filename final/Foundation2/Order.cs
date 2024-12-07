using System.Reflection.Emit;
using System.Reflection.Metadata.Ecma335;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    // methods

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new();
    }

    public void AddProduct(Product product1, Product product2)
    {
        _products.Add(product1);
        _products.Add(product2);
    }

    public float CalculateTotalCost()
    {
        float productTotal = 0;
        float shippingCost = 0;

        foreach (Product product in _products)
        {
            float productCost = product.CalculateProductCost();
            productTotal += productCost;
        }

        if (_customer.LivesInUsa())
        {
            shippingCost = 5;
        }

        else
        {
            shippingCost = 35;
        }

        return productTotal + shippingCost;
    }

    public string PackingLabel()
    {
        string label = "";

        foreach (Product product in _products)
        {
            label += $"{product.GetProductName()} {product.GetProductId()}\n";
        }

        return label;
    }

    public string ShippingLabel()
    {
        return $"{_customer.GetName()} {_customer.GetAddress()}";
    }
}
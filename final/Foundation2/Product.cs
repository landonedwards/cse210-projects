public class Product
{
    private string _name;
    private int _productId;
    private float _pricePerUnit;
    private int _quantity;

    // methods

    public Product(string name, int productId, float pricePerUnit, int quantity)
    {
        _name = name;
        _productId = productId;
        _pricePerUnit = pricePerUnit;
        _quantity = quantity;
    }

    public float CalculateProductCost()
    {
        return _pricePerUnit * _quantity;
    }

    public string GetProductName()
    {
        return _name;
    }

    public int GetProductId()
    {
        return _productId;
    }
}
public class Product
{
    private string _productName;
    private string _productId;
    private int _price;
    private int _quantity;

    public Product(string productName, string productId, int price, int quantity)
    {
        _productName = productName;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }
    public int ProductTotal()
    {
        return _price * _quantity;
    }

    public string GetLabel()
    {
        return $"Product Name: {_productName} Product ID: {_productId}\n";
    }
    
}